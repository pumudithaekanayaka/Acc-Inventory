using System.Data.SqlClient;
using System.IO;
using System.Globalization;

namespace Acc_Inventory
{
    public partial class DistributeForm : Form
    {
        private DatabaseManager dbManager;

        public DistributeForm(DatabaseManager databaseManager)
        {
            InitializeComponent();
            dbManager = databaseManager;
            this.AutoScaleMode = AutoScaleMode.Dpi;
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
        }

        private static void LogChanges(string logMessage)
        {
            string documentsFolder = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string logFolderPath = Path.Combine(documentsFolder, "Inventory Logs/Received Logs");
            string logFilePath = Path.Combine(logFolderPath, $"Received_log_{DateTime.Now:yyyyMMdd}.txt");
            int maxRows = 100;
            List<string> logLines = new List<string>();

            if (File.Exists(logFilePath))
            {
                using (StreamReader reader = new StreamReader(logFilePath))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        logLines.Add(line);
                    }
                }
            }

            using (StreamWriter writer = new StreamWriter(logFilePath, true))
            {
                writer.WriteLine(logMessage);
            }

            if (logLines.Count > maxRows)
            {
                File.WriteAllLines(logFilePath, logLines.Skip(logLines.Count - maxRows));
            }
        }

        private void update_btn3_Click_1(object sender, EventArgs e)
        {
            try
            {
                dbManager.OpenConnection();

                string query = "UPDATE inventory SET stock = stock + @stock5 WHERE page_no = @page_no";
                using (SqlCommand cmd = new SqlCommand(query, dbManager.GetConnection()))
                {
                    cmd.Parameters.AddWithValue("@part_id", page_no_txt.Text);

                    decimal stockValue = 0;
                    if (decimal.TryParse(stock_txt.Text, out stockValue))
                    {
                        cmd.Parameters.AddWithValue("@stock", stockValue);

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            string logMessage = $"{user_lbl_recieve.Text} updated record with part ID {page_no_txt.Text} successfully with a increase of {stockValue} from the stock value of {stock_lbl.Text} at {DateTime.Now}";
                            LogChanges(logMessage);

                            string distributionQuery = "INSERT INTO received (page_no, item_name, add_by, add_quantity, date) VALUES (@page_no, @item_name, @add_by, @add_quantity, @date)";
                            using (SqlCommand distributionCmd = new SqlCommand(distributionQuery, dbManager.GetConnection()))
                            {
                                distributionCmd.Parameters.AddWithValue("@page_no", page_no_txt.Text);
                                distributionCmd.Parameters.AddWithValue("@item_name", item_cat_lbl.Text);
                                distributionCmd.Parameters.AddWithValue("@add_by", user_lbl_recieve.Text);
                                distributionCmd.Parameters.AddWithValue("@add_quantity", stockValue);
                                distributionCmd.Parameters.AddWithValue("@date", DateTime.Now);

                                int distributionRowsAffected = distributionCmd.ExecuteNonQuery();

                                if (distributionRowsAffected > 0)
                                {
                                    MessageBox.Show("Data recieved and logged successfully!");
                                    stock_txt.Text = "";
                                    stock_lbl.Text = (decimal.Parse(stock_lbl.Text, CultureInfo.InvariantCulture) + stockValue).ToString(CultureInfo.InvariantCulture);
                                }
                                else
                                {
                                    MessageBox.Show("Failed to log recieve data!");
                                }
                            }
                        }
                        else
                        {
                            MessageBox.Show("Record not found!");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Invalid input for stock value!");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                dbManager.CloseConnection();
            }
        }

        private void load_btn3_Click(object sender, EventArgs e)
        {
            try
            {
                dbManager.OpenConnection();

                string query = "SELECT * FROM inventory WHERE page_no LIKE '%' + @page_no + '%'";
                using (SqlCommand cmd = new SqlCommand(query, dbManager.GetConnection()))
                {
                    cmd.Parameters.AddWithValue("@page_no", page_no_txt.Text);
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            item_name_lbl.Text = reader.GetString(1);
                            item_cat_lbl.Text = reader.GetString(2);
                            upper_lbl.Text = reader.GetDecimal(3).ToString(CultureInfo.InvariantCulture);
                            lower_lbl.Text = reader.GetDecimal(4).ToString(CultureInfo.InvariantCulture);
                            stock_lbl.Text = reader.GetDecimal(5).ToString(CultureInfo.InvariantCulture);

                            decimal stockValue;
                            if (decimal.TryParse(stock_lbl.Text, out stockValue) && decimal.TryParse(lower_lbl.Text, out decimal lowerValue))
                            {
                                if (stockValue < lowerValue)
                                {
                                    MessageBox.Show("Stock value is less than lower limit!");
                                }
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Record not found!");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                dbManager.CloseConnection();
            }
        }

        private void Recieve_Load(object sender, EventArgs e)
        {
            string username = CurrentUser.Username;

            if (username != null)
            {
                user_lbl_recieve.Text = $"{username}";
            }
            else
            {
                user_lbl_recieve.Text = $"Unable to retrieve username.";
            }
        }
    }
}
