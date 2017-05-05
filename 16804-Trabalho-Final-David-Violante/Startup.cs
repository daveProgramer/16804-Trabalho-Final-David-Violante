using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(_16804_Trabalho_Final_David_Violante.Startup))]
namespace _16804_Trabalho_Final_David_Violante
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
