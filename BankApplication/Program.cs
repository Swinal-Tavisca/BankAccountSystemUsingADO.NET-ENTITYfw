
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using MyDatabaseLibrary;
using BankApplication;


namespace BankApplication
{
    class Program
    {
        public static int index = 0;

        public void NewAccountDetails(int method)
        {
            
            Class1 my_ADO_object = new Class1();
            EntityClass my_ENTITY_object = new EntityClass();
            
            Console.WriteLine("                 NEW ACCOUNT");
            Console.WriteLine();

            Console.Write("       --> ENTER NAME : ");
            String name = Console.ReadLine();

            Console.Write("       --> ENTER ID : ");
            int id = int.Parse(Console.ReadLine());

            Console.Write("       --> ENTER BALANCE : ");
            int balance = int.Parse(Console.ReadLine());

            Console.Write("       --> ACCOUNT TYPE : 1. CURRENT  2. SAVING  3. DMAT ");
            String type = Console.ReadLine();
            Console.WriteLine();

            if(method==1)
            {
                my_ADO_object.insert_into_myBankDB(id, name, balance, type);

            }
            if(method==2)
            {
                my_ENTITY_object.insert_into_myBankDB(id, name, balance, type);
            }
                
           
            
        }
        public void view_details(int method)
        {
            Console.WriteLine();
            Console.Write("        --> ENTER YOUR ID : ");
            int id = int.Parse(Console.ReadLine());
            Class1 view_details_object = new Class1();
            EntityClass my_ENTITY_object = new EntityClass();
            if(method==1)
            {
                view_details_object.display_myBankDB(id);
            }
            if(method==2)
            {
                my_ENTITY_object.display_myBankDB(id);
            }
            
        }
        public void deposite_money(int method)
        {
            Console.WriteLine();
            Console.Write("        --> ENTER ACCOUNT NUMBER : ");
            int account_no = int.Parse(Console.ReadLine());
            Console.Write("        --> ENTER AMOUNT TO BE DEPOSITE : ");
            int amount = int.Parse(Console.ReadLine());
            if(method==1)
            {
                Class1 deposite_money_object = new Class1();
                deposite_money_object.deposite_myBankDb(account_no, amount);
            }
            if(method==2)
            {
                EntityClass my_ENTITY_object = new EntityClass();
                my_ENTITY_object.deposite_myBankDb(account_no, amount);
            }
            
        }
        public void withdraw_money(int method)
        {
            Console.WriteLine();
            Console.Write("        --> ENTER ACCOUNT NUMBER : ");
            int account_no = int.Parse(Console.ReadLine());
            Console.Write("        --> ENTER AMOUNT TO BE WITHDRAW : ");
            int amount = int.Parse(Console.ReadLine());
            if(method==1)
            {
                Class1 deposite_money_object = new Class1();
                deposite_money_object.withdraw_myBankDB(account_no, amount);
            }
            if(method==2)
            {
                EntityClass my_ENTITY_object = new EntityClass();
                my_ENTITY_object.withdraw_myBankDB(account_no, amount);
            }
            
        }
        public void interest_amount(int method)
        {
            Console.WriteLine();
            Console.Write("        --> ENTER ACCOUNT NUMBER : ");
            int account_no = int.Parse(Console.ReadLine());
            Console.Write("        --> ENTER YOUR ACCOUNT TYPE : ");
            Console.Write("        --> 1. CURRENT 2. SAVINGS 3. DMAT  ");
            int option = int.Parse(Console.ReadLine());

            if (method == 1)
            {
                Class1 interest_amount_object = new Class1();
                interest_amount_object.calculate_interest(account_no, option);
            }
            if(method == 2)
            {
                Class1 interest_amount_object = new Class1();
                interest_amount_object.calculate_interest(account_no, option);
            }
           
            
            

        }
        public void use_existing_account(int method)
        {
            int flag = 0;
            do
            {
                Console.WriteLine();
                Console.WriteLine("               OLD ACCOUNTS");
                Console.WriteLine();
                Console.WriteLine("        --> 1. VIEW DETAILS");
                Console.WriteLine("        --> 2. DEPOSITE MONEY");
                Console.WriteLine("        --> 3. WITHDRAW MONEY");
                Console.WriteLine("        --> 4. CALCULATE INTEREST");
                Console.WriteLine("        --> 5. EXIT TO MAIN MENU");

                int option = int.Parse(Console.ReadLine());
                if(option==1)
                {
                    Program view_details_obect = new Program();
                    view_details_obect.view_details(method);

                }
                else if(option==2)
                {
                    Program deposite_money_object = new Program();
                    deposite_money_object.deposite_money(method);
                }
                else if(option==3)
                {
                    Program withdraw_money_object = new Program();
                    withdraw_money_object.withdraw_money(method);
                }
                else if(option==4)
                {
                    Program interest = new Program();
                    interest.interest_amount(method);

                }
                else if(option==5)
                {
                    flag = 1;
                }

            } while (flag == 0);

            

        }
     

        static void Main(string[] args)
        {
            
            int flag = 0;
            Console.WriteLine("        ENTER METHOD TO BE USED");
            Console.WriteLine("    --> 1. ADO.NET");
            Console.WriteLine("    --> 2. ENTITY FRAMEWORK");
            Console.WriteLine();

            int method = int.Parse(Console.ReadLine());

            do
            {
                    
                    Console.WriteLine("        BANK MANAGER");
                    Console.WriteLine("    --> 1. ADD ACCOUNT");
                    Console.WriteLine("    --> 2. USE EXISTING");
                    Console.WriteLine("    --> 3. EXIT");
                    int option = int.Parse(Console.ReadLine());
                    if (option == 1)
                    {
                        Program new_account = new Program();
                        new_account.NewAccountDetails(method);

                    }
                    else if (option == 2)
                    {
                        Program use_existing_account_object = new Program();
                        use_existing_account_object.use_existing_account(method);

                    }
                    else if (option == 3)
                    {
                        flag = 1;
                    }

                } while (flag == 0);
            Console.ReadKey();
        }

           


            
        
    }
}
