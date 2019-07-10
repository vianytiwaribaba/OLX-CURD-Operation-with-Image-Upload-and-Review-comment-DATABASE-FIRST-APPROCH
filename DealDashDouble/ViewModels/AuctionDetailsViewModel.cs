using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DealDashDouble.ViewModels
{
    public class AuctionDetailsViewModel
    {
        public tbl_Auction Auction { get; set; }

        public List<tbl_Comment> Comments { get; set; }

    }
}