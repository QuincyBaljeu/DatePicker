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
            this.Grp_NewEvent = new System.Windows.Forms.GroupBox();
            this.Btn_CreateEvent = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Btn_AddAvailability = new System.Windows.Forms.Button();
            this.Txt_AvailabilityName = new System.Windows.Forms.TextBox();
            this.Grp_NewEvent.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Txt_EventName
            // 
            this.Txt_EventName.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.Txt_EventName.Location = new System.Drawing.Point(8, 23);
            this.Txt_EventName.Margin = new System.Windows.Forms.Padding(4);
            this.Txt_EventName.Name = "Txt_EventName";
            this.Txt_EventName.Size = new System.Drawing.Size(217, 22);
            this.Txt_EventName.TabIndex = 0;
            this.Txt_EventName.Text = "Event Name";
            this.Txt_EventName.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Txt_EventName_MouseClick);
            // 
            // Grp_NewEvent
            // 
            this.Grp_NewEvent.Controls.Add(this.Btn_CreateEvent);
            this.Grp_NewEvent.Controls.Add(this.Txt_EventName);
            this.Grp_NewEvent.Location = new System.Drawing.Point(16, 15);
            this.Grp_NewEvent.Margin = new System.Windows.Forms.Padding(4);
            this.Grp_NewEvent.Name = "Grp_NewEvent";
            this.Grp_NewEvent.Padding = new System.Windows.Forms.Padding(4);
            this.Grp_NewEvent.Size = new System.Drawing.Size(409, 64);
            this.Grp_NewEvent.TabIndex = 2;
            this.Grp_NewEvent.TabStop = false;
            this.Grp_NewEvent.Text = "New Event";
            // 
            // Btn_CreateEvent
            // 
            this.Btn_CreateEvent.Location = new System.Drawing.Point(235, 23);
            this.Btn_CreateEvent.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_CreateEvent.Name = "Btn_CreateEvent";
            this.Btn_CreateEvent.Size = new System.Drawing.Size(167, 25);
            this.Btn_CreateEvent.TabIndex = 2;
            this.Btn_CreateEvent.Text = "Create event";
            this.Btn_CreateEvent.UseVisualStyleBackColor = true;
            this.Btn_CreateEvent.Click += new System.EventHandler(this.Btn_CreateEvent_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Btn_AddAvailability);
            this.groupBox1.Controls.Add(this.Txt_AvailabilityName);
            this.groupBox1.Location = new System.Drawing.Point(16, 84);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(409, 64);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Existing event";
            // 
            // Btn_AddAvailability
            // 
            this.Btn_AddAvailability.Location = new System.Drawing.Point(235, 23);
            this.Btn_AddAvailability.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_AddAvailability.Name = "Btn_AddAvailability";
            this.Btn_AddAvailability.Size = new System.Drawing.Size(167, 25);
            this.Btn_AddAvailability.TabIndex = 1;
            this.Btn_AddAvailability.Text = "Add Availability";
            this.Btn_AddAvailability.UseVisualStyleBackColor = true;
            this.Btn_AddAvailability.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Btn_AddAvailability_MouseClick);
            // 
            // Txt_AvailabilityName
            // 
            this.Txt_AvailabilityName.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.Txt_AvailabilityName.Location = new System.Drawing.Point(8, 23);
            this.Txt_AvailabilityName.Margin = new System.Windows.Forms.Padding(4);
            this.Txt_AvailabilityName.Name = "Txt_AvailabilityName";
            this.Txt_AvailabilityName.Size = new System.Drawing.Size(217, 22);
            this.Txt_AvailabilityName.TabIndex = 0;
            this.Txt_AvailabilityName.Text = "Name";
            this.Txt_AvailabilityName.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Txt_AvailabilityName_MouseClick);

            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 175);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Grp_NewEvent);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Login";
            this.Text = "Login";
            this.Grp_NewEvent.ResumeLayout(false);
            this.Grp_NewEvent.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox Txt_EventName;
        private System.Windows.Forms.GroupBox Grp_NewEvent;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button Btn_CreateEvent;
        private System.Windows.Forms.Button Btn_AddAvailability;
        private System.Windows.Forms.TextBox Txt_AvailabilityName;
    }
}