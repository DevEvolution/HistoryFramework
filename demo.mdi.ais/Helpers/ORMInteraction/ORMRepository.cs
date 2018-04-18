using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo.mdi.ais.Helpers.ORMInteraction
{
    public static class ORMRepository
    {
        private static readonly string connectionString = "Provider=Microsoft.Ace.OLEDB.12.0;" + @"Data Source=ais.db.accdb";
        public static OleDbConnection connection = new OleDbConnection(connectionString);

        public static ORMList Accounts { get; private set; } = new ORMList(connection, "Accounts");
        public static ORMList Salts { get; private set; } = new ORMList(connection, "Salts");


    }
}
