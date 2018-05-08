using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace lab_10_circle
{
    class Program
    {
        static int counter;
        static void Main(string[] args)
        {
            bool repeat = true;
            {
                while (repeat)
                {
                    Console.WriteLine("please enter the radius");
                    {
                        Circle circle1 = new Circle();

                        
                        circle1.Radius = double.Parse(Console.ReadLine());
                        circle1.Radius = 3.14;
                        double circumfrence = circle1.CalculateCircumfrence();

                        double area = circle1.CalculateArea();
                        string formattedCir = circle1.CalculateFormattedCircumfrence();
                        string formattedArea = circle1.CalculatedFormattedArea();
                        Console.WriteLine($"{circumfrence} is the circumfrence\n{formattedCir} is the formatted circumfrence\n{area} is the area and\n{formattedArea} is the formatted area");

                        counter++;
                                              
                    }
                    Console.WriteLine("would you like to continue? (1) to continue and (2) to end");
                    string response = Console.ReadLine();

                    if (response == "2")
                    {
                        Console.WriteLine($"you entered {counter} number of circles, goodbye");
                        
                        break;
                    }
                   
                    
                    

                    
                           
                }
                
            }
                

        }
    }
        
        

}

