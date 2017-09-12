using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bingfa
{
    class Program
    {
        private static object o = new object();
        private static ConcurrentQueue<Product> _Products { get; set; }
        /*  coder:天才卧龙  
         *  代码中 创建三个并发线程 来操作_Products 集合
         *  System.Collections.Generic.List 这个列表在多个线程访问下，不能保证是安全的线程，所以不能接受并发的请求，我们必须对ADD方法的执行进行串行化
         */
        static void Main(string[] args)
        {
            _Products = new ConcurrentQueue<Product>();
            /*创建任务 t1  t1 执行 数据集合添加操作*/
            Task t1 = Task.Factory.StartNew(() =>
            {
                AddProducts();
            });
            /*创建任务 t2  t2 执行 数据集合添加操作*/
            Task t2 = Task.Factory.StartNew(() =>
            {
                AddProducts();
            });
            /*创建任务 t3  t3 执行 数据集合添加操作*/
            Task t3 = Task.Factory.StartNew(() =>
            {
                AddProducts();
            });
            Task.WaitAll(t1, t2, t3);
            Console.WriteLine(_Products.Count);
            //foreach (var p in _Products)
            //{
            //    Console.WriteLine(p.Name);
            //}
            Console.ReadLine();
        }

        /*执行集合数据添加操作*/
        static void AddProducts()
        {
            Parallel.For(0, 1000, (i) =>
            {
                Product product = new Product();
                product.Name = "name" + i;
                product.Category = "Category" + i;
                product.SellPrice = i;
                //lock (o)
                //{
                    _Products.Enqueue(product);
                //}
            });

        }
    }

    class Product
    {
        public string Name { get; set; }
        public string Category { get; set; }
        public int SellPrice { get; set; }
    }
}
