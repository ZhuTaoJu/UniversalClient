using Hardcodet.Wpf.TaskbarNotification;
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

namespace Wisdom.WPF_Pure
{
    /// <summary>
    /// NotifyIconCodeAndXaml.xaml 的交互逻辑
    /// </summary>
    public partial class NotifyIconCodeAndXaml : Window
    {
        private TaskbarIcon _tb;
        public NotifyIconCodeAndXaml()
        {
            InitializeComponent();
            _tb = (TaskbarIcon)FindResource("MyNotifyIcon");
        }
    }
}
