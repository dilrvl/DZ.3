using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    internal class Program
    {
        enum DayOfWeek
        {
            Понедельник = 1,
            Вторник,
            Среда,
            Четверг,
            Пятница,
            Суббота,
            Воскресенье
        }
        static void Task1()
        {
            Console.WriteLine("Задание 1");
            int[] ints = new int[10];
            Console.WriteLine("Введите числа для последовательности!");
            int znach = int.Parse(Console.ReadLine());
            for (int i = 1; i < 10; i++)
            { 
                int peremen = int.Parse(Console.ReadLine());

                if (peremen > znach)
                {
                    znach = peremen; 
                }
                else if (i == 9 && peremen > znach)
                {
                    Console.WriteLine("Последовательность не нарушена!");
                }
                else
                {
                    Console.WriteLine($"Последовательность из чисел обрывается на {i + 1}-ом числе!");
                    break;
                }
            
            }
        }
        static void Task2()
        {
            Console.WriteLine("Введите порядковый номер карты (от 6 до 14):");
            string input = Console.ReadLine();
            int cardnumber;

            try
            {
                // Проверка, является ли введенная строка числом
                if (!int.TryParse(input, out cardnumber))
                {
                    throw new FormatException("Введено недопустимое значение. Пожалуйста, введите число.");
                }
                // Проверка диапазона
                if (cardnumber < 6 || cardnumber > 14)
                {
                    throw new ArgumentOutOfRangeException("Порядковый номер должен быть от 6 до 14.");
                }

                // Определение достоинства карты
                string cardvalue = GetCardValue(cardnumber);
                Console.WriteLine($"Достоинство карты: {cardvalue}");
            }
            catch (FormatException ex)
            {
                Console.WriteLine($"Ошибка: {ex.Message}");
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine($"Ошибка: {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Произошла непредвиденная ошибка: {ex.Message}");
            }
            finally
            {
                Console.WriteLine("Завершение программы.");
            }
        }
        static string GetCardValue(int number)
        {
            // Массив с достоинствами карт от 6 до 14
            string[] cardValues = { "Шестёрка", "Семёрка", "Восьмёрка", "Девятка", "Десятка", "Валет", "Дама", "Король", "Туз" };
            // Индекс в массиве соответствует порядковому номеру карты
            return cardValues[number - 6]; // Вычитаем 6, чтобы получить правильный индекс
        }
        static void Task4()
        {
            Console.WriteLine("Введите порядковый номер дня недели (от 1 до 7):");
            string input = Console.ReadLine();
            // Проверка, является ли введенная строка числом
            if (int.TryParse(input, out int day))
            {
                // Проверка диапазона
                if (day >= 1 && day <= 7)
                {
                    // Получение названия дня недели из перечисления
                    DayOfWeek days = (DayOfWeek)day;
                    Console.WriteLine($"День недели: {days}");
                }
                else
                {
                    Console.WriteLine("Ошибка: Порядковый номер должен быть от 1 до 7.");
                }
            }
            else
            {
                Console.WriteLine("Ошибка: Введено недопустимое значение. Пожалуйста, введите число.");
            }
        }
        static void Task5()
        {
            Console.WriteLine("Задание 5: ");
            // Создаем массив строк с игрушками
            string[] toys = { "Hello Kitty", "Car", "Barbie doll", "Ball", "Doll", "Hello Kitty", "Teddy Bear", "Barbie doll" };
            // Переменная для подсчета кукол в "сумке"
            int сount = 0;
            // Обходим массив с помощью foreach
            foreach (string toy in toys)
            {
                // Проверяем, является ли игрушка "Hello Kitty" или "Barbie doll"
                if (toy == "Hello Kitty" || toy == "Barbie doll")
                {
                    сount++; // Увеличиваем счетчик
                }
            }
            // Выводим количество кукол в "сумке"
            Console.WriteLine($"Количество кукол в 'сумке': {сount}");
        }

            static void Main(string[] args)
        {
            Task1();
            Task2();
            Task4();
            Task5();
        }
    }
}
