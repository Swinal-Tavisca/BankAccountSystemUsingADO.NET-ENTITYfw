using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyDatabaseLibrary;

namespace MyEntityClass
{
    public class Class2 : account
    {
        mybankdbEntities my_connection_object = new mybankdbEntities();

        public void insert_into_myBankDB(int id, String name, int balance, String type)
        {
            var test = new account
            {

            };


        }
    }
}
