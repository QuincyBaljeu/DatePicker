namespace DatePicker
{
    partial class Login
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
            this.Txt_EventName = new System.Windows.Forms.TextBox();
            this.Btn_CreateEvent = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Txt_EventName
            // 
            this.Txt_EventName.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.Txt_EventName.Location = new System.Drawing.Point(12, 12);
            this.Txt_EventName.Name = "Txt_EventName";
            this.Txt_EventName.Size = new System.Drawing.Size(164, 20);
            this.Txt_EventName.TabIndex = 0;
            this.Txt_EventName.Text = "Event Name";
            // 
            // Btn_CreateEvent
            // 
            this.Btn_CreateEvent.Location = new System.Drawing.Point(182, 12);
            this.Btn_CreateEvent.Name = "Btn_CreateEvent";
            this.Btn_CreateEvent.Size = new System.Drawing.Size(116, 21);
            this.Btn_CreateEvent.TabIndex = 1;
            this.Btn_CreateEvent.Text = "Create Event";
            this.Btn_CreateEvent.UseVisualStyleBackColor = true;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(332, 128);
            this.Controls.Add(this.Btn_CreateEvent);
            this.Controls.Add(this.Txt_EventName);
            this.Name = "Login";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Txt_EventName;
        private System.Windows.Forms.Button Btn_CreateEvent;
    }
}