using System.Runtime.Intrinsics.X86;

internal class Program
{
    private static void Main(string[] args)
    {
        int Input(string text) 
        {
            Console.Write(text);
            return Convert.ToInt32(Console.ReadLine());
        }

        double InputD(string text) 
        {
            Console.WriteLine(text);
            return Convert.ToDouble(Console.ReadLine());
        }

        

        /////HOME WORK/////HOME WORK/////HOME WORK/////HOME WORK/////HOME WORK//////HOME WORK//////HOME WORK/////HOME WORK/////
        
        void Task41() 
        {
            //Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
            //0, 7, 8, -2, -2-> 2
            //- 1, -7, 567, 89, 223-> 3

            int M = Input($"Сколько цифр будет введено?: ");
            int count = 0;
            int number= 0;
            for (int i = 0; i < M; i++)
            {
                number = Input("Введи целое число= ");
                if (number > 0)
                {
                    count++;
                }
            }

            Console.Write($"Вы ввели {count} число/числа/чисел > 0");
        }
        //Task41();

        void Task43() 
        {
            //Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых,
            //заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
            //b1 = 2, k1 = 5, b2 = 4, k2 = 9-> (-0, 5; -0,5)
            double b1 = InputD("Введи b1 = ");
            double k1 = InputD("Введи k1 = ");
            double b2 = InputD("Введи b2 = ");
            double k2 = InputD("Введи k2 = ");
            if (k1 / k2 != 1 & k1 % k2 != 1)  
            {
                double x = (b2 - b1) / (k1 - k2);
                double y = k1 * x + b1;
                Console.WriteLine($" Точка пересечения имеет коорджинаты ({x},{y})");
            }
            else
                Console.WriteLine($" Точек пересечения нет ");
            
        }
        Task43();
    }
}