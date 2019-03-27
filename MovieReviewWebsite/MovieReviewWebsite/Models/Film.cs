using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MovieReviewWebsite.Models
{
    public class Film
    {
        public virtual int FilmID { get; set; }
        public virtual string Name { get; set; }
        public virtual string Description { get; set; }
        public virtual string FilmLength { get; set; }
        public virtual int GenreID { get; set; }
        public virtual string Genre { get; set; }
        public virtual string Rating { get; set; }

    }
}