using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(UIHumanResource.Startup))]
namespace UIHumanResource
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
