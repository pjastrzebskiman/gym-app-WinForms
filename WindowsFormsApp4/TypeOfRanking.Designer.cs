namespace WindowsFormsApp4
{
    partial class TypeOfRanking
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
            this.label1 = new System.Windows.Forms.Label();
            this.total_ranking_btn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lift_ranking_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ranking totali";
            // 
            // total_ranking_btn
            // 
            this.total_ranking_btn.Location = new System.Drawing.Point(192, 24);
            this.total_ranking_btn.Name = "total_ranking_btn";
            this.total_ranking_btn.Size = new System.Drawing.Size(75, 23);
            this.total_ranking_btn.TabIndex = 1;
            this.total_ranking_btn.Text = "Pokaż";
            this.total_ranking_btn.UseVisualStyleBackColor = true;
            this.total_ranking_btn.Click += new System.EventHandler(this.total_ranking_btn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ranking poszczególnych bojów";
            // 
            // lift_ranking_btn
            // 
            this.lift_ranking_btn.Location = new System.Drawing.Point(192, 69);
            this.lift_ranking_btn.Name = "lift_ranking_btn";
            this.lift_ranking_btn.Size = new System.Drawing.Size(75, 23);
            this.lift_ranking_btn.TabIndex = 3;
            this.lift_ranking_btn.Text = "Pokaż";
            this.lift_ranking_btn.UseVisualStyleBackColor = true;
            this.lift_ranking_btn.Click += new System.EventHandler(this.lift_ranking_btn_Click);
            // 
            // TypeOfRanking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lift_ranking_btn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.total_ranking_btn);
            this.Controls.Add(this.label1);
            this.Name = "TypeOfRanking";
            this.Text = "TypeOfRanking";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button total_ranking_btn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button lift_ranking_btn;
    }
}