using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(viewBagdatatempdata.Startup))]
namespace viewBagdatatempdata
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
