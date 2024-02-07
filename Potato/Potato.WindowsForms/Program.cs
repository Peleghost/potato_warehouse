using Microsoft.Data.Sqlite;
using Microsoft.Extensions.DependencyInjection;
using Potato.Domain.Repositories;
using Potato.Infrastructure.Persistence.Repositories;
using System.Data;

namespace Potato.WindowsForms
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        ///
        
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            
            // Dependency Injection
            var services = new ServiceCollection();
            services.AddTransient<IArmazemRepository, ArmazemRepository>();
            services.AddTransient<IUserRepository, UserRepository>();
            services.AddTransient<IPecaRepository, PecaRepository>();
            services.AddTransient<IPecaEstoqueRepository, PecaEstoqueRepository>();
            services.AddTransient<IClienteRepository, ClienteRepository>();
            services.AddTransient<IVeiculoRepository, VeiculoRepository>();
            services.AddTransient<IServicoRepository, ServicoRepository>();

            // Inject IDbConnection, with implementation from SqliteConnection class.
            string dbPath = "Data Source=" + Path.Combine(AppDomain.CurrentDomain.BaseDirectory + "Data\\PotatoDB.db");
            services.AddTransient<IDbConnection>((sp) => new SqliteConnection(dbPath));
            
            services.AddTransient<Form1>();
            services.AddTransient<LoginForm>();
            //

            using ServiceProvider serviceProvider = services.BuildServiceProvider();
            var loginForm = serviceProvider.GetRequiredService<LoginForm>();
            var form1 = serviceProvider.GetRequiredService<Form1>();

            var dialogResult = loginForm.ShowDialog();

            if (dialogResult == DialogResult.OK)
            {
                Application.Run(form1);
                loginForm.Close();
            }
            else
            {
                Application.Exit();
            }
        }
    }
}