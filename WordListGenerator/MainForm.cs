using AhbkFormActions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using AhbkPasswordGenerator;
using AhbkLanguageHelper;

namespace WordListGenerator
{
	public partial class MainForm : Form
	{
       
        private bool switchButton = true;
		private Thread thread;
		private string appendType = null;
        private int tempValue;

        public MainForm()
		{
			InitializeComponent();
		}

		private void checkBoxCustomCharset_CheckedChanged(object sender, EventArgs e)
		{
			new FormActions().ToggleTextBoxes(textBoxCustom, checkBoxCustomCharset);
		}

		private void checkBoxAppends_CheckedChanged(object sender, EventArgs e)
		{
			new FormActions().TogglePanels(panelAppends, checkBoxAppends);

            if (checkBoxAppends.CheckState==CheckState.Checked)
            {
				tempValue =(int) numericPasswordLength.Value;
				if (textBoxAppends.TextLength > 0 && radioAfter.Checked || textBoxAppends.TextLength > 0 && radioBefore.Checked)
				{
					new FormActions().ToggleButtons(buttonGenerate, textBoxAppends);
				}
            }
            else
            {
				new FormActions().ToggleButtons(buttonGenerate, checkBoxAppends);
            }
           

		}

		private void checkBoxPasswordSequence_CheckedChanged(object sender, EventArgs e)
		{
			new FormActions().TogglePanels(panelPasswordSequence, checkBoxPasswordSequence);
			
			if (checkBoxPasswordSequence.CheckState==CheckState.Checked)
            {
				numericPasswordLength.Enabled = false;

				new FormActions().ToggleButtons(buttonGenerate, comboBoxPasswordSequence);

			}
            else
            {
				numericPasswordLength.Enabled = true;
				new FormActions().ToggleButtonsReverse(buttonGenerate, checkBoxPasswordSequence);

			}
			
		}

		private void buttonFile_Click(object sender, EventArgs e)
		{
			

			SaveFileDialog fileDialog = new SaveFileDialog();

		  
			fileDialog.Filter = "Metin Dosyaları (*.txt)|*.txt";

		   
			fileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

		   
			if (fileDialog.ShowDialog() == DialogResult.OK)
			{
			 
				string dosyaYolu = fileDialog.FileName; 
				textBoxFilePath.Text = dosyaYolu;
				new FormActions().TogglePanels(panelSettings, true);
				new FormActions().ToggleButtons(buttonGenerate, textBoxFilePath);

			}
			else
			{
				new FormActions().TogglePanels(panelSettings, false);
				new FormActions().ToggleButtons(buttonGenerate, textBoxFilePath);
			}
			
		}

		private void textBoxPasswordSequence_TextChanged(object sender, EventArgs e)
		{
			
		}

		private void textBoxPasswordSequence_KeyPress(object sender, KeyPressEventArgs e)
		{
			char[] izinVerilenKarakterler = { '+', '*', '#'};

			// Tuşa basılan karakteri kontrol edin
			char girilenKarakter = e.KeyChar;
			if (!izinVerilenKarakterler.Contains(girilenKarakter))
			{
				// İzin verilmeyen karakter ise, işlemi iptal edin
				e.Handled = true;
			}
			if (e.KeyChar == (char)Keys.Back)
			{
				// Backspace tuşu ise, işlemi iptal edin
				e.Handled = false;
			} if (e.KeyChar == (char)Keys.Delete)
			{
				// Backspace tuşu ise, işlemi iptal edin
				e.Handled = false;
			}
		}

		private void buttonGenerate_Click(object sender, EventArgs e)
		{
           
            if (switchButton)
            {
				switchButton = false;
				thread = new Thread(() => GeneratorStart(progressBarGenerate));
				SwitchButtonAction(buttonGenerate,switchButton);
               
			}
            else
            {
							
				switchButton = true;
				SwitchButtonAction(buttonGenerate,switchButton);
				Thread.Sleep(1);
			}
			 
			
			
			
			

		}

