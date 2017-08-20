using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TheoryOfProgramming.Startup))]
namespace TheoryOfProgramming
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
