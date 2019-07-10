using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DealDashDouble.Models
{
    public class SharedServices
    {
        public int SavePicture(tbl_Picture picture)
        {
            DealDoubleDBContext context = new DealDoubleDBContext();

            context.tbl_Picture.Add(picture);

            context.SaveChanges();

            return picture.PicID;
        }

    }
}