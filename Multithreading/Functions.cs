using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;

namespace Multithreading
{
    public class Functions
    {
        /// <summary>
        /// Method first
        /// </summary>
        public static void Function01()
        {
            int loopCount = 2000;

            MethodBase.GetCurrentMethod();
            for (int i = 0; i < loopCount; i++)
            {
                Console.WriteLine("{0} is {1}", MethodBase.GetCurrentMethod().ToString(), i);

                if (i % 2 == 0)
                {
                    Thread.Sleep(2);
                }
            }
        }

        /// <summary>
        /// Second Method
        /// </summary>
        public static void Function02()
        {
            int loopCount = 2000;
            for (int i = 0; i < loopCount; i++)
            {
                Console.WriteLine("{0} is {1}", MethodBase.GetCurrentMethod().ToString(), i);

                if (i % 3 == 0)
                {
                    Thread.Sleep(2);
                }
            }
        }
    }
}
