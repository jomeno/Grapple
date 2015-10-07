using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Grapple.Web.Models
{
    public class GiftOrder
    {
        public int GiftOrderID { get; set; }
        public int MerchantID { get; set; }

        public double Amount { get; set; }

        public string RecipientName { get; set; }
        public string RecipienEmail { get; set; }
        public string RecipientMobile { get; set; }
    }
}