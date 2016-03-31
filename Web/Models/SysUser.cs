using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Web.Models
{
    public class SysUser
    {
        public int ID { get; set; }
        [Required(AllowEmptyStrings = false, ErrorMessage = "请输入{0}")]
        [StringLength(20, MinimumLength = 3, ErrorMessage = "{0}的长度在{2}至{1}个字符间")]
        [Column("LoginName"),Display(Name ="用户名")]
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString ="{0:yyyy-MM-dd}",ApplyFormatInEditMode =true)]
        public DateTime CreateDate { get; set; }
        public virtual ICollection<SysUserRole> SysUserRoles { get; set; }
        public int? SysDepartmentID { get; set; }
        public virtual SysDepartment SysDepartment { get; set; }
    }
}