namespace Application
{
    partial class AddAClientPanel
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
            this.inputFIOOfClientTextBox = new System.Windows.Forms.TextBox();
            this.inputFIOLab = new System.Windows.Forms.Label();
            this.inputNumLab = new System.Windows.Forms.Label();
            this.InputPassName = new System.Windows.Forms.Label();
            this.inputNumOfClientTextBox = new System.Windows.Forms.TextBox();
            this.inputPassOfClientTextBox = new System.Windows.Forms.TextBox();
            this.addClinetButton = new System.Windows.Forms.Button();
            this.inputBillOfClientTextBox = new System.Windows.Forms.TextBox();
            this.InputBillLab = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // inputFIOOfClientTextBox
            // 
            this.inputFIOOfClientTextBox.Location = new System.Drawing.Point(122, 91);
            this.inputFIOOfClientTextBox.Name = "inputFIOOfClientTextBox";
            this.inputFIOOfClientTextBox.Size = new System.Drawing.Size(306, 22);
            this.inputFIOOfClientTextBox.TabIndex = 0;
            // 
            // inputFIOLab
            // 
            this.inputFIOLab.AutoSize = true;
            this.inputFIOLab.Location = new System.Drawing.Point(198, 71);
            this.inputFIOLab.Name = "inputFIOLab";
            this.inputFIOLab.Size = new System.Drawing.Size(150, 17);
            this.inputFIOLab.TabIndex = 1;
            this.inputFIOLab.Text = "Ввести ФИО клиента";
            this.inputFIOLab.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.inputFIOLab.Click += new System.EventHandler(this.label1_Click);
            // 
            // inputNumLab
            // 
            this.inputNumLab.AutoSize = true;
            this.inputNumLab.Location = new System.Drawing.Point(168, 130);
            this.inputNumLab.Name = "inputNumLab";
            this.inputNumLab.Size = new System.Drawing.Size(199, 17);
            this.inputNumLab.TabIndex = 2;
            this.inputNumLab.Text = "Ввести номер счёта клиента";
            // 
            // InputPassName
            // 
            this.InputPassName.AutoSize = true;
            this.InputPassName.Location = new System.Drawing.Point(185, 188);
            this.InputPassName.Name = "InputPassName";
            this.InputPassName.Size = new System.Drawing.Size(163, 17);
            this.InputPassName.TabIndex = 4;
            this.InputPassName.Text = "Ввести пароль клиента";
            this.InputPassName.Click += new System.EventHandler(this.label2_Click);
            // 
            // inputNumOfClientTextBox
            // 
            this.inputNumOfClientTextBox.Location = new System.Drawing.Point(122, 150);
            this.inputNumOfClientTextBox.Name = "inputNumOfClientTextBox";
            this.inputNumOfClientTextBox.Size = new System.Drawing.Size(306, 22);
            this.inputNumOfClientTextBox.TabIndex = 5;
            // 
            // inputPassOfClientTextBox
            // 
            this.inputPassOfClientTextBox.Location = new System.Drawing.Point(122, 208);
            this.inputPassOfClientTextBox.Name = "inputPassOfClientTextBox";
            this.inputPassOfClientTextBox.Size = new System.Drawing.Size(306, 22);
            this.inputPassOfClientTextBox.TabIndex = 6;
            this.inputPassOfClientTextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // addClinetButton
            // 
            this.addClinetButton.Location = new System.Drawing.Point(201, 312);
            this.addClinetButton.Name = "addClinetButton";
            this.addClinetButton.Size = new System.Drawing.Size(155, 66);
            this.addClinetButton.TabIndex = 7;
            this.addClinetButton.Text = "Добавить нового клиента";
            this.addClinetButton.UseVisualStyleBackColor = true;
            this.addClinetButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // inputBillOfClientTextBox
            // 
            this.inputBillOfClientTextBox.Location = new System.Drawing.Point(122, 259);
            this.inputBillOfClientTextBox.Name = "inputBillOfClientTextBox";
            this.inputBillOfClientTextBox.Size = new System.Drawing.Size(306, 22);
            this.inputBillOfClientTextBox.TabIndex = 8;
            // 
            // InputBillLab
            // 
            this.InputBillLab.AutoSize = true;
            this.InputBillLab.Location = new System.Drawing.Point(168, 239);
            this.InputBillLab.Name = "InputBillLab";
            this.InputBillLab.Size = new System.Drawing.Size(230, 17);
            this.InputBillLab.TabIndex = 9;
            this.InputBillLab.Text = "Указать текущий баланс клиента";
            // 
            // AddAClientPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(539, 450);
            this.Controls.Add(this.InputBillLab);
            this.Controls.Add(this.inputBillOfClientTextBox);
            this.Controls.Add(this.addClinetButton);
            this.Controls.Add(this.inputPassOfClientTextBox);
            this.Controls.Add(this.inputNumOfClientTextBox);
            this.Controls.Add(this.InputPassName);
            this.Controls.Add(this.inputNumLab);
            this.Controls.Add(this.inputFIOLab);
            this.Controls.Add(this.inputFIOOfClientTextBox);
            this.ImeMode = System.Windows.Forms.ImeMode.On;
            this.Name = "AddAClientPanel";
            this.Text = "AddAClientPanel";
            this.Load += new System.EventHandler(this.AddAClientPanel_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox inputFIOOfClientTextBox;
        private System.Windows.Forms.Label inputFIOLab;
        private System.Windows.Forms.Label inputNumLab;
        private System.Windows.Forms.Label InputPassName;
        private System.Windows.Forms.TextBox inputNumOfClientTextBox;
        private System.Windows.Forms.TextBox inputPassOfClientTextBox;
        private System.Windows.Forms.Button addClinetButton;
        private System.Windows.Forms.TextBox inputBillOfClientTextBox;
        private System.Windows.Forms.Label InputBillLab;
    }
}