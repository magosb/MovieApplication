using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MagsAzureApp.Startup))]
namespace MagsAzureApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
