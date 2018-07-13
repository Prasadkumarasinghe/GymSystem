namespace SolidProject.Entities.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PK001 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Members",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        MemberId = c.String(),
                        FName = c.String(),
                        LName = c.String(),
                        Gender = c.String(),
                        Address = c.String(),
                        Mob = c.String(),
                        DOB = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Members");
        }
    }
}
