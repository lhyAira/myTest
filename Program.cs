using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication241
{
    class Program
    {
        //changesomething
        static void Main(string[] args)
        {
            string input = string.Empty;
            while (!string.IsNullOrEmpty(input = Console.ReadLine()))
            {
                int[] arrParam = input.Split(' ').Select(x => int.Parse(x)).ToArray();
                count = arrParam[0];
                last = arrParam[1];
                li = new List<int[]>();
                for (int i = 0; i < count; i++)
                {
                    li.Add(Console.ReadLine().Split(' ').Select(x => int.Parse(x)).ToArray());
                }

                int temp = int.MaxValue;
                for (int i = 0; i < li.Count; i++)
                {
                    if (li[i][0] == 0)
                    {
                        findx(li[i][1], li[i][2]);
                        if (sumMoney < temp)
                        {
                            temp = sumMoney;
                        }
                    }
                }
                Console.WriteLine(sumMoney);
            }
        }
        static List<int[]> li;
        static int last;
        static int count;
        static int sumMoney;
        static void findx(int end, int money)
        {
            if (end == last)
            {
                sumMoney = money;
                return;
            }
            for (int i = 0; i < count; i++)
            {
                if (end == li[i][0] && li[i][1] > li[i][0])
                {
                    findx(li[i][1], money + li[i][2]);
                }
            }
        }
    }
}
