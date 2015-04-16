using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppMultiplicacion
{
    class Program
    {
        static void Main(string[] args)
        {

            int i;
            
            try
            {
                for (i = 1; i <= 10; i++)
                {
                    Console.WriteLine("5 * " + i +"=" + 5*i );
                }
            }
            catch (Exception error)
            {
                Console.WriteLine("El error es:" + error.Message);
            }

            Console.ReadKey();
        }
    }
}
