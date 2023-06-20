using OperatorOverloadingApplication;
using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Xml.Linq;

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

            string s = "muthukumar";
            string a = s;
            s = "muthu";
            Console.WriteLine(a);
            Console.WriteLine(s);

            Rectangle r = new Rectangle();
            r.Acceptdetails();
            r.Display();
            Console.ReadLine();


            Books Book1;   /* Declare Book1 of type Book */

            /* book  specification */
            Book1.title = "C Programming";
            Book1.author = "Nuha Ali";
            Book1.subject = "C Programming Tutorial";
            Book1.book_id = 6495407;

          



        }



        enum Days { Sun, Mon, tue, Wed, thu, Fri, Sat };
        struct Books
        {
            public string title;
            public string author;
            public string subject;
            public int book_id;
          
        };
    }
}

