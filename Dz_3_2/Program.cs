using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Dz_3_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 0;
            StreamReader fil = new StreamReader("dat.txt");


            do
            {
                try {

                    n = Convert.ToInt32(fil.ReadLine());

                    if (n == 0)
                    {
                        continue;
                    }
                    else
                    {

                        Console.WriteLine(n);
                    }


                }
                
                catch (Exception e)
                {
                    Console.WriteLine("Ошибка: " + e.Message);
                }
            }
                while (n != 0) ;
           
            Console.ReadKey();
            fil.Close();
        }
    }
}
