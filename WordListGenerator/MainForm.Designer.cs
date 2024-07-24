
namespace WordListGenerator
{
    partial class MainForm
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dosyaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yardımToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.donateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hakkımızdaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelActionTypes = new System.Windows.Forms.Panel();
            this.panelSettings = new System.Windows.Forms.Panel();
            this.groupBoxAppends = new System.Windows.Forms.GroupBox();
            this.buttonAppends = new System.Windows.Forms.Button();
            this.panelAppends = new System.Windows.Forms.Panel();
            this.radioAfter = new System.Windows.Forms.RadioButton();
            this.radioBefore = new System.Windows.Forms.RadioButton();
            this.textBoxAppends = new System.Windows.Forms.TextBox();
            this.checkBoxAppends = new System.Windows.Forms.CheckBox();
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.buttonHelpSequence = new System.Windows.Forms.Button();
            this.panelPasswordSequence = new System.Windows.Forms.Panel();
            this.checkBoxEditPassword = new System.Windows.Forms.CheckBox();
            this.buttonSaveTemplate = new System.Windows.Forms.Button();
            this.buttonNew = new System.Windows.Forms.Button();
            this.comboBoxPasswordSequence = new System.Windows.Forms.ComboBox();
            this.labelTemplate = new System.Windows.Forms.Label();
            this.textBoxPasswordSequence = new System.Windows.Forms.TextBox();
            this.checkBoxPasswordSequence = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkBoxCustomCharset = new System.Windows.Forms.CheckBox();
            this.textBoxCustom = new System.Windows.Forms.TextBox();
            this.checkBoxSymbols = new System.Windows.Forms.CheckBox();
            this.checkBoxNumbers = new System.Windows.Forms.CheckBox();
            this.checkBoxUpperCase = new System.Windows.Forms.CheckBox();
            this.checkBoxLoweCase = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.numericPasswordLength = new System.Windows.Forms.NumericUpDown();
            this.labelLength = new System.Windows.Forms.Label();
            this.labelPass = new System.Windows.Forms.Label();
            this.numericUpDownPasswordTotal = new System.Windows.Forms.NumericUpDown();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.buttonFile = new System.Windows.Forms.Button();
            this.textBoxFilePath = new System.Windows.Forms.TextBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabelGenerated = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripShowPassword = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripPasswordTotal = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolTipTotalValue = new System.Windows.Forms.ToolStripStatusLabel();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.progressBarGenerate = new System.Windows.Forms.ProgressBar();
            this.buttonGenerate = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panelActionTypes.SuspendLayout();
            this.panelSettings.SuspendLayout();
            this.groupBoxAppends.SuspendLayout();
            this.panelAppends.SuspendLayout();
            this.groupBox.SuspendLayout();
            this.panelPasswordSequence.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericPasswordLength)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPasswordTotal)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dosyaToolStripMenuItem,
            this.yardımToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(7, 7);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(879, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dosyaToolStripMenuItem
            // 
            this.dosyaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.dosyaToolStripMenuItem.Name = "dosyaToolStripMenuItem";
            this.dosyaToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.dosyaToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(93, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // yardımToolStripMenuItem
            // 
            this.yardımToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.donateToolStripMenuItem,
            this.hakkımızdaToolStripMenuItem});
            this.yardımToolStripMenuItem.Name = "yardımToolStripMenuItem";
            this.yardımToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.yardımToolStripMenuItem.Text = "Help";
            // 
            // donateToolStripMenuItem
            // 
            this.donateToolStripMenuItem.Name = "donateToolStripMenuItem";
            this.donateToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.donateToolStripMenuItem.Text = "Donate";
            this.donateToolStripMenuItem.Click += new System.EventHandler(this.donateToolStripMenuItem_Click);
            // 
            // hakkımızdaToolStripMenuItem
            // 
            this.hakkımızdaToolStripMenuItem.Name = "hakkımızdaToolStripMenuItem";
            this.hakkımızdaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.hakkımızdaToolStripMenuItem.Text = "About";
            this.hakkımızdaToolStripMenuItem.Click += new System.EventHandler(this.hakkımızdaToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panelActionTypes);
            this.panel1.Controls.Add(this.statusStrip1);
            this.panel1.Controls.Add(this.groupBox4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(7, 31);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(6);
            this.panel1.Size = new System.Drawing.Size(879, 369);
            this.panel1.TabIndex = 1;
            // 
            // panelActionTypes
            // 
            this.panelActionTypes.BackColor = System.Drawing.Color.Transparent;
            this.panelActionTypes.Controls.Add(this.panelSettings);
            this.panelActionTypes.Controls.Add(this.groupBox3);
            this.panelActionTypes.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelActionTypes.Location = new System.Drawing.Point(6, 6);
            this.panelActionTypes.Name = "panelActionTypes";
            this.panelActionTypes.Size = new System.Drawing.Size(867, 264);
            this.panelActionTypes.TabIndex = 19;
            // 
            // panelSettings
            // 
            this.panelSettings.BackColor = System.Drawing.Color.Gainsboro;
            this.panelSettings.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelSettings.Controls.Add(this.groupBoxAppends);
            this.panelSettings.Controls.Add(this.groupBox);
            this.panelSettings.Controls.Add(this.groupBox1);
            this.panelSettings.Controls.Add(this.groupBox2);
            this.panelSettings.Enabled = false;
            this.panelSettings.Location = new System.Drawing.Point(3, 64);
            this.panelSettings.Name = "panelSettings";
            this.panelSettings.Padding = new System.Windows.Forms.Padding(6);
            this.panelSettings.Size = new System.Drawing.Size(858, 196);
            this.panelSettings.TabIndex = 20;
            // 
            // groupBoxAppends
            // 
            this.groupBoxAppends.Controls.Add(this.buttonAppends);
            this.groupBoxAppends.Controls.Add(this.panelAppends);
            this.groupBoxAppends.Controls.Add(this.checkBoxAppends);
            this.groupBoxAppends.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.groupBoxAppends.Location = new System.Drawing.Point(564, 79);
            this.groupBoxAppends.Name = "groupBoxAppends";
            this.groupBoxAppends.Size = new System.Drawing.Size(284, 109);
            this.groupBoxAppends.TabIndex = 22;
            this.groupBoxAppends.TabStop = false;
            this.groupBoxAppends.Text = "Password Appends";
            // 
            // buttonAppends
            // 
            this.buttonAppends.Image = global::WordListGenerator.Properties.Resources.help;
            this.buttonAppends.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonAppends.Location = new System.Drawing.Point(256, 11);
            this.buttonAppends.Name = "buttonAppends";
            this.buttonAppends.Size = new System.Drawing.Size(25, 23);
            this.buttonAppends.TabIndex = 18;
            this.buttonAppends.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAppends.UseVisualStyleBackColor = true;
            // 
            // panelAppends
            // 
            this.panelAppends.Controls.Add(this.radioAfter);
            this.panelAppends.Controls.Add(this.radioBefore);
            this.panelAppends.Controls.Add(this.textBoxAppends);
            this.panelAppends.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelAppends.Enabled = false;
            this.panelAppends.Location = new System.Drawing.Point(3, 55);
            this.panelAppends.Name = "panelAppends";
            this.panelAppends.Size = new System.Drawing.Size(278, 51);
            this.panelAppends.TabIndex = 8;
            // 
            // radioAfter
            // 
            this.radioAfter.ForeColor = System.Drawing.Color.Maroon;
            this.radioAfter.Location = new System.Drawing.Point(184, 16);
            this.radioAfter.Name = "radioAfter";
            this.radioAfter.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.radioAfter.Size = new System.Drawing.Size(85, 19);
            this.radioAfter.TabIndex = 21;
            this.radioAfter.TabStop = true;
            this.radioAfter.Text = "After";
            this.radioAfter.UseVisualStyleBackColor = true;
            this.radioAfter.Click += new System.EventHandler(this.radioAfter_Click);
            // 
            // radioBefore
            // 
            this.radioBefore.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.radioBefore.ForeColor = System.Drawing.Color.Maroon;
            this.radioBefore.Location = new System.Drawing.Point(3, 16);
            this.radioBefore.Name = "radioBefore";
            this.radioBefore.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.radioBefore.Size = new System.Drawing.Size(100, 19);
            this.radioBefore.TabIndex = 20;
            this.radioBefore.TabStop = true;
            this.radioBefore.Text = "Before";
            this.radioBefore.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.radioBefore.UseVisualStyleBackColor = true;
            this.radioBefore.Click += new System.EventHandler(this.radioBefore_Click);
            // 
            // textBoxAppends
            // 
            this.textBoxAppends.Location = new System.Drawing.Point(109, 14);
            this.textBoxAppends.Name = "textBoxAppends";
            this.textBoxAppends.Size = new System.Drawing.Size(69, 23);
            this.textBoxAppends.TabIndex = 19;
            this.textBoxAppends.TextChanged += new System.EventHandler(this.textBoxAppends_TextChanged);
            // 
            // checkBoxAppends
            // 
            this.checkBoxAppends.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBoxAppends.ForeColor = System.Drawing.Color.Maroon;
            this.checkBoxAppends.Location = new System.Drawing.Point(30, 17);
            this.checkBoxAppends.Name = "checkBoxAppends";
            this.checkBoxAppends.Size = new System.Drawing.Size(220, 19);
            this.checkBoxAppends.TabIndex = 7;
            this.checkBoxAppends.Text = "Activate  Appends";
            this.checkBoxAppends.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBoxAppends.UseVisualStyleBackColor = true;
            this.checkBoxAppends.CheckedChanged += new System.EventHandler(this.checkBoxAppends_CheckedChanged);
            // 
            // groupBox
            // 
            this.groupBox.Controls.Add(this.buttonHelpSequence);
            this.groupBox.Controls.Add(this.panelPasswordSequence);
            this.groupBox.Controls.Add(this.checkBoxPasswordSequence);
            this.groupBox.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.groupBox.Location = new System.Drawing.Point(210, 82);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(345, 109);
            this.groupBox.TabIndex = 23;
            this.groupBox.TabStop = false;
            this.groupBox.Text = "Password Template";
            // 
            // buttonHelpSequence
            // 
            this.buttonHelpSequence.Image = global::WordListGenerator.Properties.Resources.help;
            this.buttonHelpSequence.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonHelpSequence.Location = new System.Drawing.Point(313, 13);
            this.buttonHelpSequence.Name = "buttonHelpSequence";
            this.buttonHelpSequence.Size = new System.Drawing.Size(25, 23);
            this.buttonHelpSequence.TabIndex = 17;
            this.buttonHelpSequence.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonHelpSequence.UseVisualStyleBackColor = true;
            this.buttonHelpSequence.Click += new System.EventHandler(this.buttonHelpSequence_Click);
            // 
            // panelPasswordSequence
            // 
            this.panelPasswordSequence.Controls.Add(this.checkBoxEditPassword);
            this.panelPasswordSequence.Controls.Add(this.buttonSaveTemplate);
            this.panelPasswordSequence.Controls.Add(this.buttonNew);
            this.panelPasswordSequence.Controls.Add(this.comboBoxPasswordSequence);
            this.panelPasswordSequence.Controls.Add(this.labelTemplate);
            this.panelPasswordSequence.Controls.Add(this.textBoxPasswordSequence);
            this.panelPasswordSequence.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelPasswordSequence.Enabled = false;
            this.panelPasswordSequence.Location = new System.Drawing.Point(3, 44);
            this.panelPasswordSequence.Name = "panelPasswordSequence";
            this.panelPasswordSequence.Size = new System.Drawing.Size(339, 62);
            this.panelPasswordSequence.TabIndex = 16;
            // 
            // checkBoxEditPassword
            // 
            this.checkBoxEditPassword.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBoxEditPassword.ForeColor = System.Drawing.Color.Maroon;
            this.checkBoxEditPassword.Location = new System.Drawing.Point(3, 34);
            this.checkBoxEditPassword.Name = "checkBoxEditPassword";
            this.checkBoxEditPassword.Size = new System.Drawing.Size(92, 19);
            this.checkBoxEditPassword.TabIndex = 20;
            this.checkBoxEditPassword.Text = "Edit";
            this.checkBoxEditPassword.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBoxEditPassword.UseVisualStyleBackColor = true;
            this.checkBoxEditPassword.Click += new System.EventHandler(this.checkBoxEditPassword_CheckedChanged);
            // 
            // buttonSaveTemplate
            // 
            this.buttonSaveTemplate.Enabled = false;
            this.buttonSaveTemplate.ForeColor = System.Drawing.Color.Maroon;
            this.buttonSaveTemplate.Location = new System.Drawing.Point(261, 32);
            this.buttonSaveTemplate.Name = "buttonSaveTemplate";
            this.buttonSaveTemplate.Size = new System.Drawing.Size(74, 23);
            this.buttonSaveTemplate.TabIndex = 19;
            this.buttonSaveTemplate.Text = "Save";
            this.buttonSaveTemplate.UseVisualStyleBackColor = true;
            this.buttonSaveTemplate.Click += new System.EventHandler(this.buttonSaveTemplate_Click);
            // 
            // buttonNew
            // 
            this.buttonNew.ForeColor = System.Drawing.Color.Maroon;
            this.buttonNew.Location = new System.Drawing.Point(261, 2);
            this.buttonNew.Name = "buttonNew";
            this.buttonNew.Size = new System.Drawing.Size(74, 23);
            this.buttonNew.TabIndex = 18;
            this.buttonNew.Text = "New";
            this.buttonNew.UseVisualStyleBackColor = true;
            this.buttonNew.Click += new System.EventHandler(this.buttonNew_Click);
            // 
            // comboBoxPasswordSequence
            // 
            this.comboBoxPasswordSequence.FormattingEnabled = true;
            this.comboBoxPasswordSequence.Location = new System.Drawing.Point(101, 2);
            this.comboBoxPasswordSequence.Name = "comboBoxPasswordSequence";
            this.comboBoxPasswordSequence.Size = new System.Drawing.Size(149, 23);
            this.comboBoxPasswordSequence.TabIndex = 14;
            this.comboBoxPasswordSequence.Text = "Please Select";
            this.comboBoxPasswordSequence.SelectedIndexChanged += new System.EventHandler(this.comboBoxPasswordSequence_SelectedIndexChanged);
            // 
            // labelTemplate
            // 
            this.labelTemplate.ForeColor = System.Drawing.Color.Maroon;
            this.labelTemplate.Location = new System.Drawing.Point(3, 5);
            this.labelTemplate.Name = "labelTemplate";
            this.labelTemplate.Size = new System.Drawing.Size(92, 20);
            this.labelTemplate.TabIndex = 15;
            this.labelTemplate.Text = "Template :";
            this.labelTemplate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBoxPasswordSequence
            // 
            this.textBoxPasswordSequence.Enabled = false;
            this.textBoxPasswordSequence.Location = new System.Drawing.Point(101, 32);
            this.textBoxPasswordSequence.Name = "textBoxPasswordSequence";
            this.textBoxPasswordSequence.Size = new System.Drawing.Size(149, 23);
            this.textBoxPasswordSequence.TabIndex = 12;
            this.textBoxPasswordSequence.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxPasswordSequence.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxPasswordSequence_KeyPress);
            // 
            // checkBoxPasswordSequence
            // 
            this.checkBoxPasswordSequence.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBoxPasswordSequence.ForeColor = System.Drawing.Color.Maroon;
            this.checkBoxPasswordSequence.Location = new System.Drawing.Point(173, 15);
            this.checkBoxPasswordSequence.Name = "checkBoxPasswordSequence";
            this.checkBoxPasswordSequence.Size = new System.Drawing.Size(131, 19);
            this.checkBoxPasswordSequence.TabIndex = 13;
            this.checkBoxPasswordSequence.Text = "Activate Template";
            this.checkBoxPasswordSequence.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBoxPasswordSequence.UseVisualStyleBackColor = true;
            this.checkBoxPasswordSequence.CheckedChanged += new System.EventHandler(this.checkBoxPasswordSequence_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBoxCustomCharset);
            this.groupBox1.Controls.Add(this.textBoxCustom);
            this.groupBox1.Controls.Add(this.checkBoxSymbols);
            this.groupBox1.Controls.Add(this.checkBoxNumbers);
            this.groupBox1.Controls.Add(this.checkBoxUpperCase);
            this.groupBox1.Controls.Add(this.checkBoxLoweCase);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.groupBox1.Location = new System.Drawing.Point(6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 3, 3, 8);
            this.groupBox1.Size = new System.Drawing.Size(842, 73);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Charset Options";
            // 
            // checkBoxCustomCharset
            // 
            this.checkBoxCustomCharset.ForeColor = System.Drawing.Color.Maroon;
            this.checkBoxCustomCharset.Location = new System.Drawing.Point(633, 15);
            this.checkBoxCustomCharset.Name = "checkBoxCustomCharset";
            this.checkBoxCustomCharset.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.checkBoxCustomCharset.Size = new System.Drawing.Size(194, 19);
            this.checkBoxCustomCharset.TabIndex = 5;
            this.checkBoxCustomCharset.Text = "Custom Charset";
            this.checkBoxCustomCharset.UseVisualStyleBackColor = true;
            // 
            // textBoxCustom
            // 
            this.textBoxCustom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.textBoxCustom.Enabled = false;
            this.textBoxCustom.Location = new System.Drawing.Point(3, 42);
            this.textBoxCustom.Margin = new System.Windows.Forms.Padding(6, 3, 6, 3);
            this.textBoxCustom.Name = "textBoxCustom";
            this.textBoxCustom.Size = new System.Drawing.Size(836, 23);
            this.textBoxCustom.TabIndex = 4;
            // 
            // checkBoxSymbols
            // 
            this.checkBoxSymbols.ForeColor = System.Drawing.Color.Maroon;
            this.checkBoxSymbols.Location = new System.Drawing.Point(456, 15);
            this.checkBoxSymbols.Name = "checkBoxSymbols";
            this.checkBoxSymbols.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.checkBoxSymbols.Size = new System.Drawing.Size(157, 19);
            this.checkBoxSymbols.TabIndex = 3;
            this.checkBoxSymbols.Text = "Symbols";
            this.checkBoxSymbols.UseVisualStyleBackColor = true;
            // 
            // checkBoxNumbers
            // 
            this.checkBoxNumbers.Checked = true;
            this.checkBoxNumbers.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxNumbers.ForeColor = System.Drawing.Color.Maroon;
            this.checkBoxNumbers.Location = new System.Drawing.Point(155, 15);
            this.checkBoxNumbers.Name = "checkBoxNumbers";
            this.checkBoxNumbers.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.checkBoxNumbers.Size = new System.Drawing.Size(130, 19);
            this.checkBoxNumbers.TabIndex = 2;
            this.checkBoxNumbers.Text = "0-9";
            this.checkBoxNumbers.UseVisualStyleBackColor = true;
            // 
            // checkBoxUpperCase
            // 
            this.checkBoxUpperCase.Checked = true;
            this.checkBoxUpperCase.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxUpperCase.ForeColor = System.Drawing.Color.Maroon;
            this.checkBoxUpperCase.Location = new System.Drawing.Point(305, 15);
            this.checkBoxUpperCase.Name = "checkBoxUpperCase";
            this.checkBoxUpperCase.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.checkBoxUpperCase.Size = new System.Drawing.Size(131, 19);
            this.checkBoxUpperCase.TabIndex = 1;
            this.checkBoxUpperCase.Text = "A-Z";
            this.checkBoxUpperCase.UseVisualStyleBackColor = true;
            // 
            // checkBoxLoweCase
            // 
            this.checkBoxLoweCase.Checked = true;
            this.checkBoxLoweCase.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxLoweCase.ForeColor = System.Drawing.Color.Maroon;
            this.checkBoxLoweCase.Location = new System.Drawing.Point(7, 15);
            this.checkBoxLoweCase.Name = "checkBoxLoweCase";
            this.checkBoxLoweCase.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.checkBoxLoweCase.Size = new System.Drawing.Size(128, 19);
            this.checkBoxLoweCase.TabIndex = 0;
            this.checkBoxLoweCase.Text = "a-z";
            this.checkBoxLoweCase.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.numericPasswordLength);
            this.groupBox2.Controls.Add(this.labelLength);
            this.groupBox2.Controls.Add(this.labelPass);
            this.groupBox2.Controls.Add(this.numericUpDownPasswordTotal);
            this.groupBox2.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.groupBox2.Location = new System.Drawing.Point(5, 82);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(197, 109);
            this.groupBox2.TabIndex = 20;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Password Options";
            // 
            // numericPasswordLength
            // 
            this.numericPasswordLength.Location = new System.Drawing.Point(138, 16);
            this.numericPasswordLength.Name = "numericPasswordLength";
            this.numericPasswordLength.Size = new System.Drawing.Size(50, 23);
            this.numericPasswordLength.TabIndex = 16;
            this.numericPasswordLength.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericPasswordLength.Value = new decimal(new int[] {
            8,
            0,
            0,
            0});
            // 
            // labelLength
            // 
            this.labelLength.AutoSize = true;
            this.labelLength.Location = new System.Drawing.Point(7, 18);
            this.labelLength.Name = "labelLength";
            this.labelLength.Size = new System.Drawing.Size(50, 15);
            this.labelLength.TabIndex = 14;
            this.labelLength.Text = "Length :";
            // 
            // labelPass
            // 
            this.labelPass.AutoSize = true;
            this.labelPass.Location = new System.Drawing.Point(8, 55);
            this.labelPass.Name = "labelPass";
            this.labelPass.Size = new System.Drawing.Size(92, 15);
            this.labelPass.TabIndex = 11;
            this.labelPass.Text = "Total Password :";
            // 
            // numericUpDownPasswordTotal
            // 
            this.numericUpDownPasswordTotal.Location = new System.Drawing.Point(106, 53);
            this.numericUpDownPasswordTotal.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numericUpDownPasswordTotal.Name = "numericUpDownPasswordTotal";
            this.numericUpDownPasswordTotal.Size = new System.Drawing.Size(82, 23);
            this.numericUpDownPasswordTotal.TabIndex = 10;
            this.numericUpDownPasswordTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numericUpDownPasswordTotal.Value = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.buttonFile);
            this.groupBox3.Controls.Add(this.textBoxFilePath);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox3.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.groupBox3.Location = new System.Drawing.Point(0, 0);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(867, 58);
            this.groupBox3.TabIndex = 21;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Output Settings";
            // 
            // buttonFile
            // 
            this.buttonFile.ForeColor = System.Drawing.Color.Maroon;
            this.buttonFile.Location = new System.Drawing.Point(778, 22);
            this.buttonFile.Name = "buttonFile";
            this.buttonFile.Size = new System.Drawing.Size(75, 23);
            this.buttonFile.TabIndex = 1;
            this.buttonFile.Text = "Save As";
            this.buttonFile.UseVisualStyleBackColor = true;
            this.buttonFile.Click += new System.EventHandler(this.buttonFile_Click);
            // 
            // textBoxFilePath
            // 
            this.textBoxFilePath.BackColor = System.Drawing.Color.Ivory;
            this.textBoxFilePath.Location = new System.Drawing.Point(10, 22);
            this.textBoxFilePath.MaxLength = 1000000;
            this.textBoxFilePath.Name = "textBoxFilePath";
            this.textBoxFilePath.ReadOnly = true;
            this.textBoxFilePath.Size = new System.Drawing.Size(762, 23);
            this.textBoxFilePath.TabIndex = 0;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabelGenerated,
            this.toolStripShowPassword,
            this.toolStripPasswordTotal,
            this.toolTipTotalValue});
            this.statusStrip1.Location = new System.Drawing.Point(6, 341);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.ManagerRenderMode;
            this.statusStrip1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.statusStrip1.Size = new System.Drawing.Size(867, 22);
            this.statusStrip1.TabIndex = 4;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabelGenerated
            // 
            this.toolStripStatusLabelGenerated.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.toolStripStatusLabelGenerated.Name = "toolStripStatusLabelGenerated";
            this.toolStripStatusLabelGenerated.Size = new System.Drawing.Size(120, 17);
            this.toolStripStatusLabelGenerated.Text = "Generated Password :";
            // 
            // toolStripShowPassword
            // 
            this.toolStripShowPassword.AutoSize = false;
            this.toolStripShowPassword.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.toolStripShowPassword.ForeColor = System.Drawing.Color.Maroon;
            this.toolStripShowPassword.Name = "toolStripShowPassword";
            this.toolStripShowPassword.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.toolStripShowPassword.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.toolStripShowPassword.Size = new System.Drawing.Size(550, 17);
            this.toolStripShowPassword.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // toolStripPasswordTotal
            // 
            this.toolStripPasswordTotal.AutoSize = false;
            this.toolStripPasswordTotal.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.toolStripPasswordTotal.ForeColor = System.Drawing.Color.Maroon;
            this.toolStripPasswordTotal.Name = "toolStripPasswordTotal";
            this.toolStripPasswordTotal.Size = new System.Drawing.Size(75, 17);
            this.toolStripPasswordTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // toolTipTotalValue
            // 
            this.toolTipTotalValue.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.toolTipTotalValue.ForeColor = System.Drawing.Color.Maroon;
            this.toolTipTotalValue.Name = "toolTipTotalValue";
            this.toolTipTotalValue.Size = new System.Drawing.Size(64, 17);
            this.toolTipTotalValue.Text = "/ 1000000";
            this.toolTipTotalValue.Visible = false;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.progressBarGenerate);
            this.groupBox4.Controls.Add(this.buttonGenerate);
            this.groupBox4.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.groupBox4.Location = new System.Drawing.Point(6, 276);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(867, 58);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Procces";
            // 
            // progressBarGenerate
            // 
            this.progressBarGenerate.Location = new System.Drawing.Point(11, 22);
            this.progressBarGenerate.Maximum = 999999999;
            this.progressBarGenerate.Name = "progressBarGenerate";
            this.progressBarGenerate.Size = new System.Drawing.Size(711, 23);
            this.progressBarGenerate.TabIndex = 2;
            // 
            // buttonGenerate
            // 
            this.buttonGenerate.Enabled = false;
            this.buttonGenerate.ForeColor = System.Drawing.Color.Maroon;
            this.buttonGenerate.Location = new System.Drawing.Point(728, 22);
            this.buttonGenerate.Name = "buttonGenerate";
            this.buttonGenerate.Size = new System.Drawing.Size(125, 23);
            this.buttonGenerate.TabIndex = 1;
            this.buttonGenerate.Text = "Generate WordList";
            this.buttonGenerate.UseVisualStyleBackColor = true;
            this.buttonGenerate.Click += new System.EventHandler(this.buttonGenerate_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(893, 407);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Padding = new System.Windows.Forms.Padding(7);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WordList Generator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelActionTypes.ResumeLayout(false);
            this.panelSettings.ResumeLayout(false);
            this.groupBoxAppends.ResumeLayout(false);
            this.panelAppends.ResumeLayout(false);
            this.panelAppends.PerformLayout();
            this.groupBox.ResumeLayout(false);
            this.panelPasswordSequence.ResumeLayout(false);
            this.panelPasswordSequence.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericPasswordLength)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPasswordTotal)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dosyaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yardımToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hakkımızdaToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelGenerated;
        private System.Windows.Forms.ToolStripStatusLabel toolStripShowPassword;
        private System.Windows.Forms.ToolStripStatusLabel toolStripPasswordTotal;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button buttonGenerate;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem donateToolStripMenuItem;
        public System.Windows.Forms.ProgressBar progressBarGenerate;
        private System.Windows.Forms.ToolStripStatusLabel toolTipTotalValue;
        private System.Windows.Forms.Panel panelActionTypes;
        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.Button buttonHelpSequence;
        private System.Windows.Forms.Panel panelPasswordSequence;
        private System.Windows.Forms.CheckBox checkBoxEditPassword;
        private System.Windows.Forms.Button buttonSaveTemplate;
        private System.Windows.Forms.Button buttonNew;
        private System.Windows.Forms.ComboBox comboBoxPasswordSequence;
        private System.Windows.Forms.Label labelTemplate;
        private System.Windows.Forms.TextBox textBoxPasswordSequence;
        private System.Windows.Forms.CheckBox checkBoxPasswordSequence;
        private System.Windows.Forms.GroupBox groupBoxAppends;
        private System.Windows.Forms.Button buttonAppends;
        private System.Windows.Forms.Panel panelAppends;
        private System.Windows.Forms.RadioButton radioAfter;
        private System.Windows.Forms.RadioButton radioBefore;
        private System.Windows.Forms.TextBox textBoxAppends;
        private System.Windows.Forms.CheckBox checkBoxAppends;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button buttonFile;
        private System.Windows.Forms.TextBox textBoxFilePath;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.NumericUpDown numericPasswordLength;
        private System.Windows.Forms.Label labelLength;
        private System.Windows.Forms.Label labelPass;
        private System.Windows.Forms.NumericUpDown numericUpDownPasswordTotal;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox checkBoxCustomCharset;
        private System.Windows.Forms.TextBox textBoxCustom;
        private System.Windows.Forms.CheckBox checkBoxSymbols;
        private System.Windows.Forms.CheckBox checkBoxNumbers;
        private System.Windows.Forms.CheckBox checkBoxUpperCase;
        private System.Windows.Forms.CheckBox checkBoxLoweCase;
        private System.Windows.Forms.Panel panelSettings;
    }
}

