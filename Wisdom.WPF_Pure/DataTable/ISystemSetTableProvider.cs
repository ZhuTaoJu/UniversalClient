using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wisdom.WPF_Pure.Models;

namespace Wisdom.WPF_Pure.DataTable
{
    public interface ISystemSetTableProvider
    {
        public TableModel<SystemSetModel> _tableModel { get; set; }
        public IConfigurationBuilder? _configurationBuilder { get; set; }
    }
}
