﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DealDashDouble.ViewModels
{
    public class CommentViewModel
    {
        public string Text { get; set; }

        public int Rating { get; set; }

        public int EntityID { get; set; }

        public int RecordID { get; set; }

        public List<tbl_Comment> Comments { get; set; }
    }
}