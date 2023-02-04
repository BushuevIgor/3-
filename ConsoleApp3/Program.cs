using System;
using System.Collections.Generic;
using System.IO.Pipes;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml.Linq;




namespace ConsoleApp3
{
    internal class Program
    {

       class Oboima
        {
            int[] volume;
            int versh;

            public Oboima(int size)
            {
                volume = new int[size];
                versh = 0;
            }

            public void Push(int a)
            {
                if(versh == volume.Length)
                {
                    Console.WriteLine("Обойма заряжена");
                    return;
                }
                volume[versh] = a;
                versh++;
            }

            public int Pop()
            {
                if(versh == 0)
                {
                    Console.WriteLine("Обойма пуста");
                    return (int)0;
                }
                versh--;
                return volume[versh];
            }

            public bool isFull()
            {
                return versh == volume.Length;
            }

            public bool isEmpty()
            {
                return versh == 0;
            }

            public int Capacity()
            {
                return volume.Length;
            }

            public int getnum()
            {
                return versh;
            }
            
        }








        static void Main(string[] args)
        {

            Oboima ob1 = new Oboima(10);
            Oboima ob2 = new Oboima(10);
            Oboima ob3 = new Oboima(10);
            int num;
            int i;

            Console.WriteLine("Поместить 10 патронов в обойму");
            for(i = 1; !ob1.isFull(); i++)
            {
                ob1.Push((int)(0 + i));
            }
            if (ob1.isFull()) {
                Console.WriteLine("Обойма 1 заполнена");
            }

            Console.WriteLine("Пересчитаем патроны");
            
            while(!ob1!.isEmpty())
            {
                num = ob1.Pop();
                Console.Write($"{num}  \n"); ;
            }

            Console.WriteLine("стрельба.....");

            if(ob1.isEmpty())
            {
                Console.WriteLine("обойма 1 пуста \n");
            }

            Console.WriteLine("Перезарядка");

            for(i = 1; !ob1.isFull(); i++)
            {
                ob1.Push((int)(0 + i));

            }

            if(ob1.isFull())
            {
                Console.WriteLine("Обойма перезаряжена");
            }

            Console.WriteLine("стрельба...");

            Console.WriteLine("Обойму заклинило!! Разрядка обоймы 1 и зарядка обоймы 2");

            while (!ob1.isEmpty())
            {
                num = ob1.Pop();
                ob2.Push(num);
            }

            Console.WriteLine("Обойма 2 заряжена! Пересчитаем патроны");

            while (!ob2.isEmpty())
            {
                num = ob2.Pop();
                Console.WriteLine(num);
            }

            Console.WriteLine("\n");

            Console.WriteLine("у нас осталось 5 патронов, зарядим их в обойму 3");

            for(i = 1; i <=5; i++)
            {
                ob3.Push((int)(0 + i));
            }

            Console.WriteLine("Емкость обоймы номер 3: " + ob3.Capacity());

            Console.WriteLine("Количество патронов в обойме номер 3: " + ob3.getnum());

            Console.WriteLine("Точно? Пересчитаем:");

            while (!ob3.isEmpty())
            {
                num = ob3.Pop();
                Console.WriteLine(num);
            }


            Console.ReadLine();









        }














   




    }
        
    }

