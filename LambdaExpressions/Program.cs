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

            var books = new BookRepo().BookList();
            // var cheapBooks = books.FindAll(book => book.Price < 10);
            var cheapBooks = books.FindAll(b => b.Price < 10);

            foreach (var book in cheapBooks)
            {
                Console.WriteLine(book.Price);
            }
        }

        //static int Square(int number)
        //{
        //    return number * number; 
        //}

        //static bool CheaperThan10Dollors(Book book)
        //{
        //    return book.Price < 10;
        //}
    }
}
