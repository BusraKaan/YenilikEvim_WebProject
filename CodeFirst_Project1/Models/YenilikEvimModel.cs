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
        //Buran�n i�erisinde yazmad���m�z hi� bir model DB �zerinde tablo olarak olu�mayacak.
        public virtual DbSet<Category> Categories { get; set; }//DB'ye Categories ad�nda tablo olu�tur komutu veriliyor.
        public virtual DbSet<Product> Products { get; set; }//DB'ye Products ad�nda tablo olu�tur komutu veriliyor.
        public virtual DbSet<Manager> Managers { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<UserActivationTime> UserActivationTimes { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
