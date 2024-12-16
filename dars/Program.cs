using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dars
{
    internal class Program
    {
    
        static void Main(string[] args)
        {
            Console.Write("10-lik sanoq sistemasidagi sonni kiriting: ");
            int s = int.Parse(Console.ReadLine());

            string natija = "";
            string hexChars = "0123456789ABCDEF";

            while (s > 0)
            {
                int q = s % 16;
                natija = hexChars[q] + natija;
                s /= 16;
            }

            Console.WriteLine("16-lik sanoq sistemasidagi natija: " + natija);
            Console.ReadKey();
        }
    }

}
   
