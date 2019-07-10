using DealDashDouble.Models;
using DealDashDouble.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace DealDashDouble.Controllers
{
    public class AuctionController : Controller
    {
        CommentViewModel model = new CommentViewModel();

        DealDoubleDBContext context = new DealDoubleDBContext();

        CommentServices commentServices = new CommentServices();

        AuctionsServices services = new AuctionsServices();

        // GET: Auction
        public ActionResult Index()
        {
            AuctionsServices services = new AuctionsServices();

           var auctions =  services.GetAllList();

            if (Request.IsAjaxRequest())
            {
                return PartialView(auctions);
            }
            else
            {
                return View(auctions);
            }

          
        }



        public ActionResult Create()
        {
            return PartialView();
        }


        [HttpPost]
        public ActionResult Create(AuctionViewModel model)
        {
            tbl_Auction auction = new tbl_Auction();

            auction.Title = model.Title;

            auction.Description = model.Description;

            auction.ActualAmount = model.ActualAmount;

            auction.StartingTime = model.StartingTime;

            auction.EndingTime = model.EndingTime;


            var pictureIDs = model.tbl_AuctionPicture.Split(new char[] { ',' },StringSplitOptions.RemoveEmptyEntries).Select(x => int.Parse(x)).ToList();

            auction.tbl_AuctionPicture = new List<tbl_AuctionPicture>();

            foreach (var picID in pictureIDs)
            {
                var auctionPicture = new tbl_AuctionPicture();

                auctionPicture.PicID = picID;


                auction.tbl_AuctionPicture.Add(auctionPicture);
            }
           

            services.CreateAdd(auction);

            return RedirectToAction("Index");
        }

        
        public ActionResult Edit(int ID)
        {
            AuctionsServices services = new AuctionsServices();

              var user = services.GetEditByID(ID);

            return View(user);
        }


        [HttpPost]
        public ActionResult Edit(tbl_Auction auction)
        {
            AuctionsServices services = new AuctionsServices();

            services.UpdateEditByID(auction);

            return RedirectToAction("Index");
        }


        public ActionResult Delete(int ID)
        {
            AuctionsServices services = new AuctionsServices();

            var user = services.GetEditByID(ID);

            return View(user);
        }


        [HttpPost]
        public ActionResult Delete(tbl_Auction auction)
        {
            AuctionsServices services = new AuctionsServices();

            services.DeleteAuction(auction);

            return RedirectToAction("Index");
        }

        public ActionResult Details(int id)
        {
           
            var auction = context.tbl_Auction.Find(id);

            return View(auction);
        }

       

    }
}