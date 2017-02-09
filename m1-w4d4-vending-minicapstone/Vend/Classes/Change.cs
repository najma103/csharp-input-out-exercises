using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vend.Classes
{
    public class Change
    {

        public double balance;
        public double Balance
        {
            get { return balance; }
            set { balance = value; }
        }

        public void UpdateBalance(double balance)
        {
            this.balance += balance;
        }
    }
}
