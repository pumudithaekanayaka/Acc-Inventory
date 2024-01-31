using System;
using System.Windows.Forms;

namespace Acc_Inventory
{
    internal static class Program
    {
        [STAThread]
        private static void Main()
        {
            DatabaseManager dbManager = new DatabaseManager();

            ShowDatabaseConnectionForm(dbManager);

            Application.Run(new Login(dbManager));
        }

        private static void ShowDatabaseConnectionForm(DatabaseManager dbManager)
        {
            using (DatabaseConnection databaseConnection = new DatabaseConnection(dbManager, true))
            {
                if (databaseConnection.ShowDialog() == DialogResult.OK)
                {
                    Properties.Settings.Default.ServerName = databaseConnection.ServerName;
                    Properties.Settings.Default.DatabaseName = databaseConnection.DatabaseName;
                    Properties.Settings.Default.Save();

                    Application.Run(new ConfigForm(new DatabaseManager(databaseConnection.ConnectionString)));
                }
                else
                {
                    Application.Exit();
                }
            }
        }
    }
}
