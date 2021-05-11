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
    public partial class Search_metod : Form
    {

        public Search_metod()
        {
            InitializeComponent();
        }

        private void search_wpis_btn_Click(object sender, EventArgs e)
        {
            new Competitor_Result_entry().Show();
        }

        private void search_pick_list_btn_Click(object sender, EventArgs e)
        {
            new Competitor_Result_pick().Show();
        }

    }
}
