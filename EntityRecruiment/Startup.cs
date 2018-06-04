using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(EntityRecruiment.Startup))]
namespace EntityRecruiment
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
