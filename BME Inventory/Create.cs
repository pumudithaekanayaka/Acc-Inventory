using System.Data.SqlClient;
using System.IO;
using System.Runtime.InteropServices;

namespace Acc_Inventory
{
    public partial class Create : Form
    {
        private DatabaseManager dbManager;

        public Create(DatabaseManager databaseManager)
        {
            InitializeComponent();
            dbManager = databaseManager;
            this.AutoScaleMode = AutoScaleMode.Dpi;
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private static void ClearTextBoxes(Control control)
        {
            foreach (Control c in control.Controls)
            {
                if (c is TextBox)
                {
                    ((TextBox)c).Clear();
                }
                else
                {
                    ClearTextBoxes(c);
                }
            }
        }

        private void save_btn_Click(object sender, EventArgs e)
        {
            try
            {
                dbManager.OpenConnection();

                string PageNo = page_no_txt.Text;
                string ItemCategory = item_cat_txt.Text;
                string ItemName = item_name_txt.Text;
                string upper = upper_txt.Text;
                string lower = lower_txt.Text;
                string stock = stock_txt.Text;

                if (string.IsNullOrEmpty(PageNo) || string.IsNullOrEmpty(ItemName) || string.IsNullOrEmpty(ItemCategory) || string.IsNullOrEmpty(upper) || string.IsNullOrEmpty(lower) || string.IsNullOrEmpty(stock))
                {
                    return;
                }

                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = dbManager.GetConnection();
                    cmd.CommandText = "INSERT INTO inventory(page_no, item_name, item_cat, upper, lower, stock, date) " +
                        "VALUES(@page_no, @item_name, @item_cat, @upper, @lower, @stock, GETDATE())";

                    cmd.Parameters.AddWithValue("@page_no", page_no_txt.Text);
                    cmd.Parameters.AddWithValue("@item_cat", item_cat_txt.Text);
                    cmd.Parameters.AddWithValue("@item_name", item_name_txt.Text);
                    cmd.Parameters.AddWithValue("@upper", upper_txt.Text);
                    cmd.Parameters.AddWithValue("@lower", lower_txt.Text);
                    cmd.Parameters.AddWithValue("@stock", stock_txt.Text);

                    cmd.ExecuteNonQuery();
                }

                ClearTextBoxes(this);
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