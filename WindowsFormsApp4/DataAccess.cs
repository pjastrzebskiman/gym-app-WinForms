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

        public void InsertPerson(string imie, string nazwisko)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("CompetitionDB")))
            {
               //Person newPerson = new Person { FirstName = imie, LastName = nazwisko };
               // List<Person> people = new List<Person>();
               // people.Add(new Person { FirstName = imie, LastName = nazwisko });

               connection.Execute("insert into Persons(FirstName,LastName) values(@FirstName, @LastName)",new Person { FirstName = imie, LastName = nazwisko });

                /*string insertQuery = @"INSERT INTO [dbo].[Persons]([FirstName], [LastName]) VALUES (@FirstName, @LastName)";

                var result = connection.Execute(insertQuery, new Person
                {
                    FirstName=imie,
                    LastName=nazwisko
                });*/



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
    }
}
