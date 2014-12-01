using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CountToNextBirthday.Startup))]
namespace CountToNextBirthday
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
           // ConfigureAuth(app);
        }
    }
}
