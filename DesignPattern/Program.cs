using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPattern.Pattern;

namespace DesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            //简单工厂模式
            new Program().GetSimpleFactory();

            //策略模式
            new Program().GetStrategyPattern();

            Console.Read();

        }

        public void GetSimpleFactory()
        {
            Operation oper = OperationFactory.createOperate("+");
            oper.NumberA = 1;
            oper.NumberB = 2;
            Console.WriteLine($"{oper.NumberA}+{oper.NumberB}={oper.GetResult()}");
        }

        public void GetStrategyPattern()
        {
            IStrategyPattern strategy = new ConcreteStrategy2();
            StrategyContext ctx = new StrategyContext(strategy);
            ctx.contextMethod();
        }
    }
}
