using System;

namespace Generics
{
    public partial class Program
    {
        // where T : IComparable
        // where T : product
        // where T : struct
        // where T : class
        // where T : new()
        public class Utilities<T> where T : IComparable

        {
            public int Max(int a, int b)
            {
                return a > b ? a : b;
            }

            public T Max(T a, T b)             {
                return a.CompareTo(b) > 0 ? a : b;
                // in the above code, compilier think its an object which we cannot compare it.
                // we need to use IComparable constraint. 
            }
        }
    }
}
