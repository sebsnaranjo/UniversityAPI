using Microsoft.Owin;
using Owin;
using System;
using System.Threading.Tasks;
using University.BL.Data;

namespace University.API
{
    public partial class Startup
    {
        public void ConfigureAuth(IAppBuilder app)
        {
            //Configura el dbcontext para que sea usado por una unica instancia por peticion
            app.CreatePerOwinContext(UniversityContext.Create);
        }
    }
}
