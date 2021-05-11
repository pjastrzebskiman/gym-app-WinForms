namespace WindowsFormsApp4
{
    partial class show_all
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
            this.show_all_listbox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // show_all_listbox
            // 
            this.show_all_listbox.FormattingEnabled = true;
            this.show_all_listbox.Location = new System.Drawing.Point(12, 12);
            this.show_all_listbox.Name = "show_all_listbox";
            this.show_all_listbox.Size = new System.Drawing.Size(765, 407);
            this.show_all_listbox.TabIndex = 0;
            // 
            // show_all
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.show_all_listbox);
            this.Name = "show_all";
            this.Text = "show_all";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox show_all_listbox;
    }
}