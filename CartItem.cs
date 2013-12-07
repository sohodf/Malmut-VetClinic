using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Vet_Clinic
{
    class CartItem
    {
        private String Name;
        private float price;
        private string desc;

        public CartItem(String name, float price, string desc)
        {
            this.Name = name;
            this.price = price;
            this.desc = desc;
        }

        public String ToString()
        {
            return Name + price.ToString() + desc;
        }
    }
}
