using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class Add_Competitor : Form
    {
        public Add_Competitor()
        {
            InitializeComponent();
        }

        private void btn_add_competitor_Click(object sender, EventArgs e)
        {
            DataAccess db = new DataAccess();
            db.InsertPerson(txt_imie.Text, txt_nazwisko.Text);

            txt_imie.Text = "";
            txt_nazwisko.Text = "";
            txt_mail.Text = "";
            txt_phone.Text = "";
        }
    }
}
