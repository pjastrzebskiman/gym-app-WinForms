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
    public partial class Competitor : Form
    {
        List<Person> people = new List<Person>();
        public Competitor()
        {
            InitializeComponent();
            Refreshview();
        }
        private void Refreshview()
        {
            competitor_list.DataSource = people;
            competitor_list.DisplayMember = "Fullinfo";

        }

        private void szukaj_btn_Click(object sender, EventArgs e)
        {
            DataAccess db = new DataAccess();
            people = db.GetPeople(nazwisko_txt.Text);
            Refreshview();
        }
    }
}
