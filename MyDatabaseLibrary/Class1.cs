using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace MyDatabaseLibrary
{
    public class Class1
    {
        SqlConnection con = new SqlConnection("Data Source=TAVLAPT148;Initial Catalog=mybankdb;Integrated Security=True");
        public void insert_into_myBankDB(int id,String name,int balance,String type)
        {
            try
            {
                con.Open();
                String query_insert = "INSERT INTO account(ID,NAME,BALANCE,TYPE) VALUES (@ID,@NAME,@BALANCE,@TYPE) ";
                SqlCommand cmd = new SqlCommand(query_insert, con);
                cmd.Parameters.AddWithValue("@ID",id);
                cmd.Parameters.AddWithValue("@NAME",name);
                cmd.Parameters.AddWithValue("@BALANCE",balance);
                cmd.Parameters.AddWithValue("@TYPE", type);
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch(Exception e)
            {
                Console.WriteLine("         DATA NOT ENTERED");
                Console.WriteLine(e);
            }

        }
        public void display_myBankDB(int id)
        {
            try
            {
                con.Open();
                String display_query = "SELECT * FROM account WHERE ID=" + id;
                SqlCommand cmd = new SqlCommand(display_query, con);
                SqlDataReader myDataReader = cmd.ExecuteReader();
                while (myDataReader.Read())
                {
                    Console.Write("\n       --> USER ID : " + myDataReader.GetValue(0));
                    Console.Write("\n       --> USER NAME : " + myDataReader.GetValue(1));
                    Console.Write("\n       --> USER BALANCE : " + myDataReader.GetValue(2));
                    Console.Write("\n       --> USER TYPE : " + myDataReader.GetValue(3));
                    Console.WriteLine();
                }
                con.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("ERROR!!!");
                Console.WriteLine(e);
            }
        }
        public void deposite_myBankDb(int account_no,int amount)
        {
            try
            {
                con.Open();
                String deposite_query = "UPDATE account SET BALANCE=BALANCE+ " + amount + " where ID=" + account_no;
                SqlCommand cmd = new SqlCommand(deposite_query, con);
                SqlDataReader myDataReader = cmd.ExecuteReader();
                while(myDataReader.Read())
                {
                    Console.Write("\n CURRENT BALANCE : " + myDataReader.GetValue(2));

                }
            }
            catch(Exception e)
            {
                Console.WriteLine("ERROR!!!");
                Console.WriteLine(e);

            }
        }
        public void withdraw_myBankDB(int account_no, int amount)
        {
            try
            {
                con.Open();
                String withdraw_query = "UPDATE account SET BALANCE=BALANCE- " + amount + " where ID=" + account_no;
                SqlCommand cmd = new SqlCommand(withdraw_query, con);
                SqlDataReader myDataReader = cmd.ExecuteReader();
                while (myDataReader.Read())
                {
                    if((int)myDataReader.GetValue(2)<1000)
                    {
                        Console.WriteLine("AMMOUNT LESS THAN 1000. \n DEPOSITE AMMOUNT!!!!!");
                    }
                    else
                    {
                        Console.Write("\n CURRENT BALANCE : " + myDataReader.GetValue(2));
                    }
                    

                }
            }
            catch(Exception e)
            {
                Console.WriteLine("ERROR!!!");
                Console.WriteLine(e);

            }

        }

        public void calculate_interest(int id,int type)
        {
            try
            {
                con.Open();
                String display_query = "SELECT * FROM account WHERE ID=" + id;
                SqlCommand cmd = new SqlCommand(display_query, con);
                SqlDataReader myDataReader = cmd.ExecuteReader();
                if (myDataReader.Read())
                {
                    if (type == 1)
                    {

                        Console.Write("\nCURRENT INTEREST : " + (0.01 * (int)myDataReader.GetValue(2)));
                    }
                    else if (type == 2)
                    {
                        Console.Write("\nCURRENT INTEREST : " + (0.04 * (int)myDataReader.GetValue(2)));
                    }
                    else if (type == 3)
                    {
                        Console.WriteLine("INTEREST : 0");

                    }
                }
                con.Close();
            }
            catch(Exception e)
            {
                Console.WriteLine("ERROR!!!");
                Console.WriteLine(e);
            }
        }
    }
}
