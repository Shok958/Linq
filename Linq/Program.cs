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

            var numbers = new List<int>()
            {
                1,2,3
            };

            numbers.Where(Predicate);

            numbers.Where(n => n > 1);//hace lo mismo que arriba
        }

        static bool Predicate(int value) {
            return value > 1;
        }
    }

    public static class ExtensionInt {

        public static bool Between(this int value, int from, int to) {
            return value >= from && value <= to;
        }

    }
}


