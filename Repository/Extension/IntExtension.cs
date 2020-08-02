using System.Collections.Generic;
using System.Data;

namespace Repository.Extension
{
    public static class IntExtension
    {
        public static DataTable ToDataTable(this IEnumerable<int> values)
        {
            var dataTable = new DataTable();

            dataTable.Columns.Add(new DataColumn("id", typeof(int)));

            foreach (int value in values)
            {
                var row = dataTable.NewRow();
                row["id"] = value;
                dataTable.Rows.Add(row);
            }

            return dataTable;
        }
    }
}
