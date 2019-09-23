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
            this.SuspendLayout();
            // 
            // DateTimePickerField
            // 
            this.DateTimePickerField.Location = new System.Drawing.Point(12, 12);
            this.DateTimePickerField.Name = "DateTimePickerField";
            this.DateTimePickerField.Size = new System.Drawing.Size(200, 20);
            this.DateTimePickerField.TabIndex = 0;
            this.DateTimePickerField.ValueChanged += new System.EventHandler(this.DateTimePicker1_ValueChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(258, 49);
            this.Controls.Add(this.DateTimePickerField);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DateTimePicker DateTimePickerField;
    }
}

