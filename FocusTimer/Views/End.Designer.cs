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
            this.bttnStartBreak = new System.Windows.Forms.Button();
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
            // End
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.bttnStartBreak);
            this.Name = "End";
            this.Size = new System.Drawing.Size(260, 480);
            this.ResumeLayout(false);

        }

        #endregion

        private Button bttnStartBreak;
    }
}
