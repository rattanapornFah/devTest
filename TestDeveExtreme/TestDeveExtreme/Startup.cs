using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TestDeveExtreme.Startup))]
namespace TestDeveExtreme
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
