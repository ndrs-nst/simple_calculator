namespace SimpleCalculator.Models
{
    internal class SubtractCommand : ICommand
    {
        public double Execute(double leftOperand, double rightOperand)
        {
            return leftOperand - rightOperand;
        }
    }
}