using QLthueBao.Models.DomainModel;
using QLthueBao.Models.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace QLthueBao.Models.Service
{
    public class LoginService
    {
        protected List<NhaMang> DSNhaMang { get; set; }

        public LoginViewModel loginViewModel;

        public LoginService()
        {
            this.DSNhaMang = new List<NhaMang>();
            this.loginViewModel = new LoginViewModel();
            this.loginViewModel.NhaMang = new List<NhaMang>();

            using (var context = new Model1())
            {
                var query = context.NhaMangs;
                foreach (var item in query)
                {
                    this.DSNhaMang.Add(item);
                }
            }
        }
        public LoginViewModel Get()
        {
            this.loginViewModel.NhaMang = this.DSNhaMang;
            return loginViewModel;
        }

    }
}