using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;

namespace WindowsFormsApp4
{
    class DataAccess
    {
        public List<Person> GetPeople(string lastName)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("CompetitionDB")))
            {
              var output=  connection.Query<Person>($"select * from Persons where LastName = '{lastName}' ").ToList();
                return output; 
            }

        }

        public List<Person> ShowAll()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("CompetitionDB")))

            {
                var output = connection.Query<Person>("select * from Persons").ToList();
                return output;
            }
        }

        public List<Result> ShowResult(int ID)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("CompetitionDB")))
            {
                var output = connection.Query<Result>($"select Squat, Bench, Deadlift from Results where ID = '{ID}' ").ToList();
                return output;
            }
        }

        public List<Result> ShowTotal()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("CompetitionDB")))
            {
                var output = connection.Query<Result>($"select FirstName ,LastName, Squat,Bench,Deadlift From Persons inner join Results on Persons.ID = Results.ID").ToList();
                return output;
            }
        }

        public List<Total> ShowTotalaa()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("CompetitionDB")))
            {
                var output = connection.Query<Total>($"select FirstName ,LastName, Squat,Bench,Deadlift From Persons inner join Results on Persons.ID = Results.ID").ToList();
               // return output.OrderByDescending(A => A.Totalfull).ToList();
                return output;

            }
        }

        public List<Total> ShowTotal_build(string sex,string lift)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("CompetitionDB")))
            {
                var output = connection.Query<Total>($"select FirstName , LastName, {lift} From Persons inner join Results on Persons.ID = Results.ID where sex ='{sex}'").ToList();
                // return output.OrderByDescending(A => A.Totalfull).ToList();
                return output;

            }
        }
    }
}
