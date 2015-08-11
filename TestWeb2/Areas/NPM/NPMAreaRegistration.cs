using System.Web.Mvc;

namespace TestWeb2.Areas.NPM
{
    public class NPMAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "NPM";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "NPM_default",
                "NPM/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}