using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wisdom.WPF_Pure.Globals.Compnents
{
    public class CustomApplication
    {
        public  IServiceCollection Services { get; set; }
        public static  IServiceProvider ServicesProvider { get; set; }
        
        public CustomApplication() {
            this.Services = new ServiceCollection();
        }

    }
}
