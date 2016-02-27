using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SparkEditor.FiestaLib.Shine
{
    public class ShineTable : DataTable
    {
        public List<string> ColumnTypes = new List<string>();

        public int ColumnCount { get { return Columns.Count; } }
        public int RowCount { get { return Rows.Count; } }

        public ShineTable(string TableName)
        {
            this.TableName = TableName;
        }
    }
}
