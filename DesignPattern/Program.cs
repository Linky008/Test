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

            //装饰模式
            new Program().GetDecoratorPattern();

            //代理模式
            new Program().GetProxyPattern();

            //工厂方法模式
            new Program().GetFactoryMethodPattern();

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

        public void GetDecoratorPattern()
        {
            Person xc = new Person("小菜");

            Console.WriteLine("\n 第一种装扮:");

            OldShoe pqx = new OldShoe();
            BigTrouser kk = new BigTrouser();
            TShirts dtx = new TShirts();

            pqx.Decorate(xc);
            kk.Decorate(pqx);
            dtx.Decorate(kk);

            dtx.Show();
        }

        public void GetProxyPattern()
        {
            SchoolGirl mm = new SchoolGirl();
            mm.Name = "娇娇";

            Proxy daili = new Proxy(mm);

            daili.GiveDolls();
            daili.GiveFlowers();
            daili.GiveChocolate();
           
        }

        public void GetFactoryMethodPattern()
        {
            IFactory factory = new StudentFactory();
            LeiFeng student = factory.CreateLeiFeng();
            LeiFeng volunteer = factory.CreateLeiFeng();

            student.BuyRice();
            student.Sweep();
            student.Wash();

            volunteer.BuyRice();
            volunteer.Sweep();
            volunteer.Wash();
        }
    }
}
