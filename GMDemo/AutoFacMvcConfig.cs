using Autofac;
using GMDemo.Logger;
using GMDemo.Repository;

namespace GMDemo
{
    public class AutoFacMvcConfig : Module
    {
        /* Not used yet
        private readonly string _connectionString;

        public AutoFacMvcConfig(string connectionString)
        {
            _connectionString = connectionString;
        }
        */

        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<MockData>().As<IGmData>().SingleInstance();
            builder.RegisterType<Logger.Logger>().As<ILogger>().SingleInstance();
            base.Load(builder);
        }
    }
}