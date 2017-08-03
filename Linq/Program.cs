using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq
{
    class Program
    {
        static void Main(string[] args)
        {

            var a = 10;
            a.Between(2, 11);

            foreach (var i in Iterator()) {
                Console.WriteLine(i);
            }

            var numbers = new List<int>()
            {
                1,2,3
            };

            var result = numbers.Where(Predicate);
            numbers.Where(n => n > 1);//hace lo mismo que arriba
            foreach (var value in result) { }
        }

        static bool Predicate(int value) {
            Console.WriteLine("He entrado");
            return value > 1;
        }

        static IEnumerable<int> Iterator() {

            for (var i = 0; 1 < 100; i++) {
                yield return i;
            }
        }
    }

    public static class ExtensionInt {

        public static bool Between(this int value, int from, int to) {
            return value >= from && value <= to;
        }

    }
}


