using System;

namespace LambdaExpressions
{
    public class Program
    {
        // what is a Lambda Expression

        // An anonymous method
        // No access modifier
        // No name
        // No return statement

        // why do we use them - for convience
        static void Main(string[] args)
        {
            // args => expression 
            // number => number * number;
            // () => ...
            // x => ...
            // (x, y, z) => ...
            Func<int, int> square = number => number * number;

            //Console.WriteLine(Square(5));
            Console.WriteLine(square(5));

            const int factor = 7;
            Func<int, int> multiplier = n => n * factor;
            var result = multiplier(16);
            Console.WriteLine(result);
        }

        //static int Square(int number)
        //{
        //    return number * number; 
        //}
    }
}
