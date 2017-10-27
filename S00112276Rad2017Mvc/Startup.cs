using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(S00112276Rad2017Mvc.Startup))]
namespace S00112276Rad2017Mvc
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
