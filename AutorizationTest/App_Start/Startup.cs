using System.Web.Mvc;
using System.Web.Services.Description;
using AutorizationTest.App_Start;
using Microsoft.Owin;
using Owin;
using AutorizationTest.Models;
using Microsoft.Owin.Security.Cookies;
using Microsoft.AspNet.Identity;

[assembly: OwinStartup(typeof(Startup))]
namespace AutorizationTest.App_Start
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            app.CreatePerOwinContext<ApplicationContext>(ApplicationContext.Create);
            app.CreatePerOwinContext<ApplicationUserManager>(ApplicationUserManager.Create);
            app.UseCookieAuthentication(new CookieAuthenticationOptions
            {
                AuthenticationType =DefaultAuthenticationTypes.ApplicationCookie,LoginPath = new PathString("/Account/Login"),
            });
            ModelBinders.Binders.Add(typeof(double), new DecimalModelBinder());
        }
    }
}