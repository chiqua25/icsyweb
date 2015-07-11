using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(IcsyMvc.Startup))]
namespace IcsyMvc
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
