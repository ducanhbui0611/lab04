﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4._3
{
    internal class Circle:Shape
    {
        //phương thức nhập liệu 
        public void inputData()
        {
            Console.WriteLine("Nap ban kinh:");
            radius = int.Parse(Console.ReadLine());
        }
        //ghi đè phương thức tính diện tích 
        public override float Area()
        {
          return 3.4F* radius * radius;
        }
        //ghi đè phương thức tính chu vi 
        public override float Circumference()
        {
           return 2 * 3.14F*radius;
        }
    }
}
