namespace JobPortal_API.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdatedJobDetails : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.JobDetails", "CompanyName", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.JobDetails", "CompanyName");
        }
    }
}
