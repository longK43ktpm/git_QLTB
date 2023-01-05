using QLthueBao.Models.DomainModel;
using QLthueBao.Models.Service;
using QLthueBao.Models.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace QLthueBao.Controllers
{
    public class AccountController : Controller
    {
        protected LoginService LoginService { get; set; } = new LoginService();
        public ActionResult Login()
        {
            return View(LoginService.Get());
        }

        [HttpPost]
        public ActionResult Login(LoginViewModel objUser)
        {
            if (ModelState.IsValid)
            {
                using (Model1 db = new Model1())
                {
                    var obj = db.Users.Where(a => a.Name.Equals(objUser.UserName) && a.Password.Equals(objUser.PassWord)).FirstOrDefault();
                    if (obj != null)
                    {
                        Session["UserID"] = obj.Id.ToString();
                        Session["UserName"] = obj.Name.ToString();
                        return RedirectToAction("index", "home");
                    }
                }
            }
            return View(LoginService.Get());
        }
        public ActionResult Logout()
        {
            Session.Remove("UserID");
            Session.Remove("UserName");
            return RedirectToAction("index", "home");
        }

        [HttpPost]
        public ActionResult SignUp(SignUpViewModel objUser)
        {
            if (ModelState.IsValid)
            {
                using (Model1 db = new Model1())
                {
                    SignUpService service = new SignUpService();
                    if (!service.isExistAccount(objUser.UserName))
                    {
                        service.RegisterAccount(objUser);
                        Session["action"] = "login";
                        Session["controller"] = "account";
                        Session["tb"] = "Đăng ký tài khoản mới thành công";
                        return RedirectToAction("thongbao", "home");
                    }
                }
            }
            Session["action"] = "login";
            Session["controller"] = "account";
            Session["tb"] = "Đăng ký tài khoản mới thất bại";
            return RedirectToAction("thongbao", "home");
        }
    }
}