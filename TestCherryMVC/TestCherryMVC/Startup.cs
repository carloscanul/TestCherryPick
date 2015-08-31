using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TestCherryMVC.Startup))]
namespace TestCherryMVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
