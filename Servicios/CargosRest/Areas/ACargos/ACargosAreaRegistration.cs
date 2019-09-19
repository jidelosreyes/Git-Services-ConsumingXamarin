using System.Web.Mvc;

namespace CargosRest.Areas.ACargos
{
    public class ACargosAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "ACargos";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "ACargos_default",
                "ACargos/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}