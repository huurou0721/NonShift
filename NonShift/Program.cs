using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NonShift
{
    public class Program
    {
        public static void Main(string[] args)
        {
            do
            {
                var input = Console.ReadLine();
                var output = NonShift(input);
                Console.WriteLine(output);
            } while (args.Length == 0); //引数なし
        }

        /// <summary>
        /// NonShift本体
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        private static string NonShift(string input)
        {
            return input + "output";
        }
    }
}
