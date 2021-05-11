using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp4
{
    class Person
    {
        public int Id { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public int Age { get; set; }

        public string Fullinfo
        {
            get
            {
                return $" Imię: { FirstName} Nazwisko: {LastName} Wiek: {Age} " ;
            }
        }



    }
}
