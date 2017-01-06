using Topshelf;

namespace SelfHostingWebApiAndTopshelf
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            HostFactory.Run(x =>
            {
                x.Service<HostingConfiguration>();
                x.RunAsLocalSystem();
                x.SetDescription("API Owin com Topshelf");
                x.SetDisplayName("selfhost.owin.webapi");
                x.SetServiceName("selfhost.owin.webapi");
            });
        }
    }
}
