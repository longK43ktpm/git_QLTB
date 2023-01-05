using QLthueBao.Models.DomainModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace QLthueBao.Models.ViewModel
{
    public class GoiCuocViewModel
    {
        public IEnumerable<GoiCuoc> DSGoiData { get; set; }
        public IEnumerable<GoiCuoc> DSGoiThoai { get; set; }
        public IEnumerable<GoiCuoc> DSGoiSMS { get; set; }

        public int page;
    }
}