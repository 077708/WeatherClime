using Autofac;
using ClimeApp.DataAccess.Repositories;
using ClimeApp.Domain.Contracts;
using ClimeDao.AppCore.Contracts;
using ClimeDao.AppCore.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClimeApp
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            var builder = new ContainerBuilder();

            builder.RegisterType<ClimeModel>().As<IClime>();
            builder.RegisterType<ClimeServices>().As<IClimeServices>();

            var container = builder.Build();

            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1(container.Resolve<IClimeServices>()));
        }
    }
}
