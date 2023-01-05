using QLthueBao.Models.DomainModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace QLthueBao.Models.Service
{
    public class UserService
    {
        protected List<User> DSUser { get; set; }
        public UserService()
        {
            this.DSUser = new List<User>();
            using (var context = new Model1())
            {
                var query = context.Users;
                foreach (var item in query)
                {
                    this.DSUser.Add(item);
                }
            }
        }

        public List<User> Get()
        {
            return this.DSUser;
        }
        public User Find(int id)
        {
            User result = null;
            using (var db = new Model1())
            {
                result = db.Users.Find(id);
            }
            return result;
        }
    }
}