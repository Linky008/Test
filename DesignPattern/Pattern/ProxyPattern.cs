using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Pattern
{
    class ProxyPattern
    {

    }

    interface GiveGift
    {
        void GiveDolls();
        void GiveFlowers();
        void GiveChocolate();

    }

    class SchoolGirl
    {
        private string name;
        public string Name { get; set; }
    }

    class Pursuit : GiveGift
    {
        SchoolGirl mm;
        public Pursuit(SchoolGirl mm)
        {
            this.mm = mm;
        }

        public void GiveDolls()
        {
            Console.WriteLine($"{mm.Name} 送你洋娃娃");
        }

        public void GiveFlowers()
        {
            Console.WriteLine($"{mm.Name} 送你鲜花");
        }

        public void GiveChocolate()
        {
            Console.WriteLine($"{mm.Name} 送你巧克力");
        }
    }

    class Proxy : GiveGift
    {
        Pursuit gg;
        public Proxy(SchoolGirl mm)
        {
            gg = new Pursuit(mm);
        }

        public void GiveDolls()
        {
            gg.GiveDolls();
        }

        public void GiveFlowers()
        {
            ((GiveGift)gg).GiveFlowers();
        }

        public void GiveChocolate()
        {
            ((GiveGift)gg).GiveChocolate();
        }
    }
}
