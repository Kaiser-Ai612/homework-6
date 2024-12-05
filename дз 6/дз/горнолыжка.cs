using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
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
namespace дз_6
{
    internal abstract class SkiiCurort
    {
        public double price;
        public string Name { get;}
        public byte peopleCount { get; }//количество людей котрое собирается посетить
        public byte dataCount { get; }//количество дней котрое собирается провести
        public byte Children { get; } = 0;        

        public SkiiCurort() { }//1
        public SkiiCurort(string name, byte people, byte day)//2
        {
            Name = name;
            peopleCount = people;
            dataCount = day;
        }
        public SkiiCurort(string name, byte people,byte day,byte children)//3
        {
            Name = name;
            peopleCount = people;
            dataCount = day;
            this.Children = children;
        }
        //1
        public abstract void Welcome();
        //2 подсчет стоимости day
        public abstract void CountPriceOne();// цену умножаем на людей вот это прайс1 если пользователь захочет увидеть
        //
        public abstract void Output(char ask);//спрашивает надо ли узнать цену за день  БЕЗ ДЕТЕЙ
        //3 про детей надо
        public abstract double CountPriceChild();// цену умножаем на людей и еще отельно детей и умножаем на дни это тоже прайс
        //4 подсчет стоимости всего
        public abstract double CountPriceAll();// цену умножаем на людей и на дни и это все прайс
        // 5
        public void Print()
        {
            Console.WriteLine($"имя горнолыжного курорта:{Name},количество взрослых людей:{peopleCount},количество дней:{dataCount},количество детей {Children} \n общая цена за {dataCount} дней :{price}");
        }
    }

    class Rose : SkiiCurort
    {
        private double priceRose = 5670;
        private double priceCH = 2000;
        public double priceDay;
        public Rose(string name, byte people, byte day) : base(name, people, day)  {}
        public Rose(string name, byte people, byte day, byte children) : base(name, people, day, children) { }

        public override void Welcome()
        {
            Console.WriteLine($"добро пожаловать в {Name}");
        }
        public override void CountPriceOne()
        {
            if (Children == 0)
            {
                priceDay = peopleCount * priceRose;
                Console.WriteLine(priceDay);
            }
            else
            {
                priceDay = peopleCount * priceRose + priceCH* Children;
                Console.WriteLine(priceDay);
            }
        }
        public override void Output(char ask)
        {
            if (ask != '1')
            {
                Console.WriteLine(priceDay);
            }
            else
            {
                Console.WriteLine("продолжаем");
            }
        }
        public override double CountPriceChild()
        {
            price = (peopleCount * priceRose + priceCH * Children)*dataCount;
            return price;
        }
        public override double CountPriceAll()
        {
            price = peopleCount * priceRose * dataCount;
            return price;
        }

    }

    class Red : SkiiCurort
    {
        private double priceRose = 7645;
        private double priceCH = 3000;
        private double priceDay;
        public Red() { }
        public Red(string name, byte people, byte day) : base(name, people, day) { }
        public Red(string name, byte people, byte day, byte children) : base(name, people, day,children) { }

        // welcome
        public override void Welcome()
        {
            Console.WriteLine($"добро пожаловать в {Name}");
        }
        public override void CountPriceOne()
        {
            if (Children == 0)
            {
                priceDay = peopleCount * priceRose;
                Console.WriteLine(priceDay);
            }
            else
            {
                priceDay = peopleCount * priceRose + priceCH * Children;
                Console.WriteLine(priceDay);
            }
        }
        public override void Output(char ask)
        {
            if (ask == '1')
            {
                Console.WriteLine(priceDay);
            }
            else
            {
                Console.WriteLine("продолжаем");
            }
        }
        public override double CountPriceChild()
        {
            price = (peopleCount * priceRose + priceCH * Children) * dataCount;
            return price;
        }
        public override double CountPriceAll()
        {
            price = peopleCount * priceRose * dataCount;
            return price;
        }
    }
    class Abzakova : SkiiCurort
    {
        private double priceRose = 4260;
        private double priceCH = 1000;
        private double priceDay;
        public Abzakova() { }
        public Abzakova(string name,byte people, byte day) : base(name, people, day) { }
        public Abzakova(string name, byte people, byte day, byte children) : base(name, people, day, children) { }

        public override void Welcome()
        {
            Console.WriteLine($"добро пожаловать в {Name}");
        }
        public override void CountPriceOne()
        {
            if (Children == 0)
            {
                priceDay = peopleCount * priceRose;
                Console.WriteLine(priceDay);
            }
            else
            {
                priceDay = peopleCount * priceRose + priceCH * Children;
                Console.WriteLine(priceDay);
            }
        }
        public override void Output(char ask)
        {
            if (ask == '1')
            {
                Console.WriteLine(priceDay);
            }
            else
            {
                Console.WriteLine("продолжаем");
            }
        }
        public override double CountPriceChild()
        {
            price = (peopleCount * priceRose + priceCH * Children) * dataCount;
            return price;
        }
        public override double CountPriceAll()
        {
            price = peopleCount * priceRose * dataCount;
            return price;
        }
    }
}
