using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AhbkFormActions
{
    public class FormActions
    {
        public void ToggleTextBoxes(TextBox textBox, CheckBox checkBox)
        {
            if (checkBox.Checked)
                textBox.Enabled = true;
            else
                textBox.Enabled = false;
            textBox.Clear();

        }
        public void ToggleButtons(Button button, TextBox textBox)
        {
            if (textBox.TextLength > 0)
                button.Enabled = true;
            else
                button.Enabled = false;
        }
        public void TogglePanels(Panel pnl, CheckBox checkBox)
        {
            if (checkBox.Checked)
                pnl.Enabled = true;
            else
                pnl.Enabled = false;

        }
        public void TogglePanels(Panel pnl, bool state)
        {
            if (state)
                pnl.Enabled = true;
            else
                pnl.Enabled = false;

        }
        public void ToggleButtons(Button pnl, CheckBox checkBox)
        {
            if (checkBox.CheckState==CheckState.Checked)
                pnl.Enabled = true;
            else
                pnl.Enabled = false;

        }
        public void ToggleButtonsReverse(Button pnl, CheckBox checkBox)
        {
            if (checkBox.CheckState == CheckState.Checked)
                pnl.Enabled = false;
            else
                pnl.Enabled = true;

        }

        public void ToggleButtons(Button pnl, ComboBox checkBox)
        {
            if (checkBox.SelectedIndex>0)
                pnl.Enabled = true;
            else
                pnl.Enabled = false;

        }



        public double FindPercent(int firstValue, decimal totalValue)
        {
            return (Convert.ToDouble(firstValue) * 100) / Convert.ToDouble(totalValue);
        }
    }
}
