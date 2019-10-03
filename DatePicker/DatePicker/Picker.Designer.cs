namespace DatePicker
{
    partial class Picker
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
            this.Btn_AddDate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // DateTimePickerField
            // 
            this.DateTimePickerField.Location = new System.Drawing.Point(11, 34);
            this.DateTimePickerField.Name = "DateTimePickerField";
            this.DateTimePickerField.Size = new System.Drawing.Size(200, 20);
            this.DateTimePickerField.TabIndex = 0;
            this.DateTimePickerField.ValueChanged += new System.EventHandler(this.DateTimePicker1_ValueChanged);
            // 
            // NameTextBox
            // 
            this.NameTextBox.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.NameTextBox.Location = new System.Drawing.Point(11, 11);
            this.NameTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(200, 20);
            this.NameTextBox.TabIndex = 1;
            this.NameTextBox.Text = "Name";
            this.NameTextBox.Click += new System.EventHandler(this.NameTextBox_Click);
            // 
            // Btn_AddDate
            // 
            this.Btn_AddDate.Location = new System.Drawing.Point(11, 59);
            this.Btn_AddDate.Margin = new System.Windows.Forms.Padding(2);
            this.Btn_AddDate.Name = "Btn_AddDate";
            this.Btn_AddDate.Size = new System.Drawing.Size(88, 20);
            this.Btn_AddDate.TabIndex = 2;
            this.Btn_AddDate.Text = "Add Date";
            this.Btn_AddDate.UseVisualStyleBackColor = true;
            this.Btn_AddDate.Click += new System.EventHandler(this.Btn_AddDate_Click);
            // 
            // Picker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(234, 197);
            this.Controls.Add(this.Btn_AddDate);
            this.Controls.Add(this.NameTextBox);
            this.Controls.Add(this.DateTimePickerField);
            this.Name = "Picker";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker DateTimePickerField;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.Button Btn_AddDate;
    }
}

