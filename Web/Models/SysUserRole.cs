namespace Web.Models
{
    public class SysUserRole
    {
        public int ID { get; set; }
        public int SysUserID { get; set; }
        public int SysRoleID { get; set; }
        public virtual SysUser SysUser { get; set; }
        public virtual SysRole SysRole { get; set; }
    }
}