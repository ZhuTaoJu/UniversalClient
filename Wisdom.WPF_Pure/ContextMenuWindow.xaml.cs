using Hardcodet.Wpf.TaskbarNotification;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using Wisdom.WPF_Pure.Globals.Variables;
using Wisdom.WPF_Pure.Systems;
using Wisdom.WPF_Pure.UserControls;

namespace Wisdom.WPF_Pure
{
    /// <summary>
    /// ContextMenuWindow.xaml 的交互逻辑
    /// </summary>
    public partial class ContextMenuWindow : Window
    {
        public ContextMenuWindow()
        {
            InitializeComponent();
            MainWindVariable.MainWindow = this;
            webView.CoreWebView2InitializationCompleted += WebView_CoreWebView2InitializationCompleted;
            InitializeAsync();

            //Process.Start(new ProcessStartInfo("http://www.wisdomofwisdom.com")
            //{ UseShellExecute = true });
            //System.Diagnostics.Process.Start("http://www.wisdomofwisdom.com");
            //System.Diagnostics.Process.Start("explorer.exe", "http://www.wisdomofwisdom.com");
        }

        private async void InitializeAsync()
        {
            await webView.EnsureCoreWebView2Async(null);
        }

        private void WebView_CoreWebView2InitializationCompleted(object sender, Microsoft.Web.WebView2.Core.CoreWebView2InitializationCompletedEventArgs e)
        {
            // 可以在这里进行更多的设置，例如添加事件处理程序等。
        }

        private void MenuItem_Balloon_Click(object sender, RoutedEventArgs e)
        {
            MyNotifyIcon.ShowBalloonTip("气球提示", "气球提示内容", BalloonIcon.Warning);
        }
        private void Balloon_UserControl_Click(object sender, RoutedEventArgs e)
        {
            BalloonUserControl customBalloon = new BalloonUserControl();
            MyNotifyIcon.ShowCustomBalloon(customBalloon, PopupAnimation.Slide, 2000);
           
        }

        /// <summary>
        /// 窗体状态改变时候触发
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Self_StateChanged(object sender, EventArgs e)
        {
            if (this.WindowState == WindowState.Minimized)
            {
                //this.Visibility = Visibility.Hidden;
            }
        }

        private void exit_Click(object sender, EventArgs e)
        {
            if (System.Windows.MessageBox.Show(this,
                                                "sure to exit?",
                                               "application",
                                                MessageBoxButton.YesNo,
                                                MessageBoxImage.Question,
                                                MessageBoxResult.No) == MessageBoxResult.Yes)
            {
                System.Windows.Application.Current.Shutdown();
            }
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (MainWindVariable.MWCloseHidden) {
                this.Visibility = Visibility.Hidden;
                e.Cancel = true;
            }
        }

        private void ShowWindow_Click(object sender, EventArgs e) {
            this.Show();
            this.WindowState = WindowState.Normal;
        }

        private void HiddenWindow_Click(object sender, EventArgs e) { 
            this.Visibility = Visibility.Hidden;
        }

        private void SystemSet_Click(object sender, EventArgs e)
        {
            SystemSet systemSet = new SystemSet();
            systemSet.Show();
        }

        private void EmbedOtherWindows_Click(object sender, EventArgs e)
        {
            EmbedOtherWindows embedOtherWindows = new EmbedOtherWindows();
            embedOtherWindows.Show();
        }

    }
}
