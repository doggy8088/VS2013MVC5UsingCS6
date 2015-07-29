using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(VS2013MVC5UsingCS6.Startup))]
namespace VS2013MVC5UsingCS6
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
