using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class Triangle{
            double side_a;
            double side_b;
            double side_c;

            public Triangle(double a, double b, double c) //constructor
            {
                side_a = a;
                side_b = b;
                side_c = c;
            }
            public bool check_triangle()
            {
                /*
                As soon as all three fields have valid data in them, it needs to run the calculations to generate the triangle information.
                We’ll need to know whether the given values produce a valid triangle A simple calculation for this is to know that no two
                sides added up can be less than the other side
                (EG 3+4 > 5, so the above triangle is valid)
                */
                if (((side_a + side_b) > side_c) && ((side_a + side_c) > side_b) && ((side_b + side_c) > side_a))
                {
                    //cout << "This is a Valid Triangle" << endl;
                    return true;
                }
                else
                {
                    Console.WriteLine("This is not a valid Triangle\n");
                    return false;
                }
            }
            public void triangle_type()
            {
                if (side_a == side_b && side_b == side_c)
                {
                    Console.WriteLine("This is an Equalateral Triangle and it is valid\n");
                }
                else if (side_a == side_b || side_a == side_c || side_b == side_c)
                {
                    Console.WriteLine("This is an Isosceles Triangle and it is valid\n");
                }
                else if (((Math.Pow(side_a, 2) + Math.Pow(side_b, 2) == Math.Pow(side_c, 2))) || ((Math.Pow(side_a, 2) + Math.Pow(side_c, 2) == Math.Pow(side_b, 2))) || ((Math.Pow(side_b, 2) + Math.Pow(side_c, 2) == Math.Pow(side_a, 2))))
                {
                    Console.WriteLine("This is a Right Triangle and it is valid\n");
                }
                else
                {
                    Console.WriteLine("This is a Triangle and it is valid\n");
                }
            }
    }

    
    class Program
    {
        static double check_input(double value, string input)
        {
            while (!double.TryParse(input, out value) || Convert.ToDouble(input) <= 0)
            {
                Console.WriteLine("This is Not a Valid Length. Please Enter a Valid Length.");
                input = Console.ReadLine();
            }
            Console.WriteLine("That is a Valid Length\n");
            value = Convert.ToDouble(input);

            return value;
        }
        
        static void Main(string[] args)
        {
            string input;
            double a = 0;
            double b = 0;
            double c = 0;

            /* Input Lengths */
            Console.WriteLine("Please Enter Length A");

            input = Console.ReadLine();
            a = check_input(a, input);

            Console.WriteLine("Please Enter Length B");
            input = Console.ReadLine();
            b = check_input(b, input);
            
            Console.WriteLine("Please Enter Length C");

            input = Console.ReadLine();
            c = check_input(c, input);      

            Console.WriteLine("Here Are Your Inputs\n");
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);
            Console.WriteLine("\n");
            
            Triangle createdTriangle = new Triangle(a, b, c);


            if (createdTriangle.check_triangle())
            {
                createdTriangle.triangle_type();
            }
            

            Console.ReadLine();
        }
    }
}
