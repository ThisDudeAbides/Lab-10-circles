﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_10_circle
{
    class Circle
    {
        private double radius;




        public double Radius
        {
            get { return radius; }
            set { radius = value; }
        }
        public double CalculateCircumfrence()
        {
            double circumfrence = Math.PI * radius * 2;
            return circumfrence;
        }
        public string CalculateFormattedCircumfrence()
        {
            string formattedString = $"{CalculateCircumfrence(), 0:N2}";
            return formattedString;
        }
        public double CalculateArea()
        {
            double area = Math.PI * radius * radius;
            return area;
        }
        public string CalculatedFormattedArea()
        {
            string formatted = $"{CalculateArea(), 0:N2}";
            return formatted;

        }


    }
}







        


       
       




       
       


  


    

           
        

    

