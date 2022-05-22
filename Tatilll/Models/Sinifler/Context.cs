using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;


namespace Tatilll.Models.Sinifler
{
    public class Context: DbContext
    {
        public DbSet<Admin> Admins { get; set; }
        public DbSet<AdresBlog> AdresBlogs { get; set; }
        public DbSet<AnaSayfa> AnaSayfas { get; set; }
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Hakkimizda> Hakkimizdas { get; set; }
        public DbSet<Iletisim> iletisims { get; set; }
        public DbSet<Yorumlar> Yorumlars { get; set; }

    }
}