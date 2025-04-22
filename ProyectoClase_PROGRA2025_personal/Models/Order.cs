using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    class Order
    {
        public Client client { get; set; }

        //LISTA
        private List<Product> productList = new List<Product>();

        //CONSTRUCTOR
        public Order()
        {

        }

        //FUNCIONES PRECIOS
        public double CalculateTotalIVA()
        {
            double finalTotal = 0;

            foreach(Product item in productList)
            {
                finalTotal += item.FinalPrice();
            }

            return finalTotal;
        }
        
        public double CalculateTotal()
        {
            double finalTotal = 0;

            foreach (Product item in productList)
            {
                finalTotal += item.Price;
            }

            return finalTotal;
        }


        
    }
}
