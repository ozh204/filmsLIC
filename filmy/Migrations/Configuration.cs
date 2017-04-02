namespace filmy.Migrations
{
    using Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<filmy.Models.FilmDBContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "filmy.Models.FilmDBContext";
        }

        protected override void Seed(filmy.Models.FilmDBContext context)
        {

            context.Films.AddOrUpdate
            (
              f => f.id,
              new Film { tytul = "Batman", premiera = new DateTime(1999, 02, 21) }
            );

        }
    }
}
