using QLthueBao.Models.DomainModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace QLthueBao.Models.ViewModel
{
    public class ThanhToanGoiViewModel
    {
        public User User { get; set; } = new User();
        public GoiCuoc GoiCuoc { get; set; } = new GoiCuoc();
    }
}