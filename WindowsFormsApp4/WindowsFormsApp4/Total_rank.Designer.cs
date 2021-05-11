namespace WindowsFormsApp4
{
    partial class Total_rank
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
            this.total_rank_listbox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // total_rank_listbox
            // 
            this.total_rank_listbox.FormattingEnabled = true;
            this.total_rank_listbox.Location = new System.Drawing.Point(24, 43);
            this.total_rank_listbox.Name = "total_rank_listbox";
            this.total_rank_listbox.Size = new System.Drawing.Size(749, 381);
            this.total_rank_listbox.TabIndex = 0;
            // 
            // Total_rank
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.total_rank_listbox);
            this.Name = "Total_rank";
            this.Text = "Total_rank";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox total_rank_listbox;
    }
}