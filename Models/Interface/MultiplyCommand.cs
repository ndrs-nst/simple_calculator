namespace SimpleCalculator.Models
{
    internal class MultiplyCommand : ICommand
    {
        public double Execute(double leftOperand, double rightOperand)
        {
            return leftOperand * rightOperand;
        }
    }
}