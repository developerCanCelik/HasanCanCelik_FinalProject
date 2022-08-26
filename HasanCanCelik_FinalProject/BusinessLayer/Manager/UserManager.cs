using DataAccessLayer.Repositories;
using EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Manager
{
    public class UserManager
    {
        Repository<User> userRepo = new Repository<User>();
        public List<User> GetAll()
        {
            return userRepo.List();
        }
        public List<User> GetByEmail(string p)
        {
            return userRepo.List(x => x.Email == p);
        }
        public int BLAdd(User u)
        {
            return userRepo.Insert(u);
        }
        public int BLUpdate(User p)
        {
            if (p.Email == "" || p.UserName.Length <= 2)
            {
                return -1;
            }
            User u = userRepo.Find(x => x.UserID == p.UserID);
            u.UserName = p.UserName;
            u.Email = p.Email;
            u.Password = p.Password;
            u.IsAdmin = p.IsAdmin;
            return userRepo.Update(u);
        }
    }
}
