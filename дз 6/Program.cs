using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using дз_6;

namespace dz6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("напишите количество людей");
                byte people = byte.Parse(Console.ReadLine());
                Console.WriteLine("напишите на сколько дней ");
                byte day = byte.Parse(Console.ReadLine());
                Console.WriteLine("и количество детей если есть ");
                byte child = byte.Parse(Console.ReadLine());
                Console.WriteLine("если хотите постетить Роза Хутор напишите 1, если Красная Поляна то 2, если Абзакова 3");
                char st = char.Parse(Console.ReadLine());
                switch (st)
                {
                    case '1':
                        SkiiCurort rose = new Rose("Роза Хутор", people, day,child);
                        rose.Welcome();
                        Console.WriteLine("если у вас есть дети напишите 1");
                        char stok = char.Parse(Console.ReadLine());
                        rose.Output(stok);
                        if (stok!='1')
                        {
                            Console.WriteLine("хотите узнать цену за один день на всех");
                            string n2 = Console.ReadLine();
                            if (n2 == "да")
                            {
                                rose.CountPriceOne();
                            }
                        }
                        if (stok == '1')
                        {
                            rose.CountPriceChild();
                        }
                        else
                        {
                            rose.CountPriceAll();
                        }
                        rose.Print();
                        break;
                    case '2':
                        SkiiCurort red = new Red("Красная Поляна", people, day,child);
                        red.Welcome();
                        Console.WriteLine("если у вас есть дети напишите 1");
                        char str = char.Parse(Console.ReadLine());
                        red.Output(str);
                        if (str != '1')
                        {
                            Console.WriteLine("хотите узнать цену за один день на всех");
                            string n1 = Console.ReadLine();
                            if (n1 == "да")
                            {
                                red.CountPriceOne();
                            }
                        }
                        if (str == '1')
                        {
                            red.CountPriceChild();
                        }
                        else
                        {
                            red.CountPriceAll();
                        }
                        red.Print();
                        break;
                    case '3':
                        SkiiCurort abzak = new Abzakova("Абзаково", people, day,child);
                        abzak.Welcome();
                        Console.WriteLine("если у вас есть дети напишите 1");
                        char stro = char.Parse(Console.ReadLine());
                        abzak.Output(stro);
                        if (stro != '1')
                        {
                            Console.WriteLine("хотите узнать цену за один день на всех");
                            string n = Console.ReadLine();
                            if (n == "да")
                            {
                                abzak.CountPriceOne();
                            }
                        }
                        else if (stro == '1')
                        {
                            abzak.CountPriceChild();
                        }
                        else
                        {
                            abzak.CountPriceAll();
                        }
                        abzak.Print();
                        break;
                    default:
                        Console.WriteLine("нет такой команды");
                        break;
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
        /*Цель задания: Написать программу, в которой реализованы все принципы ООП. Для этого
необходимо реализовать не менее 4 классов:
● Один должен быть абстрактным
● Должно быть не менее 2 наследников
● Не менее 5 методов в каждом классе (необходимо показать свойство на
чтение и на чтение-запись)
● Не менее 4 свойств
● Должно быть не менее 2 конструкторов в классах наследниках

В Main создать объекты классов, показать работу методов. В программе для ваших
объектов используйте какие-то данные, который необходимо читать с файла/введены с
клавиатуры/прописано в коде. Например, класс человек, создаете экземпляры для
человека, а имена, фамилии читаете с файла/вводите с клавиатуры/заранее прописано в
коде .
Необходимо быть готовым к тому, что каждый принцип нужно объяснять. Ваша программа
должна объяснять человеку то, о чем у вас тема и показать основные моменты вашей
темы, то, что считаете важным.
         */
    }
}
