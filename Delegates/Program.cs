using System;

namespace Delegates
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Delegates
            // An object that knows how to call a method (or a group of methods).
            // A reference to a function.

            // why do we need delegates?
            // for designing extensible and flexible applications (eg frameworks) 

            var processor = new PhotoProcessor();
            var filters = new PhotoFilters();

            // PhotoProcessor.PhotoFilterHandler filterHandler = filters.ApplyConstrast;
            Action<Photo> filterHandler = filters.ApplyConstrast;
            filterHandler += filters.ApplyBrightness;
            filterHandler += RemoveRedEyeFilter;

            processor.Process("photo.jpg", filterHandler);
        }

           static void RemoveRedEyeFilter(Photo photo)
           {
              Console.WriteLine("Apply Remove Red Eye");
           }

        // Interfaces or Delegates?

        // Use a delegate when
        // An eventing design pattern is used.
        // The caller doesn't need to access other properties or methods on the object implementing the method. 
    }
}
