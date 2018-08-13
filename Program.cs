using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication241
{
    class Program
    {
        //过年回家
        //时间限制：1秒 空间限制：32768K 热度指数：1078
        //本题知识点： 查找 图
        //算法知识视频讲解
        //校招时部分企业笔试将禁止编程题跳出页面，为提前适应，练习时请使用在线自测，而非本地IDE。
        //题目描述
        //NowCoder今年买了一辆新车，他决定自己开车回家过年。回家过程中要经过n个大小收费站，每个收费站的费用不同，你能帮他计算一下最少需要给多少过路费吗？
        //输入描述:
        //输入包含多组数据，每组数据第一行包含两个正整数m（1≤m≤500）和n（1≤n≤30），其中n表示有n个收费站，编号依次为1、2、…、n。出发地的编号为0，终点的编号为n，即需要从0到n。
        //紧接着m行，每行包含三个整数f、t、c，（0≤f, t≤n; 1≤c≤10），分别表示从编号为f的地方开到t，需要交c元的过路费。
        //输出描述:
        //对应每组数据，请输出至少需要交多少过路费。
        //示例1
        //输入
        //复制
        //8 4
        //0 1 10
        //0 2 5
        //1 2 2
        //1 3 1
        //2 1 3
        //2 3 9
        //2 4 2
        //3 4 4
        //输出
        //复制
        //7
        //案例通过！部分通过！ lhy edit
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
