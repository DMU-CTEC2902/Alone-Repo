using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FullMVCProject.Startup))]
namespace FullMVCProject
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
