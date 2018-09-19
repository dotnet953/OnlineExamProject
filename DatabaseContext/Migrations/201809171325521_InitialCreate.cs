namespace DatabaseContext.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Organizations",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Code = c.String(),
                        Address = c.String(),
                        ContactNo = c.Int(nullable: false),
                        About = c.String(),
                        LogoName = c.String(),
                        LogoUrl = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Courses",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        OrganizationId = c.Int(nullable: false),
                        Name = c.String(),
                        Code = c.String(),
                        CourseDuration = c.String(),
                        Credit = c.String(),
                        OutLine = c.String(),
                        Tags = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Organizations", t => t.OrganizationId, cascadeDelete: true)
                .Index(t => t.OrganizationId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Courses", "OrganizationId", "dbo.Organizations");
            DropIndex("dbo.Courses", new[] { "OrganizationId" });
            DropTable("dbo.Courses");
            DropTable("dbo.Organizations");
        }
    }
}
