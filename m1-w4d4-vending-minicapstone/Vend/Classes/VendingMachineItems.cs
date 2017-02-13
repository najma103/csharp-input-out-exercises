using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vend.Classes
{
    public class VendingMachineItems
    {
        private string slot = "";
        private string name = "";
        private double price = 0.00;
        private int quantity = 0;
        private int quantityRemaining = 0;

        public string Slot
        {
            get { return slot; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public double Price
        {
            get { return price; }
            set { price = value; }
        }
        public int Quantity
        {
            get { return quantity; }
            set { quantity = value; }
        }
        public int QuantityRemaining
        {
            get { return quantityRemaining; }
            set { quantityRemaining = value; }
        }

    }
}
