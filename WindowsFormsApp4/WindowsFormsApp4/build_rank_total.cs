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
    public partial class build_rank_total : Form
    {
        //List<Person> people = new List<Person>();
      //  List<Result> result = new List<Result>();
        List<Total> total_list = new List<Total>();
        string lift="";
        string sex = "";
        public build_rank_total()
        {
            InitializeComponent();
            Refreshview();
            DataAccess db = new DataAccess();
           // total_list = db.ShowTotal_build().OrderByDescending(item => item.Totalfull).ToList();

           // Refreshview();
        }

        private void select_lift_box_SelectedIndexChanged(object sender, EventArgs e)
        {
            lift = select_lift_box.Text;
        }

        private void Refreshview()
        {
            total_rank_selected_lift_box.DataSource = total_list;
            total_rank_selected_lift_box.DisplayMember = "ShowTotal_build";

        }

        private void total_rank_selected_lift_box_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void sex_select_box_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (sex_select_box.Text == "Obie płcie")// do poprwy bo nie sortuje
            {
                sex = "K' or sex='M";
            }
            else
            {
                sex = sex_select_box.Text;
            }
        }

        private void generate_total_rank_btn_Click(object sender, EventArgs e)
        {
            DataAccess db = new DataAccess();
            if(lift=="Squat")
            {
                total_list = db.ShowTotal_build(sex, lift).OrderByDescending(item => item.Total_lift_squat).ToList();
                total_rank_selected_lift_box.DataSource = total_list;
                total_rank_selected_lift_box.DisplayMember = "Total_lift_squat";

            }
            else if(lift=="Bench")
            {
                total_list = db.ShowTotal_build(sex, lift).OrderByDescending(item => item.Total_lift_bench).ToList();
                total_rank_selected_lift_box.DataSource = total_list;
                total_rank_selected_lift_box.DisplayMember = "Total_lift_bench";
            }
            else
            {
                total_list = db.ShowTotal_build(sex, lift).OrderByDescending(item => item.Total_lift_dead).ToList();
                total_rank_selected_lift_box.DataSource = total_list;
                total_rank_selected_lift_box.DisplayMember = "Total_lift_dead";
            }

        }
    }
}
