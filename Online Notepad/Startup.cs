using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Online_Notepad.Startup))]
namespace Online_Notepad
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
