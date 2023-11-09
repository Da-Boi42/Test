using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mine
{
    class Program
    {
        class Person {
            int age;
            
            public void SayHi() {
                Console.WriteLine("Hi");
            }
            static void Main(string[] args)
            {
                Person p1 = new Person();
                p1.SayHi();
            }
        }
    }
}