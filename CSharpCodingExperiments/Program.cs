using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCodingExperiments
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> testing = new List<string>();
            testing.Add("One");
            testing.Add("Two");
            testing.Add("Three");
            testing.Add("Mouse");
            bool inList = testing.Contains("Mouse");
            Console.WriteLine(inList);

        }
    }
}
