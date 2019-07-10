using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DealDashDouble.Models
{
    public class CommentServices
    {

        public bool LeaveComment(tbl_Comment comment)
        {
            DealDoubleDBContext context = new DealDoubleDBContext();

            context.tbl_Comment.Add(comment);

            return context.SaveChanges() > 0;

        }

        public List<tbl_Comment>Listcomment(int entityID , int recordID)
        {
            DealDoubleDBContext context = new DealDoubleDBContext();

            return context.tbl_Comment.Where(x => x.EntityID == entityID && x.RecordID == recordID).ToList();

        }
    }
}