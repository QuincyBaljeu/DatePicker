namespace DatePicker
{
    partial class Form1
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
            this.DateTimePickerField = new System.Windows.Forms.DateTimePicker();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.AddDateButton = new System.Windows.Forms.Button();
            this.ConnectButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // DateTimePickerField
            // 
            this.DateTimePickerField.Location = new System.Drawing.Point(11, 65);
            this.DateTimePickerField.Name = "DateTimePickerField";
            this.DateTimePickerField.Size = new System.Drawing.Size(200, 20);
            this.DateTimePickerField.TabIndex = 0;
            this.DateTimePickerField.ValueChanged += new System.EventHandler(this.DateTimePicker1_ValueChanged);
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(11, 42);
            this.NameTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(200, 20);
            this.NameTextBox.TabIndex = 1;
            this.NameTextBox.Text = "   name";
            this.NameTextBox.Click += new System.EventHandler(this.NameTextBox_Click);
            // 
            // AddDateButton
            // 
            this.AddDateButton.Location = new System.Drawing.Point(11, 90);
            this.AddDateButton.Margin = new System.Windows.Forms.Padding(2);
            this.AddDateButton.Name = "AddDateButton";
            this.AddDateButton.Size = new System.Drawing.Size(88, 20);
            this.AddDateButton.TabIndex = 2;
            this.AddDateButton.Text = "add date";
            this.AddDateButton.UseVisualStyleBackColor = true;
            this.AddDateButton.Click += new System.EventHandler(this.AddDateButton_Click);
            // 
            // ConnectButton
            // 
            this.ConnectButton.Location = new System.Drawing.Point(11, 14);
            this.ConnectButton.Name = "ConnectButton";
            this.ConnectButton.Size = new System.Drawing.Size(75, 23);
            this.ConnectButton.TabIndex = 3;
            this.ConnectButton.Text = "Connect";
            this.ConnectButton.UseVisualStyleBackColor = true;
            this.ConnectButton.Click += new System.EventHandler(this.ConnectButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(234, 197);
            this.Controls.Add(this.ConnectButton);
            this.Controls.Add(this.AddDateButton);
            this.Controls.Add(this.NameTextBox);
            this.Controls.Add(this.DateTimePickerField);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker DateTimePickerField;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.Button AddDateButton;
        private System.Windows.Forms.Button ConnectButton;
    }
}

