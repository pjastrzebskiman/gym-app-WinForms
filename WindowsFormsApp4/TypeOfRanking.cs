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
    public partial class TypeOfRanking : Form
    {
        public TypeOfRanking()
        {
            InitializeComponent();
        }

        private void lift_ranking_btn_Click(object sender, EventArgs e)
        {
        }

        private void total_ranking_btn_Click(object sender, EventArgs e)
        {
            new Total_rank().Show();

        }
    }
}
