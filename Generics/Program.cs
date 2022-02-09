namespace Generics
{
    public partial class Program
    {
        static void Main(string[] args)
        {
            var number = new Nullable<int>(5);
            System.Console.WriteLine("Has Value ? " + number.HasValue);
            System.Console.WriteLine("Value: " + number.GetValueOrDefault());

            var number1 = new Nullable<int>();
            System.Console.WriteLine("Has Value ? " + number1.HasValue);
            System.Console.WriteLine("Value: " + number1.GetValueOrDefault());

            
        }
    }
}
