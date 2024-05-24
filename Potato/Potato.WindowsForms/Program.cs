using Microsoft.Data.Sqlite;
using Microsoft.Extensions.DependencyInjection;
using Potato.Domain.Repositories;
using Potato.Infrastructure.Persistence.Repositories;
using System.Data;
using static System.Environment;

namespace Potato.WindowsForms
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            // Set Application CurrentCulture to Invariant for formatting decimals correctly avoiding issues in DB inserts and queries
            Application.CurrentCulture = System.Globalization.CultureInfo.InvariantCulture;

            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            
            //// Dependency Injection
            var services = new ServiceCollection();
            services.AddTransient<IArmazemRepository, ArmazemRepository>();
            services.AddTransient<IUserRepository, UserRepository>();
            services.AddTransient<IPecaRepository, PecaRepository>();
            services.AddTransient<IPecaEstoqueRepository, PecaEstoqueRepository>();
            services.AddTransient<IClienteRepository, ClienteRepository>();
            services.AddTransient<IVeiculoRepository, VeiculoRepository>();
            services.AddTransient<IServicoRepository, ServicoRepository>();
            

            // Create directory in Special Folder C:\ProgramData for database folder, and copy clean database from install directory \Data to Special Folder
            try
            {
                string appFolder = GetFolderPath(SpecialFolder.CommonApplicationData);
                appFolder = Path.Combine(appFolder, "BatataMotosDb");

                if (!Directory.Exists(appFolder))
                {
                    Directory.CreateDirectory(appFolder);
                }

                string dbPath = Path.Combine(appFolder, "PotatoDB.db");

                if (!File.Exists(dbPath))
                {
                    string dataPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory + "Data\\PotatoDB.db");
                    File.Copy(dataPath, dbPath, true);
                }

                // Inject IDbConnection, with implementation from SqliteConnection class.
                services.AddTransient<IDbConnection>((sp) => new SqliteConnection($"Data Source={dbPath}"));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }

            // ---------- Local Connection ----------
            //
            //string dbPath = "Data Source=" + Path.Combine(AppDomain.CurrentDomain.BaseDirectory + "Data\\PotatoDB.db");
            //services.AddTransient<IDbConnection>((sp) => new SqliteConnection(dbPath));
            //
            // -----------------------------------------------------------------------------------------------------------

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