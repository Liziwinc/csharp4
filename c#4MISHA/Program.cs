using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace c_4MISHA
{
    internal class Program
    {
        [DllImport("DLLForSharp.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern void input(double[] array);
        [DllImport("DLLForSharp.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern void output(double[] array);
        [DllImport("DLLForSharp.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern void summa(double[] array,int i,int j);
        static void Main()
        {
            double[] array = new double[11];
            int menu;
            int X, Y;
            input(array);
            do
            {
                Console.Clear();
                Console.WriteLine("1.Ввод массива");
                Console.WriteLine("2.Вывод массива");
                Console.WriteLine("3.Обработка массива");
                Console.WriteLine("0.Выход");
                if (!Int32.TryParse(Console.ReadLine(), out menu))
                {
                    Console.WriteLine("Некорректный ввод");
                    menu = -1;
                }
                switch (menu)
                {
                    case 1:
                        Console.Clear();
                        input(array);
                        Console.ReadKey();
                        break;
                    case 2:
                        Console.Clear();
                        output(array);
                        Console.ReadKey();
                        break;
                    case 3:
                        Console.Clear();                        
                        do
                        {
                            Console.WriteLine("Введите X: ");
                        } while (!Int32.TryParse(Console.ReadLine(), out X)||X<0||X>9);
                        do
                        {
                            Console.WriteLine("Введите Y: ");
                        } while (!Int32.TryParse(Console.ReadLine(), out Y) || Y <= X || Y > 10);
                        summa(array,X,Y);
                        Console.ReadKey();
                        break;
                }
            } while (menu != 0);
        }
    }
}
