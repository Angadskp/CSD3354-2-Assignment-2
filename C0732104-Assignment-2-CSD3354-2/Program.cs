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
        static void Main(string[] args)
        {
            DelegateExcercises delegateExcercises = new DelegateExcercises();
            delegateExcercises.Method3();
        }
    }
    public class DelegateExcercises
    {
        public delegate int MyDelegate();

        void Method1()
        {
            System.Console.WriteLine("MyDelegate");
        }
        public void Method3()
        {
            MyDelegate myDelegate = new MyDelegate(Method1);
            myDelegate();
        }
    }
}