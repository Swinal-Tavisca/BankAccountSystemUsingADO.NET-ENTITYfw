using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDatabaseLiabrary
{
    public class Class1
    {
        SqlConnection con;

        SqlDataReader reader;
        public void MyConnection()
        {
            try
            {
                con = new SqlConnection();
                con.ConnectionString = "Data Source= TAVLAPT148 ;Initial Catalog=MyBankdb;Integrated Security=true";

                con.Open();
            }
            catch(Exception e)
            {

            }
        }
    }
}
