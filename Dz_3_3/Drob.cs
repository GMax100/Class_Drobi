using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dz_3_3
{
    class Drob
    {
        private int chislitel, znamenal;
        //нулевой конструктор
        public Drob()
        {
            chislitel = 0;
            znamenal = 0;
        }
        //инициализация дроби
        public Drob(int _chslitel, int _znamenal)
        {
            chislitel = _chslitel;
            znamenal = _znamenal;
        }
        // метод вывода дроби
        public void PrintDrob()
        {
            Console.WriteLine("_"+ chislitel +"_");
            Console.WriteLine(" " + znamenal);
        }
        //метод сложения дробей 
        public void Plus(Drob a, Drob b)
        {
            Drob c = new Drob();
            if (a.znamenal == b.znamenal)
            {
                c.znamenal = a.znamenal;
                //c.znamenal = a.znamenal * b.znamenal;//общий знаменатель
                c.chislitel = a.chislitel  + b.chislitel ;
                
            }
            else
            {
                c.znamenal = a.znamenal * b.znamenal;//общий знаменатель
                c.chislitel = a.chislitel * b.znamenal + b.chislitel * a.znamenal;
            }

            c.PrintDrob();
        }
        //метод вычитания дробей 
        public void Minus(Drob a,Drob b)
        {
            Drob c = new Drob();
            if (a.znamenal == b.znamenal)
            {
                c.znamenal = a.znamenal;
                //c.znamenal = a.znamenal * b.znamenal;//общий знаменатель
                c.chislitel = a.chislitel - b.chislitel;

            }
            else
            {
                c.znamenal = a.znamenal * b.znamenal;//общий знаменатель
                c.chislitel = a.chislitel * b.znamenal - b.chislitel * a.znamenal;
            }

            c.PrintDrob();

        }
        //метод умножения 
        public void Umno(Drob a,Drob b)
        {
            Drob c = new Drob();
            c.chislitel = a.chislitel * b.chislitel;
            c.znamenal = b.znamenal * a.znamenal;
            c.PrintDrob();
        }
        //метод деления 
        public void Delenie(Drob a,Drob b)
        {
            Drob c = new Drob();
            c.chislitel = a.chislitel * b.znamenal;
            c.znamenal = b.chislitel * a.znamenal;
            c.PrintDrob();
        }
    }
}
