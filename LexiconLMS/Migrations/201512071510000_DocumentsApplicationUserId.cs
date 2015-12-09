namespace LexiconLMS.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DocumentsApplicationUserId : DbMigration
    {
        public override void Up()
        {
            DropIndex("dbo.Documents", new[] { "ApplicationUser_Id" });
            DropColumn("dbo.Documents", "ApplicationUserId");
            RenameColumn(table: "dbo.Documents", name: "ApplicationUser_Id", newName: "ApplicationUserId");
            AlterColumn("dbo.Documents", "ApplicationUserId", c => c.String(maxLength: 128));
            CreateIndex("dbo.Documents", "ApplicationUserId");
        }
        
        public override void Down()
        {
            DropIndex("dbo.Documents", new[] { "ApplicationUserId" });
            AlterColumn("dbo.Documents", "ApplicationUserId", c => c.Int());
            RenameColumn(table: "dbo.Documents", name: "ApplicationUserId", newName: "ApplicationUser_Id");
            AddColumn("dbo.Documents", "ApplicationUserId", c => c.Int());
            CreateIndex("dbo.Documents", "ApplicationUser_Id");
        }
    }
}
