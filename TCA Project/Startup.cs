using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TCA_Project.Startup))]
namespace TCA_Project
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
