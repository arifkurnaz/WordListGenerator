using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WordListGenerator.Libraries
{
    class FormActions
    {
        public void ToggleTextBoxes(TextBox textBox,CheckBox checkBox)
        {
            if (checkBox.Checked)
                textBox.Enabled=true;
           else
                textBox.Enabled = false;
                textBox.Clear();
            
        }
        public void ToggleButtons(Button button,TextBox textBox)
        {
            if (textBox.TextLength > 0)
                button.Enabled = true;
            else
                button.Enabled = false; 
        }
        public void TogglePanels(Panel pnl,CheckBox checkBox)
        {
            if (checkBox.Checked)
                pnl.Enabled = true;
            else
                pnl.Enabled = false;
           
        }  public void ToggleButtons(Button pnl,CheckBox checkBox)
        {
            if (checkBox.Checked)
                pnl.Enabled = true;
            else
                pnl.Enabled = false;
           
        }

       public double FindPercent(int firstValue,decimal totalValue)
        {
            return (Convert.ToDouble(firstValue) * 100) / Convert.ToDouble(totalValue);
        }
    }
}
