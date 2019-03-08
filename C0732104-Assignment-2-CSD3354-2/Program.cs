using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C0732104_Assignment_2_CSD3354_2
//Angad Singh   C0732104
//Arshdeep Singh Brar C0730228
//Assigmnment 2 
//March 8,2019
//Csd3354-2
{
    public class Program
    {
        public delegate void MyDelegate();

        public void Method1()
        {
            Console.WriteLine("Method1");
            Console.ReadLine();
        }
        public void Method2()
        {
            MyDelegate mydelegate = new MyDelegate(Method1);
            mydelegate();
        }
        static void Main(string[] args)
        {

        }
    }
}