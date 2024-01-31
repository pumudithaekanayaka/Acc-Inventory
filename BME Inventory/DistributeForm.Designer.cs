namespace Acc_Inventory
{
    partial class DistributeForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DistributeForm));
            label9 = new Label();
            stock_txt = new TextBox();
            stock_lbl = new Label();
            page_no_txt = new TextBox();
            item_cat_lbl = new Label();
            item_name_lbl = new Label();
            load_btn = new Button();
            update_btn = new Button();
            lower_lbl = new Label();
            upper_lbl = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label10 = new Label();
            user_lbl_recieve = new Label();
            SuspendLayout();
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(488, 230);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(78, 21);
            label9.TabIndex = 68;
            label9.Text = "Quantity";
            // 
            // stock_txt
            // 
            stock_txt.BorderStyle = BorderStyle.FixedSingle;
            stock_txt.Location = new Point(418, 265);
            stock_txt.Margin = new Padding(4, 5, 4, 5);
            stock_txt.Name = "stock_txt";
            stock_txt.Size = new Size(300, 29);
            stock_txt.TabIndex = 66;
            // 
            // stock_lbl
            // 
            stock_lbl.AutoSize = true;
            stock_lbl.Location = new Point(278, 265);
            stock_lbl.Margin = new Padding(4, 0, 4, 0);
            stock_lbl.Name = "stock_lbl";
            stock_lbl.Size = new Size(126, 21);
            stock_lbl.TabIndex = 65;
            stock_lbl.Text = "Stock Available";
            // 
            // page_no_txt
            // 
            page_no_txt.BorderStyle = BorderStyle.FixedSingle;
            page_no_txt.Location = new Point(278, 19);
            page_no_txt.Margin = new Padding(4, 5, 4, 5);
            page_no_txt.Name = "page_no_txt";
            page_no_txt.Size = new Size(300, 29);
            page_no_txt.TabIndex = 64;
            // 
            // item_cat_lbl
            // 
            item_cat_lbl.AutoSize = true;
            item_cat_lbl.Location = new Point(278, 119);
            item_cat_lbl.Margin = new Padding(4, 0, 4, 0);
            item_cat_lbl.Name = "item_cat_lbl";
            item_cat_lbl.Size = new Size(122, 21);
            item_cat_lbl.TabIndex = 62;
            item_cat_lbl.Text = "Item Category";
            // 
            // item_name_lbl
            // 
            item_name_lbl.AutoSize = true;
            item_name_lbl.Location = new Point(278, 69);
            item_name_lbl.Margin = new Padding(4, 0, 4, 0);
            item_name_lbl.Name = "item_name_lbl";
            item_name_lbl.Size = new Size(95, 21);
            item_name_lbl.TabIndex = 61;
            item_name_lbl.Text = "Item Name";
            // 
            // load_btn
            // 
            load_btn.BackColor = Color.Crimson;
            load_btn.FlatAppearance.BorderSize = 0;
            load_btn.FlatStyle = FlatStyle.Flat;
            load_btn.Location = new Point(588, 19);
            load_btn.Margin = new Padding(4, 5, 4, 5);
            load_btn.Name = "load_btn";
            load_btn.Size = new Size(120, 35);
            load_btn.TabIndex = 60;
            load_btn.Text = "Load";
            load_btn.UseVisualStyleBackColor = false;
            load_btn.Click += load_btn3_Click;
            // 
            // update_btn
            // 
            update_btn.BackColor = Color.Crimson;
            update_btn.FlatAppearance.BorderSize = 0;
            update_btn.FlatStyle = FlatStyle.Flat;
            update_btn.Location = new Point(738, 265);
            update_btn.Margin = new Padding(4, 5, 4, 5);
            update_btn.Name = "update_btn";
            update_btn.Size = new Size(92, 38);
            update_btn.TabIndex = 59;
            update_btn.Text = "Update";
            update_btn.UseVisualStyleBackColor = false;
            update_btn.Click += update_btn3_Click_1;
            // 
            // lower_lbl
            // 
            lower_lbl.AutoSize = true;
            lower_lbl.Location = new Point(278, 215);
            lower_lbl.Margin = new Padding(4, 0, 4, 0);
            lower_lbl.Name = "lower_lbl";
            lower_lbl.Size = new Size(100, 21);
            lower_lbl.TabIndex = 58;
            lower_lbl.Text = "Lower Limit";
            // 
            // upper_lbl
            // 
            upper_lbl.AutoSize = true;
            upper_lbl.Location = new Point(278, 165);
            upper_lbl.Margin = new Padding(4, 0, 4, 0);
            upper_lbl.Name = "upper_lbl";
            upper_lbl.Size = new Size(99, 21);
            upper_lbl.TabIndex = 57;
            upper_lbl.Text = "Upper Limit";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(10, 265);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(117, 21);
            label6.TabIndex = 52;
            label6.Text = "Current Stock";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(10, 215);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(100, 21);
            label5.TabIndex = 51;
            label5.Text = "Lower Limit";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(10, 165);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(99, 21);
            label4.TabIndex = 50;
            label4.Text = "Upper Limit";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(10, 119);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(122, 21);
            label3.TabIndex = 49;
            label3.Text = "Item Category";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(10, 69);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(95, 21);
            label2.TabIndex = 48;
            label2.Text = "Item Name";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(10, 19);
            label10.Margin = new Padding(4, 0, 4, 0);
            label10.Name = "label10";
            label10.Size = new Size(75, 21);
            label10.TabIndex = 47;
            label10.Text = "Page No";
            // 
            // user_lbl_recieve
            // 
            user_lbl_recieve.AutoSize = true;
            user_lbl_recieve.Location = new Point(311, 634);
            user_lbl_recieve.Margin = new Padding(4, 0, 4, 0);
            user_lbl_recieve.Name = "user_lbl_recieve";
            user_lbl_recieve.Size = new Size(89, 21);
            user_lbl_recieve.TabIndex = 79;
            user_lbl_recieve.Text = "Username";
            user_lbl_recieve.Visible = false;
            // 
            // DistributeForm
            // 
            AutoScaleDimensions = new SizeF(120F, 120F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.White;
            ClientSize = new Size(850, 351);
            Controls.Add(page_no_txt);
            Controls.Add(user_lbl_recieve);
            Controls.Add(load_btn);
            Controls.Add(label3);
            Controls.Add(update_btn);
            Controls.Add(stock_txt);
            Controls.Add(item_name_lbl);
            Controls.Add(label9);
            Controls.Add(label4);
            Controls.Add(lower_lbl);
            Controls.Add(label2);
            Controls.Add(item_cat_lbl);
            Controls.Add(stock_lbl);
            Controls.Add(label5);
            Controls.Add(upper_lbl);
            Controls.Add(label10);
            Controls.Add(label6);
            Font = new Font("Google Sans", 10.2F);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            Name = "DistributeForm";
            Text = "Received Items";
            WindowState = FormWindowState.Maximized;
            Load += Recieve_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label9;
        private TextBox stock_txt;
        private Label stock_lbl;
        private TextBox page_no_txt;
        private Label item_cat_lbl;
        private Label item_name_lbl;
        private Button load_btn;
        private Button update_btn;
        private Label lower_lbl;
        private Label upper_lbl;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label10;
        private Label user_lbl_recieve;
    }
}