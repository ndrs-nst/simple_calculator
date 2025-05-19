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

            // Please consider to change this code if application should supports tab movement, keypress on button
            foreach (Button btn in tableLayoutPanel.Controls)
            {
                btn.TabStop = false;
                btn.KeyPress += (s, e) => { e.Handled = true; };
            }
        }

        private void UpdateDisplay()
        {
            mainDisplayTextBox.Text = _viewModel.MainDisplay;
            subDisplayTextBox.Text = _viewModel.SubDisplay;
        }

        private void digitButton_Click(object sender, EventArgs e)
        {
            var button = sender as Button;
            _viewModel.InputDigitCommand.Execute(button.Text);
            UpdateDisplay();
        }

        private void clearEntryButton_Click(object sender, EventArgs e)
        {
            _viewModel.ClearEntryCommand.Execute(null);
            UpdateDisplay();
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            _viewModel.ClearCommand.Execute(null);
            UpdateDisplay();
        }

        private void backspaceButton_Click(object sender, EventArgs e)
        {
            _viewModel.BackspaceCommand.Execute(null);
            UpdateDisplay();
        }

        private void divideButton_Click(object sender, EventArgs e)
        {
            _viewModel.SetOperatorCommand.Execute(MathOperator.Divide);
            UpdateDisplay();
        }

        private void multiplyButton_Click(object sender, EventArgs e)
        {
            _viewModel.SetOperatorCommand.Execute(MathOperator.Multiply);
            UpdateDisplay();
        }

        private void substractButton_Click(object sender, EventArgs e)
        {
            _viewModel.SetOperatorCommand.Execute(MathOperator.Subtract);
            UpdateDisplay();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            _viewModel.SetOperatorCommand.Execute(MathOperator.Add);
            UpdateDisplay();
        }

        private void enterButton_Click(object sender, EventArgs e)
        {
            _viewModel.CalculateCommand.Execute(null);
            UpdateDisplay();
        }

        private void signChangeButton_Click(object sender, EventArgs e)
        {
            _viewModel.ToggleSignCommand.Execute(null);
            UpdateDisplay();
        }

        private void decimalButton_Click(object sender, EventArgs e)
        {
            _viewModel.InputDecimalCommand.Execute(null);
            UpdateDisplay();
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            KeyPressBinding(keyData);
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void KeyPressBinding(Keys key)
        {
            switch (key)
            {
                case Keys.D0:
                case Keys.NumPad0:
                    _viewModel.InputDigitCommand.Execute("0");
                    UpdateDisplay();
                    break;
                case Keys.D1:
                case Keys.NumPad1:
                    _viewModel.InputDigitCommand.Execute("1");
                    UpdateDisplay();
                    break;
                case Keys.D2:
                case Keys.NumPad2:
                    _viewModel.InputDigitCommand.Execute("2");
                    UpdateDisplay();
                    break;
                case Keys.D3:
                case Keys.NumPad3:
                    _viewModel.InputDigitCommand.Execute("3");
                    UpdateDisplay();
                    break;
                case Keys.D4:
                case Keys.NumPad4:
                    _viewModel.InputDigitCommand.Execute("4");
                    UpdateDisplay();
                    break;
                case Keys.D5:
                case Keys.NumPad5:
                    _viewModel.InputDigitCommand.Execute("5");
                    UpdateDisplay();
                    break;
                case Keys.D6:
                case Keys.NumPad6:
                    _viewModel.InputDigitCommand.Execute("6");
                    UpdateDisplay();
                    break;
                case Keys.D7:
                case Keys.NumPad7:
                    _viewModel.InputDigitCommand.Execute("7");
                    UpdateDisplay();
                    break;
                case Keys.D8:
                case Keys.NumPad8:
                    _viewModel.InputDigitCommand.Execute("8");
                    UpdateDisplay();
                    break;
                case Keys.D9:
                case Keys.NumPad9:
                    _viewModel.InputDigitCommand.Execute("9");
                    UpdateDisplay();
                    break;
                case Keys.Decimal:
                case Keys.OemPeriod:
                    _viewModel.InputDecimalCommand.Execute(null);
                    UpdateDisplay();
                    break;
                case Keys.Enter:
                    _viewModel.CalculateCommand.Execute(null);
                    UpdateDisplay();
                    break;
                case Keys.Back:
                    _viewModel.BackspaceCommand.Execute(null);
                    UpdateDisplay();
                    break;
                case Keys.Delete:
                    _viewModel.ClearEntryCommand.Execute(null);
                    UpdateDisplay();
                    break;
                case Keys.Escape:
                    _viewModel.ClearCommand.Execute(null);
                    UpdateDisplay();
                    break;
                case Keys.F9:
                    _viewModel.ToggleSignCommand.Execute(null);
                    UpdateDisplay();
                    break;
                case Keys.Add:
                case Keys.Oemplus:
                    _viewModel.SetOperatorCommand.Execute(MathOperator.Add);
                    UpdateDisplay();
                    break;
                case Keys.Subtract:
                case Keys.OemMinus:
                    _viewModel.SetOperatorCommand.Execute(MathOperator.Subtract);
                    UpdateDisplay();
                    break;
                case Keys.Multiply:
                    _viewModel.SetOperatorCommand.Execute(MathOperator.Multiply);
                    UpdateDisplay();
                    break;
                case Keys.Divide:
                    _viewModel.SetOperatorCommand.Execute(MathOperator.Divide);
                    UpdateDisplay();
                    break;
                default:
                    // No action for other key for now...
                    break;
            }
        }
    }
}
