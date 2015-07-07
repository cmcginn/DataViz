using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DataViz.Web.Startup))]
namespace DataViz.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
