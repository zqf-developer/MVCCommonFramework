using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVCCommonFramework.Startup))]
namespace MVCCommonFramework
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
