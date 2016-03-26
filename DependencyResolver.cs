using System;
using Autofac;
using SandBoxTest.Services;

namespace SandBoxTest
{
    public class DependencyResolver
    {
        private static Autofac.IContainer Container { set; get; }

        public static IContainer GetContainer(Action<ContainerBuilder> builderFunc = null)
        {
            if (Container != null)
            {
                return Container;
            }
            var builder = new ContainerBuilder();
            builder.RegisterType<WorkerService>().As<IWorkerService>();
            if (builderFunc != null)
            {
                builderFunc(builder);
            }

            Container = builder.Build();
            return Container;
        }
    }
}