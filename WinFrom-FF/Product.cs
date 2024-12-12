using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFrom_FF
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Category { get; set; }
        public int QuantityInStock { get; set; }
        public double Price { get; set; }
        public double CostPrice { get; set;}
        public  double Discount { get; set; }
    }
}
