namespace FocusTimer.Views
{
    partial class End
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(End));
            this.bttnStartBreak = new System.Windows.Forms.Button();
            this.labelMainText = new System.Windows.Forms.Label();
            this.linkLabelSettings = new System.Windows.Forms.LinkLabel();
            this.bttnContinueFocusTime = new System.Windows.Forms.Button();
            this.pictureBoxMain = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMain)).BeginInit();
            this.SuspendLayout();
            // 
            // bttnStartBreak
            // 
            this.bttnStartBreak.Location = new System.Drawing.Point(3, 427);
            this.bttnStartBreak.Name = "bttnStartBreak";
            this.bttnStartBreak.Size = new System.Drawing.Size(254, 50);
            this.bttnStartBreak.TabIndex = 0;
            this.bttnStartBreak.Text = "Start Break";
            this.bttnStartBreak.UseVisualStyleBackColor = true;
            this.bttnStartBreak.Click += new System.EventHandler(this.bttnStartBreak_Click);
            // 
            // labelMainText
            // 
            this.labelMainText.Location = new System.Drawing.Point(3, 189);
            this.labelMainText.Name = "labelMainText";
            this.labelMainText.Size = new System.Drawing.Size(251, 23);
            this.labelMainText.TabIndex = 1;
            this.labelMainText.Text = "You Focus Time is finished.";
            this.labelMainText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // linkLabelSettings
            // 
            this.linkLabelSettings.Location = new System.Drawing.Point(3, 401);
            this.linkLabelSettings.Name = "linkLabelSettings";
            this.linkLabelSettings.Size = new System.Drawing.Size(254, 23);
            this.linkLabelSettings.TabIndex = 2;
            this.linkLabelSettings.TabStop = true;
            this.linkLabelSettings.Text = "Go to Settings >";
            this.linkLabelSettings.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.linkLabelSettings.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelSettings_LinkClicked);
            // 
            // bttnContinueFocusTime
            // 
            this.bttnContinueFocusTime.Location = new System.Drawing.Point(80, 215);
            this.bttnContinueFocusTime.Name = "bttnContinueFocusTime";
            this.bttnContinueFocusTime.Size = new System.Drawing.Size(98, 30);
            this.bttnContinueFocusTime.TabIndex = 3;
            this.bttnContinueFocusTime.Text = "+5 Minutes";
            this.bttnContinueFocusTime.UseVisualStyleBackColor = true;
            this.bttnContinueFocusTime.Click += new System.EventHandler(this.bttnContinueFocusTime_Click);
            // 
            // pictureBoxMain
            // 
            this.pictureBoxMain.Image = global::FocusTimer.Properties.Resources.check_circle_FILL1_wght400_GRAD0_opsz48;
            this.pictureBoxMain.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxMain.InitialImage")));
            this.pictureBoxMain.Location = new System.Drawing.Point(3, 3);
            this.pictureBoxMain.Name = "pictureBoxMain";
            this.pictureBoxMain.Size = new System.Drawing.Size(251, 183);
            this.pictureBoxMain.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBoxMain.TabIndex = 7;
            this.pictureBoxMain.TabStop = false;
            // 
            // End
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pictureBoxMain);
            this.Controls.Add(this.bttnContinueFocusTime);
            this.Controls.Add(this.linkLabelSettings);
            this.Controls.Add(this.labelMainText);
            this.Controls.Add(this.bttnStartBreak);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "End";
            this.Size = new System.Drawing.Size(260, 480);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMain)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Button bttnStartBreak;
        private Label labelMainText;
        private LinkLabel linkLabelSettings;
        private Button bttnContinueFocusTime;
        private PictureBox pictureBoxMain;
    }
}
