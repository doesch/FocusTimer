namespace FocusTimer.Views
{
    partial class Statistics
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
            this.linkLabelStartPage = new System.Windows.Forms.LinkLabel();
            this.dataGridViewStatistics = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStatistics)).BeginInit();
            this.SuspendLayout();
            // 
            // bttnStartFocusTime
            // 
            this.bttnStartFocusTime.BackColor = System.Drawing.SystemColors.HotTrack;
            this.bttnStartFocusTime.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttnStartFocusTime.ForeColor = System.Drawing.Color.White;
            this.bttnStartFocusTime.Location = new System.Drawing.Point(3, 427);
            this.bttnStartFocusTime.Name = "bttnStartFocusTime";
            this.bttnStartFocusTime.Size = new System.Drawing.Size(254, 50);
            this.bttnStartFocusTime.TabIndex = 0;
            this.bttnStartFocusTime.Text = "Start Focus Time";
            this.bttnStartFocusTime.UseVisualStyleBackColor = false;
            this.bttnStartFocusTime.Click += new System.EventHandler(this.bttnStartFocusTime_Click);
            // 
            // linkLabelStartPage
            // 
            this.linkLabelStartPage.Location = new System.Drawing.Point(3, 401);
            this.linkLabelStartPage.Name = "linkLabelStartPage";
            this.linkLabelStartPage.Size = new System.Drawing.Size(254, 23);
            this.linkLabelStartPage.TabIndex = 1;
            this.linkLabelStartPage.TabStop = true;
            this.linkLabelStartPage.Text = "Start Page";
            this.linkLabelStartPage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.linkLabelStartPage.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelStartPage_LinkClicked);
            // 
            // dataGridViewStatistics
            // 
            this.dataGridViewStatistics.AllowUserToAddRows = false;
            this.dataGridViewStatistics.AllowUserToDeleteRows = false;
            this.dataGridViewStatistics.AllowUserToResizeRows = false;
            this.dataGridViewStatistics.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridViewStatistics.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridViewStatistics.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewStatistics.ColumnHeadersVisible = false;
            this.dataGridViewStatistics.GridColor = System.Drawing.Color.White;
            this.dataGridViewStatistics.Location = new System.Drawing.Point(3, 3);
            this.dataGridViewStatistics.MultiSelect = false;
            this.dataGridViewStatistics.Name = "dataGridViewStatistics";
            this.dataGridViewStatistics.ReadOnly = true;
            this.dataGridViewStatistics.RowHeadersVisible = false;
            this.dataGridViewStatistics.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridViewStatistics.RowTemplate.Height = 25;
            this.dataGridViewStatistics.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewStatistics.Size = new System.Drawing.Size(254, 395);
            this.dataGridViewStatistics.TabIndex = 2;
            // 
            // Statistics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.dataGridViewStatistics);
            this.Controls.Add(this.linkLabelStartPage);
            this.Controls.Add(this.bttnStartFocusTime);
            this.Name = "Statistics";
            this.Size = new System.Drawing.Size(260, 480);
            this.Load += new System.EventHandler(this.Statistics_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStatistics)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Button bttnStartFocusTime;
        private LinkLabel linkLabelStartPage;
        private DataGridView dataGridViewStatistics;
    }
}
