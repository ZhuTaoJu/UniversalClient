using Hardcodet.Wpf.TaskbarNotification;
using System;
using System.Collections.Generic;
using System.Drawing;
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
    /// NotifyIcon.xaml 的交互逻辑
    /// </summary>
    public partial class NotifyIcon : Window
    {
        public NotifyIcon()
        {
            InitializeComponent();
            //CodeAchieve();
        }

        /// <summary>
        /// 代码方式实现通知栏托标；
        /// </summary>
        public void CodeAchieve() {
            TaskbarIcon tbi = new TaskbarIcon();
            tbi.Icon = new Icon("bitbug_favicon.ico");
            //tbi.Icon = new Icon("logo.png");
            tbi.ToolTipText = "hello world";
        }

    }
}
