namespace WindowsFormsApp4
{
    partial class build_rank_total
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
            this.select_lift_box = new System.Windows.Forms.ComboBox();
            this.sex_select_box = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.total_rank_selected_lift_box = new System.Windows.Forms.ListBox();
            this.generate_total_rank_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // select_lift_box
            // 
            this.select_lift_box.FormattingEnabled = true;
            this.select_lift_box.Items.AddRange(new object[] {
            "Squat",
            "Bench",
            "Deadlift"});
            this.select_lift_box.Location = new System.Drawing.Point(82, 78);
            this.select_lift_box.Name = "select_lift_box";
            this.select_lift_box.Size = new System.Drawing.Size(121, 21);
            this.select_lift_box.TabIndex = 0;
            this.select_lift_box.SelectedIndexChanged += new System.EventHandler(this.select_lift_box_SelectedIndexChanged);
            // 
            // sex_select_box
            // 
            this.sex_select_box.FormattingEnabled = true;
            this.sex_select_box.Items.AddRange(new object[] {
            "M",
            "K",
            "Obie płcie"});
            this.sex_select_box.Location = new System.Drawing.Point(234, 78);
            this.sex_select_box.Name = "sex_select_box";
            this.sex_select_box.Size = new System.Drawing.Size(121, 21);
            this.sex_select_box.TabIndex = 1;
            this.sex_select_box.SelectedIndexChanged += new System.EventHandler(this.sex_select_box_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(79, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Bój";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(231, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "płeć";
            // 
            // total_rank_selected_lift_box
            // 
            this.total_rank_selected_lift_box.FormattingEnabled = true;
            this.total_rank_selected_lift_box.Location = new System.Drawing.Point(28, 179);
            this.total_rank_selected_lift_box.Name = "total_rank_selected_lift_box";
            this.total_rank_selected_lift_box.Size = new System.Drawing.Size(472, 121);
            this.total_rank_selected_lift_box.TabIndex = 4;
            this.total_rank_selected_lift_box.SelectedIndexChanged += new System.EventHandler(this.total_rank_selected_lift_box_SelectedIndexChanged);
            // 
            // generate_total_rank_btn
            // 
            this.generate_total_rank_btn.Location = new System.Drawing.Point(185, 125);
            this.generate_total_rank_btn.Name = "generate_total_rank_btn";
            this.generate_total_rank_btn.Size = new System.Drawing.Size(75, 23);
            this.generate_total_rank_btn.TabIndex = 5;
            this.generate_total_rank_btn.Text = "Pokaż";
            this.generate_total_rank_btn.UseVisualStyleBackColor = true;
            this.generate_total_rank_btn.Click += new System.EventHandler(this.generate_total_rank_btn_Click);
            // 
            // build_rank_total
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(555, 338);
            this.Controls.Add(this.generate_total_rank_btn);
            this.Controls.Add(this.total_rank_selected_lift_box);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.sex_select_box);
            this.Controls.Add(this.select_lift_box);
            this.Name = "build_rank_total";
            this.Text = "build_rank_total";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox select_lift_box;
        private System.Windows.Forms.ComboBox sex_select_box;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox total_rank_selected_lift_box;
        private System.Windows.Forms.Button generate_total_rank_btn;
    }
}