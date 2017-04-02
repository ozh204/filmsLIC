namespace filmy.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Film",
                c => new
                    {
                        id = c.Long(nullable: false, identity: true),
                        nazwa = c.String(),
                        typ = c.String(),
                        gatunek = c.String(),
                        rezyseria = c.String(),
                        scenariusz = c.String(),
                        produkcja = c.String(),
                        premiera = c.String(),
                    })
                .PrimaryKey(t => t.id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Film");
        }
    }
}
