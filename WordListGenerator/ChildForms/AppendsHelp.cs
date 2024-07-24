using AhbkLanguageHelper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WordListGenerator.ChildForms
{
    public partial class AppendsHelp : Form
    {
        public AppendsHelp()
        {
            InitializeComponent();
        }

        private void AppendsHelp_Load(object sender, EventArgs e)
        {
            LanguageHelper languageHelper = new LanguageHelper();
            labelCaption.Text = languageHelper.Read("help_message","password_template");
            labelLoverCase.Text = languageHelper.Read("help_lower_case", "password_template");
            labelUpperCase.Text = languageHelper.Read("help_upper_case", "password_template");
            labelNumbers.Text = languageHelper.Read("help_numbers", "password_template");
            labelExample.Text = languageHelper.Read("help_example", "password_template");
        }
    }
}
