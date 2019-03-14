using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Pattern
{
    class FactoryMethodPattern
    {

    }

    class LeiFeng
    {
        public void Sweep()
        {
            Console.WriteLine("扫地");
        }

        public void Wash()
        {
            Console.WriteLine("洗衣");
        }

        public void BuyRice()
        {
            Console.WriteLine("买米");
        }
    }

    interface IFactory
    {
        LeiFeng CreateLeiFeng();
    }

    class Volunteer : LeiFeng
    {

    }

    class Student : LeiFeng
    {

    }

    class StudentFactory : IFactory
    {
        public LeiFeng CreateLeiFeng()
        {
            return new Student();
        }
    }

    class VolunteerFactory : IFactory
    {
        public LeiFeng CreateLeiFeng()
        {
            return new Volunteer();
        }
    }


}
