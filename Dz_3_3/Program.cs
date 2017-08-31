using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dz_3_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int ch, zn,caseSwitch;
            Console.WriteLine("Введиете числитель для первой дроби");
            ch = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите знаменаменатель для первой дроби");
            zn = Convert.ToInt32(Console.ReadLine());
            Drob a = new Drob(ch, zn);
            //Drob d1 = new Drob(3,4);
            ch = 0;
            zn = 0;
            Console.WriteLine("Введиете числитель для второй дроби");
            ch = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите знаменаменатель для второй дроби");
            zn = Convert.ToInt32(Console.ReadLine());
            Drob b = new Drob(ch,zn);
            // d1.PrintDrob();
            Drob c = new Drob();
            Console.WriteLine("Выберите действие" + "\n1_+" + "\n2_-"+ "\n3_*"+ "\n4_/");
            caseSwitch = Convert.ToInt32(Console.ReadLine());
            switch (caseSwitch)
            {
                case 1:
                    Console.WriteLine("Вы выбрали сложение");
                    c.Plus(a, b);
                    break;

                case 2:
                    Console.WriteLine("Вы выбрали разность");
                    c.Minus(a, b);
                    break;


                case 3:
                    Console.WriteLine("Вы выбрали умножение");
                    c.Umno(a, b);
                    break;

                case 4:
                    Console.WriteLine("Вы выбрали деление");
                    c.Delenie(a, b);
                    break;



            }


            Console.ReadKey();
        }
    }
}
