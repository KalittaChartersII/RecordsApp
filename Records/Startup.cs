using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Records.Startup))]
namespace Records
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
