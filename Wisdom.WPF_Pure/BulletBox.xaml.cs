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
using System.Windows.Forms;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Wisdom.WPF_Pure
{
    /// <summary>
    /// BulletBox.xaml 的交互逻辑
    /// </summary>
    public partial class BulletBox : Window
    {
        public BulletBox()
        {
            InitializeComponent();
        }

        private void Button_Balloon_Click(object sender, RoutedEventArgs e)
        {
            MyNotifyIcon.ShowBalloonTip("气球提示", "气球提示内容", BalloonIcon.Warning);
        }
    }
}
