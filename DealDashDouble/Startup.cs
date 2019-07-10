using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DealDashDouble.Startup))]
namespace DealDashDouble
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
