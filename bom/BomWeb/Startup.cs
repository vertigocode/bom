using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BomWeb.Startup))]
namespace BomWeb
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
        }
    }
}
