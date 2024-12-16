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

            while (s > 0)
            {
                int q = s % 8;
                natija = q + natija;
                s /= 8;
            }

            Console.WriteLine("8-lik sanoq sistemasidagi natija: " + natija);
            Console.ReadKey();
        }
    }
}
