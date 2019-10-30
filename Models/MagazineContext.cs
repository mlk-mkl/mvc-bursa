using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace TASK4.Models
{

 
        public class MagazineContext : DbContext
        {
            public DbSet<Magazine> Magazines { get; set; }
            public DbSet<Purchase> Purchases { get; set; }
        }

        public class MagazineDbInitializer : DropCreateDatabaseAlways<MagazineContext>
        {
            protected override void Seed(MagazineContext db)
            {
                db.Magazines.Add(new Magazine { Name = "TEENVOGUE", Country = "USA", Price = 220, Site= "https://www.teenvogue.com/" });
                db.Magazines.Add(new Magazine { Name = "BILLBOARD", Country = "Ucraine", Price = 40, Site= "https://www.billboard.com/music/magazine" });
                db.Magazines.Add(new Magazine { Name = "VOGUE", Country = "Russia", Price = 150, Site= "https://www.vogue.com/" });

                db.Magazines.Add(new Magazine { Name = "MARIE CLAIRE", Country = "USA", Price = 220, Site= "https://www.marieclaire.com/" });
                db.Magazines.Add(new Magazine { Name = "TIME", Country = "Ucraine", Price = 40, Site= "https://time.com/" });
                db.Magazines.Add(new Magazine { Name = "WONDERLAND", Country = "Russia", Price = 150, Site= "https://www.wonderlandmagazine.com" });

                db.Magazines.Add(new Magazine { Name = "GLAMOUR", Country = "USA", Price = 220, Site = "https://www.glamour.com/" });
                db.Magazines.Add(new Magazine { Name = "FASHION", Country = "Ucraine", Price = 40, Site = "https://fashionmagazine.com" });
                db.Magazines.Add(new Magazine { Name = "COSMOPOLITAN", Country = "Russia", Price = 150, Site = "https://www.cosmopolitan.com" });


            base.Seed(db);
            }
        }
    
}