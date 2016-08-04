using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ST_MVC_Day1Homework.Startup))]
namespace ST_MVC_Day1Homework
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
