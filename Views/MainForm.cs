using SimpleCalculator.Models;
using SimpleCalculator.ViewModels;
using System;
using System.Windows.Forms;

namespace SimpleCalculator
{
    public partial class MainForm : Form
    {
        private readonly CalculatorViewModel _viewModel = new CalculatorViewModel();

        public MainForm()
        {
            InitializeComponent();
            UpdateDisplay();

            // I will disable tabstop on button to prevent keydown event blocking
            // Please consider to change this code if application should supports tab movement
            foreach (Button btn in tableLayoutPanel.Controls)
                btn.TabStop = false;
        }

        private void UpdateDisplay()
        {
            mainDisplayTextBox.Text = _viewModel.MainDisplay;
            subDisplayTextBox.Text = _viewModel.SubDisplay;
        }

        private void digitButton_Click(object sender, EventArgs e)
        {
            var button = sender as Button;
            _viewModel.InputDigit(button.Text);
            UpdateDisplay();
        }

        private void clearEntryButton_Click(object sender, EventArgs e)
        {
            _viewModel.ClearEntry();
            UpdateDisplay();
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            _viewModel.Clear();
            UpdateDisplay();
        }

        private void backspaceButton_Click(object sender, EventArgs e)
        {
            _viewModel.Backspace();
            UpdateDisplay();
        }

        private void divideButton_Click(object sender, EventArgs e)
        {
            _viewModel.SetOperator(MathOperator.Divide);
            UpdateDisplay();
        }

        private void multiplyButton_Click(object sender, EventArgs e)
        {
            _viewModel.SetOperator(MathOperator.Multiply);
            UpdateDisplay();
        }

        private void substractButton_Click(object sender, EventArgs e)
        {
            _viewModel.SetOperator(MathOperator.Subtract);
            UpdateDisplay();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            _viewModel.SetOperator(MathOperator.Add);
            UpdateDisplay();
        }

        private void enterButton_Click(object sender, EventArgs e)
        {
            _viewModel.Calculate();
            UpdateDisplay();
        }

        private void signChangeButton_Click(object sender, EventArgs e)
        {
            _viewModel.ToggleSign();
            UpdateDisplay();
        }

        private void decimalButton_Click(object sender, EventArgs e)
        {
            _viewModel.InputDecimal();
            UpdateDisplay();
        }

        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.D0:
                case Keys.NumPad0:
                    _viewModel.InputDigit("0");
                    UpdateDisplay();
                    break;
                case Keys.D1:
                case Keys.NumPad1:
                    _viewModel.InputDigit("1");
                    UpdateDisplay();
                    break;
                case Keys.D2:
                case Keys.NumPad2:
                    _viewModel.InputDigit("2");
                    UpdateDisplay();
                    break;
                case Keys.D3:
                case Keys.NumPad3:
                    _viewModel.InputDigit("3");
                    UpdateDisplay();
                    break;
                case Keys.D4:
                case Keys.NumPad4:
                    _viewModel.InputDigit("4");
                    UpdateDisplay();
                    break;
                case Keys.D5:
                case Keys.NumPad5:
                    _viewModel.InputDigit("5");
                    UpdateDisplay();
                    break;
                case Keys.D6:
                case Keys.NumPad6:
                    _viewModel.InputDigit("6");
                    UpdateDisplay();
                    break;
                case Keys.D7:
                case Keys.NumPad7:
                    _viewModel.InputDigit("7");
                    UpdateDisplay();
                    break;
                case Keys.D8:
                case Keys.NumPad8:
                    _viewModel.InputDigit("8");
                    UpdateDisplay();
                    break;
                case Keys.D9:
                case Keys.NumPad9:
                    _viewModel.InputDigit("9");
                    UpdateDisplay();
                    break;
                case Keys.Decimal:
                case Keys.OemPeriod:
                    _viewModel.InputDecimal();
                    UpdateDisplay();
                    break;
                case Keys.Enter:
                    _viewModel.Calculate();
                    UpdateDisplay();
                    break;
                case Keys.Back:
                    _viewModel.Backspace();
                    UpdateDisplay();
                    break;
                case Keys.Delete:
                    _viewModel.ClearEntry();
                    UpdateDisplay();
                    break;
                case Keys.Escape:
                    _viewModel.Clear();
                    UpdateDisplay();
                    break;
                case Keys.F9:
                    _viewModel.ToggleSign();
                    UpdateDisplay();
                    break;
                case Keys.Add:
                case Keys.Oemplus:
                    _viewModel.SetOperator(MathOperator.Add);
                    UpdateDisplay();
                    break;
                case Keys.Subtract:
                case Keys.OemMinus:
                    _viewModel.SetOperator(MathOperator.Subtract);
                    UpdateDisplay();
                    break;
                case Keys.Multiply:
                    _viewModel.SetOperator(MathOperator.Multiply);
                    UpdateDisplay();
                    break;
                case Keys.Divide:
                    _viewModel.SetOperator(MathOperator.Divide);
                    UpdateDisplay();
                    break;
                default:
                    // No action for other key for now...
                    break;
            }
        }
    }
}
