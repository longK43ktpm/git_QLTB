using QLthueBao.Models.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace QLthueBao.Models.Service
{
    public class HomePageService
    {
        protected KhuyenMaiService khuyenMaiService;
        protected GoiCuocService goiCuocService;
        protected UserService userService;
        protected HomePageViewModel HomePageViewModel { get; set; }

        public HomePageService()
        {
            this.khuyenMaiService = new KhuyenMaiService();
            this.goiCuocService = new GoiCuocService();
            this.userService = new UserService();
            this.HomePageViewModel = new HomePageViewModel();
        }
        public HomePageViewModel Get()
        {
            this.HomePageViewModel.DSKhuyenMai = this.khuyenMaiService.Get();
            this.HomePageViewModel.DSCuocGiamDan = this.goiCuocService.GetTop5();
            this.HomePageViewModel.DSGoiData = this.goiCuocService.GetData();
            this.HomePageViewModel.DSGoiThoai = this.goiCuocService.GetThoai();
            this.HomePageViewModel.DSGoiSMS = this.goiCuocService.GetSMS();
            this.HomePageViewModel.DSUser = this.userService.Get();

            return this.HomePageViewModel;
        }

    }
}