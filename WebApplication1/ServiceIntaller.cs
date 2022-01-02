using Castle.MicroKernel.Registration;
using Castle.MicroKernel.SubSystems.Configuration;
using Castle.Windsor;
using WebApplication1.DatabaseAdapter;
using WebApplication1.Interface;

namespace WebApplication1
{
    public class ServiceIntaller : IWindsorInstaller
    {
        public void Install(IWindsorContainer container, IConfigurationStore store)
        {
            // IDatabase dastabase = new SQLDatabase();
            container.Register
                (
                Component
                .For<IDatabase>()
                .ImplementedBy<OracleDatabase>()
                .LifestyleSingleton()
                );
        }


    }
}