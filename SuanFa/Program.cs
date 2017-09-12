using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SuanFa
{
    class Program
    {
        static void Main(string[] args)
        {
            //递归
            //DiGui();
            //分治，递归
            //FenZhi();
            //快速排序
            QuickSort(new int[] { 9,8,7,6,5,4,3,2,1,0 });

        }

        public static void DiGui()
        {
            Console.WriteLine("输入数字:");
            string num = Console.ReadLine();
            int result = GetJieCheng(Convert.ToInt32(num));
            Console.WriteLine("{0}的阶乘为：{1}", num, result);
            Console.Read();
        }

        public static int GetJieCheng(int num)
        {
            if (num == 1)
            {
                return 1;
            }
            else
            {
                return num * GetJieCheng(num - 1);
            }
        }

        public static void FenZhi()
        {
            //给定数字列表求和
            List<int> arr = new List<int> { 1, 2, 3, 4, 5, 6, 7 };
            int result = Sum(arr);
            Console.WriteLine(result);
            Console.Read();

        }

        public static int Sum(List<int> arr)
        {
            if (arr.Count == 1)
                return arr[0];
            else
            {
                int arr0 = arr[0];
                arr.RemoveAt(0);
                return arr0 + Sum(arr);
            }
        }

        public static void QuickSort(int[] array)
        {
            Console.Write("排序前：");
            ShowArray(array);

            int left = 4, right = array.Length - 1,i=1;
            //快速排序
            FastSort(array, left, right,i);

            Console.Write("最终排序后：");
            ShowArray(array);
            Console.Read();
        }

        public static void FastSort(int[] array, int left, int right,int i)
        {
            if (left < right)
            {
                int key = array[left];
                int low = left;
                int high = right;
                while (low < high)
                {
                    while (low< high && array[high] > key)
                    {
                        high--;
                    }
                    array[low] = array[high];
                    while (low<high && array[low] < key)
                    {
                        low++;
                    }
                    array[high] = array[low];
                }

                array[low] = key;

                Console.Write("第{0}次排序后：", i);
                ShowArray(array);
                i++;

                FastSort(array, left, low - 1,i);
                FastSort(array, low + 1, right,i);

               
                

            }
        }

        public static void ShowArray(int[] array)
        {
            foreach (int a in array)
            {
                Console.Write(a);
            }
            Console.WriteLine();
        }
    }
}
