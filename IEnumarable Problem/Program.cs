using System;
using System.Collections.Generic;

namespace Dynamic_Key_Word_Problem
{
    class Bike
    {
        public String Name { get; set; }
        public string Number { get; set; }

    }

    class Car
    {
        public String Name { get; set; }
        public string Number { get; set; }

    }
    class Program
    {
        public static void Main(String[] args)
        {
            Bike t1 = new Bike();
            t1.Name = "NS 200";
            t1.Number = "KA 41 1234";

            Car t2 = new Car();
            t2.Name = "Brezza";
            t2.Number = "KA 41 4321";

            List<object> myList = new List<object>();
            myList.Add(t1);
            myList.Add(t2);

            foreach (dynamic obj in myList)
            {
                Console.WriteLine("Name:- " + obj.Name + "\tNumber :- " + obj.Number);
            }

            Console.ReadLine();
        }
    }
}
