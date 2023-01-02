using System;

namespace Lecture18_Datatypes
{
    class Program
    {
        static void Main(string[] args)
        {
            string myname = "Michael";

            string message = "My name is " + myname;

            string capsMessage = message.ToUpper();
            
            string lowercasemessage = message.ToLower();
            
            
            Console.WriteLine("My name is " + myname);

            Console.WriteLine(capsMessage);

            Console.WriteLine(lowercasemessage);

            Console.Read();
        }
    }
}
