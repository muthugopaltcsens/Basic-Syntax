using System;
namespace RectangleApplication
{
    /* This program demonstrates
     The basic syntax of C# programming 
     Language */
    class Rectangle
    {
        // member variables
        double length;
        double width;
        public void Acceptdetails() //member methods
        {
            length = 4.5;
            width = 3.5;
        }
        public double GetArea()       //Member Functions
        {
            return length * width;
        }
        public void Display() //member methods
        {
            Console.WriteLine($"Length: {length}, Width: {width}, Area: {GetArea()}");
        }
    }
    class ExecuteRectangle
    {
        public static void Main(string[] args)
        {
            Rectangle r = new Rectangle();
            r.Acceptdetails();
            r.Display();
            Console.ReadLine();
        }
    }
}

