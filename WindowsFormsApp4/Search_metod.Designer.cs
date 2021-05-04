namespace WindowsFormsApp4
{
    partial class Search_metod
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
            this.search_wpis_btn = new System.Windows.Forms.Button();
            this.search_pick_list_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // search_wpis_btn
            // 
            this.search_wpis_btn.Location = new System.Drawing.Point(51, 102);
            this.search_wpis_btn.Name = "search_wpis_btn";
            this.search_wpis_btn.Size = new System.Drawing.Size(100, 30);
            this.search_wpis_btn.TabIndex = 5;
            this.search_wpis_btn.Text = "Szukaj";
            this.search_wpis_btn.UseVisualStyleBackColor = true;
            this.search_wpis_btn.Click += new System.EventHandler(this.search_wpis_btn_Click);
            // 
            // search_pick_list_btn
            // 
            this.search_pick_list_btn.Location = new System.Drawing.Point(182, 102);
            this.search_pick_list_btn.Name = "search_pick_list_btn";
            this.search_pick_list_btn.Size = new System.Drawing.Size(100, 30);
            this.search_pick_list_btn.TabIndex = 7;
            this.search_pick_list_btn.Text = "Szukaj";
            this.search_pick_list_btn.UseVisualStyleBackColor = true;
            this.search_pick_list_btn.Click += new System.EventHandler(this.search_pick_list_btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Szukaj po nazwisku";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(179, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Wybierz z listy";
            // 
            // Search_metod
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(319, 170);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.search_pick_list_btn);
            this.Controls.Add(this.search_wpis_btn);
            this.Name = "Search_metod";
            this.Text = "Search_metod";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button search_wpis_btn;
        private System.Windows.Forms.Button search_pick_list_btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}