using QLthueBao.Models.DomainModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace QLthueBao.Models.Service
{
    public class KhuyenMaiService
    {
        protected List<KhuyenMai> DSKhuyenMai { get; set; }
        public KhuyenMaiService()
        {
            this.DSKhuyenMai = new List<KhuyenMai>();
            using (var context = new Model1())
            {
                var query = context.KhuyenMais;
                foreach (var item in query)
                {
                    DSKhuyenMai.Add(item);
                }
            }
        }

        public List<KhuyenMai> Get()
        {
            return DSKhuyenMai;
        }
    }
}