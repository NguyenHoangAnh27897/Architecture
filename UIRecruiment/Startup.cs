using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(UIRecruiment.Startup))]
namespace UIRecruiment
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
