using System.Diagnostics;

namespace Logical_Programming_Problems
{


    public static class StopWatch
    {
        static void Main(string[] args)
        {
            int input1;

            Stopwatch stopw = new Stopwatch();


            Console.Write(" \t 1-Start Timer\n \t 2-Stop Timer\n");
            Console.WriteLine("Please enter '1' to start timer whenever you want");
            input1 = Convert.ToInt32(Console.ReadLine());
            if (input1 == 1)
            {
                stopw.Start();

            }
            else
            {
                throw (new InvalidOperationException("Please Start the timer with 1"));
            }




            Console.WriteLine("Please enter '2' to stop the timer whenever you want");
            input1 = Convert.ToInt32(Console.ReadLine());
            if (input1 == 2)
            {
                stopw.Stop();

            }

            else
            {
                throw (new InvalidOperationException("Please end the timer with 2"));
            }

            Console.WriteLine(" Time elapsed: {0} ", stopw.Elapsed);



        }
    }

}

