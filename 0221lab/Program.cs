using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0221lab
{
    class Program
    {
        delegate bool dg1(int a);
        delegate double dg2(int a);
        delegate int dg3(int[] arr);
        static void Main(string[] args)
        {
            #region 1
            dg1 ifEven = delegate (int a)
              {
                  return a % 2 == 0;
              };
            Console.WriteLine(ifEven(3));
            #endregion

            #region 2
            dg2 Pow2 = delegate (int a)
            {
                return Math.Pow(a, 2);
            };
            Console.WriteLine(Pow2(3));
            #endregion

            #region 3
            dg2 Pow3 = (int a) => Math.Pow(a, 3);
            Console.WriteLine(Pow3(3));
            #endregion

            #region 4
            DateTime now = DateTime.Now;
            dg1 progday=(int a) => 256 == a;
            Console.WriteLine(progday(now.DayOfYear));
            #endregion

            #region 5
            int[] arr = new int[] { -8, 2, 3, 14, 56, 6, 2, 8, 9, 10 };
            dg3 arrayMax = (int[] array) => array.Max();
            Console.WriteLine(arrayMax(arr));
            #endregion

            #region 6
            dg3 arrayMin = (int[] array) => array.Min();
            Console.WriteLine(arrayMin(arr));
            #endregion

            #region 7
            dg3 arrayOdd = (int[] array) =>
            {
                int count = 0;
                foreach (int i in array)
                {
                    if (i % 2 != 0)
                    {
                        count++;
                    }
                }
                return count;
            };
            Console.WriteLine(arrayOdd(arr));
            #endregion

        }
    }
}
