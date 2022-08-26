using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Entities
{
    public class Product
    {
        [Key]
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public int Stock { get; set; }
        public double Price { get; set; }
        public bool IsPublish { get; set; }
        public User User { get; set; }
        public int UserID { get; set; }
        public Category Category { get; set; }
        public int CategoryID { get; set; }
        public Tag Tag { get; set; }
        public int TagID { get; set; }
    }
}
