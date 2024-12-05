using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using лаба_6;

namespace laba6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Task1();
            Task2();
            Task3();
            Task4();
        }
        static void Task1()
        /*Упражнение 7.1 Создать класс счет в банке с закрытыми полями: номер счета, баланс, тип
банковского счета (использовать перечислимый тип из упр. 3.1). Предусмотреть методы для
доступа к данным – заполнения и чтения. Создать объект класса, заполнить его поля и
вывести информацию об объекте класса на печать.
             */
        {
            Console.WriteLine("Упражнение 7.1");
            Bank bank = new Bank();
            try
            {
                bool Flag = true;
                while(Flag)
                {
                    Console.WriteLine("ввeдите id");
                    uint id = uint.Parse(Console.ReadLine());
                    Console.WriteLine("ввeдите имя");
                    string name = Console.ReadLine();
                    Console.WriteLine("введите фамилию");
                    string surname = Console.ReadLine();
                    bank.VvodInfo(id, name, surname);
                    Console.WriteLine("введите сумму денег на счету");
                    double balance = double.Parse(Console.ReadLine());

                    Console.WriteLine("какой типа счета будет \n напишите 1 если сберегательный \n напишите 2 если кредитный");
                    char st = char.Parse(Console.ReadLine());
                    switch (st)
                    {
                        case '1':
                            bank.Vvod(balance, accType.saving);
                            break;
                        case '2':
                            bank.Vvod(balance, accType.saving);
                            break;
                        default:
                            Console.WriteLine(" вы ввели неправильное значение");
                            break;
                    }
                    bank.Print();
                    Console.WriteLine("хотите выйти или заполнить заново. если хотите заполнить нажмите любую букву, а если выйти то любое число");

                    string input = Console.ReadLine();

                    // Проверяем, является ли введенное значение числом
                    if (double.TryParse(input, out _))
                    {
                        Flag = false; // Выход из цикла, если введено число
                    }
                }
            }
            catch (FormatException)
            {
                // Обработка случая, когда строка не является корректным числом
                Console.WriteLine("Ошибка: введена некорректная строка. Пожалуйста, введите число.");
            }
            catch (OverflowException)
            {
                // Обработка случая, когда число выходит за пределы допустимого диапазона
                Console.WriteLine("Ошибка: введенное число слишком велико или слишком мало.");
            }            
        }
        static void Task2()
        /*Упражнение 7.2 Изменить класс счет в банке из упражнения 7.1 таким образом, чтобы
номер счета генерировался сам и был уникальным. Для этого надо создать в классе
статическую переменную и метод, который увеличивает значение этого переменной.
         */
        {
            Console.WriteLine("Упражнение 7.2");

            Bank bank = new Bank();
            try
            {
                bool Flag = true;
                while (Flag)
                {
                    Console.WriteLine("ввeдите имя");
                    string name = Console.ReadLine();
                    Console.WriteLine("введите фамилию");
                    string surname = Console.ReadLine();
                    bank.VvodInfoGen(name, surname);
                    Console.WriteLine("введите сумму денег на счету");
                    double balance = double.Parse(Console.ReadLine());

                    Console.WriteLine("какой типа счета будет \n напишите 1 если сберегательный \n напишите 2 если кредитный");
                    char st = char.Parse(Console.ReadLine());
                    switch (st)
                    {
                        case '1':
                            bank.Vvod(balance, accType.saving);
                            break;
                        case '2':
                            bank.Vvod(balance, accType.saving);
                            break;
                        default:
                            Console.WriteLine(" вы ввели неправильное значение");
                            break;
                    }
                    bank.Print();
                    Console.WriteLine("хотите выйти или заполнить заново. если хотите заполнить нажмите любую букву, а если выйти то любое число");

                    string input = Console.ReadLine();

                    // Проверяем, является ли введенное значение числом
                    if (double.TryParse(input, out _))
                    {
                        Flag = false; // Выход из цикла, если введено число
                    }
                }
            }
            catch (FormatException)
            {
                // Обработка случая, когда строка не является корректным числом
                Console.WriteLine("Ошибка: введена некорректная строка. Пожалуйста, введите число.");
            }
            catch (OverflowException)
            {
                // Обработка случая, когда число выходит за пределы допустимого диапазона
                Console.WriteLine("Ошибка: введенное число слишком велико или слишком мало.");
            }
        }
        static void Task3()
        /*Упражнение 7.3 Добавить в класс счет в банке два метода: снять со счета и положить на
счет. Метод снять со счета проверяет, возможно ли снять запрашиваемую сумму, и в случае
положительного результата изменяет баланс.
         */
        {
            Console.WriteLine("Упражнение 7.3");
            Bank bank = new Bank();
            try
            {
                bool Flag = true;
                while (Flag)
                {
                    Console.WriteLine("ввeдите имя");
                    string name = Console.ReadLine();
                    Console.WriteLine("введите фамилию");
                    string surname = Console.ReadLine();
                    bank.VvodInfoGen(name, surname);
                    Console.WriteLine("введите сумму денег на счету");
                    double balance = double.Parse(Console.ReadLine());

                    Console.WriteLine("какой типа счета будет \n напишите 1 если сберегательный \n напишите 2 если кредитный");
                    char st = char.Parse(Console.ReadLine());
                    switch (st)
                    {
                        case '1':
                            bank.Vvod(balance, accType.saving);
                            break;
                        case '2':
                            bank.Vvod(balance, accType.saving);
                            break;
                        default:
                            Console.WriteLine(" вы ввели неправильное значение");
                            break;
                    }
                    bank.Print();

                    Console.WriteLine("напишите 1 если хотите вывести сумму");
                    double summa;
                    switch (char.Parse(Console.ReadLine()))
                    {
                        case '1':
                            summa = double.Parse(Console.ReadLine());
                            bank.Snyat(summa);
                            break;
                        case '2':
                            summa = double.Parse(Console.ReadLine());
                            bank.Vnesty(summa);
                            break;
                        default:
                            Console.WriteLine("неправильно введена команда");
                            break;
                    }
                    bank.Print();
                    Console.WriteLine("хотите выйти или заполнить заново. если хотите заполнить нажмите любую букву, а если выйти то любое число");

                    string input = Console.ReadLine();

                    // Проверяем, является ли введенное значение числом
                    if (double.TryParse(input, out _))
                    {
                        Flag = false; // Выход из цикла, если введено число
                    }
                }
            }
            catch (FormatException)
            {
                // Обработка случая, когда строка не является корректным числом
                Console.WriteLine("Ошибка: введена некорректная строка. Пожалуйста, введите число.");
            }
            catch (OverflowException)
            {
                // Обработка случая, когда число выходит за пределы допустимого диапазона
                Console.WriteLine("Ошибка: введенное число слишком велико или слишком мало.");
            }
        }
        
        static void Task4()
        /*Домашнее задание 7.1 Реализовать класс для описания здания (уникальный номер здания,
высота, этажность, количество квартир, подъездов). Поля сделать закрытыми,
предусмотреть методы для заполнения полей и получения значений полей для печати.
Добавить методы вычисления высоты этажа, количества квартир в подъезде, количества
квартир на этаже и т.д. Предусмотреть возможность, чтобы уникальный номер здания
генерировался программно. Для этого в классе предусмотреть статическое поле, которое бы
хранило последний использованный номер здания, и предусмотреть метод, который
увеличивал бы значение этого поля.
         */
        {
            Console.WriteLine("Упражнение 7.1");
            House house = new House();
            try
            {
                bool Flag = true;
                while (Flag)
                {
                    Console.WriteLine("введите высоту здания");
                    ushort high = ushort.Parse(Console.ReadLine());
                    Console.WriteLine("введите количество этажей в метрах");
                    ushort floors = ushort.Parse(Console.ReadLine());
                    Console.WriteLine("введите количество квартир");
                    ushort flats = ushort.Parse(Console.ReadLine());
                    Console.WriteLine("введите количество подъездов");
                    ushort podyezd = ushort.Parse(Console.ReadLine());
                    house.Info(high, floors,flats, podyezd);
                    house.Print();
                    Console.WriteLine("если хотите посчитать количество квартир в подъезде то напишите 1, если количество квартир на этаже то 2, если узнать на какой высоте находится этаж 3");
                    char st = char.Parse(Console.ReadLine());
                    switch (st)
                    {
                        case '1':
                            house.CountFlatOnPod();
                            break;
                        case '2':
                            house.CountFlatOnFloor();
                            break;
                        case '3':
                            Console.WriteLine("введите сумму денег на счету");
                            byte n = byte.Parse(Console.ReadLine());
                            house.FloorHigh(n);
                            break;
                        default:
                            Console.WriteLine(" вы ввели неправильное значение");
                            break;
                    }
                    
                    Console.WriteLine("хотите выйти или заполнить заново. если хотите заполнить нажмите любую букву, а если выйти то любое число");

                    string input = Console.ReadLine();

                    // Проверяем, является ли введенное значение числом
                    if (double.TryParse(input, out _))
                    {
                        Flag = false; // Выход из цикла, если введено число
                    }
                }
            }
            catch (FormatException)
            {
                // Обработка случая, когда строка не является корректным числом
                Console.WriteLine("Ошибка: введена некорректная строка. Пожалуйста, введите число.");
            }
            catch (OverflowException)
            {
                // Обработка случая, когда число выходит за пределы допустимого диапазона
                Console.WriteLine("Ошибка: введенное число слишком велико или слишком мало.");
            }
        }
    }
}
