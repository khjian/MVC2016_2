namespace Web.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DropLastLoginTimeToSysUser : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.SysUser", "LastLoginTime");
        }
        
        public override void Down()
        {
            AddColumn("dbo.SysUser", "LastLoginTime", c => c.DateTime(nullable: false));
        }
    }
}
