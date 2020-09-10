using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello
{
    class Program
    {
        /// <summary>
        /// Main entry point that is run when you press run
        /// </summary>
        /// <param name="args">Command line arguments to custimise what the program does</param>
        /// 
        static void Main(string[] args)
        {
            // Ask the user their name
            string name = Console.ReadLine();

            // Say hello
            SayHello(100, "Mr Dring");

            // Wait for user to type something before closing 
            Console.ReadLine();       
        }

        /// <summary>
        /// Say hello any number of times
        /// </summary>
        /// <param name="howManyTimes">Number of times to say hello</param>
        /// <param name="name">Who to say hello to</param>
        static void SayHello(int howManyTimes, string name)
        {
            for(int num = 0; num < howManyTimes; num++)
            {
                Console.WriteLine("Hello " + name);
            }
        }
    }
}
