using demo.mdi.ais.Helpers.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo.mdi.ais.Helpers.ORMInteraction
{
    public class ORMList
    {
        DataTable table;
        OleDbDataAdapter adapter;

        List<ORMBaseModel> list = new List<ORMBaseModel>();

        public ORMList(OleDbConnection connection, string tableName)
        {
            adapter = new OleDbDataAdapter($"SELECT * FROM {tableName}", connection);
            table = new DataTable();
            adapter.Fill(table);
        }

        public void Add(ORMBaseModel item)
        {
            //            item.Row = table.NewRow();
            table.Rows.Add(item.Row);
            list.Add(item);
            OleDbCommandBuilder builder = new OleDbCommandBuilder(adapter);
            adapter.Update(table);

            table.Clear();
            adapter.Fill(table);
        }

        public void Remove(ORMBaseModel item)
        {
            list.Remove(item);
            adapter.Update(table);
        }

        public ORMBaseModel this[int index]
        {
            get => list[index];
            set { list[index] = value; adapter.Update(table); }
        }

        public List<ORMBaseModel> ToList()
            => list;

        public DataRow GetNewRow()
            => table.NewRow();
    }
}
