using System;

namespace Test
{
    class Random {
    static void Main(string[] args) {
         Console.WriteLine(RandomNr(args));

    }

// This method creates a random number
        static int RandomNr(int range) {
            int num = new random.Next(range);
            return num;
        }
    }
}
