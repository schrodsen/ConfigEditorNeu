using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Autofac;
using ConfigEditor.Model.Contracts;
using ConfigEditor.Model.Dto;

namespace ConfigEditor.Ui
{
    public partial class MainForm : Form
    {
        private IXmlService XmlService { get; }

        private Config DataModel { get; set; } 

        public MainForm()
        {
            InitializeComponent();

            XmlService = Program.AutofacContainer.Resolve<IXmlService>();
        }

        private void tsbBrowse_Click(object sender, EventArgs e)
        {
            var result = this.openFileDialogBrowser.ShowDialog();

            if (result != DialogResult.OK)
                return;

            this.tbFilePath.Text = this.openFileDialogBrowser.FileName;

            // if auto load
            // this.LoadData();
            // this.RefreshForm();
        }

        private void tslLoadFile_Click(object sender, EventArgs e)
        {
            this.LoadData();
            this.RefreshForm();
        }

        private void tsbSaveFile_Click(object sender, EventArgs e)
        {
            try
            {
                this.XmlService.WriteXml(this.tbFilePath.Text, this.DataModel);
            }
            catch (Exception)
            {
                // log - MessageBox
            }
        }

        private void LoadData()
        {
            try
            {
                this.DataModel = this.XmlService.ReadXml<Config>(this.tbFilePath.Text);
            }
            catch (Exception)
            {
                // log - MessageBox
            }
        }

        private void RefreshForm()
        {
            // ToDo
        }
    }
}
