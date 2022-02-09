using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    public class PhotoProcessor
    {
        // System.Action<>
        // System.Func<>
        // public delegate void PhotoFilterHandler(Photo photo);
        // public void Process(string path, PhotoFilterHandler filterHandler)
        public void Process(string path, Action<Photo> filterHandler)
        {
            var photo = Photo.Load(path);

            filterHandler(photo);

            //var filters = new PhotoFilters();

            //filters.ApplyBrightness(photo);
            //filters.ApplyConstrast(photo);
            //filters.Resize(photo);

            photo.Save();
        }
    }
}
