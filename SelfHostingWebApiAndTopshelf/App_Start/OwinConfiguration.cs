using Owin;

namespace SelfHostingWebApiAndTopshelf
{
    public class OwinConfiguration
    {
        public void Configuration(IAppBuilder app)
        {
            app.UseRequestScopeContext();
            Startup.Configuration(app);
        }
    }
}
