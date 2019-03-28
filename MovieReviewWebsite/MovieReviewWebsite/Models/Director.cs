using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MovieReviewWebsite.Models
{
    public class Director
    {
        public virtual int DirectorID { get; set; }
        public virtual string DirectorName { get; set; }
        public virtual string Description { get; set; }
    }
}