﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vend.Classes;

namespace Vend
{
    public class Program
    {
        static void Main(string[] args)
        {

            VendMachine vending = new VendMachine();
            vending.VendMethod();
        }
    }
}
