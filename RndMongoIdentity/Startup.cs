using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(RndMongoIdentity.Startup))]
namespace RndMongoIdentity
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
