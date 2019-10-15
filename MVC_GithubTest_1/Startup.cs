using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVC_GithubTest_1.Startup))]
namespace MVC_GithubTest_1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
