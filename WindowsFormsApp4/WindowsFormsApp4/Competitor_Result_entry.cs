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
    public partial class Competitor_Result_entry : Form
    {
        List<Person> people = new List<Person>();
        List<Result> result = new List<Result>();

        public Competitor_Result_entry()
        {
            InitializeComponent();
            Refreshview();

        }
        private void Refreshview()
        {
            competitor_name_listbox.DataSource = people;
            competitor_name_listbox.DisplayMember = "Fullinfo";
            competitor_result_listbox.DataSource = result;
            competitor_result_listbox.DisplayMember = "FullResult";

        }
        private void search_competitor_entry_btn_Click(object sender, EventArgs e)
        {
            DataAccess db = new DataAccess();
            people = db.GetPeople(secondName_search_entry_text.Text);
            Refreshview();
        }


        private void competitor_name_listbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataAccess db = new DataAccess();
            //result = db.ShowResult(db.GetPeopleId(secondName_search_entry_text.Text));
            result = db.ShowResult(competitor_name_listbox.SelectedIndex+1);
            Refreshview();



        }
    }
}
