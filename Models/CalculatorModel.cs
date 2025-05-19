using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalculator.Models
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
        private Dictionary<MathOperator, ICommand> _commands = new Dictionary<MathOperator, ICommand>
        {
            { MathOperator.Add, new AddCommand() },
            { MathOperator.Subtract, new SubtractCommand() },
            { MathOperator.Multiply, new MultiplyCommand() },
            { MathOperator.Divide, new DivideCommand() }
        };

        public double LeftOperand { get; set; }
        public double RightOperand { get; set; }
        public MathOperator Operator { get; set; }

        public double Calculate()
        {
            if (_commands.TryGetValue(Operator, out ICommand command))
            {
                return command.Execute(LeftOperand, RightOperand);
            }
            else
            {
                throw new InvalidOperationException("Invalid operation.");
            }
        }
    }
}
