namespace Web.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddLastLoginTimeToSysUser : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.SysUser", "LastLoginTime", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.SysUser", "LastLoginTime");
        }
    }
}
