using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args) => Load();

        public static void Load()
        {
            Console.Clear();
            Console.Write("Введите имя для талицы рекордов: ");
            string text = Console.ReadLine();
            
            new TypingMenu(0, 10, new TypingData(text));
        }
    }
}
