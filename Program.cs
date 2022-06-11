using System;
using static System.Console;


namespace lesson_4_8_3

{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("\nДобро пожаловать в игру \"Угадай число\" от 0 до N. \nВведите число N и нажмите клавишу \"Enter\": ");
            Random rand = new Random();
            int length = int.Parse(ReadLine());
            int a = rand.Next(0, length);
            int count = 0;
            while (true)
            {
                WriteLine("\nВведите целое число, если играть надоело введите слово \"стоп\" и нажмите клавишу \"Enter\": ");
                count++;
                string num = ReadLine();
                switch (num)
                {
                        case "стоп":
                        WriteLine($"Вы вышли из игры, загаданное число = {a}");
                        break;
                        default:
                        int number = Convert.ToInt32(num);
                        if (number > a)
                        {
                            Write("\nВведённое число больше загаданного. Попробуйте ещё раз");
                            continue;
                        }
                        else if (number < a)
                        {
                            Write("\nВведённое число меньше загаданного. Попробуйте ещё раз");
                            continue;
                        }
                        else
                        {
                            Write($"Поздравляю, число угадано! Число попыток: {count}");
                            break;
                        }
                }
                ReadKey();
                break;
            }
        }
        
    }
}