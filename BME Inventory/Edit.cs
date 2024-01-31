using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Globalization;

namespace Acc_Inventory
{
    public partial class Edit : Form
    {
        private DatabaseManager dbManager;

        public Edit(DatabaseManager databaseManager)
        {
            InitializeComponent();
            dbManager = databaseManager;
            this.AutoScaleMode = AutoScaleMode.Dpi;
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
        }

        private void load_btn_Click(object sender, EventArgs e)
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
                            item_name_txt.Text = reader.GetString(1);
                            item_cat_txt.Text = reader.GetString(2);
                            upper_lbl_edit.Text = reader.GetDecimal(3).ToString(CultureInfo.InvariantCulture);
                            lower_lbl_edit.Text = reader.GetDecimal(4).ToString(CultureInfo.InvariantCulture);
                            stock_lbl.Text = reader.GetDecimal(5).ToString(CultureInfo.InvariantCulture);

                            decimal stockValue;
                            if (decimal.TryParse(stock_lbl.Text, out stockValue) && decimal.TryParse(lower_lbl_edit.Text, out decimal lowerValue))
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

        private void update_btn_Click(object sender, EventArgs e)
        {
            try
            {
                dbManager.OpenConnection();

                string query = "UPDATE inventory SET item_name = @item_name, item_cat = @item_cat, stock = @stock WHERE page_no = @page_no";
                using (SqlCommand cmd = new SqlCommand(query, dbManager.GetConnection()))
                {
                    cmd.Parameters.AddWithValue("@page_no", page_no_txt.Text);
                    cmd.Parameters.AddWithValue("@item_name", item_name_txt.Text);
                    cmd.Parameters.AddWithValue("@item_cat", item_cat_txt.Text);
                    cmd.Parameters.AddWithValue("@stock", stock_txt1.Text);
                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Record updated successfully!");
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

        private void delete_btn_Click(object sender, EventArgs e)
        {
            try
            {
                dbManager.OpenConnection();

                string query = "DELETE FROM inventory WHERE page_no = @page_no";
                using (SqlCommand cmd = new SqlCommand(query, dbManager.GetConnection()))
                {
                    cmd.Parameters.AddWithValue("@page_no", page_no_txt.Text);

                    DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete this record?", "Confirmation", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Record deleted successfully!");
                        }
                        else
                        {
                            MessageBox.Show("Record not found!");
                        }
                    }
                    else if (dialogResult == DialogResult.No)
                    {
                        Hide();
                        Create form1 = new Create(dbManager);
                        form1.Show();
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
    }
}

