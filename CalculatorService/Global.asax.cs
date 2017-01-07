using Autofac;
using Autofac.Integration.Wcf;
using System;

namespace CalculatorService
{
    public class Global : System.Web.HttpApplication
    {

        protected void Application_Start(object sender, EventArgs e)
        {
            ContainerBuilder builder = new ContainerBuilder();
            builder.RegisterModule<CalculatorModule>();
            AutofacHostFactory.Container = builder.Build();
        }
    }
}