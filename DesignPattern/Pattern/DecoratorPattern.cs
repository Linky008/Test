using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Pattern
{
    public class DecoratorPattern
    {

    }

    public class Person
    {
        public Person() { }

        private string name;
        public Person(string name)
        {
            this.name = name;
        }

        public virtual void Show()
        {
            Console.WriteLine($"装扮的{name}");
        }
    }

    public class Finery : Person
    {
        protected Person component;

        //打扮
        public void Decorate(Person component)
        {
            this.component = component;
        }

        public override void Show()
        {
            if (component!=null)
            {
                component.Show();
            }
        }
    }

    public class TShirts : Finery
    {
        public override void Show()
        {
            Console.Write("大T恤 ");
            base.Show();
        }
    }

    public class BigTrouser : Finery
    {
        public override void Show()
        {
            Console.Write("垮裤 ");
            base.Show();
        }
    }

    public class OldShoe : Finery
    {
        public override void Show()
        {
            Console.Write("破球鞋 ");
            base.Show();
        }
    }

    public class XiZhuang : Finery
    {
        public override void Show()
        {
            Console.Write("西装 ");
            base.Show();
        }
    }

    public class LingDai : Finery
    {
        public override void Show()
        {
            Console.Write("领带 ");
            base.Show();
        }
    }

    public class PiXie : Finery
    {
        public override void Show()
        {
            Console.Write("皮鞋 ");
            base.Show();
        }
    }



}
