using System;
using System.Collections.Generic;
using System.Formats.Asn1;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Реализовать класс для описания здания (уникальный номер здания,
высота, этажность, количество квартир, подъездов). Поля сделать закрытыми,
предусмотреть методы для заполнения полей и получения значений полей для печати.
Добавить методы вычисления высоты этажа, количества квартир в подъезде, количества
квартир на этаже и т.д. Предусмотреть возможность, чтобы уникальный номер здания
генерировался программно. Для этого в классе предусмотреть статическое поле, которое бы
хранило последний использованный номер здания, и предусмотреть метод, который
увеличивал бы значение этого поля.
 */

namespace лаба_6
{
    internal class House
    {
        private uint id;
        private static uint idgen = 0;
        private ushort high;//meters
        private ushort floors;
        private ushort flat;
        private ushort podyezd;

        public void Info(ushort h,ushort f, ushort fl,ushort p)
        {
            this.id = GenId();
            this.high = h;
            this.floors = f;
            this.flat = fl;
            this.podyezd = p;
        }

        private uint GenId()
        {
            idgen++; return id ;
        }
        public void FloorHigh(byte num)
        {
            if (high / floors >= 2)
            {
                float one = (high / floors) * num;
                Console.WriteLine($"{num} этаж находится на высоте {one} метра(ов)");
            }
            else
            {
                Console.WriteLine("невозможное значение");
            }
        }
        public void CountFlatOnPod()
        {
            if (flat > podyezd)
            {
                int k = flat / podyezd;
                Console.WriteLine($"в подьезде {k} квратир(а)");
            }
            else
            {
                Console.WriteLine("невозможное значение");
            }
        }
        public void CountFlatOnFloor()
        {
            int k = flat / podyezd;
            if (k/floors > 0)
            {
                Console.WriteLine($"на каждом этаже минимум есть по {k/floors} квартир(е)/(ы)");
            }
            else
            {
                Console.WriteLine("невозможное значение");
            }
        }

        public void Print()
        {
            Console.WriteLine($"id {id},высота дома {high} м,всего этажей {floors}, всего квартир{flat},количество подъездов {podyezd}");
        }
    }
}