		private  void GeneratorStart(ProgressBar progressBar)
		{
			
			using (StreamWriter writer = new StreamWriter(textBoxFilePath.Text.Trim()))
			{
				PasswordGenerator generator = new PasswordGenerator();
				if (progressBar.InvokeRequired)
				{
					progressBar.Invoke(new Action(() => progressBar.Maximum = (int)numericUpDownPasswordTotal.Value-1));
				}
				else
				{
					progressBar.Value = (int)numericUpDownPasswordTotal.Value;
				}
			   
			  

				generator.CheckAppends			= checkStateCOntrol(checkBoxAppends);
				generator.CheckCustomCharset	= checkStateCOntrol(checkBoxCustomCharset);
				generator.CheckLowerCase		= checkStateCOntrol(checkBoxLoweCase);
				generator.CheckNumbers			= checkStateCOntrol(checkBoxNumbers);
				generator.CheckPasswordSequence = checkStateCOntrol(checkBoxPasswordSequence);
				generator.CheckSymbols			= checkStateCOntrol(checkBoxSymbols); 
				generator.CheckUpperCase		= checkStateCOntrol(checkBoxUpperCase);
				generator.CustomCharset			= textBoxCustom.Text.Trim();
				generator.Appends				= textBoxAppends.Text.Trim();
				generator.AppendType = this.appendType;
				FormActions action = new FormActions();

				string password = "";
				toolTipTotalValue.Visible = true;
				toolTipTotalValue.Text = "/ "+numericUpDownPasswordTotal.Value.ToString();
				for (int i = 0; i < numericUpDownPasswordTotal.Value; i++)
				{
					if (checkBoxPasswordSequence.Checked)
					{
						password = generator.PasswordGenerateWithSequence(textBoxPasswordSequence.Text);
					}
					else
					{
						password = generator.PasswordGenerate(Convert.ToInt32(numericPasswordLength.Value));
					}
					writer.WriteLine(password);
					
					
					
					if (switchButton)
					{
						writer.Close();
						if (progressBar.InvokeRequired)
						{
							progressBar.Invoke(new Action(() => progressBar.Value = 0));
						}
						else
						{
							progressBar.Value = 0;
						}
						thread.Abort();
						toolStripShowPassword.Text = "";
						toolStripPasswordTotal.Text ="";
						toolTipTotalValue.Visible = false;
						toolTipTotalValue.Text ="";
						SwitchButtonAction(buttonGenerate, true);


						break;
                    }
                    else
                    {
						if (progressBar.InvokeRequired)
						{
							progressBar.Invoke(new Action(() => progressBar.Value = i));
						}
						else
						{
							progressBar.Value = i;
							
						}
						toolStripShowPassword.Text = password;
						toolStripPasswordTotal.Text = (i + 1).ToString();
						Thread.Sleep(1);
					}
				}
				
				DialogResult result=MessageBox.Show(new LanguageHelper().Read("finish_operation","generator"),"",MessageBoxButtons.OK);
                if (result == DialogResult.OK)
                {
					
					switchButton = true;
				
					toolStripShowPassword.Text = "";
					toolStripPasswordTotal.Text = "";
					toolTipTotalValue.Visible = false;
					toolTipTotalValue.Text = "";
					SwitchButtonAction(buttonGenerate, true);
					thread.Abort();
				}
				
				
				




			}
		}
		private bool checkStateCOntrol(CheckBox checkBox) 
		{
			if (checkBox.CheckState == CheckState.Checked)
			{
				return true;
			}
			else
			{
				return false;
			}
		}

		private void SwitchButtonAction(Button button,bool toogleKey)
        {
            if (!toogleKey){
				thread.Start();
				panelActionTypes.Enabled = false;
				button.Text = new LanguageHelper().Read("btn_abort", "program");
				

				
            }else
            {
				//thread.Interrupt();
				button.Invoke(new Action(() =>button.Text = new LanguageHelper().Read("btn_generate", "program")));
				thread.Abort();
				toolStripShowPassword.Text = "";
				toolStripPasswordTotal.Text = "";
				toolTipTotalValue.Visible = false;
				progressBarGenerate.Value = 0;
				panelActionTypes.Enabled = true;



			}
        }

		

        private void Form1_Load(object sender, EventArgs e)
        {
		
			LanguageHelper languageHelper = new LanguageHelper();
			
			this.Text= languageHelper.Read("title", "program");
			groupBox1.Text= languageHelper.Read("groupbox_charset", "program");
			groupBox2.Text= languageHelper.Read("groupbox_password", "program");
			groupBox3.Text= languageHelper.Read("groupbox_output", "program");
			groupBox4.Text= languageHelper.Read("groupbox_process", "program");
			groupBoxAppends.Text= languageHelper.Read("groupbox_appends", "program");
			groupBox.Text= languageHelper.Read("groupbox_sequence", "program");
			radioBefore.Text= languageHelper.Read("radio_before", "program");
			radioAfter.Text= languageHelper.Read("radio_after", "program");
			labelLength.Text= languageHelper.Read("label_length", "program");
			labelPass.Text= languageHelper.Read("label_total", "program");
			labelTemplate.Text= languageHelper.Read("label_template", "program");			
			buttonSaveTemplate.Text= languageHelper.Read("btn_save", "program");
			buttonFile.Text= languageHelper.Read("btn_save_as", "program");
			buttonGenerate.Text= languageHelper.Read("btn_generate", "program");
			buttonNew.Text= languageHelper.Read("btn_new", "program");
			toolStripStatusLabelGenerated.Text= languageHelper.Read("status_generated", "program");			
			comboBoxPasswordSequence.Text= languageHelper.Read("combobox_sequence", "program");
			checkBoxAppends.Text= languageHelper.Read("check_append", "program");
			checkBoxEditPassword.Text= languageHelper.Read("check_edit", "program");
			checkBoxPasswordSequence.Text= languageHelper.Read("check_sequence", "program");
			checkBoxSymbols.Text= languageHelper.Read("check_symbols", "program");
			checkBoxCustomCharset.Text= languageHelper.Read("check_custom_charset", "program");
			dosyaToolStripMenuItem.Text= languageHelper.Read("menu_file", "program");
			yardımToolStripMenuItem.Text= languageHelper.Read("menu_help", "program");
			donateToolStripMenuItem.Text= languageHelper.Read("menu_donate", "program");
			hakkımızdaToolStripMenuItem.Text= languageHelper.Read("menu_about", "program");
			exitToolStripMenuItem.Text= languageHelper.Read("menu_exit", "program");
			loadSequence(comboBoxPasswordSequence); // loading combobox 

		}

