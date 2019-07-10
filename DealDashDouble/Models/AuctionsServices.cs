using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DealDashDouble.Models
{
    public class AuctionsServices
    {
        public void CreateAdd(tbl_Auction auction)
        {
            DealDoubleDBContext context = new DealDoubleDBContext();

            context.tbl_Auction.Add(auction);

            context.SaveChanges();
        }//Create ka post wala h 

        public List<tbl_Auction> GetAllList()
        {
            DealDoubleDBContext context = new DealDoubleDBContext();

            return context.tbl_Auction.ToList();

        }//List wala h  




        public tbl_Auction GetEditByID(int ID)
        {
            DealDoubleDBContext context = new DealDoubleDBContext();

            return context.tbl_Auction.Find(ID);

        }//Edit ka Get wala h 


        public void UpdateEditByID(tbl_Auction auction)
        {
            DealDoubleDBContext context = new DealDoubleDBContext();

            context.Entry(auction).State = System.Data.Entity.EntityState.Modified;

            context.SaveChanges();

        }//Edit ka post wala h 


        public void DeleteAuction(tbl_Auction auction)
        {
            DealDoubleDBContext context = new DealDoubleDBContext();

            context.Entry(auction).State = System.Data.Entity.EntityState.Deleted;

            context.SaveChanges();

        }//Delete ka post wala h 

      
        
    }
}