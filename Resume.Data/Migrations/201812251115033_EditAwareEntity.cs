namespace Resume.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class EditAwareEntity : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Awards", "Institute", c => c.String());
            DropColumn("dbo.Awards", "Institue");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Awards", "Institue", c => c.String());
            DropColumn("dbo.Awards", "Institute");
        }
    }
}
