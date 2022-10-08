using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsCollections 
{ 
    class Generics
    {
       
        public delegate T Delegate<T>(T num);
        class cal
        {
            public int square(int num)
            {
                return (num*num);
            }
            public int cube(int n)
            {
                return (n*n*n);
            }
            public double square(double n)
            {
                return (n*n);
            }
            public double cube(double n)
            {
                return (n*n*n);
            }
           public double circle(double r)
           {
            return (3.142 * r * r);
           }
        }
        class Program
        {
            static void Main(string[] args)
            {
                cal cal = new cal();
                Delegate<int> del = new Delegate<int>(cal.square);
                Console.WriteLine("square in int is : " + del(10));
               
                del = cal.cube;
                Console.WriteLine("cube in int is : " + del(3));

                
                Delegate<double> del1 = new Delegate<double>(cal.square);
                Console.WriteLine("square in double is: " + del1(10.5));
                
                del1 = cal.cube;
                Console.WriteLine("cube in double is : " + del1(9.5));

                del1 = cal.circle;
                Console.WriteLine("Area of circle is : " + del1(4));
                Console.ReadLine();
            }
        }
    }
}