namespace SimpleCalculator.Models
{
    internal class AddCommand : ICommand
    {
        public double Execute(double leftOperand, double rightOperand)
        {
            return leftOperand + rightOperand;
        }
    }
}