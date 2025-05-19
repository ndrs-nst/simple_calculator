namespace SimpleCalculator.Models
{
    internal interface ICommand
    {
        double Execute(double leftOperand, double rightOperand);
    }
}
