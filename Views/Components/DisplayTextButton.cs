using System.ComponentModel;
using System.Windows.Forms;

namespace SimpleCalculator.Views.Components
{
    public class BaseCustomButton : Button
    {
        public BaseCustomButton()
        {
            
        }
    }

    public class DisplayTextButton : BaseCustomButton
    {
        private string _displayText = string.Empty;

        [Category("Display")]
        [Description("Sets the text displayed on the button.")]
        [DefaultValue("Display")]
        public string DisplayText
        {
            get { return _displayText; }
            set
            {
                if (_displayText != value)
                {
                    _displayText = value;
                    this.Text = value;
                    this.Invalidate();
                }
            }
        }

        public DisplayTextButton()
        {
            this.Text = _displayText;
        }
    }
}
