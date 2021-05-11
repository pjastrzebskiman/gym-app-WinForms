using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp4
{
    class Total
    {
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public int Age { get; set; }
        public int Squat { get; set; }
        public int Bench { get; set; }
        public int Deadlift { get; set; }
        public int Category { get; set; }
        public string Sex { get; set; }
        public int Id { get; set; }
        public int Totalfull
        {
            get
            {
                return Squat + Bench + Deadlift;
            }
            set
            {
                //Totalfull = Squat + Bench + Deadlift;
            }
        }

        public string Totalaa
        {
            get
            {
                //int a = Squat + Bench + Deadlift;
                return $" Imię: {FirstName} Nazwisko {LastName} Przysiad: {Squat} Wyciskanie: {Bench} Martwy ciąg {Deadlift} , Total: { Totalfull} ";

            }
        }

        public string Total_lift_squat
        {
            get
            {
                return $" Imię: {FirstName} Nazwisko {LastName} Przysiad: {Squat}";
            }
        }
        public string Total_lift_bench
        {
            get
            {
                return $" Imię: {FirstName} Nazwisko {LastName} Wyciskanie: {Bench}";
            }
        }

        public string Total_lift_dead
        {
            get
            {
                return $" Imię: {FirstName} Nazwisko {LastName} Ciąg: {Deadlift}";
            }
        }

    }
}
