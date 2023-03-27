using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Tuan4_BigSchool.Startup))]
namespace Tuan4_BigSchool
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
