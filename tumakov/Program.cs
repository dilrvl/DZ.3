using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tumakov
{
    internal class Program
    {
        static void Task1()
        {
            Console.WriteLine("Упражнение 4.1");
            Console.WriteLine("Введите номер дня в году (от 1 до 365): ");
            int dayyear = int.Parse(Console.ReadLine());
            // Массив с количеством дней в каждом месяце (не високосный год)
            int[] dayMonth = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
            string[] monthname = { "января", "февраля", "марта", "апреля", "мая", "июня", "июля", "августа", "сентября", "октября", "ноября", "декабря" };
            int month = 0;
            //Определение месяца и дня
            while (dayyear > dayMonth[month])
            {
                dayyear -= dayMonth[month];
                month++;
            }
            Console.WriteLine($"День {dayyear} года соответсвует {dayyear} {monthname[month]}");
        }
        static void Task2()
        {
            Console.WriteLine("Упражнение 4.2");
            Console.WriteLine("Введите номер дня в году (от 1 до 365): ");
            int dayyear;
            //Проверка на корректность ввода 
            while
                (!int.TryParse(Console.ReadLine(), out dayyear) || dayyear < 1 || dayyear > 365)
            {
                Console.WriteLine(" Пожалуйста введите корректное число от 1 до 365. ");
            }
            // Массив с количеством дней в каждом месяце (не високосный год)
            int[] dayMonth = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
            string[] monthname = { "января", "февраля", "марта", "апреля", "мая", "июня", "июля", "августа", "сентября", "октября", "ноября", "декабря" };
            int month = 0;
            //Определение месяца и дня
            while (dayyear > dayMonth[month])
            {
                dayyear -= dayMonth[month];
                month++;
            }
            Console.WriteLine($"День {dayyear} года соответсвует {dayyear} {monthname[month]}");
        }
        static void Task3()
        {
            Console.WriteLine("Домашнее задание 4.1");
            Console.WriteLine("Введите год: ");
            int year = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите номер дня в году (от 1 до 365): ");
            int dayyear = int.Parse(Console.ReadLine());
            //Проверка является ли год високосным
            bool Year = (year % 4 == 0 && year % 100 != 0) || (year % 400 == 0);
            // Массив с количеством дней в каждом месяце (не високосный год)
            int[] dayMonth = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
            string[] monthname = { "января", "февраля", "марта", "апреля", "мая", "июня", "июля", "августа", "сентября", "октября", "ноября", "декабря" };
            int month = 0;
            //Определение месяца и дня
            while (dayyear > dayMonth[month])
            {
                dayyear -= dayMonth[month];
                month++;
            }
            Console.WriteLine($"День {dayyear} года соответсвует {dayyear} {monthname[month]}");
        }





        static void Main(string[] args)
        {
            Task1();
            Task2();
            Task3();


        }
    }
}
