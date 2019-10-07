namespace DatePicker
{
    partial class EventInfo
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
            this.Btn_SetEventName = new System.Windows.Forms.Button();
            this.Txt_EventName = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Btn_SetEventName);
            this.groupBox1.Controls.Add(this.Txt_EventName);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(277, 64);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Event Info";
            // 
            // Btn_SetEventName
            // 
            this.Btn_SetEventName.Location = new System.Drawing.Point(161, 19);
            this.Btn_SetEventName.Name = "Btn_SetEventName";
            this.Btn_SetEventName.Size = new System.Drawing.Size(100, 23);
            this.Btn_SetEventName.TabIndex = 1;
            this.Btn_SetEventName.Text = "Set Name";
            this.Btn_SetEventName.UseVisualStyleBackColor = true;
            this.Btn_SetEventName.Click += new System.EventHandler(this.Btn_SetEventName_Click);
            // 
            // Txt_EventName
            // 
            this.Txt_EventName.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.Txt_EventName.Location = new System.Drawing.Point(7, 20);
            this.Txt_EventName.Name = "Txt_EventName";
            this.Txt_EventName.Size = new System.Drawing.Size(148, 20);
            this.Txt_EventName.TabIndex = 0;
            this.Txt_EventName.Text = "Event Name";
            this.Txt_EventName.Click += new System.EventHandler(this.Txt_EventName_Click);
            // 
            // EventInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(345, 122);
            this.Controls.Add(this.groupBox1);
            this.Name = "EventInfo";
            this.Text = "EventInfo";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button Btn_SetEventName;
        private System.Windows.Forms.TextBox Txt_EventName;
    }
}