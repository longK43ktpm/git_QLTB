using QLthueBao.Models.DomainModel;
using QLthueBao.Models.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;

namespace QLthueBao.Models.Service
{
    public class GoiCuocService
    {
        protected List<GoiCuoc> DSGoiData { get; set; }
        protected List<GoiCuoc> DSGoiThoai { get; set; }
        protected List<GoiCuoc> DSGoiSMS { get; set; }

        public GoiCuocViewModel goiCuocViewModel;
        public GoiCuocService()
        {
            this.DSGoiData = new List<GoiCuoc>();
            this.DSGoiThoai = new List<GoiCuoc>();
            this.DSGoiSMS = new List<GoiCuoc>();
            this.goiCuocViewModel = new GoiCuocViewModel();

            using (var context = new Model1())
            {
                var query = context.GoiCuocs.Where(x => x.Id_Loai_cuoc == 1);
                foreach (var item in query)
                {
                    this.DSGoiData.Add(item);
                }
            }

            using (var context = new Model1())
            {
                var query = context.GoiCuocs.Where(x => x.Id_Loai_cuoc == 2);
                foreach (var item in query)
                {
                    this.DSGoiThoai.Add(item);
                }
            }

            using (var context = new Model1())
            {
                var query = context.GoiCuocs.Where(x => x.Id_Loai_cuoc == 3);
                foreach (var item in query)
                {
                    this.DSGoiSMS.Add(item);
                }
            }
        }

        public List<GoiCuoc> GetData()
        {
            return this.DSGoiData;
        }
        public List<GoiCuoc> GetThoai()
        {
            return this.DSGoiThoai;
        }
        public List<GoiCuoc> GetSMS()
        {
            return this.DSGoiSMS;
        }
        public List<GoiCuoc> GetTop5()
        {
            List<GoiCuoc> topGoiCuoc = new List<GoiCuoc>();
            using (var context = new Model1())
            {
                var query = context.GoiCuocs.OrderByDescending(x => x.Luot_mua);
                foreach (var item in query)
                {
                    topGoiCuoc.Add(item);
                }
            }
            return topGoiCuoc;
        }
        public GoiCuocViewModel Get()
        {
            this.goiCuocViewModel.DSGoiData = this.DSGoiData;
            this.goiCuocViewModel.DSGoiThoai = this.DSGoiThoai;
            this.goiCuocViewModel.DSGoiSMS = this.DSGoiSMS;
            return this.goiCuocViewModel;
        }
        public GoiCuoc Find(int id)
        {
            GoiCuoc result = null;
            using (var db = new Model1())
            {
                result = db.GoiCuocs.Find(id);
            }
            return result;

        }
    }
}