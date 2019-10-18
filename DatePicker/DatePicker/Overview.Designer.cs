namespace DatePicker
{
    partial class Overview
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
            this.ButtonGetData = new System.Windows.Forms.Button();
            this.EventNameInfo = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // ButtonGetData
            // 
            this.ButtonGetData.Location = new System.Drawing.Point(144, 12);
            this.ButtonGetData.Name = "ButtonGetData";
            this.ButtonGetData.Size = new System.Drawing.Size(100, 20);
            this.ButtonGetData.TabIndex = 0;
            this.ButtonGetData.Text = "Get data";
            this.ButtonGetData.UseVisualStyleBackColor = true;
            this.ButtonGetData.Click += new System.EventHandler(this.ButtonGetData_Click);
            // 
            // EventNameInfo
            // 
            this.EventNameInfo.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.EventNameInfo.Location = new System.Drawing.Point(12, 12);
            this.EventNameInfo.Name = "EventNameInfo";
            this.EventNameInfo.Size = new System.Drawing.Size(126, 20);
            this.EventNameInfo.TabIndex = 1;
            this.EventNameInfo.Text = "Event name";
            this.EventNameInfo.Click += new System.EventHandler(this.EventNameInfo_Click);
            // 
            // Overview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(268, 57);
            this.Controls.Add(this.EventNameInfo);
            this.Controls.Add(this.ButtonGetData);
            this.Name = "Overview";
            this.Text = "Overview";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ButtonGetData;
        private System.Windows.Forms.TextBox EventNameInfo;
    }
}