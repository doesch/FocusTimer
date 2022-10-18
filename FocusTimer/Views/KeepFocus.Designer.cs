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
            this.BttnStop = new System.Windows.Forms.Button();
            this.labelCurrentTime = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.linkLabelBreak = new System.Windows.Forms.LinkLabel();
            this.pictureBoxMain = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMain)).BeginInit();
            this.SuspendLayout();
            // 
            // BttnStop
            // 
            this.BttnStop.Location = new System.Drawing.Point(3, 427);
            this.BttnStop.Name = "BttnStop";
            this.BttnStop.Size = new System.Drawing.Size(254, 50);
            this.BttnStop.TabIndex = 0;
            this.BttnStop.Text = "Stop";
            this.BttnStop.UseVisualStyleBackColor = true;
            this.BttnStop.Click += new System.EventHandler(this.BttnStop_Click);
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
            // linkLabelBreak
            // 
            this.linkLabelBreak.Location = new System.Drawing.Point(3, 401);
            this.linkLabelBreak.Name = "linkLabelBreak";
            this.linkLabelBreak.Size = new System.Drawing.Size(254, 23);
            this.linkLabelBreak.TabIndex = 2;
            this.linkLabelBreak.TabStop = true;
            this.linkLabelBreak.Text = "Take a Break >";
            this.linkLabelBreak.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.linkLabelBreak.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelBreak_LinkClicked);
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
            this.label1.Text = "Stay Focused!";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // KeepFocus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBoxMain);
            this.Controls.Add(this.linkLabelBreak);
            this.Controls.Add(this.labelCurrentTime);
            this.Controls.Add(this.BttnStop);
            this.Name = "KeepFocus";
            this.Size = new System.Drawing.Size(260, 480);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMain)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Button BttnStop;
        private Label labelCurrentTime;
        private ImageList imageList1;
        private LinkLabel linkLabelBreak;
        private PictureBox pictureBoxMain;
        private Label label1;
    }
}
