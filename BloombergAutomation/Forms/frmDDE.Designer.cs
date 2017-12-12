namespace BloombergAutomation.Forms
{
    partial class frmDDE
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cboWindowNum = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCommand = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnExecute = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMessage = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnChangeLanguageToChinese = new System.Windows.Forms.Button();
            this.btnReLogin = new System.Windows.Forms.Button();
            this.btnCopyScreen = new System.Windows.Forms.Button();
            this.btnChangeLanguageToEnglish = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cboWindowNum
            // 
            this.cboWindowNum.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboWindowNum.FormattingEnabled = true;
            this.cboWindowNum.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.cboWindowNum.Location = new System.Drawing.Point(102, 12);
            this.cboWindowNum.Name = "cboWindowNum";
            this.cboWindowNum.Size = new System.Drawing.Size(75, 20);
            this.cboWindowNum.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "Window Num:";
            // 
            // txtCommand
            // 
            this.txtCommand.Location = new System.Drawing.Point(102, 53);
            this.txtCommand.Name = "txtCommand";
            this.txtCommand.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtCommand.Size = new System.Drawing.Size(370, 22);
            this.txtCommand.TabIndex = 43;
            this.txtCommand.Text = "US594918BT09 <Corp>DES<GO>";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 56);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 12);
            this.label7.TabIndex = 42;
            this.label7.Text = "DDE Command:";
            // 
            // btnExecute
            // 
            this.btnExecute.Location = new System.Drawing.Point(494, 53);
            this.btnExecute.Name = "btnExecute";
            this.btnExecute.Size = new System.Drawing.Size(75, 23);
            this.btnExecute.TabIndex = 41;
            this.btnExecute.Text = "Execute";
            this.btnExecute.UseVisualStyleBackColor = true;
            this.btnExecute.Click += new System.EventHandler(this.btnExecute_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 12);
            this.label3.TabIndex = 45;
            this.label3.Text = "Result:";
            // 
            // txtMessage
            // 
            this.txtMessage.Location = new System.Drawing.Point(102, 114);
            this.txtMessage.Multiline = true;
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtMessage.Size = new System.Drawing.Size(542, 126);
            this.txtMessage.TabIndex = 44;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnChangeLanguageToChinese);
            this.groupBox1.Controls.Add(this.btnReLogin);
            this.groupBox1.Controls.Add(this.btnCopyScreen);
            this.groupBox1.Controls.Add(this.btnChangeLanguageToEnglish);
            this.groupBox1.Location = new System.Drawing.Point(15, 249);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(698, 87);
            this.groupBox1.TabIndex = 46;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Bloomberg Function Test";
            // 
            // btnChangeLanguageToChinese
            // 
            this.btnChangeLanguageToChinese.Location = new System.Drawing.Point(343, 21);
            this.btnChangeLanguageToChinese.Name = "btnChangeLanguageToChinese";
            this.btnChangeLanguageToChinese.Size = new System.Drawing.Size(114, 43);
            this.btnChangeLanguageToChinese.TabIndex = 20;
            this.btnChangeLanguageToChinese.Text = "Change Language to Chinese";
            this.btnChangeLanguageToChinese.UseVisualStyleBackColor = true;
            this.btnChangeLanguageToChinese.Click += new System.EventHandler(this.btnChangeLanguageToChinese_Click);
            // 
            // btnReLogin
            // 
            this.btnReLogin.Location = new System.Drawing.Point(111, 21);
            this.btnReLogin.Name = "btnReLogin";
            this.btnReLogin.Size = new System.Drawing.Size(85, 43);
            this.btnReLogin.TabIndex = 15;
            this.btnReLogin.Text = "ReLogin";
            this.btnReLogin.UseVisualStyleBackColor = true;
            this.btnReLogin.Click += new System.EventHandler(this.btnReLogin_Click);
            // 
            // btnCopyScreen
            // 
            this.btnCopyScreen.Location = new System.Drawing.Point(6, 21);
            this.btnCopyScreen.Name = "btnCopyScreen";
            this.btnCopyScreen.Size = new System.Drawing.Size(85, 43);
            this.btnCopyScreen.TabIndex = 17;
            this.btnCopyScreen.Text = "Copy Screen";
            this.btnCopyScreen.UseVisualStyleBackColor = true;
            this.btnCopyScreen.Click += new System.EventHandler(this.btnCopyScreen_Click);
            // 
            // btnChangeLanguageToEnglish
            // 
            this.btnChangeLanguageToEnglish.Location = new System.Drawing.Point(215, 21);
            this.btnChangeLanguageToEnglish.Name = "btnChangeLanguageToEnglish";
            this.btnChangeLanguageToEnglish.Size = new System.Drawing.Size(106, 43);
            this.btnChangeLanguageToEnglish.TabIndex = 16;
            this.btnChangeLanguageToEnglish.Text = "Change Language to English";
            this.btnChangeLanguageToEnglish.UseVisualStyleBackColor = true;
            this.btnChangeLanguageToEnglish.Click += new System.EventHandler(this.btnChangeLanguageToEnglish_Click);
            // 
            // frmDDE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(862, 405);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtMessage);
            this.Controls.Add(this.txtCommand);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnExecute);
            this.Controls.Add(this.cboWindowNum);
            this.Controls.Add(this.label1);
            this.Name = "frmDDE";
            this.Text = "frmDDE";
            this.Load += new System.EventHandler(this.frmDDE_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboWindowNum;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCommand;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnExecute;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMessage;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnReLogin;
        private System.Windows.Forms.Button btnCopyScreen;
        private System.Windows.Forms.Button btnChangeLanguageToEnglish;
        private System.Windows.Forms.Button btnChangeLanguageToChinese;
    }
}