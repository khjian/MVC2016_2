namespace Web.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddSomeThingToSysUser : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.SysUser", "LastLoginTime", c => c.DateTime(nullable: false));
            AddColumn("dbo.SysUser", "LastLoginIP", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.SysUser", "LastLoginIP");
            DropColumn("dbo.SysUser", "LastLoginTime");
        }
    }
}
