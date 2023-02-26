namespace Logical_Programming_Problems
{


    public static class ReverseNumber
    {
        static void Main(string[] args)
        {
            int n, rev = 0, rem;
            Console.WriteLine("Enter Number");
            Console.WriteLine("\n");
            n = Convert.ToInt32(Console.ReadLine());

            while (n != 0)
            {
                rem = n % 10;
                rev = rev * 10 + rem;
                n /= 10;
            }
            Console.WriteLine("Reversed Number is : {0}", rev);

        }

    }

}

