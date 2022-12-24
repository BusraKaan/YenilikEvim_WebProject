namespace CodeFirst_Project1.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<CodeFirst_Project1.Models.YenilikEvimModel>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;//Ba�lang��ta false idi. True oldu�unda DB �zerinde de�i�iklik oldu�un da de�i�iklikleri direkt SQLe yans�t anlam�na geliyor.
            AutomaticMigrationDataLossAllowed = true;//Veri kay�plar�n� kabul ediyorum demek oluyor.
        }

        protected override void Seed(CodeFirst_Project1.Models.YenilikEvimModel context)
        {
            context.Categories.AddOrUpdate(s => s.ID, new Models.Category() { ID = 1, Name = "Mutfak", Description = "Mutfak e�yalar�" });
            context.Managers.AddOrUpdate(s => s.ID, new Models.Manager()
            {
                ID = 1,
                NameSurname = "Admin Developer",
                Mail = "admin@admin.com",
                Password = "1234",
                UserName = "Admin",
                Image = "none.jpg",
                Status = true
            });

        }
    }
}
