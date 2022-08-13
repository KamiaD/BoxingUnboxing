using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoxingUnboxing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Boxing
            //The process of converting value type to a reference type is called Boxing.Boxing is implicit conversion
            int anum = 123;
            Object obj = anum;
            Console.WriteLine("Boxing example");
            Console.WriteLine("Integer value" + anum);
            Console.WriteLine("Object Value" + obj);
            
            //Unboxing
            //The process of converting reference type to a value type is called Unboxing
            Object obj2 = 123;
            Console.WriteLine("Unboxing example");
            int anum2 = (int)obj2;
            Console.WriteLine("Object Value"+obj2);
            Console.WriteLine("Integer value"+ anum2);
            Console.ReadLine();
        }
    }
}
