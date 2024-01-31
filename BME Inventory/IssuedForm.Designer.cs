namespace Acc_Inventory
{
    partial class Distribute
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Distribute));
            lower_lbl = new Label();
            upper_lbl = new Label();
            stock_txt = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            update_btn = new Button();
            load_btn = new Button();
            item_name_lbl = new Label();
            item_cat_lbl = new Label();
            page_no_txt = new TextBox();
            stock_lbl = new Label();
            label8 = new Label();
            user_lbl_distribution = new Label();
            SuspendLayout();
            // 
            // lower_lbl
            // 
            lower_lbl.AutoSize = true;
            lower_lbl.Font = new Font("Google Sans", 10.2F);
            lower_lbl.Location = new Point(158, 214);
            lower_lbl.Margin = new Padding(4, 0, 4, 0);
            lower_lbl.Name = "lower_lbl";
            lower_lbl.Size = new Size(100, 21);
            lower_lbl.TabIndex = 35;
            lower_lbl.Text = "Lower Limit";
            // 
            // upper_lbl
            // 
            upper_lbl.AutoSize = true;
            upper_lbl.Font = new Font("Google Sans", 10.2F);
            upper_lbl.Location = new Point(158, 164);
            upper_lbl.Margin = new Padding(4, 0, 4, 0);
            upper_lbl.Name = "upper_lbl";
            upper_lbl.Size = new Size(99, 21);
            upper_lbl.TabIndex = 34;
            upper_lbl.Text = "Upper Limit";
            // 
            // stock_txt
            // 
            stock_txt.BorderStyle = BorderStyle.FixedSingle;
            stock_txt.Font = new Font("Google Sans", 10.2F);
            stock_txt.Location = new Point(308, 264);
            stock_txt.Margin = new Padding(4, 5, 4, 5);
            stock_txt.Name = "stock_txt";
            stock_txt.Size = new Size(300, 29);
            stock_txt.TabIndex = 30;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Google Sans", 10.2F);
            label6.Location = new Point(7, 264);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(117, 21);
            label6.TabIndex = 25;
            label6.Text = "Current Stock";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Google Sans", 10.2F);
            label5.Location = new Point(7, 214);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(100, 21);
            label5.TabIndex = 24;
            label5.Text = "Lower Limit";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Google Sans", 10.2F);
            label4.Location = new Point(7, 164);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(99, 21);
            label4.TabIndex = 23;
            label4.Text = "Upper Limit";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Google Sans", 10.2F);
            label3.Location = new Point(7, 116);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(122, 21);
            label3.TabIndex = 22;
            label3.Text = "Item Category";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Google Sans", 10.2F);
            label2.Location = new Point(7, 66);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(95, 21);
            label2.TabIndex = 21;
            label2.Text = "Item Name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Google Sans", 10.2F);
            label1.Location = new Point(7, 16);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(75, 21);
            label1.TabIndex = 20;
            label1.Text = "Page No";
            // 
            // update_btn
            // 
            update_btn.BackColor = Color.Crimson;
            update_btn.FlatAppearance.BorderSize = 0;
            update_btn.FlatStyle = FlatStyle.Flat;
            update_btn.Font = new Font("Google Sans", 10.2F);
            update_btn.Location = new Point(658, 264);
            update_btn.Margin = new Padding(4, 5, 4, 5);
            update_btn.Name = "update_btn";
            update_btn.Size = new Size(95, 42);
            update_btn.TabIndex = 36;
            update_btn.Text = "Update";
            update_btn.UseVisualStyleBackColor = false;
            update_btn.Click += update_btn3_Click;
            // 
            // load_btn
            // 
            load_btn.BackColor = Color.Crimson;
            load_btn.FlatAppearance.BorderSize = 0;
            load_btn.FlatStyle = FlatStyle.Flat;
            load_btn.Font = new Font("Google Sans", 10.2F);
            load_btn.Location = new Point(478, 16);
            load_btn.Margin = new Padding(4, 5, 4, 5);
            load_btn.Name = "load_btn";
            load_btn.Size = new Size(118, 39);
            load_btn.TabIndex = 37;
            load_btn.Text = "Load";
            load_btn.UseVisualStyleBackColor = false;
            load_btn.Click += load_btn_Click;
            // 
            // item_name_lbl
            // 
            item_name_lbl.AutoSize = true;
            item_name_lbl.Font = new Font("Google Sans", 10.2F);
            item_name_lbl.Location = new Point(158, 66);
            item_name_lbl.Margin = new Padding(4, 0, 4, 0);
            item_name_lbl.Name = "item_name_lbl";
            item_name_lbl.Size = new Size(95, 21);
            item_name_lbl.TabIndex = 39;
            item_name_lbl.Text = "Item Name";
            // 
            // item_cat_lbl
            // 
            item_cat_lbl.AutoSize = true;
            item_cat_lbl.Font = new Font("Google Sans", 10.2F);
            item_cat_lbl.Location = new Point(158, 116);
            item_cat_lbl.Margin = new Padding(4, 0, 4, 0);
            item_cat_lbl.Name = "item_cat_lbl";
            item_cat_lbl.Size = new Size(122, 21);
            item_cat_lbl.TabIndex = 40;
            item_cat_lbl.Text = "Item Category";
            // 
            // page_no_txt
            // 
            page_no_txt.BorderStyle = BorderStyle.FixedSingle;
            page_no_txt.Font = new Font("Google Sans", 10.2F);
            page_no_txt.Location = new Point(158, 16);
            page_no_txt.Margin = new Padding(4, 5, 4, 5);
            page_no_txt.Name = "page_no_txt";
            page_no_txt.Size = new Size(300, 29);
            page_no_txt.TabIndex = 42;
            // 
            // stock_lbl
            // 
            stock_lbl.AutoSize = true;
            stock_lbl.Font = new Font("Google Sans", 10.2F);
            stock_lbl.Location = new Point(158, 264);
            stock_lbl.Margin = new Padding(4, 0, 4, 0);
            stock_lbl.Name = "stock_lbl";
            stock_lbl.Size = new Size(126, 21);
            stock_lbl.TabIndex = 43;
            stock_lbl.Text = "Stock Available";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Google Sans", 10.2F);
            label8.Location = new Point(313, 227);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(78, 21);
            label8.TabIndex = 45;
            label8.Text = "Quantity";
            // 
            // user_lbl_distribution
            // 
            user_lbl_distribution.AutoSize = true;
            user_lbl_distribution.Location = new Point(15, 776);
            user_lbl_distribution.Margin = new Padding(4, 0, 4, 0);
            user_lbl_distribution.Name = "user_lbl_distribution";
            user_lbl_distribution.Size = new Size(91, 25);
            user_lbl_distribution.TabIndex = 81;
            user_lbl_distribution.Text = "Username";
            user_lbl_distribution.Visible = false;
            // 
            // Distribute
            // 
            AutoScaleDimensions = new SizeF(120F, 120F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.White;
            ClientSize = new Size(809, 513);
            Controls.Add(user_lbl_distribution);
            Controls.Add(label8);
            Controls.Add(lower_lbl);
            Controls.Add(label6);
            Controls.Add(label3);
            Controls.Add(load_btn);
            Controls.Add(label4);
            Controls.Add(item_cat_lbl);
            Controls.Add(page_no_txt);
            Controls.Add(update_btn);
            Controls.Add(label2);
            Controls.Add(stock_lbl);
            Controls.Add(label1);
            Controls.Add(upper_lbl);
            Controls.Add(label5);
            Controls.Add(stock_txt);
            Controls.Add(item_name_lbl);
            Font = new Font("Segoe UI", 10.8F);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 5, 4, 5);
            Name = "Distribute";
            Text = "Distribution Form";
            WindowState = FormWindowState.Maximized;
            Load += Distribute_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lower_lbl;
        private Label upper_lbl;
        private TextBox stock_txt;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button update_btn;
        private Button load_btn;
        private Label item_name_lbl;
        private Label item_cat_lbl;
        private TextBox page_no_txt;
        private Label stock_lbl;
        private Label label8;
        private Label user_lbl_distribution;
    }
}