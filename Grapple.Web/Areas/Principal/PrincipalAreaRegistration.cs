using System.Web.Mvc;

namespace Grapple.Web.Areas.Admin
{
    public class PrincipalAreaRegistration : AreaRegistration
    {
        public override string AreaName
        {
            get
            {
                return "Principal";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context)
        {
            context.MapRoute(
                "Principal",
                "Principal/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional },
                new[] { "Grapple.Web.Areas.Principal.Controllers" }
            );
        }
    }
}