using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media.Imaging;
using Wisdom.WPF_Pure.Commands;
using Wisdom.WPF_Pure.DataTable;
using Wisdom.WPF_Pure.Globals.Compnents;
using Wisdom.WPF_Pure.Models;
using Wisdom.WPF_Pure.Systems;

namespace Wisdom.WPF_Pure
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public App()
        {
            CustomApplication customApplication = new CustomApplication();
            //MainWindow.Icon = BitmapFrame.Create(new Uri("pack://application:,,,/Resources/Icons//bitbug_favicon.ico", UriKind.RelativeOrAbsolute));

            //初始化DI实列；
            IServiceCollection services = customApplication.Services;
            services.AddTransient<ISystemSetTableProvider, SystemSetTableProvider>();
            services.AddTransient(typeof(ShowMessageCommand));
            //services.AddTransient(typeof(ISystemSetTableProvider), typeof(SystemSetTableProvider));
            //services.AddScoped<ISystemSetTableProvider, SystemSetTableProvider>();
            //services.AddSingleton<ISystemSetTableProvider, SystemSetTableProvider>();
            //services.AddSingleton(sp =>{
            //    return new SystemSetTableProvider();
            //});
            //services.AddSingleton<ISystemSetTableProvider>(new SystemSetTableProvider());//把实列对象加入DI
            ServiceProvider serviceProvider=services.BuildServiceProvider();
            CustomApplication.ServicesProvider = serviceProvider;
            services.AddSingleton<IServiceProvider>(serviceProvider);

            

        }
    }
}
