namespace Combinations.Common{
    using System;
    using System.Collections.Generic;
    public class Algorithms{

        private static int count = 0;
        private static List<long> combinationsCache;
        private static long countCombinations(int n, int level)
        {
            count++;

            Console.WriteLine(count);

            if (n < 0)
            {
                return 0;
            }

            if (n == 0 && level == 0)
            {
                return 0;
            }

            if (n == 0 && level > 0)
            {
                return 1;
            }

            return countCombinations(n - 1, level + 1) 
                    + countCombinations(n - 2, level + 1)
                    + countCombinations(n - 3, level + 1);
        }

        public static long countCombinationsDinamica(int n, int level)
        {
            if (n < 0)
            {
                return 0;
            }
            if (n == 0 && level == 0)
            {
                return 0;
            }
            if (n == 0 && level > 0)
            {
                combinationsCache[n] = 1;
            }
            if (combinationsCache[n] == 0)
            {
                combinationsCache[n] = countCombinationsDinamica(n - 1, level + 1)+ countCombinationsDinamica(n - 2, level + 1) + countCombinationsDinamica(n - 3, level + 1);
            }
            return combinationsCache[n];
        }

    }

}