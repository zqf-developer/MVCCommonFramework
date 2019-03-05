using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVCCommon.Service.Domain.Startup))]
namespace MVCCommon.Service.Domain
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
