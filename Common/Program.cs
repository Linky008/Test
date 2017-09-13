using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Common
{
    class Program
    {

        static void Main(string[] args)
        {
            //正则
            RegEX();

            //委托

        }

        #region 正则
        private static void RegEX()
        {
            showMatch();
            Console.WriteLine("---------------------------------------------------------------------");

            Replace();
            Console.WriteLine("---------------------------------------------------------------------");

            Match();
            Console.WriteLine("---------------------------------------------------------------------");

            Match2();
            Console.ReadKey();
        }
        private static void showMatch()
        {
            string str = "A Thousand Splendid     Suns";
            Console.WriteLine("Matching words that start with 'S': ");
            string expr = @"\bS\S*";

            Console.WriteLine("The Expression: " + expr);
            MatchCollection mc = Regex.Matches(str, expr);
            foreach (Match m in mc)
            {
                Console.WriteLine(m);
            }
        }

        public static void Replace()
        {
            string input = "Hello   World   ";
            string pattern = "\\s+";
            string replacement = " ";
            Regex rgx = new Regex(pattern);
            string result = rgx.Replace(input, replacement);

            Console.WriteLine("Original String: {0}", input);
            Console.WriteLine("Replacement String: {0}", result);
        }

        public static void Match()
        {
            var source = "刘备关羽张飞孙权何问起";
            //方法一
            Regex regex = new Regex("孙权");
            if (regex.IsMatch(source))
            {
                Console.WriteLine("字符串中包含有敏感词:孙权！");
            }
            //方法二
            if (Regex.IsMatch(source, "孙权"))
            {
                Console.WriteLine("字符串中包含有敏感词:孙权！");
            }
        }

        public static void Match2()
        {
            var source = "123abc345DEf";
            Regex regex = new Regex("def", RegexOptions.IgnoreCase);
            if (regex.IsMatch(source))
            {
                Console.WriteLine("字符串中包含有敏感词:def！");
            }
            Console.ReadLine();
        }

        #endregion

        #region 委托

        #endregion
    }
}
