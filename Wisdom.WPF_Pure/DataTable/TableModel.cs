using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wisdom.WPF_Pure.Models;

namespace Wisdom.WPF_Pure.DataTable
{
    public class TableModel<T>
    {
        public List<T>?  Data { get; set; }
        public List<TableField>?   field { get; set; }
    }

}
