using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace simple_calculator.Models
{
    internal enum MathOperator
    {
        Add,
        Subtract,
        Multiply,
        Divide
    }

    internal class CalculatorModel
    {
        public double LeftOperand { get; set; }
        public double RightOperand { get; set; }
        public MathOperator Operator { get; set; }

        public double Calculate()
        {
            switch (Operator)
            {
                case MathOperator.Add:
                    return LeftOperand + RightOperand;
                case MathOperator.Subtract:
                    return LeftOperand - RightOperand;
                case MathOperator.Multiply:
                    return LeftOperand * RightOperand;
                case MathOperator.Divide:
                    if (RightOperand != 0)
                        return LeftOperand / RightOperand;
                    else
                        throw new DivideByZeroException("Cannot divide by zero.");
                default:
                    throw new InvalidOperationException("Invalid operation.");
            }
        }
    }
}
