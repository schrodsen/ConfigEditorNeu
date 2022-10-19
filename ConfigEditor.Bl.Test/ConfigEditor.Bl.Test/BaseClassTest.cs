using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using Autofac;
using Autofac.Builder;
using ConfigEditor.Bl.Services;

namespace ConfigEditor.Bl.Test
{
    public abstract class BaseClassTest<TSystemUnderTest>
        where TSystemUnderTest : class
    {
        protected TSystemUnderTest Sut;

        /// <summary>
        /// Builder to register all needed types.
        /// </summary>
        public ContainerBuilder Builder { get; protected set; }

        /// <summary>
        /// Container to resolve all registered types.
        /// </summary>
        public IContainer Container { get; protected set; }

        [TestInitialize]
        public virtual async Task Setup()
        {
            Builder = new ContainerBuilder();
            await RegisterTypes(Builder);
            Container = Builder.Build(ContainerBuildOptions.IgnoreStartableComponents);
            await InitializeEnvironment();
        }

        [TestCleanup]
        public virtual Task Teardown()
        {
            return Task.CompletedTask;
        }

        /// <summary>
        /// Register new types and classes for the unit tests.
        /// </summary>
        /// <param name="builder"></param>
        protected virtual Task RegisterTypes(ContainerBuilder builder)
        {
            // Probably not required...
            builder.RegisterType<XmlService>().InstancePerDependency();
            return Task.CompletedTask;
        }

        /// <summary>
        /// Initialize any required instances / SUT (system under test).
        /// </summary>
        protected virtual Task InitializeEnvironment()
        {
            Sut = Container.Resolve<TSystemUnderTest>();
            return Task.CompletedTask;
        }
    }
}
