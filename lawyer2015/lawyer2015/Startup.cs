using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(lawyer2015.Startup))]
namespace lawyer2015
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
