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
    public partial class show_all : Form
    {
        List<Person> people = new List<Person>();

        public show_all()
        {
            InitializeComponent();
            Refreshview();
            DataAccess db = new DataAccess();
            people = db.ShowAll();
            Refreshview();

        }
        private void Refreshview()
        {
            show_all_listbox.DataSource = people;
            show_all_listbox.DisplayMember = "Fullinfo";

        }

    }
}
