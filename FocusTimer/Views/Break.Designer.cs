namespace FocusTimer.Views
{
    partial class Break
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.bttnStartFocusTime = new System.Windows.Forms.Button();
            this.labelCurrentTime = new System.Windows.Forms.Label();
            this.linkLabelSettings = new System.Windows.Forms.LinkLabel();
            this.labelMainText = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bttnStartFocusTime
            // 
            this.bttnStartFocusTime.Location = new System.Drawing.Point(3, 427);
            this.bttnStartFocusTime.Name = "bttnStartFocusTime";
            this.bttnStartFocusTime.Size = new System.Drawing.Size(254, 50);
            this.bttnStartFocusTime.TabIndex = 0;
            this.bttnStartFocusTime.Text = "Start Focus Time";
            this.bttnStartFocusTime.UseVisualStyleBackColor = true;
            this.bttnStartFocusTime.Click += new System.EventHandler(this.bttnStartFocusTime_Click);
            // 
            // labelCurrentTime
            // 
            this.labelCurrentTime.BackColor = System.Drawing.SystemColors.Window;
            this.labelCurrentTime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelCurrentTime.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelCurrentTime.Location = new System.Drawing.Point(3, 85);
            this.labelCurrentTime.Name = "labelCurrentTime";
            this.labelCurrentTime.Size = new System.Drawing.Size(251, 50);
            this.labelCurrentTime.TabIndex = 2;
            this.labelCurrentTime.Text = "----";
            this.labelCurrentTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // linkLabelSettings
            // 
            this.linkLabelSettings.Location = new System.Drawing.Point(3, 401);
            this.linkLabelSettings.Name = "linkLabelSettings";
            this.linkLabelSettings.Size = new System.Drawing.Size(254, 23);
            this.linkLabelSettings.TabIndex = 3;
            this.linkLabelSettings.TabStop = true;
            this.linkLabelSettings.Text = "Go to Settings >";
            this.linkLabelSettings.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.linkLabelSettings.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelSettings_LinkClicked);
            // 
            // labelMainText
            // 
            this.labelMainText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelMainText.Location = new System.Drawing.Point(3, 62);
            this.labelMainText.Name = "labelMainText";
            this.labelMainText.Size = new System.Drawing.Size(251, 23);
            this.labelMainText.TabIndex = 4;
            this.labelMainText.Text = "Your Break Time:";
            this.labelMainText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Break
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.labelMainText);
            this.Controls.Add(this.linkLabelSettings);
            this.Controls.Add(this.labelCurrentTime);
            this.Controls.Add(this.bttnStartFocusTime);
            this.Name = "Break";
            this.Size = new System.Drawing.Size(260, 480);
            this.ResumeLayout(false);

        }

        #endregion

        private Button bttnStartFocusTime;
        private Label labelCurrentTime;
        private LinkLabel linkLabelSettings;
        private Label labelMainText;
    }
}
