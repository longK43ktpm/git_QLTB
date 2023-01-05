using QLthueBao.Models.ViewModel;
using QLthueBao.Models.DomainModel;
using QLthueBao.Models.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls;
using System.Web.UI;

namespace QLthueBao.Controllers
{
    public class HomeController : Controller
    {
        protected HomePageService HomePageService { get; set; } = new HomePageService();
        public ActionResult Index()
        {
            return View(HomePageService.Get());
        }
        public ActionResult GoiCuoc(int id = 1)
        {
            GoiCuocService service = new GoiCuocService();
            service.goiCuocViewModel.page = id;

            return View(service.Get());
        }
        
        public ActionResult UserMenu()
        {
            return PartialView();
        }
        public ActionResult ChiTiet(int? id = null)
        {
            if (id == null)
            {
                return RedirectToAction("GoiCuoc");
            }
            GoiCuocService service = new GoiCuocService();
            ChiTietViewModel detailPage = new ChiTietViewModel();
            detailPage.GoiCuoc = new GoiCuoc();
            detailPage.LoaiGoiCuoc = new LoaiGoiCuoc();
            detailPage.GoiCuoc = service.Find(id.Value);
            string loaiCuoc = "";
            switch (detailPage.GoiCuoc.Id_Loai_cuoc)
            {
                case 1: loaiCuoc = "Data";
                    break;
                case 2: loaiCuoc = "Thoại";
                    break;
                case 3: loaiCuoc = "SMS";
                    break;
            }
            detailPage.LoaiGoiCuoc.Name = loaiCuoc;
            return View(detailPage);
        }

        public ActionResult ThongBao()
        {
            return View();
        }
    }
}