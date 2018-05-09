using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(LinaMovies.Web.Startup))]
namespace LinaMovies.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
