using System;
using System.Collections.Generic;
using System.Text;

namespace Singleton_Design_Pattern
{
    public sealed class Singleton
    {
        // Counter to check how many instance of singleton class is created.
        private static int counter = 0;

        private static Singleton instance = null;
        public static Singleton GetInstance
        {
            get
            {
                // Create instance only if it not created already. 
                // This code works fine if single thread is trying to create instance. - Race condition
                if(instance == null)
                {
                    instance = new Singleton();
                }

                return instance;
            }
        }

        // Restrict multiple instance creation by making all constructor as private
        // and change class to sealed class so that it has not inherited anymore

        // Private constructor ensures that object is not instantiated other than with in the class itself
        private Singleton()
        {
            counter++;
            Console.WriteLine("Counter Value " + counter.ToString());
        }

        public void PrintDetails(string message)
        {
            Console.WriteLine(message);
        }

        // A class with in another class is called a nested class. 

        /*
        * If we remove sealed keyword, we can inherit the singleton class from nested class (DerivedSingleton)
        * and instantiate multiple objects of Singleton class.
        * This violates singleton design principles.
        */

        //public class DerivedSingleton : Singleton
        //{
        //}

    }
}
