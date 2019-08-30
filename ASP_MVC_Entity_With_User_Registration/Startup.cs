using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ASP_MVC_Entity_With_User_Registration.Startup))]
namespace ASP_MVC_Entity_With_User_Registration
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
