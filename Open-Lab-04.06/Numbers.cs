using System;
using System.Collections.Generic;

namespace Open_Lab_04._06
{
    public class Numbers
    {
        public int[] NoOdds(int[] numbers)
        {
            var a = new List<int>();

            foreach (var num in numbers)
                if (num % 2 == 0)
                    a.Add(num);

            return a.ToArray();
        }
    }
}
