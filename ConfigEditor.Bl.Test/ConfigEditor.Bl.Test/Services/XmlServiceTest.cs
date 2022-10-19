using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

using Autofac;
using ConfigEditor.Bl.Services;
using ConfigEditor.Model.Contracts;
using ConfigEditor.Model.Dto;

namespace ConfigEditor.Bl.Test
{
    [TestClass]
    public class XmlServiceTest : BaseClassTest<XmlService>
    {
        [TestMethod]
        public void Read_xml_should_succeed()
        {
            // arrange
            var fullFileName = @"C:\temp\config.xml";
            var testDataObject = new Config
            {
                Servers = new List<Server>()
                {
                    new Server
                    {
                        Path = @"C:\test",
                        ConnectionString = "whatever",
                    },
                },
                Clients = new List<Client>()
                {
                    new Client()
                    {
                        Path = @"C:\neu",
                        TSClient = true,
                    },
                    new Client()
                    {
                        Path = @"C:\neu2",
                        TSClient = false,
                    },
                },
            };

            var xmlService = Container.Resolve<XmlService>();
            xmlService.WriteXml(fullFileName, testDataObject);

            // act
            var dataObject = Sut.ReadXml<Config>(fullFileName);

            // assert
            Assert.AreEqual(testDataObject.Servers.Count, dataObject.Servers.Count);
            Assert.AreEqual(testDataObject.Clients.Count, dataObject.Clients.Count);
        }
    }
}
