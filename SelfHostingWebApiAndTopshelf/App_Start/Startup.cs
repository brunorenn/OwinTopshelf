using System.Web.Http;
using Owin;
using SelfHostingWebApiAndTopshelf.Implementation;
using SelfHostingWebApiAndTopshelf.Interface;
using SimpleInjector;
using SimpleInjector.Integration.WebApi;

//[assembly: OwinStartup(typeof(MyApp.Startup))]
namespace SelfHostingWebApiAndTopshelf
{
    public static class Startup
    {
        private static Container Container { get; set; }

        public static void Configuration(IAppBuilder app)
        {
            Container = new Container();
            Container.Options.DefaultScopedLifestyle = new WebApiRequestLifestyle();

            Container.Register<ITeste, Teste>(Lifestyle.Scoped);

            app.UseOwinContextInjector(Container);

            Container.Verify();

            var config = new HttpConfiguration
            {
                DependencyResolver = new SimpleInjectorWebApiDependencyResolver(Container)
            };

            // Set webapi dependency resolver

            WebApiConfig.Register(config);
            app.UseWebApi(config);
        }
    }
}
