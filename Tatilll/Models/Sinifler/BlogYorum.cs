using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Tatilll.Models.Sinifler
{
    public class BlogYorum
    {
        public IEnumerable<Blog> Deyer1 { get; set; }
        public IEnumerable<Yorumlar> Deyer2 { get; set; }
        public IEnumerable<Blog> Deyer3 { get; set; }
    }
}