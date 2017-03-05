using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MEFWithRootTemplate.Startup))]
namespace MEFWithRootTemplate
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
