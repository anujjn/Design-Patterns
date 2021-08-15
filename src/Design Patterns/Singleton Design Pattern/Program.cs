using System;
using System.Threading.Tasks;

namespace Singleton_Design_Pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            // assuming singleton class is invoked from Employee class
            Singleton fromEmployee = Singleton.GetInstance;
            fromEmployee.PrintDetails("Message from employee");

            // assuming singleton class is invoked from Student class
            Singleton fromStudent = Singleton.GetInstance;
            fromStudent.PrintDetails("Messaage from student");

            /*
            * Instantiating singleton from a derived class. This violates singleton pattern principles.
            */
            //Singleton.DerivedSingleton derivedObj = new Singleton.DerivedSingleton();
            //derivedObj.PrintDetails("From Derived");

            /*
             * Singleton Thread Safety Scenario
             * This will create multiple instance of SingletonThreadSafety
             * if thread safe SingletonThreadSafety is not created - use lock
             */
            Parallel.Invoke(PrintEmployeeDetails, PrintStudentDetails);

            Console.ReadLine();


        }

        private static void PrintEmployeeDetails()
        {
            SingletonThreadSafety fromEmployee = SingletonThreadSafety.GetInstance;
            fromEmployee.PrintMessage("From Employee");
        }

        private static void PrintStudentDetails()
        {
            SingletonThreadSafety fromEmployee = SingletonThreadSafety.GetInstance;
            fromEmployee.PrintMessage("From Student");
        }
    }
}
