using SelfHostingWebApiAndTopshelf.Interface;

namespace SelfHostingWebApiAndTopshelf.Implementation
{
    public class Teste : ITeste
    {
        public string GetString()
        {
            return "Teste Simple Injector";
        }
    }
}
