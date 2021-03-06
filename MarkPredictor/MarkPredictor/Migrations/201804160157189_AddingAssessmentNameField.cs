namespace MarkPredictor.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddingAssessmentNameField : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Assessments", "Name", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Assessments", "Name");
        }
    }
}
