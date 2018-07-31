using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
namespace MyDatabaseLibrary
{
    public class EntityClass
    {
        mybankEntities bankObj = new mybankEntities();
        public void insert_into_myBankDB(int id, String name, int balance, String type)
        {
            account acc = new account();
            acc.ID = id;
            acc.NAME = name;
            acc.BALANCE = balance;
            acc.TYPE = type;
            bankObj.accounts.Add(acc);
            bankObj.SaveChanges();
        }
        public void display_myBankDB(int id)
        {
            account acc = new account();
            Console.WriteLine("        --> USER ID : "+bankObj.accounts.Find(id).ID);
            Console.WriteLine("        --> USER NAME : "+ bankObj.accounts.Find(id).NAME);
            Console.WriteLine("        --> USER BALANCE : "+ bankObj.accounts.Find(id).BALANCE);
            Console.WriteLine("        --> USER TYPE : "+ bankObj.accounts.Find(id).TYPE);

        }
        public void deposite_myBankDb(int account_no, int amount)
        {
            account acc = new account();

            var add_val = bankObj.accounts.Find(account_no);
            add_val.BALANCE = add_val.BALANCE + amount;
            
            bankObj.SaveChanges();


        }
        public void withdraw_myBankDB(int account_no, int amount)
        {
            account acc = new account();
            var withdraw_val = bankObj.accounts.Find(account_no);
            withdraw_val.BALANCE = withdraw_val.BALANCE - amount;
            //acc.BALANCE = withdraw_val;
           // bankObj.accounts.Add(acc);
            bankObj.SaveChanges();
        }
        public void calculate_interest(int id, int type)
        {


        }
    }
}

