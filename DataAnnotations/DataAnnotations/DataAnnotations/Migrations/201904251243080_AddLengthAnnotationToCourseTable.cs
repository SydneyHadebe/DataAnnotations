namespace DataAnnotations.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddLengthAnnotationToCourseTable : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Courses", "Name", c => c.String(nullable: false, maxLength: 255));
            AlterColumn("dbo.Courses", "Description", c => c.String(nullable: false, maxLength: 500));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Courses", "Description", c => c.String(nullable: false, maxLength: 255));
            AlterColumn("dbo.Courses", "Name", c => c.String(nullable: false, maxLength: 200));
        }
    }
}
