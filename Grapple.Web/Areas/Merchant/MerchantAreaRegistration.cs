using System.Web.Mvc;

namespace Grapple.Web.Areas.Admin
{
    public class MerchantAreaRegistration : AreaRegistration
    {
        public override string AreaName
        {
            get
            {
                return "Merchant";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context)
        {
            context.MapRoute(
                "Merchant",
                "Admin/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional },
                new[] { "Grapple.Web.Areas.Merchant.Controllers" }
            );
        }
    }
}