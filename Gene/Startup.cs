using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Gene.Startup))]
namespace Gene
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
