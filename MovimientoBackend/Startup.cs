using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MovimientoBackend.Startup))]
namespace MovimientoBackend
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
