using DataAccessLayer.Concrete;
using DataAccessLayer.Repositories;
using EntityLayer.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Manager
{
    public class ProductManager
    {
        Repository<Product> productRepo = new Repository<Product>();
        public List<Product> GetAll()
        {
            using (var c = new Context())
            {
                c.Products.Include(c => c.Category).ToList();
                c.Products.Include(c => c.Tag).ToList();
                return c.Products.Include(c => c.User).ToList();
            }

        }
        public List<Product> GetAllOnlyUserID(int p)
        {
            return productRepo.List(x => x.UserID == p);
        }
        public List<Product> GetOnlyProduct(int p)
        {
            return productRepo.List(x => x.ProductID == p);
        }
        public int BLAdd(Product c)
        {
            return productRepo.Insert(c);
        }

        public int BLDell(int p)
        {
            if (p != 0)
            {
                Product c = productRepo.Find(x => x.ProductID == p);
                return productRepo.Delete(c);
            }
            else
            {
                return -1;
            }
        }

        public int BLUpdate(Product p)
        {
            if (p.ProductName == "" || p.Stock < 0)
            {
                return -1;
            }
            Product ct = productRepo.Find(x => x.ProductID == p.ProductID);
            ct.UserID = p.UserID;
            ct.ProductID = p.ProductID;
            ct.CategoryID = p.CategoryID;
            ct.TagID = p.TagID;
            ct.ProductName = p.ProductName;
            ct.Price = p.Price;
            ct.Stock = p.Stock;
            ct.IsPublish = p.IsPublish;
            return productRepo.Update(ct);

        }
    }
}
