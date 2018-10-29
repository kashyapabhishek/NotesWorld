using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(NotesWorld.Startup))]
namespace NotesWorld
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
