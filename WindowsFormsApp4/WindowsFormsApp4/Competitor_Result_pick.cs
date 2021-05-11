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
    public partial class Competitor_Result_pick : Form
    {
        List<Person> people = new List<Person>();
        List<Result> result = new List<Result>();
        public Competitor_Result_pick()
        {
            InitializeComponent();
            Refreshview();
            DataAccess db = new DataAccess();
            people = db.ShowAll();
            Refreshview();
        }

        private void Refreshview()
        {
            Competitor_select_result_listbox.DataSource = people;
            Competitor_select_result_listbox.DisplayMember = "Fullinfo";
            Competitor_selected_Results_listox.DataSource = result;
            Competitor_selected_Results_listox.DisplayMember = "FullResult";

        }

        private void Competitor_select_result_listbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataAccess db = new DataAccess();
            result = db.ShowResult(Competitor_select_result_listbox.SelectedIndex + 1);
            Refreshview();
        }
    }
}
