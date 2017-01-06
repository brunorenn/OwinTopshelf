using SelfHostingWebApiAndTopshelf.Interface;

namespace SelfHostingWebApiAndTopshelf.Implementation
{
    public class Test : ITest
    {
        public string GetString()
        {
            return "Teste Simple Injector";
        }
    }
}
