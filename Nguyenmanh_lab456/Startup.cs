using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Nguyenmanh_lab456.Startup))]
namespace Nguyenmanh_lab456
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
