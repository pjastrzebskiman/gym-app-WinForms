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
    public partial class Total_rank : Form
    {
       // List<Person> people = new List<Person>();
       // List<Result> result = new List<Result>();
         List<Total>total_list= new List<Total>();
        public Total_rank()
        {
            InitializeComponent();
            Refreshview();
            DataAccess db = new DataAccess();
            total_list = db.ShowTotalaa().OrderByDescending(item => item.Totalfull).ToList();

            Refreshview();

        }
        private void Refreshview()
        {
            total_rank_listbox.DataSource = total_list;
            total_rank_listbox.DisplayMember = "Totalaa";

        }
    }
}
