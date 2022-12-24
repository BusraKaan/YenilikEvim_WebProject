using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace CodeFirst_Project1.Models
{
    public partial class YenilikEvimModel : DbContext
    {
        public YenilikEvimModel()
            : base("name=YenilikEvimModel")
        {
        }
        //Buranýn içerisinde yazmadýðýmýz hiç bir model DB üzerinde tablo olarak oluþmayacak.
        public virtual DbSet<Category> Categories { get; set; }//DB'ye Categories adýnda tablo oluþtur komutu veriliyor.
        public virtual DbSet<Product> Products { get; set; }//DB'ye Products adýnda tablo oluþtur komutu veriliyor.
        public virtual DbSet<Manager> Managers { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<UserActivationTime> UserActivationTimes { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
