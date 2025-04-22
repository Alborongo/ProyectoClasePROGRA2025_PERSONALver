using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public string Descr { get; set; }

        public Product()
        {

        }

        //CONSTRUCTOR
        public Product(string name, double price, string descr)
        {
            this.Name = name;
            this.Price = price;
            this.Descr = descr;
        }

        //FUNCION IVA
        public double FinalPrice()
        {
            return this.Price * 1.21;
        }

    }
}
