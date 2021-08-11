namespace WindowsFormsApp4
{
    partial class Add_Competitor
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.txt_imie = new System.Windows.Forms.TextBox();
            this.txt_nazwisko = new System.Windows.Forms.TextBox();
            this.txt_mail = new System.Windows.Forms.TextBox();
            this.txt_phone = new System.Windows.Forms.TextBox();
            this.btn_add_competitor = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Imie";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(55, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nazwisko";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(55, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "email";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(55, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "nr telefonu";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(58, 173);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(140, 17);
            this.checkBox1.TabIndex = 4;
            this.checkBox1.Text = "Wyślij maila powitalnego";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // txt_imie
            // 
            this.txt_imie.Location = new System.Drawing.Point(131, 32);
            this.txt_imie.Name = "txt_imie";
            this.txt_imie.Size = new System.Drawing.Size(100, 20);
            this.txt_imie.TabIndex = 5;
            // 
            // txt_nazwisko
            // 
            this.txt_nazwisko.Location = new System.Drawing.Point(131, 67);
            this.txt_nazwisko.Name = "txt_nazwisko";
            this.txt_nazwisko.Size = new System.Drawing.Size(100, 20);
            this.txt_nazwisko.TabIndex = 6;
            // 
            // txt_mail
            // 
            this.txt_mail.Location = new System.Drawing.Point(131, 102);
            this.txt_mail.Name = "txt_mail";
            this.txt_mail.Size = new System.Drawing.Size(100, 20);
            this.txt_mail.TabIndex = 7;
            // 
            // txt_phone
            // 
            this.txt_phone.Location = new System.Drawing.Point(131, 132);
            this.txt_phone.Name = "txt_phone";
            this.txt_phone.Size = new System.Drawing.Size(100, 20);
            this.txt_phone.TabIndex = 8;
            // 
            // btn_add_competitor
            // 
            this.btn_add_competitor.Location = new System.Drawing.Point(153, 215);
            this.btn_add_competitor.Name = "btn_add_competitor";
            this.btn_add_competitor.Size = new System.Drawing.Size(75, 23);
            this.btn_add_competitor.TabIndex = 9;
            this.btn_add_competitor.Text = "Dodaj";
            this.btn_add_competitor.UseVisualStyleBackColor = true;
            this.btn_add_competitor.Click += new System.EventHandler(this.btn_add_competitor_Click);
            // 
            // Add_Competitor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_add_competitor);
            this.Controls.Add(this.txt_phone);
            this.Controls.Add(this.txt_mail);
            this.Controls.Add(this.txt_nazwisko);
            this.Controls.Add(this.txt_imie);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Add_Competitor";
            this.Text = "Add_Competitor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.TextBox txt_imie;
        private System.Windows.Forms.TextBox txt_nazwisko;
        private System.Windows.Forms.TextBox txt_mail;
        private System.Windows.Forms.TextBox txt_phone;
        private System.Windows.Forms.Button btn_add_competitor;
    }
}