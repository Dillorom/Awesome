namespace Awesome.Api.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MakeNamePropertyRequired : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Values", "Name", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Values", "Name", c => c.String());
        }
    }
}
