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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Break));
            this.bttnStartFocusTime = new System.Windows.Forms.Button();
            this.labelCurrentTime = new System.Windows.Forms.Label();
            this.linkLabelStart = new System.Windows.Forms.LinkLabel();
            this.pictureBoxMain = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labelCurrentFocusTimeOfTheDay = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMain)).BeginInit();
            this.SuspendLayout();
            // 
            // bttnStartFocusTime
            // 
            this.bttnStartFocusTime.BackColor = System.Drawing.SystemColors.HotTrack;
            this.bttnStartFocusTime.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttnStartFocusTime.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bttnStartFocusTime.ForeColor = System.Drawing.Color.White;
            this.bttnStartFocusTime.Location = new System.Drawing.Point(3, 427);
            this.bttnStartFocusTime.Name = "bttnStartFocusTime";
            this.bttnStartFocusTime.Size = new System.Drawing.Size(254, 50);
            this.bttnStartFocusTime.TabIndex = 0;
            this.bttnStartFocusTime.Text = "Start Focus Time";
            this.bttnStartFocusTime.UseVisualStyleBackColor = false;
            this.bttnStartFocusTime.Click += new System.EventHandler(this.bttnStartFocusTime_Click);
            // 
            // labelCurrentTime
            // 
            this.labelCurrentTime.BackColor = System.Drawing.SystemColors.Window;
            this.labelCurrentTime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelCurrentTime.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelCurrentTime.Location = new System.Drawing.Point(3, 215);
            this.labelCurrentTime.Name = "labelCurrentTime";
            this.labelCurrentTime.Size = new System.Drawing.Size(251, 50);
            this.labelCurrentTime.TabIndex = 2;
            this.labelCurrentTime.Text = "----";
            this.labelCurrentTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // linkLabelStart
            // 
            this.linkLabelStart.Location = new System.Drawing.Point(3, 401);
            this.linkLabelStart.Name = "linkLabelStart";
            this.linkLabelStart.Size = new System.Drawing.Size(254, 23);
            this.linkLabelStart.TabIndex = 3;
            this.linkLabelStart.TabStop = true;
            this.linkLabelStart.Text = "Start Page";
            this.linkLabelStart.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.linkLabelStart.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelStart_LinkClicked);
            // 
            // pictureBoxMain
            // 
            this.pictureBoxMain.Image = global::FocusTimer.Properties.Resources.local_cafe_FILL1_wght400_GRAD0_opsz48;
            this.pictureBoxMain.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxMain.InitialImage")));
            this.pictureBoxMain.Location = new System.Drawing.Point(3, 3);
            this.pictureBoxMain.Name = "pictureBoxMain";
            this.pictureBoxMain.Size = new System.Drawing.Size(251, 183);
            this.pictureBoxMain.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBoxMain.TabIndex = 5;
            this.pictureBoxMain.TabStop = false;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(3, 189);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(251, 23);
            this.label1.TabIndex = 8;
            this.label1.Text = "Take a break!";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelCurrentFocusTimeOfTheDay
            // 
            this.labelCurrentFocusTimeOfTheDay.Location = new System.Drawing.Point(3, 329);
            this.labelCurrentFocusTimeOfTheDay.Name = "labelCurrentFocusTimeOfTheDay";
            this.labelCurrentFocusTimeOfTheDay.Size = new System.Drawing.Size(251, 20);
            this.labelCurrentFocusTimeOfTheDay.TabIndex = 9;
            this.labelCurrentFocusTimeOfTheDay.Text = "Your total focus time for today is:";
            this.labelCurrentFocusTimeOfTheDay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Break
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.labelCurrentFocusTimeOfTheDay);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBoxMain);
            this.Controls.Add(this.linkLabelStart);
            this.Controls.Add(this.labelCurrentTime);
            this.Controls.Add(this.bttnStartFocusTime);
            this.Name = "Break";
            this.Size = new System.Drawing.Size(260, 480);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMain)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Button bttnStartFocusTime;
        private Label labelCurrentTime;
        private LinkLabel linkLabelStart;
        private PictureBox pictureBoxMain;
        private Label label1;
        private Label labelCurrentFocusTimeOfTheDay;
    }
}
