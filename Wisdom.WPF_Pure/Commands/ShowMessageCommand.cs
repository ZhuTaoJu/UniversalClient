using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using Wisdom.WPF_Pure.Globals.Compnents;
using Wisdom.WPF_Pure.Globals.Variables;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Wisdom.WPF_Pure.Commands
{
    public class ShowMessageCommand : ICommand
    {
        public event EventHandler? CanExecuteChanged;
        private readonly IServiceProvider _serviceProvider;

        public ShowMessageCommand() {

            //ActivatorUtilities.CreateInstance<IServiceProvider>(provider, "test");
            //ActivatorUtilities.CreateInstance<IServiceProvider>(CustomApplication.ServicesProvider);
            //ActivatorUtilities.GetServiceOrCreateInstance<IServiceProvider>(provider);
            //var serviceProvider = CustomApplication.ServicesProvider.GetRequiredService<IServiceProvider>();

            _serviceProvider = CustomApplication.ServicesProvider;
        }

        public bool CanExecute(object? parameter)
        {
            return true;
        }

        public void Execute(object? parameter)
        {
            if (MainWindVariable.MainWindow == null)
            {
                MainWindVariable.MainWindow = new ContextMenuWindow();
                MainWindVariable.MainWindow.Show();
            }
            else {
                //MainWindVariable.MainWindow.Show();
                if (MainWindVariable.MainWindow.Visibility == Visibility.Visible)
                {
                    //MainWindVariable.MainWindow.Visibility = Visibility.Hidden;
                }
                else
                {
                    MainWindVariable.MainWindow.Visibility = Visibility.Visible;
                    MainWindVariable.MainWindow.Activate();
                }
                MainWindVariable.MainWindow.WindowState = WindowState.Normal;
            }
        }
    }
}
