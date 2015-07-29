using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] list = { 34, 72, 13, 44, 25, 30, 10 };
            int[] temp = list;

            Console.Write("原始数组： ");
            foreach (int i in list)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();

            // 逆转数组
            Array.Reverse(temp);
            Console.Write("逆转数组： ");
            foreach (int i in temp)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();

            // 排序数组
            Array.Sort(list);
            Console.Write("排序数组： ");
            foreach (int i in list)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();

            Console.ReadKey();

            List<ListArrytest> arrylist = new List<ListArrytest>();
            for (int i = 0; i < 8; i++)
            {
                ListArrytest arrytest = new ListArrytest();
                arrytest.Tyear = (DateTime.Now.Year - i).ToString();
                arrytest.Tmonth = (DateTime.Now.Month - i).ToString();
                arrytest.Tdays = (DateTime.Now.Day - i).ToString();
                arrylist.Add(arrytest);
            }
           
        }
    }
}
