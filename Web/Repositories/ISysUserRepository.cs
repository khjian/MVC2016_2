using System.Linq;
using Web.Models;

namespace Web.Repositories
{
    public interface ISysUserRepository
    {
        //查询所有用户
        IQueryable<SysUser> SelectAll();

        //通过用户名查询用户
        SysUser SelectByName(string userName);

        //添加用户
        void Add(SysUser sysUser);

        //删除用户
        bool Delete(int id);

        //编辑用户
        void Update(SysUser sysUser);
    }
}
