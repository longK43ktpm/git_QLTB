using QLthueBao.Models.DomainModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace QLthueBao.Models.ViewModel
{
    public class HomePageViewModel
    {
        public IEnumerable<KhuyenMai> DSKhuyenMai { get; set; }
        public IEnumerable<GoiCuoc> DSGoiData { get; set; }
        public IEnumerable<GoiCuoc> DSGoiThoai { get; set; }
        public IEnumerable<GoiCuoc> DSGoiSMS { get; set; }
        public IEnumerable<GoiCuoc> DSCuocGiamDan { get; set; }
        public IEnumerable<User> DSUser { get; set; }


    }
}