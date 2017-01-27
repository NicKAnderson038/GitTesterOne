using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Git.Tester.Startup))]
namespace Git.Tester
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
