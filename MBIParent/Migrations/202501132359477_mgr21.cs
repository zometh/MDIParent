namespace MBIParent.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mgr21 : DbMigration
    {
        public override void Up()
        {
            DropIndex("dbo.Etudiants", new[] { "classe_ID" });
            AddColumn("dbo.Etudiants", "IdClasse", c => c.Int(nullable: false));
            CreateIndex("dbo.Etudiants", "Classe_ID");
        }
        
        public override void Down()
        {
            DropIndex("dbo.Etudiants", new[] { "Classe_ID" });
            DropColumn("dbo.Etudiants", "IdClasse");
            CreateIndex("dbo.Etudiants", "classe_ID");
        }
    }
}
