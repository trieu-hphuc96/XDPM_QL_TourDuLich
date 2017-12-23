using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(XDPM_QL_TourDuLich.Startup))]
namespace XDPM_QL_TourDuLich
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
