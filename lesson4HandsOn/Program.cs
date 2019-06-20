using System;

namespace lesson4HandsOn
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Doubled Number: " + DoubleMe(4));
            Console.WriteLine("Quadrupled Number: " + quadrupleMe(4));
              Console.WriteLine("Number doubled many times: " + DoubleNumberMultipleTimes(7, 9));

        }
        public static int DoubleMe(int number){
            return (number*2);
        }
         public static int quadrupleMe(int number)
         {
             return (DoubleMe(DoubleMe(number)));
         }

         public static int DoubleNumberMultipleTimes(int numberTobeDoubled, int numberOfTimes)
         {
                for (int i = 0; i < numberOfTimes; i++ ){
                    numberTobeDoubled = DoubleMe(numberTobeDoubled);
                }
                return numberTobeDoubled;
         }
    }

}
