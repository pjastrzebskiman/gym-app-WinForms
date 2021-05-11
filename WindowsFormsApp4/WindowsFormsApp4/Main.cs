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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void szukaj_zawodnika_btn_Click(object sender, EventArgs e)
        {
            new Competitor().Show();
        }

        private void show_all_btn_Click(object sender, EventArgs e)
        {
            new show_all().Show();
        }

        private void search_results_competitor_btn_Click(object sender, EventArgs e)
        {
            new Search_metod().Show();
        }

        private void ranking_btn_Click(object sender, EventArgs e)
        {
            new TypeOfRanking().Show();
        }
    }
}
