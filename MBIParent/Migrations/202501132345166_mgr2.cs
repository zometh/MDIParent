namespace MBIParent.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mgr2 : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Etudiants", "IdClasse");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Etudiants", "IdClasse", c => c.Int(nullable: false));
        }
    }
}
