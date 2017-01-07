using Autofac;
using Autofac.Integration.Wcf;
using ServiceA;
using ServiceB;
using System.ServiceModel;

namespace CalculatorService
{
    public class CalculatorModule: Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            base.Load(builder);
            builder.Register(_ => new ChannelFactory<IServiceA>("*")).SingleInstance();
            builder.Register(_ => new ChannelFactory<IServiceB>("*")).SingleInstance();
            builder.Register(ctx => ctx.Resolve<ChannelFactory<IServiceA>>().CreateChannel())
                .As<IServiceA>().UseWcfSafeRelease();
            builder.Register(ctx => ctx.Resolve<ChannelFactory<IServiceB>>().CreateChannel())
                .As<IServiceB>().UseWcfSafeRelease();
            builder.RegisterType<CalculatorService>();
        }
    }
}