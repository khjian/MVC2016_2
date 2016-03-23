using System.Data.Entity;
using System.Linq;
using System.Web.Mvc;
using Web.DAL;
using Web.Models;

namespace Web.Controllers
{
    public class AccountController : Controller
    {
        private AccountContext db = new AccountContext();
        // GET: Account
        public ActionResult Index()
        {
            return View(db.SysUsers);
        }

        //新建用户
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(SysUser sysUser)
        {
            db.SysUsers.Add(sysUser);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        //修改用户
        public ActionResult Edit(int id)
        {
            SysUser sysUser = db.SysUsers.Find(id);
            return View(sysUser);
        }
        [HttpPost]
        public ActionResult Edit(SysUser sysUser)
        {
            db.Entry(sysUser).State = EntityState.Modified;
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        //删除用户
        public ActionResult Delete(int id)
        {
            SysUser sysUser = db.SysUsers.Find(id);
            return View(sysUser);
        }
        [HttpPost,ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            SysUser sysUser = db.SysUsers.Find(id);
            db.SysUsers.Remove(sysUser);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult Details(int id)
        {
            SysUser sysUser = db.SysUsers.Find(id);
            return View(sysUser);
        }

        #region CURDdemo
        public ActionResult EFQueryDemo()
        {
            //1,[基本查询] 查询所有的SysUser
            var users = from u in db.SysUsers
                        select u;//表达式方式
            users = db.SysUsers;//函数式方式

            //2,[条件查询] 加入查询条件
            users = from u in db.SysUsers
                    where u.UserName == "Tom"
                    select u;//表达式方式
            users = db.SysUsers.Where(u => u.UserName == "Tom");//函数式方式

            //3,[排序和分页查询]
            users = (from u in db.SysUsers
                     orderby u.UserName
                     select u).Skip(0).Take(5);//表达式方式
            users = db.SysUsers.OrderBy(u => u.UserName).Skip(0).Take(5);//函数式方式

            //4,[聚合查询]
            //查user总数
            var num = db.SysUsers.Count();
            //查最小ID
            var minId = db.SysUsers.Min(u => u.ID);

            //5,连接查询
            var users2 = from ur in db.SysUserRoles
                         join u in db.SysUsers
                         on ur.SysUserID equals u.ID
                         select ur;

            return View();
        }

        public ActionResult EFUpdateDemo()
        {
            var sysUser = db.SysUsers.FirstOrDefault(u => u.UserName == "Tom");
            if (sysUser != null)
            {
                sysUser.UserName = "Tom2";
            }
            db.SaveChanges();
            return View();
        }

        public ActionResult EFAddDemo()
        {
            //添加
            //1.创建新的实体
            var newSysUser = new SysUser()
            {
                UserName = "Scott",
                Password = "tiger",
                Email = "Scott@sohu.com"
            };
            //2.增加
            db.SysUsers.Add(newSysUser);
            //3.保存修改
            db.SaveChanges();

            return View("EFQueryDemo");
        }


        public ActionResult EFDeleteDemo()
        {
            //删除
            //1.找到需要删除的对象
            var delSysUser = db.SysUsers.FirstOrDefault(u => u.UserName == "Scott");
            //2.删除
            if (delSysUser != null)
            {
                db.SysUsers.Remove(delSysUser);
            }
            //3.保存修改
            db.SaveChanges();
            return View("EFQueryDemo");
        }
        #endregion

        #region 注册和登陆
        public ActionResult Login()
        {
            ViewBag.LoginState = "登录前。。。";
            return View();
        }

        [HttpPost]
        public ActionResult Login(FormCollection fc)
        {
            //获取表单数据
            string email = fc["inputEmail3"];
            string password = fc["inputPassword3"];

            var user = db.SysUsers.Where(b => b.Email == email && b.Password == password);
            if (user.Count() > 0)
            {
                //登录后的状态
                ViewBag.LoginState = email + "登陆后……";
            }
            else
            {
                ViewBag.LoginState = email + "用户不存在……";
            }
            return View();
        }

        public ActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Register(FormCollection fc)
        {
            //获取表单数据
            string email = fc["inputEmail3"];
            string password = fc["inputPassword3"];

            return View();
        }
        #endregion
    }
}