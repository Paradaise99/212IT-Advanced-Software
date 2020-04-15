using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactManager8299745CSharp
{
    public class DbCon //this class is the class were we make the conection to the database;
    {
        private string conString = "Server=db212it.cgqw6genwnm1.us-east-1.rds.amazonaws.com; User ID=admin; Password=Paradaise99?; Database=HarrisContactDb"; // this is the sql string that makes the connection to the database using name password and more;

        public DataTable GetAllPersonal() //this is the method that will run the query in sql that will get all the data from the personal table; 
        {
            using (var conn = new MySqlConnection(conString))
            {
                conn.Open(); //here it opens the connetction to the database;
                DataTable personalContactDt = new DataTable();
                List<PersonalContact> personalContacts = new List<PersonalContact>();
                using (var cmd = new MySqlCommand("CALL selectAllPersonal()", conn)) //here is were the query is run;
                using (var reader = cmd.ExecuteReader())
                    while (reader.Read())
                    {
                        personalContacts.Add(new PersonalContact //here the constroctor personalcontacts is getting all the collums from the database and telling what data type it is;
                        {
                            ContactID = reader.GetInt32(0),
                            ContactFName = reader.GetString(1),
                            ContactLName = reader.GetString(2),
                            ContactEmail = reader.GetString(3),
                            ContactTel = reader.GetString(4),
                            ContactAddr1 = reader.GetString(5),
                            ContactAddr2 = reader.GetString(6),
                            ContactCity = reader.GetString(7),
                            ContactPostcode = reader.GetString(8),
                            ContactHomeTel = reader.GetString(9)
                        });
                    }
                personalContactDt.Columns.Add("ContactID");
                personalContactDt.Columns.Add("ContactFName");
                personalContactDt.Columns.Add("ContactLName");
                personalContactDt.Columns.Add("ContactEmail");
                personalContactDt.Columns.Add("ContactTel");
                personalContactDt.Columns.Add("ContactAddr1");
                personalContactDt.Columns.Add("ContactAddr2");
                personalContactDt.Columns.Add("ContactCity");
                personalContactDt.Columns.Add("ContactPostcode");
                personalContactDt.Columns.Add("ContactHomeTel");

                foreach (var item in personalContacts) //here the data that was collected in the database is showed in the table;
                {
                    var row = personalContactDt.NewRow();

                    row["ContactID"] = item.ContactID;
                    row["ContactFName"] = item.ContactFName;
                    row["ContactLName"] = item.ContactLName;
                    row["ContactEmail"] = item.ContactEmail;
                    row["ContactTel"] = item.ContactTel;
                    row["ContactAddr1"] = item.ContactAddr1;
                    row["ContactAddr2"] = item.ContactAddr2;
                    row["ContactCity"] = item.ContactCity;
                    row["ContactPostcode"] = item.ContactPostcode;
                    row["ContactHomeTel"] = item.ContactHomeTel;

                    personalContactDt.Rows.Add(row);

                }
                return personalContactDt; //because it is a method it needs to return something and here it is returning the data that is in the table;

            }
        }


        public async void InsertPersonal(PersonalContact personalContact) //this is a methot that will run a query that in insert personal contatct in to the data base;
        {
            using (var conn = new MySqlConnection(conString))
            {
                await conn.OpenAsync();
                using (var cmd = new MySqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = "CALL insertPersonal(@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9);";
                    cmd.Parameters.AddWithValue("p1", personalContact.ContactFName);
                    cmd.Parameters.AddWithValue("p2", personalContact.ContactLName);
                    cmd.Parameters.AddWithValue("p3", personalContact.ContactEmail);
                    cmd.Parameters.AddWithValue("p4", personalContact.ContactTel);
                    cmd.Parameters.AddWithValue("p5", personalContact.ContactAddr1);
                    cmd.Parameters.AddWithValue("p6", personalContact.ContactAddr2);
                    cmd.Parameters.AddWithValue("p7", personalContact.ContactCity);
                    cmd.Parameters.AddWithValue("p8", personalContact.ContactPostcode);
                    cmd.Parameters.AddWithValue("p9", personalContact.ContactHomeTel);
                    await cmd.ExecuteNonQueryAsync(); //here is the code that makes the sql page exacute the query;
                }
            }
        }

        public async void UpdatePersonal(PersonalContact personalContact) //this is the method that updates the existing contacts and runs that query;
        {
            using (var conn = new MySqlConnection(conString))
            {
                await conn.OpenAsync(); //this is the code used so wen the conection isnt completed in a serten time it will give a error 
                using (var cmd = new MySqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = "CALL updatePersonal(@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9,@p10);";
                    cmd.Parameters.AddWithValue("p1", personalContact.ContactID);
                    cmd.Parameters.AddWithValue("p2", personalContact.ContactFName);
                    cmd.Parameters.AddWithValue("p3", personalContact.ContactLName);
                    cmd.Parameters.AddWithValue("p4", personalContact.ContactEmail);
                    cmd.Parameters.AddWithValue("p5", personalContact.ContactTel);
                    cmd.Parameters.AddWithValue("p6", personalContact.ContactAddr1);
                    cmd.Parameters.AddWithValue("p7", personalContact.ContactAddr2);
                    cmd.Parameters.AddWithValue("p8", personalContact.ContactCity);
                    cmd.Parameters.AddWithValue("p9", personalContact.ContactPostcode);
                    cmd.Parameters.AddWithValue("p10", personalContact.ContactHomeTel);
                    await cmd.ExecuteNonQueryAsync(); //here is the code that makes the sql page exacute the query;
                }
            }
        }

        public async void DeletePersonal(int id) //this is the method that deletes the intire data from a specifc contact;
        {
            using (var conn = new MySqlConnection(conString))
            {
                await conn.OpenAsync();
                using (var cmd = new MySqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = "CALL deletePersonal(@p1);";
                    cmd.Parameters.AddWithValue("p1", id);
                    await cmd.ExecuteNonQueryAsync();
                }
            }
        }

        public DataTable GetAllBusiness() //this is the code that makes the samething but this time for business contacts; but all the rest is the same;
        {
            using (var conn = new MySqlConnection(conString))
            {
                conn.Open();
                DataTable businessContactDt = new DataTable();
                List<BusinessContact> businessContacts = new List<BusinessContact>();
                using (var cmd = new MySqlCommand("CALL selectAllBusiness()", conn))
                using (var reader = cmd.ExecuteReader())
                    while (reader.Read())
                    {
                        businessContacts.Add(new BusinessContact
                        {
                            ContactID = reader.GetInt32(0),
                            ContactFName = reader.GetString(1),
                            ContactLName = reader.GetString(2),
                            ContactEmail = reader.GetString(3),
                            ContactTel = reader.GetString(4),
                            ContactAddr1 = reader.GetString(5),
                            ContactAddr2 = reader.GetString(6),
                            ContactCity = reader.GetString(7),
                            ContactPostcode = reader.GetString(8),
                            ContactBusinessTel = reader.GetString(9)
                        });
                    }
                businessContactDt.Columns.Add("ContactID");
                businessContactDt.Columns.Add("ContactFName");
                businessContactDt.Columns.Add("ContactLName");
                businessContactDt.Columns.Add("ContactEmail");
                businessContactDt.Columns.Add("ContactTel");
                businessContactDt.Columns.Add("ContactAddr1");
                businessContactDt.Columns.Add("ContactAddr2");
                businessContactDt.Columns.Add("ContactCity");
                businessContactDt.Columns.Add("ContactPostcode");
                businessContactDt.Columns.Add("ContactBusinessTel");

                foreach (var item in businessContacts)
                {
                    var row = businessContactDt.NewRow();

                    row["ContactID"] = item.ContactID;
                    row["ContactFName"] = item.ContactFName;
                    row["ContactLName"] = item.ContactLName;
                    row["ContactEmail"] = item.ContactEmail;
                    row["ContactTel"] = item.ContactTel;
                    row["ContactAddr1"] = item.ContactAddr1;
                    row["ContactAddr2"] = item.ContactAddr2;
                    row["ContactCity"] = item.ContactCity;
                    row["ContactPostcode"] = item.ContactPostcode;
                    row["ContactBusinessTel"] = item.ContactBusinessTel;

                    businessContactDt.Rows.Add(row);

                }
                return businessContactDt;

            }
        }

        public async void InsertBusiness(BusinessContact businessContact)
        {
            using (var conn = new MySqlConnection(conString))
            {
                await conn.OpenAsync();
                using (var cmd = new MySqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = "CALL insertBusiness(@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9);";
                    cmd.Parameters.AddWithValue("p1", businessContact.ContactFName);
                    cmd.Parameters.AddWithValue("p2", businessContact.ContactLName);
                    cmd.Parameters.AddWithValue("p3", businessContact.ContactEmail);
                    cmd.Parameters.AddWithValue("p4", businessContact.ContactTel);
                    cmd.Parameters.AddWithValue("p5", businessContact.ContactAddr1);
                    cmd.Parameters.AddWithValue("p6", businessContact.ContactAddr2);
                    cmd.Parameters.AddWithValue("p7", businessContact.ContactCity);
                    cmd.Parameters.AddWithValue("p8", businessContact.ContactPostcode);
                    cmd.Parameters.AddWithValue("p9", businessContact.ContactBusinessTel);
                    await cmd.ExecuteNonQueryAsync();
                }
            }
        }

        public async void UpdateBusiness(BusinessContact businessContact)
        {
            using (var conn = new MySqlConnection(conString))
            {
                await conn.OpenAsync();
                using (var cmd = new MySqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = "CALL updatePersonal(@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9,@p10);";
                    cmd.Parameters.AddWithValue("p1", businessContact.ContactID);
                    cmd.Parameters.AddWithValue("p2", businessContact.ContactFName);
                    cmd.Parameters.AddWithValue("p3", businessContact.ContactLName);
                    cmd.Parameters.AddWithValue("p4", businessContact.ContactEmail);
                    cmd.Parameters.AddWithValue("p5", businessContact.ContactTel);
                    cmd.Parameters.AddWithValue("p6", businessContact.ContactAddr1);
                    cmd.Parameters.AddWithValue("p7", businessContact.ContactAddr2);
                    cmd.Parameters.AddWithValue("p8", businessContact.ContactCity);
                    cmd.Parameters.AddWithValue("p9", businessContact.ContactPostcode);
                    cmd.Parameters.AddWithValue("p10", businessContact.ContactBusinessTel);
                    await cmd.ExecuteNonQueryAsync();
                }
            }
        }

        public async void DeleteBusiness(int id)
        {
            using (var conn = new MySqlConnection(conString))
            {
                await conn.OpenAsync();
                using (var cmd = new MySqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = "CALL deleteBusiness(@p1);";
                    cmd.Parameters.AddWithValue("p1", id);
                    await cmd.ExecuteNonQueryAsync();
                }
            }
        }
    }
}
