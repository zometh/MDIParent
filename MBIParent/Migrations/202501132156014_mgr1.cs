namespace MBIParent.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mgr1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Classes",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Libelle = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Etudiants",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Prenom = c.String(),
                        nom = c.String(),
                        IdClasse = c.Int(nullable: false),
                        classe_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Classes", t => t.classe_ID)
                .Index(t => t.classe_ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Etudiants", "classe_ID", "dbo.Classes");
            DropIndex("dbo.Etudiants", new[] { "classe_ID" });
            DropTable("dbo.Etudiants");
            DropTable("dbo.Classes");
        }
    }
}
