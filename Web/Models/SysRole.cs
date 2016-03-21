using System.Collections.Generic;

namespace Web.Models
{
    public class SysRole
    {
        public int ID { get; set; }
        public string RoleName { get; set; }
        public string RoleDesc { get; set; }
        public virtual ICollection<SysUserRole> SysUserRoles { get; set; }
    }
}