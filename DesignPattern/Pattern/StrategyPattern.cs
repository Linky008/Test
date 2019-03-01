using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Pattern
{
    public interface IStrategyPattern
    {
        void AlgorithmMethod();
    }

    public class ConcreteStrategy : IStrategyPattern
    {
        public void AlgorithmMethod()
        {
            Console.WriteLine("this is a ConcreteStrategy methoid...");
        }
    }

    public class ConcreteStrategy2 : IStrategyPattern
    {
        public void AlgorithmMethod()
        {
            Console.WriteLine("this is a ConcreteStrategy2 methoid...");
        }
    }

    public class StrategyContext
    {
        //持有一个策略实现的引用
        private IStrategyPattern strategy;

        //使用构造器注入具体的策略类
        public StrategyContext(IStrategyPattern strategy)
        {
            this.strategy = strategy;
        }

        public void contextMethod()
        {
            //调用策略实现的方法
            strategy.AlgorithmMethod();
        }
    }
}
