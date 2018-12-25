using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Resume.Web.Startup))]
namespace Resume.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
