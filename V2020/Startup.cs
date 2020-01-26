using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(V2020.Startup))]
namespace V2020
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
