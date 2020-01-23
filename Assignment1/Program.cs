using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    class Program
    {
        public static string Display()
        {
            return "Welcome to the World of C#";
        }
        public static string Message(string name)
        {
            return "Hi!" + name + " Welcome to the world of C#";

        }
         static void Print(int i,int j)
        {
         while(i<=j)
            {
                Console.WriteLine(i);
                i++;
            }
            
        }
         public static string EvenNum(int no)
        {
            if (no % 2 == 0)
            {
                return "Even";
            }
            else
                return "Odd";
        }

        public static double Conv(double fh)
        {
            return ((fh - 32) * 5) / 9;


        }


        public static void Shop()
        {
            int choice;
            do
            {
                Console.WriteLine(" Enter your required product number : ");
                int pronum = int.Parse(Console.ReadLine());
                Console.WriteLine(" Enter No.of Quantity you required : ");
                int quan = int.Parse(Console.ReadLine());
                switch (pronum)
                {
                    case 1:
                        Console.WriteLine(quan * 22.5);
                        break;
                    case 2:
                        Console.WriteLine(quan * 44.50);
                        break;
                    case 3:
                        Console.WriteLine(quan * 9.98);
                        break;
                    default:
                        Console.WriteLine("Invalid Option");
                        break;

                }
                
                Console.WriteLine("Do you want to Continue? Yes(1) No(0)");
                 choice = int.Parse(Console.ReadLine());
            } while (choice == 1);
            if (choice!=1)
                Environment.Exit(0);

        }

         public static void Square(int sq)
        {
            for(int i=0;i<=sq;i++)
            {
                Console.Write(i * i+" ");
            }
        }

        public static int Factorial(int fact)
        {
            int res = 1;
            for (int i = 1; i <= fact; i++)
            {
                res = res* i;
            }
            return res;
        }

        public static int Fibonacci(int fib)
        {
            int res;
            if (fib == 0)
                return 0;
            else if (fib == 1)
                return 1;
            else
                res = ((Fibonacci(fib - 1) + Fibonacci(fib - 2)));
            if (res < 40)
                return res;

                
        }
 static void Main(string[] args)
        {
            /*Console.WriteLine(Display());

            Console.WriteLine("\n");

            Console.WriteLine("Enter your Name : ");
            string name = Console.ReadLine();
            Console.WriteLine(Message(name));

            Console.WriteLine("Enter any two numbers:");
            int i = int.Parse(Console.ReadLine());
            int j = int.Parse(Console.ReadLine());
            Print(i,j);
            


            Console.WriteLine("Enter a number:");
            int no = int.Parse(Console.ReadLine());
            Console.WriteLine(no + " is "+EvenNum(no));
            
            Console.WriteLine("Enter the temperature in Fahrenheit: ");
            int fh = int.Parse(Console.ReadLine());
            Console.WriteLine(Conv(fh));
            

            Console.WriteLine("ProductNumber \t Product Price");
            Console.WriteLine(" Product 1 \t    22.5"); 
            Console.WriteLine(" Product 2 \t    44.50");
            Console.WriteLine(" Product 3 \t    9.98");
            Shop();

            

            Console.WriteLine("Enter a number:");
            int sq = int.Parse(Console.ReadLine());
            Square(sq);

     
            Console.WriteLine("Enter a number:");
            int fact = int.Parse(Console.ReadLine());
            Console.WriteLine("Factorial of " +fact+ " is : "+ Factorial(fact));

    */
            Console.WriteLine("Fibonacci Series Till 40 : ");
            for(int i=0;i<=40 ;i++)
            {
                Console.WriteLine(Fibonacci(i));
                

            }


       
            Console.ReadKey();
        }
    }
}
