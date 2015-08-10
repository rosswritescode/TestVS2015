using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TestWeb2.Startup))]
namespace TestWeb2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
