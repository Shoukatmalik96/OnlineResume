namespace Resume.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class editAgain : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Educations", "Institute", c => c.String());
            DropColumn("dbo.Educations", "Institue");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Educations", "Institue", c => c.String());
            DropColumn("dbo.Educations", "Institute");
        }
    }
}
