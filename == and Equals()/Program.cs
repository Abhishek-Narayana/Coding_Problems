using System;
using System.Collections.Generic;

namespace Root_Program
{

    interface ISolid
    {
        void Area();
    }

    sealed partial class Square
    {
        internal int Width { get; set; }
        internal int Breadth { get; set; }
    }

    sealed partial class Square : ISolid
    {
        int Height { get; set; }

        public Square(int Breadth, int Width, int Height = 5)
        {
            this.Width = Width;
            this.Breadth = Breadth;
            this.Height = Height;
        }

        public static Square operator +(Square s1, Square s2)
        {
            Square s3 = new Square(s1.Breadth + s2.Breadth, s1.Width + s2.Width, s1.Height + s2.Height);
            return s3;
        }

        public void Area()
        {
            Console.WriteLine("Area is : {0}cm", this.Width * this.Breadth);
        }

        void ISolid.Area()
        {
            Console.WriteLine("Solid area is : {0}cm", this.Height * this.Width * this.Breadth);
        }
    }

    static class Meter
    {
        public static void AreaInMeter(this Square obj)
        {
            Console.WriteLine("Square area is : {0}m", (obj.Width * obj.Breadth)/100);
        }
    }

    class Rectangle
    {
        internal int Width { get; set; }
        internal int Breadth { get; set; }
        int Height { get; set; }

        public Rectangle(int Breadth, int Width, int Height = 5)
        {
            this.Width = Width;
            this.Breadth = Breadth;
            this.Height = Height;
        }

        public void Area()
        {
            Console.WriteLine("Reactangle area is : {0}cm", this.Width * this.Breadth);
        }
    }

        class Program
    {
        static void Main(string[] args)
        {
            Square s1 = new Square(10, 10);
            Square s2 = new Square(10, 10);

            Console.WriteLine("== operator result is {0}", s1 == s2); // returns true if reference of both object is same
            Console.WriteLine("Equals method result is {0}", s1.Equals(s2)); // true if the specified object is equal to the current object, otherwise false

            Square s3 = s1 + s2;

            s3.Area();
            ISolid solid = s3;
            solid.Area();

            s3.AreaInMeter();

            Rectangle r1 = new Rectangle(10, 20);
            Rectangle r2 = new Rectangle(10, 5);

            List<object> myList = new List<object>();
            myList.Add(s1);
            myList.Add(s2);
            myList.Add(r1);
            myList.Add(r2);

            foreach (dynamic obj in myList)
            {
                obj.Area();
            }

        }
    }
}
