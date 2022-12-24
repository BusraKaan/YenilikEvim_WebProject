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
            AutomaticMigrationsEnabled = true;//Baþlangýçta false idi. True olduðunda DB üzerinde deðiþiklik olduðun da deðiþiklikleri direkt SQLe yansýt anlamýna geliyor.
            AutomaticMigrationDataLossAllowed = true;//Veri kayýplarýný kabul ediyorum demek oluyor.
        }

        protected override void Seed(CodeFirst_Project1.Models.YenilikEvimModel context)
        {
            context.Categories.AddOrUpdate(s => s.ID, new Models.Category() { ID = 1, Name = "Mutfak", Description = "Mutfak eþyalarý" });
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
