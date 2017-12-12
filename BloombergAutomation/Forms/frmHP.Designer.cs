namespace BloombergAutomation.Forms
{
    partial class frmHP
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tabResult = new System.Windows.Forms.TabControl();
            this.tabPagePicture = new System.Windows.Forms.TabPage();
            this.picResult = new System.Windows.Forms.PictureBox();
            this.tabPageText = new System.Windows.Forms.TabPage();
            this.txtResult = new System.Windows.Forms.RichTextBox();
            this.btnExecute = new System.Windows.Forms.Button();
            this.txtISIN = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cboWindowNum = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cboPricingSource = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dtEndDate = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dtStartDate = new System.Windows.Forms.DateTimePicker();
            this.groupBox1.SuspendLayout();
            this.tabResult.SuspendLayout();
            this.tabPagePicture.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picResult)).BeginInit();
            this.tabPageText.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tabResult);
            this.groupBox1.Location = new System.Drawing.Point(12, 118);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(826, 425);
            this.groupBox1.TabIndex = 53;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Result";
            // 
            // tabResult
            // 
            this.tabResult.Controls.Add(this.tabPagePicture);
            this.tabResult.Controls.Add(this.tabPageText);
            this.tabResult.Location = new System.Drawing.Point(18, 25);
            this.tabResult.Name = "tabResult";
            this.tabResult.SelectedIndex = 0;
            this.tabResult.Size = new System.Drawing.Size(802, 394);
            this.tabResult.TabIndex = 0;
            // 
            // tabPagePicture
            // 
            this.tabPagePicture.Controls.Add(this.picResult);
            this.tabPagePicture.Location = new System.Drawing.Point(4, 22);
            this.tabPagePicture.Name = "tabPagePicture";
            this.tabPagePicture.Padding = new System.Windows.Forms.Padding(3);
            this.tabPagePicture.Size = new System.Drawing.Size(794, 368);
            this.tabPagePicture.TabIndex = 0;
            this.tabPagePicture.Text = "Picture";
            this.tabPagePicture.UseVisualStyleBackColor = true;
            // 
            // picResult
            // 
            this.picResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picResult.Location = new System.Drawing.Point(3, 3);
            this.picResult.Name = "picResult";
            this.picResult.Size = new System.Drawing.Size(788, 362);
            this.picResult.TabIndex = 0;
            this.picResult.TabStop = false;
            // 
            // tabPageText
            // 
            this.tabPageText.Controls.Add(this.txtResult);
            this.tabPageText.Location = new System.Drawing.Point(4, 22);
            this.tabPageText.Name = "tabPageText";
            this.tabPageText.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageText.Size = new System.Drawing.Size(794, 368);
            this.tabPageText.TabIndex = 1;
            this.tabPageText.Text = "Text";
            this.tabPageText.UseVisualStyleBackColor = true;
            // 
            // txtResult
            // 
            this.txtResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtResult.Location = new System.Drawing.Point(3, 3);
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(788, 362);
            this.txtResult.TabIndex = 0;
            this.txtResult.Text = "";
            // 
            // btnExecute
            // 
            this.btnExecute.Location = new System.Drawing.Point(604, 87);
            this.btnExecute.Name = "btnExecute";
            this.btnExecute.Size = new System.Drawing.Size(75, 23);
            this.btnExecute.TabIndex = 52;
            this.btnExecute.Text = "Execute";
            this.btnExecute.UseVisualStyleBackColor = true;
            this.btnExecute.Click += new System.EventHandler(this.btnExecute_Click);
            // 
            // txtISIN
            // 
            this.txtISIN.Location = new System.Drawing.Point(104, 49);
            this.txtISIN.Name = "txtISIN";
            this.txtISIN.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtISIN.Size = new System.Drawing.Size(193, 22);
            this.txtISIN.TabIndex = 51;
            this.txtISIN.Text = "US594918BT09";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 52);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(30, 12);
            this.label7.TabIndex = 50;
            this.label7.Text = "ISIN:";
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
            this.cboWindowNum.Location = new System.Drawing.Point(104, 12);
            this.cboWindowNum.Name = "cboWindowNum";
            this.cboWindowNum.Size = new System.Drawing.Size(75, 20);
            this.cboWindowNum.TabIndex = 49;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 12);
            this.label1.TabIndex = 48;
            this.label1.Text = "Window Num:";
            // 
            // cboPricingSource
            // 
            this.cboPricingSource.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPricingSource.FormattingEnabled = true;
            this.cboPricingSource.Location = new System.Drawing.Point(104, 85);
            this.cboPricingSource.Name = "cboPricingSource";
            this.cboPricingSource.Size = new System.Drawing.Size(75, 20);
            this.cboPricingSource.TabIndex = 55;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 12);
            this.label2.TabIndex = 54;
            this.label2.Text = "Source:";
            // 
            // dtEndDate
            // 
            this.dtEndDate.CustomFormat = "yyyy/MM/dd";
            this.dtEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtEndDate.Location = new System.Drawing.Point(461, 85);
            this.dtEndDate.Name = "dtEndDate";
            this.dtEndDate.Size = new System.Drawing.Size(115, 22);
            this.dtEndDate.TabIndex = 59;
            this.dtEndDate.Value = new System.DateTime(2015, 6, 2, 15, 26, 12, 996);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(425, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(11, 12);
            this.label4.TabIndex = 58;
            this.label4.Text = "~";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(251, 85);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 12);
            this.label5.TabIndex = 57;
            this.label5.Text = "Range:";
            // 
            // dtStartDate
            // 
            this.dtStartDate.CustomFormat = "yyyy/MM/dd";
            this.dtStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtStartDate.Location = new System.Drawing.Point(295, 85);
            this.dtStartDate.Name = "dtStartDate";
            this.dtStartDate.Size = new System.Drawing.Size(115, 22);
            this.dtStartDate.TabIndex = 56;
            this.dtStartDate.Value = new System.DateTime(2015, 6, 2, 15, 26, 12, 996);
            // 
            // frmHP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(855, 555);
            this.Controls.Add(this.dtEndDate);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dtStartDate);
            this.Controls.Add(this.cboPricingSource);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnExecute);
            this.Controls.Add(this.txtISIN);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cboWindowNum);
            this.Controls.Add(this.label1);
            this.Name = "frmHP";
            this.Text = "frmHP";
            this.Load += new System.EventHandler(this.frmHP_Load);
            this.groupBox1.ResumeLayout(false);
            this.tabResult.ResumeLayout(false);
            this.tabPagePicture.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picResult)).EndInit();
            this.tabPageText.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TabControl tabResult;
        private System.Windows.Forms.TabPage tabPagePicture;
        private System.Windows.Forms.PictureBox picResult;
        private System.Windows.Forms.TabPage tabPageText;
        private System.Windows.Forms.RichTextBox txtResult;
        private System.Windows.Forms.Button btnExecute;
        private System.Windows.Forms.TextBox txtISIN;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cboWindowNum;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboPricingSource;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtEndDate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtStartDate;
    }
}