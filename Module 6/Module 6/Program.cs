﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Triangle te = new Triangle(5, 10, 10);
            Console.WriteLine(te.Area());

            Console.Read();
        }
    }
}