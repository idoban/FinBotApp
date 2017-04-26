using System.Linq;
using System.Reflection;
using Autofac;
using Autofac.Integration.WebApi;

namespace FinBot
{
    public class Bootstrapper
    {
        private readonly IContainer _container;

        public Bootstrapper(params object[] instances)
        {
            ContainerBuilder builder = new ContainerBuilder();

            builder.RegisterApiControllers(Assembly.GetExecutingAssembly());

            builder.RegisterAssemblyTypes(typeof (Bootstrapper).Assembly)
                .AsImplementedInterfaces()
                .SingleInstance();

            if (instances != null && instances.Any())
            {
                foreach (var instance in instances)
                {
                    builder.RegisterInstance(instance)
                        .AsImplementedInterfaces();
                }
            }

            _container = builder.Build();
        }

        public IContainer GetContainer()
        {
            return _container;
        }

        public T Get<T>()
        {
            return _container.Resolve<T>();
        }
    }
}