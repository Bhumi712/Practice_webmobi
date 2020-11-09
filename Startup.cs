using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BhumiMehta_WebMobi.Startup))]
namespace BhumiMehta_WebMobi
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
