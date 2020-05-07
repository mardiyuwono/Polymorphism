﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    public class Canon : PrinterWindows
    {
        public override void Show()
        {
            Console.WriteLine("\nEpson display dimension : 9.5*12");
        }

        public override void Print()
        {
            Console.WriteLine("Epson printer printing....");
        }
    }
}