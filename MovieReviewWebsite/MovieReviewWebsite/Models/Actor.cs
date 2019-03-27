using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MovieReviewWebsite.Models
{
    public class Actor
    {
        public virtual int ActorID { get; set; }
        public virtual string ActorName { get; set; }
        public virtual string Description { get; set; }
    }
}