using System;
using System.Collections.Generic;
using System.Text;

namespace Singleton_Design_Pattern
{
    public sealed class SingletonThreadSafety
    {
        private static int counter = 0;
        private static SingletonThreadSafety instance = null;

        /*
        * Lazy Initialization in Singleton : GetInstance Property is responsible for the 
        * SingletonThreadSafety Instance creation. SingletonThreadSafety object is not created
        * until and unless GetInstance is invoked. Hence, there is a delay in instance 
        * creation till the GetInstance is accessed.  This Delay in Instance creation is 
        * called Lazy Initialization.
        */

        /*
         * There is a chance that we may end up creating multiple instances 
         * when multiple threads (Parallel.Invoke ) invoke the GetInstance at the same time.
         
         * This Thread racing situation causes thread safety issues in Singleton Initialization and 
         * further the current code ends up in creating multiple instances of Singleton objects in 
         * memory. 
         
         * Locks are the best way to control thread race condition
         */

        private static readonly  object lockObject = new object();
        public static SingletonThreadSafety GetInstance 
        {
            get 
            {
                // Check lock only if instance is null - Double checked locking
                if (instance == null)
                {
                    // For thread safety
                    lock (lockObject)
                    {
                        if (instance == null)
                        {
                            instance = new SingletonThreadSafety();
                        }
                    }
                }
                return instance;
            }
        }
        private SingletonThreadSafety()
        {
            counter++;
            Console.WriteLine("Counter Value" + counter.ToString());
        }

        public void PrintMessage(string message)
        {
            Console.WriteLine(message);
        }
    }
}
