namespace FocusTimer
{
    partial class KeepFocus
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KeepFocus));
            this.BttnMain = new System.Windows.Forms.Button();
            this.labelCurrentTime = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.pictureBoxMain = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.linkLabelStart = new System.Windows.Forms.LinkLabel();
            this.trackBarVolume = new System.Windows.Forms.TrackBar();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarVolume)).BeginInit();
            this.SuspendLayout();
            // 
            // BttnMain
            // 
            this.BttnMain.BackColor = System.Drawing.SystemColors.HotTrack;
            this.BttnMain.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BttnMain.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BttnMain.ForeColor = System.Drawing.Color.White;
            this.BttnMain.Location = new System.Drawing.Point(3, 427);
            this.BttnMain.Name = "BttnMain";
            this.BttnMain.Size = new System.Drawing.Size(254, 50);
            this.BttnMain.TabIndex = 0;
            this.BttnMain.Text = "Take a Break";
            this.BttnMain.UseVisualStyleBackColor = false;
            this.BttnMain.Click += new System.EventHandler(this.BttnMain_Click);
            // 
            // labelCurrentTime
            // 
            this.labelCurrentTime.BackColor = System.Drawing.SystemColors.Window;
            this.labelCurrentTime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelCurrentTime.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelCurrentTime.Location = new System.Drawing.Point(3, 215);
            this.labelCurrentTime.Name = "labelCurrentTime";
            this.labelCurrentTime.Size = new System.Drawing.Size(251, 50);
            this.labelCurrentTime.TabIndex = 1;
            this.labelCurrentTime.Text = "----";
            this.labelCurrentTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // pictureBoxMain
            // 
            this.pictureBoxMain.Image = global::FocusTimer.Properties.Resources.center_focus_weak_FILL1_wght400_GRAD0_opsz48;
            this.pictureBoxMain.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxMain.InitialImage")));
            this.pictureBoxMain.Location = new System.Drawing.Point(3, 3);
            this.pictureBoxMain.Name = "pictureBoxMain";
            this.pictureBoxMain.Size = new System.Drawing.Size(251, 183);
            this.pictureBoxMain.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBoxMain.TabIndex = 6;
            this.pictureBoxMain.TabStop = false;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(3, 189);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(251, 23);
            this.label1.TabIndex = 7;
            this.label1.Text = "Stay focused!";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // linkLabelStart
            // 
            this.linkLabelStart.Location = new System.Drawing.Point(3, 401);
            this.linkLabelStart.Name = "linkLabelStart";
            this.linkLabelStart.Size = new System.Drawing.Size(254, 23);
            this.linkLabelStart.TabIndex = 8;
            this.linkLabelStart.TabStop = true;
            this.linkLabelStart.Text = "Start Page";
            this.linkLabelStart.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.linkLabelStart.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelStart_LinkClicked);
            // 
            // trackBarVolume
            // 
            this.trackBarVolume.LargeChange = 1;
            this.trackBarVolume.Location = new System.Drawing.Point(3, 321);
            this.trackBarVolume.Maximum = 2;
            this.trackBarVolume.Name = "trackBarVolume";
            this.trackBarVolume.Size = new System.Drawing.Size(251, 45);
            this.trackBarVolume.TabIndex = 9;
            this.trackBarVolume.Value = 2;
            this.trackBarVolume.Scroll += new System.EventHandler(this.trackBarVolume_Scroll);
            this.trackBarVolume.ValueChanged += new System.EventHandler(this.volumeValueChanged);
            // 
            // KeepFocus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.Controls.Add(this.trackBarVolume);
            this.Controls.Add(this.linkLabelStart);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBoxMain);
            this.Controls.Add(this.labelCurrentTime);
            this.Controls.Add(this.BttnMain);
            this.Name = "KeepFocus";
            this.Size = new System.Drawing.Size(260, 480);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarVolume)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button BttnMain;
        private Label labelCurrentTime;
        private ImageList imageList1;
        private PictureBox pictureBoxMain;
        private Label label1;
        private LinkLabel linkLabelStart;
        private TrackBar trackBarVolume;
    }
}
