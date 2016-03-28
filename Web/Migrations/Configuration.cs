namespace Web.Migrations
{
    using Models;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Web.DAL.AccountContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(DAL.AccountContext context)
        {
            //#region 初始化数据
            //var sysUsers = new List<SysUser>
            //{
            //    new SysUser { UserName = "Tom",Email="Tom@sohu.com",Password="1"},
            //    new SysUser { UserName = "Jerry",Email="Jerry@sohu.com",Password="2"}
            //};
            //sysUsers.ForEach(s => context.SysUsers.AddOrUpdate(p => p.UserName, s));
            //context.SaveChanges();

            //var sysRoles = new List<SysRole>
            //{
            //    new SysRole { RoleName = "Administrators",RoleDesc="Administrators have full authorization to perform system administation."},
            //    new SysRole { RoleName = "General Users",RoleDesc="General Users can access the shared data they authorezed for."}
            //};
            //sysRoles.ForEach(s => context.SysRoles.AddOrUpdate(r => r.RoleName, s));
            //context.SaveChanges();

            //var sysUserRoles = new List<SysUserRole>
            //{
            //    new SysUserRole {
            //        SysUserID = sysUsers.Single(s=>s.UserName == "Tom").ID,
            //        SysRoleID = sysRoles.Single(s=>s.RoleName == "Administrators").ID
            //    },
            //    new SysUserRole {
            //        SysUserID = sysUsers.Single(s=>s.UserName == "Tom").ID,
            //        SysRoleID = sysRoles.Single(s=>s.RoleName == "General Users").ID
            //    },
            //    new SysUserRole {
            //        SysUserID = sysUsers.Single(s=>s.UserName == "Jerry").ID,
            //        SysRoleID = sysRoles.Single(s=>s.RoleName == "General Users").ID
            //    }
            //};

            //foreach (SysUserRole item in sysUserRoles)
            //{
            //    var sysUserRoleInDataBase = context.SysUserRoles.Where(s =>
            //    s.SysUser.ID == item.SysUserID && s.SysRole.ID == item.SysRoleID).SingleOrDefault();
            //    if (sysUserRoleInDataBase == null)
            //    {
            //        context.SysUserRoles.Add(item);
            //    }
            //}
            //#endregion

        }
    }
}
