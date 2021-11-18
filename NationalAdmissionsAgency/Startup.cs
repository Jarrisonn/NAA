using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(NationalAdmissionsAgency.Startup))]
namespace NationalAdmissionsAgency
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
