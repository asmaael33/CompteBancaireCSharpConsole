using System;

namespace CompteBancaire
{
    public class CompareTwoInteger
    {

        public static void Main()
        {
            int int1 = 23, int2 = 24;
            
            
            if (int1 == int2) 
                Console.WriteLine("{0} and {1} are equal.\n", int1, int2);
            else
                Console.WriteLine("{0} and {1} are not equal.\n", int1, int2);

            Console.ReadKey();
        }
    }
}
