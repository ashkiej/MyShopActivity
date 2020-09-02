using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MyShopActivity.WebUI.Startup))]
namespace MyShopActivity.WebUI
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
