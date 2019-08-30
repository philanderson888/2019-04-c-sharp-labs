using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(lab_84_ASP_MVC_With_Authentication.Startup))]
namespace lab_84_ASP_MVC_With_Authentication
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
