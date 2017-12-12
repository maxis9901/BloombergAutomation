namespace BloombergAutomation.Forms
{
    partial class frmEmail
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
            this.btnExecute = new System.Windows.Forms.Button();
            this.txtRecipient = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cboWindowNum = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSubject = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnExecute
            // 
            this.btnExecute.Location = new System.Drawing.Point(23, 137);
            this.btnExecute.Name = "btnExecute";
            this.btnExecute.Size = new System.Drawing.Size(75, 23);
            this.btnExecute.TabIndex = 51;
            this.btnExecute.Text = "Execute";
            this.btnExecute.UseVisualStyleBackColor = true;
            this.btnExecute.Click += new System.EventHandler(this.btnExecute_Click);
            // 
            // txtRecipient
            // 
            this.txtRecipient.Location = new System.Drawing.Point(110, 51);
            this.txtRecipient.Name = "txtRecipient";
            this.txtRecipient.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtRecipient.Size = new System.Drawing.Size(260, 22);
            this.txtRecipient.TabIndex = 50;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(21, 54);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 12);
            this.label7.TabIndex = 49;
            this.label7.Text = "Recipient:";
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
            this.cboWindowNum.Location = new System.Drawing.Point(110, 14);
            this.cboWindowNum.Name = "cboWindowNum";
            this.cboWindowNum.Size = new System.Drawing.Size(75, 20);
            this.cboWindowNum.TabIndex = 48;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 12);
            this.label1.TabIndex = 47;
            this.label1.Text = "Window Num:";
            // 
            // txtSubject
            // 
            this.txtSubject.Location = new System.Drawing.Point(110, 79);
            this.txtSubject.Name = "txtSubject";
            this.txtSubject.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtSubject.Size = new System.Drawing.Size(260, 22);
            this.txtSubject.TabIndex = 53;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 12);
            this.label2.TabIndex = 52;
            this.label2.Text = "Subject:";
            // 
            // frmEmail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(472, 215);
            this.Controls.Add(this.txtSubject);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnExecute);
            this.Controls.Add(this.txtRecipient);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cboWindowNum);
            this.Controls.Add(this.label1);
            this.Name = "frmEmail";
            this.Text = "frmEmail";
            this.Load += new System.EventHandler(this.frmEmail_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExecute;
        private System.Windows.Forms.TextBox txtRecipient;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cboWindowNum;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSubject;
        private System.Windows.Forms.Label label2;
    }
}