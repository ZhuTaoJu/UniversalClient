using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Wisdom.WPF_Pure.Globals.Compnents;
using Wisdom.WPF_Pure.Models;

namespace Wisdom.WPF_Pure.DataTable
{
    public class SystemSetTableProvider: ISystemSetTableProvider
    {
        public TableModel<SystemSetModel> _tableModel { get; set; }
        public IConfigurationBuilder? _configurationBuilder { get; set; }
        public IConfigurationProvider _configurationProvider { get; set; }
        public SystemSetTableProvider() {
            //_tableModel  = ConfigHelper.Get<TableModel<SystemSetModel>>("SystemSet", path : "DataTable");
            _configurationBuilder = new ConfigurationBuilder();
            _tableModel = ConfigHelper.Get<TableModel<SystemSetModel>>("SystemSet", path: "DataTable");

        }

    }
}
