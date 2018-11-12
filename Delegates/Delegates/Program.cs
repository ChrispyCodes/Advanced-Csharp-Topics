using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    class Program
    {
        static void Main(string[] args)
        {
            var processor = new PhotoProcessor();
            var filters = new PhotoFilters();
            Action<Photo> filterHandler = filters.ApplyBrigthness;
            filterHandler += filters.ApplyContrast;
            filterHandler += RemoveRedEye;

            processor.Process("Photo.jpg", filterHandler);

            Console.ReadLine();
        }

        static void RemoveRedEye(Photo photo)
        {
            Console.WriteLine("Apply RemoveRedEye");
        }
    }
}
