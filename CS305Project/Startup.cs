using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CS305Project.Startup))]
namespace CS305Project
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
