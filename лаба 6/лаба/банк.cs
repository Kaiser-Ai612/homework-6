using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Упражнение 7.1 Создать класс счет в банке с закрытыми полями: номер счета, баланс, тип
банковского счета (использовать перечислимый тип из упр. 3.1). Предусмотреть методы для
доступа к данным – заполнения и чтения. Создать объект класса, заполнить его поля и
вывести информацию об объекте класса на печать.
             */

namespace лаба_6
{
    enum accType
    {
        saving,
        credit,
    }
    internal class Bank
    {
        private uint id;
        private static uint idgen;
        private string name;
        private string surname;
        private double balance;
        private accType accType1;

        public void VvodInfo(uint ID, string NAME, string SURNAME)
        {
            this.id = ID;
            this.name = NAME;
            this.surname = SURNAME;
        }
        public void Vvod(double BALANCE, accType TYPE)
        {
            this.balance = BALANCE;
            this.accType1 = TYPE;
        }
        // 2
        public void VvodInfoGen(string NAME, string SURNAME)
        {
            this.id = IdGen();
            this.name = NAME;
            this.surname = SURNAME;
        }
        private uint IdGen()
        {
            idgen++;
            return idgen;
        }
        //3
        public void  Snyat(double a)
        {
            if (a < balance)
            {
                this.balance -= a;
            }
            else
            {
                Console.WriteLine("");
            }
        }
        public void Vnesty(double a)
        {
            this.balance += a;
        }
        public void Print()
        {
            Console.WriteLine($"id:{id}, имя;{name} ,фамилия:{surname} ,\n баланс:{balance} ,тип счета :{accType1}");
        }        
    }
}
