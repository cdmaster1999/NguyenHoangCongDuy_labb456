using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CongDuy_Lab456.Startup))]
namespace CongDuy_Lab456
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
