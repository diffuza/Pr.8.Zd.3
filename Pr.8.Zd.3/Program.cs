using System;
namespace Hello
{
    class Program
    {
        static void Main()
        {
            Console.Write("Введите значение координаты x=");
            float x = float.Parse(Console.ReadLine());
            Console.Write("Введите значение координаты y=");
            float y = float.Parse(Console.ReadLine());
            if (-23<x && x<0 && x<y && y<0 )
                Console.WriteLine("Точка (x,y) лежит внутри закрашенной области");
            else if (-23>x || x>0 || y>0 )
                Console.WriteLine("Точка (x,y) лежит вне закрашенной области");
            else Console.WriteLine("Точка (x,y) лежит на границе закрашенной области");
        }
    }
}