using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(EntityHumanResource.Startup))]
namespace EntityHumanResource
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
