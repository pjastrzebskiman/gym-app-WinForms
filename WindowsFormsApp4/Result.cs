using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp4
{
    class Result
    {
       
        public int Squat { get; set; }
        public int Bench { get; set; }
        public int Deadlift { get; set; }
        public int Category { get; set; }
        public string Sex { get; set; }
        public int Id { get; set; }


        public string FullResult
        {
            get
            {
                return $"Przysiad: {Squat} Wyciskanie: {Bench} Martwy ciąg {Deadlift}";
            }
        }

        public string Total
        {
        get
            {
                int a = Squat + Bench + Deadlift;
                return $" Przysiad: {Squat} Wyciskanie: {Bench} Martwy ciąg {Deadlift} , Total: { a} ";

            }
        }
    }


}
