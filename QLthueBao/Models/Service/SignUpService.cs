using QLthueBao.Models.DomainModel;
using QLthueBao.Models.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace QLthueBao.Models.Service
{
    public class SignUpService
    {
        public bool isExistAccount(string account)
        {

            Model1 db = new Model1();
            User taikhoan = (from tk in db.Users
                             where tk.Name.Equals(account)
                             select tk).SingleOrDefault();
            if (taikhoan != null)
            {
                return true;
            }
            return false;
        }
        public void RegisterAccount(SignUpViewModel register)
        {
            Model1 db = new Model1();
            int idNM = 1;
            switch (register.TenNhaMang)
            {
                case "Viettel":
                    idNM = 1;
                    break;
                case "MobiFone":
                    idNM = 4;
                    break;
                case "VinaPhone":
                    idNM = 5;
                    break;
                case "Vietnamobile":
                    idNM = 6;
                    break;
            }
            User account = new User
            {
                Name = register.UserName,
                Password = register.Password,
                Phone_number = register.Sdt,
                Created = DateTime.Now,
                Tai_khoan_goc = 30000,
                Id_nha_mang = idNM,

            };
            db.Users.Add(account);
            db.SaveChanges();

        }
    }
}