        private void checkBoxEditPassword_CheckedChanged(object sender, EventArgs e)
        {
			new FormActions().ToggleTextBoxes(textBoxPasswordSequence, checkBoxEditPassword);
			new FormActions().ToggleButtons(buttonSaveTemplate, checkBoxEditPassword);
			
		}

        private void textBoxFilePath_DoubleClick(object sender, EventArgs e)
        {
			SaveFileDialog fileDialog = new SaveFileDialog();


			fileDialog.Filter = "Metin Dosyaları (*.txt)|*.txt";


			fileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);


			if (fileDialog.ShowDialog() == DialogResult.OK)
			{

				string dosyaYolu = fileDialog.FileName;
				textBoxFilePath.Text = dosyaYolu;
				new FormActions().ToggleButtons(buttonGenerate, textBoxFilePath);
			}
			else
			{
				new FormActions().ToggleButtons(buttonGenerate, textBoxFilePath);
			}
		}

        private void donateToolStripMenuItem_Click(object sender, EventArgs e)
        {
			new ChildForms.Donate().ShowDialog();
        }

        private void hakkımızdaToolStripMenuItem_Click(object sender, EventArgs e)
        {
			new ChildForms.Aboutus().ShowDialog();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
			DialogResult result=MessageBox.Show(new LanguageHelper().Read("message_exit", "program"), "", MessageBoxButtons.OKCancel);
			if (result == DialogResult.OK) Application.Exit();

        }

        private void buttonSaveTemplate_Click(object sender, EventArgs e)
        {
			AhbkDatHelper.Dathelper helper = new AhbkDatHelper.Dathelper();
			helper.addFormat(textBoxPasswordSequence.Text.Trim());
			DialogResult result = MessageBox.Show(new LanguageHelper().Read("message_sequence_create", "program"), "",MessageBoxButtons.OK);
            if (result == DialogResult.OK)
            {
				loadSequence(comboBoxPasswordSequence);
				checkBoxEditPassword.Checked = false;
				buttonSaveTemplate.Enabled = false;


			}
			loadSequence(comboBoxPasswordSequence);
        }

		private void loadSequence(ComboBox comboBox) {

            if (comboBox.Items.Count > 0)
            {
				comboBox.Items.Clear();
            }
			comboBox.Items.Add(new LanguageHelper().Read("combobox_sequence", "program"));
			AhbkDatHelper.Dathelper helper = new AhbkDatHelper.Dathelper();
            foreach (var item in helper.GetFormats())
            {
				comboBox.Items.Add(item);
            }

		}

        private void buttonNew_Click(object sender, EventArgs e)
        {
            if (textBoxPasswordSequence.Enabled == false)
            {
				textBoxPasswordSequence.Enabled = true;
				buttonSaveTemplate.Enabled = true;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxPasswordSequence.SelectedIndex > 0)
            {
			textBoxPasswordSequence.Text=comboBoxPasswordSequence.SelectedItem.ToString();
				textBoxPasswordSequence.Enabled = false;
				checkBoxEditPassword.Checked = false;
				buttonSaveTemplate.Enabled = false;
            }
           
        }

        private void buttonHelpSequence_Click(object sender, EventArgs e)
        {
			new ChildForms.SequenceHelp().ShowDialog();
        }

        private void buttonAppends_Click(object sender, EventArgs e)
        {
			new ChildForms.AppendsHelp().ShowDialog();
		}

        private void radioBefore_CheckedChanged(object sender, EventArgs e)
        {
			
			radioAfter.Checked = false;
			this.appendType = "BEFORE";
		}

        private void radioAfter_CheckedChanged(object sender, EventArgs e)
        {
			
			
		
			this.appendType = "AFTER";
		}

        private void radioAfter_Click(object sender, EventArgs e)
        {
			radioBefore.Checked = false;
			radioAfter.Checked = true;
			this.appendType = "AFTER";
		}

        private void radioBefore_Click(object sender, EventArgs e)
        {
			radioBefore.Checked = true;
			radioAfter.Checked = false;
			this.appendType = "BEFORE";
		}

        private void textBoxAppends_TextChanged(object sender, EventArgs e)
        {
			if(numericPasswordLength.Enabled)
			numericPasswordLength.Value = ( tempValue - textBoxAppends.TextLength);
			
        }

        private void comboBoxPasswordSequence_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxPasswordSequence.SelectedIndex > 0)
            {
				textBoxPasswordSequence.Text = comboBoxPasswordSequence.Text;
				
            }
			new FormActions().ToggleButtons(buttonGenerate, comboBoxPasswordSequence);
		}
    }
}
