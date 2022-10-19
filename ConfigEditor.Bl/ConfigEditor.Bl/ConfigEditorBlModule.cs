using Autofac;
using ConfigEditor.Bl.Services;

namespace ConfigEditor.Bl
{
    public class ConfigEditorBlModule : Module
    {
        /// <summary>
        /// Loads all type registrations at runtime.
        /// </summary>
        /// <param name="builder">IOC Container</param>
        protected override void Load(ContainerBuilder builder)
        {
            // register services
            builder.RegisterType<XmlService>().AsImplementedInterfaces().InstancePerDependency();
        }
    }
}
