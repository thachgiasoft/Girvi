using System;
using System.Collections.Generic;
using System.Text;

namespace JewelleryManagement.Common.Sql
{
    public class IndexSchema
    {
        public string IndexName;

        public bool IsUnique;

        public List<IndexColumn> Columns;
    }

    public class IndexColumn
    {
        public string ColumnName;
        public bool IsAscending;
    }
}
