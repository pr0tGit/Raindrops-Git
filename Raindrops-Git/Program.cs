using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Raindrops_Git
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Convert(30));
            Console.ReadLine();
        }

        public static string Convert(int number)
        {            
            var theFactors = Enumerable.Range(1, number).Where(n => number % n == 0).Where(m => m == 3 || m == 5 || m == 7);
            if (theFactors.Count() > 0)
            {
                StringBuilder sb = new StringBuilder();

                foreach (var elem in theFactors)
                    switch (elem)
                    {
                        case 3:
                            sb.Append("Pling");
                            break;
                        case 5:
                            sb.Append("Plang");
                            break;
                        case 7:
                            sb.Append("Plong");
                            break;
                        default:
                            break;
                    }

                return sb.ToString();
            }
            else
            {
                return System.Convert.ToString(number);
            }
        } // end of Convert method
    }
}
