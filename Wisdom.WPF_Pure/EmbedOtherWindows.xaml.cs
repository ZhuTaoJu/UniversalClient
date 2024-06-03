using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Interop;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Wisdom.WPF_Pure
{
    /// <summary>
    /// EmbedOtherWindows.xaml 的交互逻辑
    /// </summary>
    public partial class EmbedOtherWindows : Window
    {
        [DllImport("user32.dll", SetLastError = true)]
        public static extern long SetParent(IntPtr hWndChild, IntPtr hWndNewParent);

        [DllImport("user32.dll", SetLastError = true)]
        public static extern bool MoveWindow(IntPtr hwnd, int x, int y, int cx, int cy, bool repaint);


        [DllImport("user32.dll", EntryPoint = "GetWindowLongA", SetLastError = true)]
        private static extern int GetWindowLong(IntPtr hwnd, int nIndex);

        [DllImport("user32.dll", EntryPoint = "SetWindowLongA", SetLastError = true)]
        private static extern int SetWindowLong(IntPtr hwnd, int nIndex, int dwNewLong);

        /// <summary>
        /// GetWindowLong中表示获得窗口样式
        /// SetWindowLong中表示设定一个新的窗口风格。
        /// </summary>
        const int GWL_STYLE = (-16);
        /// <summary>
        /// 窗口具有标题栏
        /// </summary>
        const int WS_CAPTION = 0x00C00000;
        /// <summary>
        /// 窗口具有调整大小边框。
        /// </summary>
        const int WS_THICKFRAME = 0x00040000;

        public EmbedOtherWindows()
        {
            InitializeComponent();
        }

        private void Button_Mspaint_Click(object sender, RoutedEventArgs e)
        {
        }

    }

}
