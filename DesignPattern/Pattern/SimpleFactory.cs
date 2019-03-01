using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Pattern
{
    public class SimpleFactory
    {

    }

    /// <summary>
    /// 操作类
    /// </summary>
    public class Operation
    {
        private double _numberA = 0;
        private double _numberB = 0;

        public double NumberA { get => _numberA; set => _numberA = value; }
        public double NumberB { get => _numberB; set => _numberB = value; }

        public virtual double GetResult()
        {
            double result = 0;
            return result;
        }
    }

    /// <summary>
    /// 加法
    /// </summary>
    public class OperationAdd : Operation
    {
        public override double GetResult()
        {
            double result = 0;
            result = NumberA + NumberB;
            return result;
        }
    }

    /// <summary>
    /// 减法
    /// </summary>
    public class OperationSub : Operation
    {
        public override double GetResult()
        {
            double result = 0;
            result = NumberA - NumberB;
            return result;
        }
    }

    /// <summary>
    /// 乘法
    /// </summary>
    public class OperationMul : Operation
    {
        public override double GetResult()
        {
            double result = 0;
            result = NumberA * NumberB;
            return result;
        }
    }

    public class OperationDiv : Operation
    {
        public override double GetResult()
        {
            double result = 0;
            if (NumberB == 0)
            {
                throw new Exception("除数不能为0");
            }
            result = NumberA / NumberB;
            return result;
        }
    }

    public class OperationFactory
    {
        public static Operation createOperate(string operate)
        {
            Operation oper = null;
            switch (operate)
            {
                case "+":oper = new OperationAdd();break;
                case "-":oper = new OperationSub();break;
                case "*":oper = new OperationMul();break;
                case "/":oper = new OperationDiv();break;
            }

            return oper;
        }
    }
}
