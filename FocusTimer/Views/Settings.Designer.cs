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
            this.bttnStart.Location = new System.Drawing.Point(3, 427);
            this.bttnStart.Name = "bttnStart";
            this.bttnStart.Size = new System.Drawing.Size(254, 50);
            this.bttnStart.TabIndex = 0;
            this.bttnStart.Text = "Start";
            this.bttnStart.UseVisualStyleBackColor = true;
            this.bttnStart.Click += new System.EventHandler(this.bttnStart_Click);
            // 
            // inputTime
            // 
            this.inputTime.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.inputTime.Location = new System.Drawing.Point(3, 36);
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
            this.inputTime.Size = new System.Drawing.Size(254, 23);
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
            this.dataGridViewPlayList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridViewPlayList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPlayList.Location = new System.Drawing.Point(3, 98);
            this.dataGridViewPlayList.MultiSelect = false;
            this.dataGridViewPlayList.Name = "dataGridViewPlayList";
            this.dataGridViewPlayList.RowHeadersVisible = false;
            this.dataGridViewPlayList.RowTemplate.Height = 25;
            this.dataGridViewPlayList.Size = new System.Drawing.Size(254, 323);
            this.dataGridViewPlayList.TabIndex = 2;
            // 
            // labelPlayList
            // 
            this.labelPlayList.AutoSize = true;
            this.labelPlayList.Location = new System.Drawing.Point(3, 80);
            this.labelPlayList.Name = "labelPlayList";
            this.labelPlayList.Size = new System.Drawing.Size(47, 15);
            this.labelPlayList.TabIndex = 3;
            this.labelPlayList.Text = "Playlist:";
            // 
            // labelFocusTimeMinutes
            // 
            this.labelFocusTimeMinutes.AutoSize = true;
            this.labelFocusTimeMinutes.Location = new System.Drawing.Point(3, 18);
            this.labelFocusTimeMinutes.Name = "labelFocusTimeMinutes";
            this.labelFocusTimeMinutes.Size = new System.Drawing.Size(124, 15);
            this.labelFocusTimeMinutes.TabIndex = 4;
            this.labelFocusTimeMinutes.Text = "Focus Time (Minutes):";
            // 
            // bttnSelectDirectory
            // 
            this.bttnSelectDirectory.Location = new System.Drawing.Point(228, 72);
            this.bttnSelectDirectory.Name = "bttnSelectDirectory";
            this.bttnSelectDirectory.Size = new System.Drawing.Size(29, 23);
            this.bttnSelectDirectory.TabIndex = 6;
            this.bttnSelectDirectory.Text = "...";
            this.bttnSelectDirectory.UseVisualStyleBackColor = true;
            this.bttnSelectDirectory.Click += new System.EventHandler(this.bttnSelectDirectory_Click);
            // 
            // Settings
            // 
            this.Controls.Add(this.bttnSelectDirectory);
            this.Controls.Add(this.labelFocusTimeMinutes);
            this.Controls.Add(this.labelPlayList);
            this.Controls.Add(this.dataGridViewPlayList);
            this.Controls.Add(this.inputTime);
            this.Controls.Add(this.bttnStart);
            this.Name = "Settings";
            this.Size = new System.Drawing.Size(260, 480);
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
    }
}
