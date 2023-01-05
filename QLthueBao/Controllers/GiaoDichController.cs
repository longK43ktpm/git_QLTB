using QLthueBao.Models.Service;
using QLthueBao.Models.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Web;
using System.Web.Mvc;

namespace QLthueBao.Controllers
{
    public class GiaoDichController : Controller
    {
        public ActionResult NapTien()
        {
            return View();
        }
        public ActionResult ThanhToanThe()
        {
            return View();
        }
        public ActionResult LichSu()
        {
            return View();
        }
        public ActionResult TraCuoc()
        {
            return View();
        }
        public ActionResult ThanhToanGoi(int idGoi)
        {
            UserService service = new UserService();
            GoiCuocService service2 = new GoiCuocService();
            ThanhToanGoiViewModel vm = new ThanhToanGoiViewModel();
            if (Session["UserID"] == null)
                return RedirectToAction("login", "account");
            vm.User = service.Find(int.Parse(Session["UserID"].ToString()));
            vm.GoiCuoc = service2.Find(idGoi);
            return View(vm);
        }
    }
}