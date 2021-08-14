using System;

namespace Singleton_Design_Pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            // assuming singleton class is invoked from fromEmployee class
            Singleton fromEmployee = Singleton.GetInstance;
            fromEmployee.PrintDetails("Message from employee");

            Singleton fromStudent = Singleton.GetInstance;
            fromStudent.PrintDetails("Messaage from student");

            /*
            * Instantiating singleton from a derived class. This violates singleton pattern principles.
            */
            //Singleton.DerivedSingleton derivedObj = new Singleton.DerivedSingleton();
            //derivedObj.PrintDetails("From Derived");

            Console.ReadLine();
        }
    }
}
