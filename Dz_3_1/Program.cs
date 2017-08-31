using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dz_3_1
{
    
    
    
    class Program
    {
        //метод защиты от "дурака"
        static int Input(string msg)
        {
            int x;
            bool flag;
            string s;

            do
            {
                Console.WriteLine(msg);
                s = Console.ReadLine();
                flag = int.TryParse(s, out x);
            }
            while (!flag);
            return x;

        }

        //структура комплехсных чисел
        struct Complex
        {
            public double re;//целая часть
            public double im;//мнимая часть
            //метод сложения 
            public Complex Plus( Complex a,Complex b)
            {
                Complex res = new Complex();
                res.re = a.re + b.re;
                res.im = a.im + b.im;
                return res;
            }
            //метод печати
            public Complex Minus (Complex a,Complex b)
            {
                Complex res = new Complex();
                res.re = a.re - b.re;
                res.im = a.im - b.im;
                return res;
            }
            //метод умножения
            public Complex Um(Complex a, Complex b)
            {
                Complex res = new Complex();
                res.re = a.re * b.re;
                res.im = a.im * b.im;
                return res;
            }

            //метод печати 
            public void PrintLine(Complex a)
            {
                Console.WriteLine("{0} + i{1}", a.re, a.im);
            }
        }


        
        //главный метод
        static void Main(string[] args)
        {
             Complex a, b;
             a.re = Input("Ведите число X целую часть: ");
             b.re = Input("Ведите число Y целую часть: ");
             a.im = Input("Ведите число X мнимую часть: ");
             b.im = Input("Ведите число Y мнимую часть: ");
            
             Console.WriteLine("Сложение комплексных чисел:       {0} + {1}i", a.Plus(a,b).re, a.Plus(a,b).im);
             Console.WriteLine("Умножение комплексных чисел:      {0} + {1}i", a.Um(a,b).re, a.Um(a,b).im);
             Console.WriteLine("Вычитание комплексных чисел:      {0} + {1}i", a.Minus(a,b).re, a.Minus(a,b).im);
            // Вывод комплексного числа а
            //a.PrintLine(a);

            Console.ReadKey();
        }
    }
}
