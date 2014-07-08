using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SatsangPravruti.Startup))]
namespace SatsangPravruti
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
