namespace filmy.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class test : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Film", "tytul", c => c.String());
            AlterColumn("dbo.Film", "premiera", c => c.DateTime(nullable: false));
            DropColumn("dbo.Film", "nazwa");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Film", "nazwa", c => c.String());
            AlterColumn("dbo.Film", "premiera", c => c.String());
            DropColumn("dbo.Film", "tytul");
        }
    }
}
