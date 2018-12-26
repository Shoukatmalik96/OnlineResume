namespace Resume.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitializedDatabase : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Abouts",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        FirstName = c.String(),
                        LastName = c.String(),
                        Email = c.String(),
                        Address = c.String(),
                        Description = c.String(),
                        GitURL = c.String(),
                        FaceBookURL = c.String(),
                        LinkedentURL = c.String(),
                        TwitterURL = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Awards",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Position = c.String(),
                        Institute = c.String(),
                        Competition = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Certifications",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        certificationName = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Educations",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Institute = c.String(),
                        Program = c.String(),
                        ProgramDescription = c.String(),
                        GPA = c.Single(nullable: false),
                        Grade = c.String(),
                        fromDate = c.DateTime(nullable: false),
                        toDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Experiences",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Post = c.String(),
                        Organization = c.String(),
                        Description = c.String(),
                        fromDate = c.DateTime(nullable: false),
                        toDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Interests",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Hobby = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Languages",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        languageName = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Skills",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        skillDescription = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Tools",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        toolName = c.String(),
                        ImageURL = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.workFlows",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        workFlowName = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.workFlows");
            DropTable("dbo.Tools");
            DropTable("dbo.Skills");
            DropTable("dbo.Languages");
            DropTable("dbo.Interests");
            DropTable("dbo.Experiences");
            DropTable("dbo.Educations");
            DropTable("dbo.Certifications");
            DropTable("dbo.Awards");
            DropTable("dbo.Abouts");
        }
    }
}
