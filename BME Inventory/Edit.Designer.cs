namespace Acc_Inventory
{
    partial class Edit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Edit));
            load_btn = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            update_btn = new Button();
            page_no_txt = new TextBox();
            item_name_txt = new TextBox();
            item_cat_txt = new TextBox();
            upper_lbl = new Label();
            lower_lbl = new Label();
            delete_btn = new Button();
            pnl_home = new Panel();
            label8 = new Label();
            stock_lbl = new Label();
            pnl_home.SuspendLayout();
            SuspendLayout();
            // 
            // load_btn
            // 
            load_btn.BackColor = Color.Crimson;
            load_btn.FlatAppearance.BorderSize = 0;
            load_btn.FlatStyle = FlatStyle.Flat;
            load_btn.Location = new Point(422, 15);
            load_btn.Name = "load_btn";
            load_btn.Size = new Size(95, 40);
            load_btn.TabIndex = 1;
            load_btn.Text = "Load";
            load_btn.UseVisualStyleBackColor = false;
            load_btn.Click += load_btn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(18, 15);
            label1.Name = "label1";
            label1.Size = new Size(79, 22);
            label1.TabIndex = 3;
            label1.Text = "Page No";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(18, 65);
            label2.Name = "label2";
            label2.Size = new Size(100, 22);
            label2.TabIndex = 4;
            label2.Text = "Item Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(18, 115);
            label3.Name = "label3";
            label3.Size = new Size(129, 22);
            label3.TabIndex = 5;
            label3.Text = "Item Category";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(18, 166);
            label4.Name = "label4";
            label4.Size = new Size(105, 22);
            label4.TabIndex = 6;
            label4.Text = "Upper Limit";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(18, 216);
            label5.Name = "label5";
            label5.Size = new Size(105, 22);
            label5.TabIndex = 7;
            label5.Text = "Lower Limit";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(18, 266);
            label6.Name = "label6";
            label6.Size = new Size(123, 22);
            label6.TabIndex = 8;
            label6.Text = "Current Stock";
            // 
            // update_btn
            // 
            update_btn.BackColor = Color.Crimson;
            update_btn.FlatAppearance.BorderSize = 0;
            update_btn.FlatStyle = FlatStyle.Flat;
            update_btn.Location = new Point(16, 312);
            update_btn.Name = "update_btn";
            update_btn.Size = new Size(95, 40);
            update_btn.TabIndex = 10;
            update_btn.Text = "Update";
            update_btn.UseVisualStyleBackColor = false;
            update_btn.Click += update_btn_Click;
            // 
            // page_no_txt
            // 
            page_no_txt.BorderStyle = BorderStyle.FixedSingle;
            page_no_txt.Location = new Point(183, 15);
            page_no_txt.Name = "page_no_txt";
            page_no_txt.Size = new Size(211, 30);
            page_no_txt.TabIndex = 11;
            // 
            // item_name_txt
            // 
            item_name_txt.BorderStyle = BorderStyle.FixedSingle;
            item_name_txt.Location = new Point(183, 65);
            item_name_txt.Name = "item_name_txt";
            item_name_txt.Size = new Size(211, 30);
            item_name_txt.TabIndex = 12;
            // 
            // item_cat_txt
            // 
            item_cat_txt.BorderStyle = BorderStyle.FixedSingle;
            item_cat_txt.Location = new Point(183, 115);
            item_cat_txt.Name = "item_cat_txt";
            item_cat_txt.Size = new Size(211, 30);
            item_cat_txt.TabIndex = 13;
            // 
            // upper_lbl
            // 
            upper_lbl.AutoSize = true;
            upper_lbl.Location = new Point(183, 166);
            upper_lbl.Name = "upper_lbl";
            upper_lbl.Size = new Size(105, 22);
            upper_lbl.TabIndex = 18;
            upper_lbl.Text = "Upper Limit";
            // 
            // lower_lbl
            // 
            lower_lbl.AutoSize = true;
            lower_lbl.Location = new Point(183, 216);
            lower_lbl.Name = "lower_lbl";
            lower_lbl.Size = new Size(105, 22);
            lower_lbl.TabIndex = 19;
            lower_lbl.Text = "Lower Limit";
            // 
            // delete_btn
            // 
            delete_btn.BackColor = Color.Crimson;
            delete_btn.FlatAppearance.BorderSize = 0;
            delete_btn.FlatStyle = FlatStyle.Flat;
            delete_btn.Location = new Point(145, 312);
            delete_btn.Name = "delete_btn";
            delete_btn.Size = new Size(95, 40);
            delete_btn.TabIndex = 20;
            delete_btn.Text = "Delete";
            delete_btn.UseVisualStyleBackColor = false;
            delete_btn.Click += delete_btn_Click;
            // 
            // pnl_home
            // 
            pnl_home.Controls.Add(label8);
            pnl_home.Dock = DockStyle.Top;
            pnl_home.Location = new Point(0, 0);
            pnl_home.Name = "pnl_home";
            pnl_home.Size = new Size(333, 60);
            pnl_home.TabIndex = 0;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Fira Sans Medium", 12F, FontStyle.Bold);
            label8.Location = new Point(75, 18);
            label8.Name = "label8";
            label8.Size = new Size(182, 24);
            label8.TabIndex = 1;
            label8.Text = "Navigation Panel";
            label8.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // stock_lbl
            // 
            stock_lbl.AutoSize = true;
            stock_lbl.Location = new Point(183, 266);
            stock_lbl.Name = "stock_lbl";
            stock_lbl.Size = new Size(57, 22);
            stock_lbl.TabIndex = 29;
            stock_lbl.Text = "Stock";
            // 
            // Edit
            // 
            AutoScaleDimensions = new SizeF(120F, 120F);
            AutoScaleMode = AutoScaleMode.Dpi;
            AutoScroll = true;
            BackColor = Color.White;
            ClientSize = new Size(584, 403);
            Controls.Add(label1);
            Controls.Add(load_btn);
            Controls.Add(item_cat_txt);
            Controls.Add(label2);
            Controls.Add(item_name_txt);
            Controls.Add(label3);
            Controls.Add(page_no_txt);
            Controls.Add(upper_lbl);
            Controls.Add(label4);
            Controls.Add(update_btn);
            Controls.Add(lower_lbl);
            Controls.Add(label5);
            Controls.Add(stock_lbl);
            Controls.Add(delete_btn);
            Controls.Add(label6);
            Font = new Font("Google Sans", 10.8F);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Edit";
            Text = "Edit Data";
            WindowState = FormWindowState.Maximized;
            pnl_home.ResumeLayout(false);
            pnl_home.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button load_btn;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Button update_btn;
        private TextBox page_no_txt;
        private TextBox item_name_txt;
        private TextBox item_cat_txt;
        private TextBox stock_txt1;
        private TextBox desc_txt_edit;
        private Label upper_lbl;
        private Label lower_lbl;
        private Label upper_lbl_edit;
        private Label lower_lbl_edit;
        private Button delete_btn;
        private Panel pnl_home;
        private Label label8;
        private Label stock_lbl;
        private ComboBox make_combo1;
        private ComboBox model_combo1;
        private Label label14;
        private Label label15;
        private Label make_lbl_edit;
        private Label model_lbl_edit;
    }
}