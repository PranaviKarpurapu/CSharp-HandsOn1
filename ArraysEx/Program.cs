using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysEx
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] i = new int[4];
            i[0] = 17;
            i[1] = 28;
            i[2] = 35;
            i[3] = 40;

            int k = i[2];
            Console.WriteLine(i[1]+"\n");

            for(int a=0;a<4;a++)
            {
                Console.WriteLine(i[a]);
            }
            Console.WriteLine("\n");
            foreach(int no in i)
            {
                Console.WriteLine(no);
            }
            Console.ReadKey();
        }
    }
}
