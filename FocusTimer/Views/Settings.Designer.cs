namespace FocusTimer
{
    partial class Settings
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
            this.button1 = new System.Windows.Forms.Button();
            this.bttnStart = new System.Windows.Forms.Button();
            this.inputTime = new System.Windows.Forms.NumericUpDown();
            this.dataGridViewPlayList = new System.Windows.Forms.DataGridView();
            this.labelPlayList = new System.Windows.Forms.Label();
            this.labelFocusTimeMinutes = new System.Windows.Forms.Label();
            this.bttnSelectDirectory = new System.Windows.Forms.Button();
            this.linkLabelStart = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.inputTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPlayList)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(3, 427);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(254, 50);
            this.button1.TabIndex = 0;
            this.button1.Text = "Start";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // bttnStart
            // 
            this.bttnStart.BackColor = System.Drawing.SystemColors.HotTrack;
            this.bttnStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttnStart.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bttnStart.ForeColor = System.Drawing.Color.White;
            this.bttnStart.Location = new System.Drawing.Point(3, 587);
            this.bttnStart.Name = "bttnStart";
            this.bttnStart.Size = new System.Drawing.Size(291, 50);
            this.bttnStart.TabIndex = 0;
            this.bttnStart.Text = "Start Focus Time";
            this.bttnStart.UseVisualStyleBackColor = false;
            this.bttnStart.Click += new System.EventHandler(this.bttnStart_Click);
            // 
            // inputTime
            // 
            this.inputTime.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.inputTime.Location = new System.Drawing.Point(3, 23);
            this.inputTime.Maximum = new decimal(new int[] {
            240,
            0,
            0,
            0});
            this.inputTime.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.inputTime.Name = "inputTime";
            this.inputTime.Size = new System.Drawing.Size(291, 27);
            this.inputTime.TabIndex = 1;
            this.inputTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.inputTime.Value = new decimal(new int[] {
            25,
            0,
            0,
            0});
            // 
            // dataGridViewPlayList
            // 
            this.dataGridViewPlayList.AllowUserToAddRows = false;
            this.dataGridViewPlayList.AllowUserToDeleteRows = false;
            this.dataGridViewPlayList.AllowUserToResizeColumns = false;
            this.dataGridViewPlayList.AllowUserToResizeRows = false;
            this.dataGridViewPlayList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridViewPlayList.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridViewPlayList.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridViewPlayList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPlayList.ColumnHeadersVisible = false;
            this.dataGridViewPlayList.GridColor = System.Drawing.Color.White;
            this.dataGridViewPlayList.Location = new System.Drawing.Point(3, 85);
            this.dataGridViewPlayList.MultiSelect = false;
            this.dataGridViewPlayList.Name = "dataGridViewPlayList";
            this.dataGridViewPlayList.RowHeadersVisible = false;
            this.dataGridViewPlayList.RowHeadersWidth = 51;
            this.dataGridViewPlayList.RowTemplate.Height = 25;
            this.dataGridViewPlayList.Size = new System.Drawing.Size(291, 473);
            this.dataGridViewPlayList.TabIndex = 2;
            // 
            // labelPlayList
            // 
            this.labelPlayList.AutoSize = true;
            this.labelPlayList.Location = new System.Drawing.Point(3, 53);
            this.labelPlayList.Name = "labelPlayList";
            this.labelPlayList.Size = new System.Drawing.Size(58, 20);
            this.labelPlayList.TabIndex = 3;
            this.labelPlayList.Text = "Playlist:";
            // 
            // labelFocusTimeMinutes
            // 
            this.labelFocusTimeMinutes.AutoSize = true;
            this.labelFocusTimeMinutes.Location = new System.Drawing.Point(3, 0);
            this.labelFocusTimeMinutes.Name = "labelFocusTimeMinutes";
            this.labelFocusTimeMinutes.Size = new System.Drawing.Size(152, 20);
            this.labelFocusTimeMinutes.TabIndex = 4;
            this.labelFocusTimeMinutes.Text = "Focus Time (Minutes):";
            // 
            // bttnSelectDirectory
            // 
            this.bttnSelectDirectory.Location = new System.Drawing.Point(265, 56);
            this.bttnSelectDirectory.Name = "bttnSelectDirectory";
            this.bttnSelectDirectory.Size = new System.Drawing.Size(29, 23);
            this.bttnSelectDirectory.TabIndex = 6;
            this.bttnSelectDirectory.Text = "...";
            this.bttnSelectDirectory.UseVisualStyleBackColor = true;
            this.bttnSelectDirectory.Click += new System.EventHandler(this.bttnSelectDirectory_Click);
            // 
            // linkLabelStart
            // 
            this.linkLabelStart.Location = new System.Drawing.Point(3, 561);
            this.linkLabelStart.Name = "linkLabelStart";
            this.linkLabelStart.Size = new System.Drawing.Size(291, 23);
            this.linkLabelStart.TabIndex = 7;
            this.linkLabelStart.TabStop = true;
            this.linkLabelStart.Text = "Start Page";
            this.linkLabelStart.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.linkLabelStart.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelStart_LinkClicked);
            // 
            // Settings
            // 
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.linkLabelStart);
            this.Controls.Add(this.bttnSelectDirectory);
            this.Controls.Add(this.labelFocusTimeMinutes);
            this.Controls.Add(this.labelPlayList);
            this.Controls.Add(this.dataGridViewPlayList);
            this.Controls.Add(this.inputTime);
            this.Controls.Add(this.bttnStart);
            this.Name = "Settings";
            this.Size = new System.Drawing.Size(297, 640);
            ((System.ComponentModel.ISupportInitialize)(this.inputTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPlayList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button button1;
        private Button bttnStart;
        private NumericUpDown inputTime;
        private DataGridView dataGridViewPlayList;
        private Label labelPlayList;
        private Label labelFocusTimeMinutes;
        private Button bttnSelectDirectory;
        private LinkLabel linkLabelStart;
    }
}
