using System;

namespace CompteBancaire
{
    internal class LoopWithForeach
    {
        public static void Main()
        {
            int[] numbers = [0, 1, 2];
            foreach (int i in numbers)
            {
                Console.WriteLine(i);
            }
        }
    }
}
