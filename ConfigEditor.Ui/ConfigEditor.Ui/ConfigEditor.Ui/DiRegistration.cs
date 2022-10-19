using Autofac;
using Autofac.Core;
using ConfigEditor.Bl;

namespace ConfigEditor.Ui
{
    internal class DiRegistration
    {
        public static IContainer Build()
        {
            var builder = new ContainerBuilder();

            // Register individual components
            builder.RegisterModule(new ConfigEditorBlModule());

            return builder.Build();
        }
    }
}
