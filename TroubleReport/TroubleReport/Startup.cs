using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TroubleReport.Startup))]
namespace TroubleReport
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
