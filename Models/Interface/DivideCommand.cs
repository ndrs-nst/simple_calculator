using System;

namespace SimpleCalculator.Models
{
    internal class DivideCommand : ICommand
    {
        public double Execute(double leftOperand, double rightOperand)
        {
            if (rightOperand != 0)
                return leftOperand / rightOperand;
            else
                throw new DivideByZeroException("Cannot divide by zero.");
        }
    }
}