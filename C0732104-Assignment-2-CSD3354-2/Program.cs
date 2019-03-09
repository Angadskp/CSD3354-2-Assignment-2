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
        public static void Main()
        {
            DelegateExercises delegateExercises = new DelegateExercises();
            delegateExercises.Method3();
            Console.ReadLine();
        }
    }

    public delegate int MyDelegate(out int i);

    public class DelegateExercises
    {
        int Method1(out int i)
        {
            System.Console.WriteLine("Method1");
            i = 10;
            return 0;
        }

        public void Method3()
        {
            MyDelegate myDelegate = new MyDelegate(Method1);
            MyDelegate myDelegate1 = new MyDelegate(Method1);
            MyDelegate myDelegate2 = myDelegate + myDelegate1;
            int intValue;
            myDelegate2(out intValue);

        }
    }

}