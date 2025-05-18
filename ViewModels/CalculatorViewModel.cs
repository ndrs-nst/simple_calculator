using SimpleCalculator.Models;
using System;

namespace SimpleCalculator.ViewModels
{
    internal class CalculatorViewModel
    {
        private readonly CalculatorModel _model = new CalculatorModel();
        private bool _isNewEntry = true;
        private bool _operatorSet = false;
        private bool _isRightOperandExist = false;
        private bool _isError = false;

        public string MainDisplay { get; private set; } = "0";
        public string SubDisplay { get; private set; } = string.Empty;

        private string OperatorToString(MathOperator op)
        {
            switch (op)
            {
                case MathOperator.Add: return "+";
                case MathOperator.Subtract: return "-";
                case MathOperator.Multiply: return "*";
                case MathOperator.Divide: return "/";
                default: return string.Empty;
            }
        }

        private void PrepareForNewCalculationDisplay()
        {
            if ((_isNewEntry && !_operatorSet) || _isError)
            {
                SubDisplay = string.Empty;
            }
        }

        private void ClearChainCalculation()
        {
            SubDisplay = string.Empty;
            _model.RightOperand = 0;
            _operatorSet = false;
            _isNewEntry = true;
        }

        public void InputDigit(string digit)
        {
            PrepareForNewCalculationDisplay();

            if (_isNewEntry || MainDisplay == "0")
                MainDisplay = digit;
            else
                MainDisplay += digit;

            _isNewEntry = false;
            _isError = false;
        }

        public void SetOperator(MathOperator op)
        {
            if (_isRightOperandExist)
            {
                _model.Calculate();
                _isRightOperandExist = false;
            }

            _model.LeftOperand = double.TryParse(MainDisplay, out var left) ? left : 0;
            _model.Operator = op;
            string leftOperandForSubDisplay = _model.LeftOperand.ToString(System.Globalization.CultureInfo.InvariantCulture);
            string operatorForSubDisplay = OperatorToString(_model.Operator);
            SubDisplay = $"{leftOperandForSubDisplay} {operatorForSubDisplay} ";
            _operatorSet = true;
            _isNewEntry = true;
        }

        public void Calculate()
        {
            if (_isError)
            {
                Clear();
                return;
            }

            if (_operatorSet)
            {
                if (_isRightOperandExist)
                {
                    _model.LeftOperand = double.TryParse(MainDisplay, out var left) ? left : 0;
                    string leftOperandForSubDisplay = _model.LeftOperand.ToString(System.Globalization.CultureInfo.InvariantCulture);
                    string operatorForSubDisplay = OperatorToString(_model.Operator);
                    string rightOperandForSubDisplay = _model.RightOperand.ToString(System.Globalization.CultureInfo.InvariantCulture);
                    SubDisplay = $"{leftOperandForSubDisplay} {operatorForSubDisplay} {rightOperandForSubDisplay} =";
                }
                else
                {
                    string leftOperandForSubDisplay = _model.LeftOperand.ToString(System.Globalization.CultureInfo.InvariantCulture);
                    string operatorForSubDisplay = OperatorToString(_model.Operator);
                    _model.RightOperand = double.TryParse(MainDisplay, out var right) ? right : 0;
                    string rightOperandForSubDisplay = _model.RightOperand.ToString(System.Globalization.CultureInfo.InvariantCulture);
                    SubDisplay = $"{leftOperandForSubDisplay} {operatorForSubDisplay} {rightOperandForSubDisplay} =";
                }

                try
                {
                    var result = _model.Calculate();
                    MainDisplay = result.ToString();
                    _isRightOperandExist = true;
                }
                catch (Exception ex)
                {
                    MainDisplay = ex.Message;
                    _isError = true;
                }
            }
        }

        public void ClearEntry()
        {
            if (_isError)
            {
                Clear();
                return;
            }

            MainDisplay = "0";
            _isNewEntry = true;
        }

        public void Clear()
        {
            MainDisplay = "0";
            SubDisplay = string.Empty;
            _model.LeftOperand = 0;
            _model.RightOperand = 0;
            _operatorSet = false;
            _isError = false;
            _isNewEntry = true;
        }
        
        public void Backspace()
        {
            if (_isError)
            {
                Clear();
                return;
            }
            if (!string.IsNullOrEmpty(SubDisplay))
            {
                ClearChainCalculation();
                return;
            }

            if (_isNewEntry || string.IsNullOrEmpty(MainDisplay))
                return;

            // Remove last character
            MainDisplay = MainDisplay.Length > 1 ? MainDisplay.Substring(0, MainDisplay.Length - 1) : "0";

            // Handle edge cases like "-" or empty string
            if (MainDisplay == "-" || MainDisplay == "")
                MainDisplay = "0";

            // If backspace results in "0", treat as new entry state for some logic
            if (MainDisplay == "0")
                _isNewEntry = true; 
        }

        public void InputDecimal()
        {
            PrepareForNewCalculationDisplay();

            if (_isNewEntry)
            {
                MainDisplay = "0.";
                _isNewEntry = false;
            }
            else if (!MainDisplay.Contains("."))
            {
                MainDisplay += ".";
            }
        }

        public void ToggleSign()
        {
            if (double.TryParse(MainDisplay, out var val))
            {
                MainDisplay = (-val).ToString();
            }
        }
    }
}

