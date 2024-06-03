using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using Wisdom.WPF_Pure.DataTable;
using Wisdom.WPF_Pure.Globals.Compnents;
using Wisdom.WPF_Pure.Models;

namespace Wisdom.WPF_Pure.Systems
{
    /// <summary>
    /// SystemSet.xaml 的交互逻辑
    /// </summary>
    public partial class SystemSet : Window
    {
        private ISystemSetTableProvider _systemSetTableProvider;
        private ShortcutsAutoStart _shortcutsAutoStart;
        public SystemSet()
        {
            InitializeComponent();
            _systemSetTableProvider = CustomApplication.ServicesProvider.GetRequiredService<ISystemSetTableProvider>();
            this.DataContext = _systemSetTableProvider._tableModel;
            _shortcutsAutoStart = new ShortcutsAutoStart();
        }

        private void Button_Ok_Click(object sender, RoutedEventArgs e)
        {
            TableModel<SystemSetModel> tm = (TableModel<SystemSetModel>)this.DataContext;
            //_systemSetTableProvider._configuration["Data[0].IsAutoStart"] = tm.Data[0].IsAutoStart.ToString();
            //var ttt = _systemSetTableProvider._configuration["Data[0].IsAutoStart"];
            //_systemSetTableProvider._configuration.Save();
            //_systemSetTableProvider._configurationBuilder.GetFileProvider().GetFileInfo("");
            //System.IO.File.WriteAllText(filePath, result);
            if (tm.Data[0].IsAutoStart)
            {
                _shortcutsAutoStart.SetMeAutoStart(true,"SXYDT","陕西意达通");
            }
            else {
                _shortcutsAutoStart.SetMeAutoStart(false,"SXYDT", "陕西意达通");
            }
        }
    }
}
