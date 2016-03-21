using System.Collections.Generic;

namespace Web.Models
{
    public class SysUser
    {
        public int ID { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public virtual ICollection<SysUserRole> SysUserRoles { get; set; }
    }
}