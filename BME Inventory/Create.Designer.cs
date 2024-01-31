using System.IO;
namespace Acc_Inventory
{
    partial class Create
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Create));
            label1 = new Label();
            label2 = new Label();
            item_cat_txt = new TextBox();
            label3 = new Label();
            item_name_txt = new TextBox();
            label4 = new Label();
            upper_txt = new TextBox();
            label5 = new Label();
            lower_txt = new TextBox();
            label6 = new Label();
            stock_txt = new TextBox();
            fileSystemWatcher1 = new FileSystemWatcher();
            save_btn = new MaterialSkin.Controls.MaterialButton();
            page_no_txt = new TextBox();
            label14 = new Label();
            panel4 = new Panel();
            ((System.ComponentModel.ISupportInitialize)fileSystemWatcher1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Google Sans", 10.2F);
            label1.Location = new Point(12, 50);
            label1.Name = "label1";
            label1.Size = new Size(75, 21);
            label1.TabIndex = 0;
            label1.Text = "Page No";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Google Sans", 10.2F);
            label2.Location = new Point(12, 136);
            label2.Name = "label2";
            label2.Size = new Size(122, 21);
            label2.TabIndex = 2;
            label2.Text = "Item Category";
            // 
            // item_cat_txt
            // 
            item_cat_txt.AutoCompleteMode = AutoCompleteMode.Suggest;
            item_cat_txt.BorderStyle = BorderStyle.FixedSingle;
            item_cat_txt.Font = new Font("Google Sans", 10.2F);
            item_cat_txt.Location = new Point(160, 136);
            item_cat_txt.Name = "item_cat_txt";
            item_cat_txt.Size = new Size(336, 29);
            item_cat_txt.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Google Sans", 10.2F);
            label3.Location = new Point(12, 90);
            label3.Name = "label3";
            label3.Size = new Size(95, 21);
            label3.TabIndex = 4;
            label3.Text = "Item Name";
            // 
            // item_name_txt
            // 
            item_name_txt.AutoCompleteMode = AutoCompleteMode.Suggest;
            item_name_txt.BorderStyle = BorderStyle.FixedSingle;
            item_name_txt.Font = new Font("Google Sans", 10.2F);
            item_name_txt.Location = new Point(160, 90);
            item_name_txt.Name = "item_name_txt";
            item_name_txt.Size = new Size(336, 29);
            item_name_txt.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Google Sans", 10.2F);
            label4.Location = new Point(12, 186);
            label4.Name = "label4";
            label4.Size = new Size(94, 21);
            label4.TabIndex = 6;
            label4.Text = "Upper limit";
            // 
            // upper_txt
            // 
            upper_txt.BorderStyle = BorderStyle.FixedSingle;
            upper_txt.Font = new Font("Google Sans", 10.2F);
            upper_txt.Location = new Point(160, 186);
            upper_txt.Name = "upper_txt";
            upper_txt.Size = new Size(336, 29);
            upper_txt.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Google Sans", 10.2F);
            label5.Location = new Point(12, 226);
            label5.Name = "label5";
            label5.Size = new Size(95, 21);
            label5.TabIndex = 8;
            label5.Text = "Lower limit";
            // 
            // lower_txt
            // 
            lower_txt.BorderStyle = BorderStyle.FixedSingle;
            lower_txt.Font = new Font("Google Sans", 10.2F);
            lower_txt.Location = new Point(160, 226);
            lower_txt.Name = "lower_txt";
            lower_txt.Size = new Size(336, 29);
            lower_txt.TabIndex = 9;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Google Sans", 10.2F);
            label6.Location = new Point(12, 266);
            label6.Name = "label6";
            label6.Size = new Size(117, 21);
            label6.TabIndex = 10;
            label6.Text = "Current Stock";
            // 
            // stock_txt
            // 
            stock_txt.BorderStyle = BorderStyle.FixedSingle;
            stock_txt.Font = new Font("Google Sans", 10.2F);
            stock_txt.Location = new Point(160, 266);
            stock_txt.Name = "stock_txt";
            stock_txt.Size = new Size(338, 29);
            stock_txt.TabIndex = 11;
            // 
            // fileSystemWatcher1
            // 
            fileSystemWatcher1.EnableRaisingEvents = true;
            fileSystemWatcher1.SynchronizingObject = this;
            // 
            // save_btn
            // 
            save_btn.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            save_btn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            save_btn.Depth = 0;
            save_btn.HighEmphasis = true;
            save_btn.Icon = null;
            save_btn.Location = new Point(160, 319);
            save_btn.Margin = new Padding(4, 6, 4, 6);
            save_btn.MouseState = MaterialSkin.MouseState.HOVER;
            save_btn.Name = "save_btn";
            save_btn.NoAccentTextColor = Color.Empty;
            save_btn.Size = new Size(119, 36);
            save_btn.TabIndex = 53;
            save_btn.Text = "Save Details";
            save_btn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            save_btn.UseAccentColor = false;
            save_btn.UseVisualStyleBackColor = true;
            save_btn.Click += save_btn_Click;
            // 
            // page_no_txt
            // 
            page_no_txt.AutoCompleteMode = AutoCompleteMode.Suggest;
            page_no_txt.BorderStyle = BorderStyle.FixedSingle;
            page_no_txt.Font = new Font("Google Sans", 10.2F);
            page_no_txt.Location = new Point(160, 50);
            page_no_txt.Name = "page_no_txt";
            page_no_txt.Size = new Size(336, 29);
            page_no_txt.TabIndex = 53;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Google Sans", 12F);
            label14.Location = new Point(12, 9);
            label14.Name = "label14";
            label14.Size = new Size(161, 25);
            label14.TabIndex = 52;
            label14.Text = "Add Item Details";
            // 
            // panel4
            // 
            panel4.AutoSize = true;
            panel4.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panel4.BackColor = Color.GhostWhite;
            panel4.Dock = DockStyle.Top;
            panel4.Location = new Point(0, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(625, 0);
            panel4.TabIndex = 54;
            // 
            // Create
            // 
            AutoScaleDimensions = new SizeF(120F, 120F);
            AutoScaleMode = AutoScaleMode.Dpi;
            AutoScroll = true;
            BackColor = Color.White;
            ClientSize = new Size(625, 392);
            Controls.Add(panel4);
            Controls.Add(lower_txt);
            Controls.Add(label4);
            Controls.Add(save_btn);
            Controls.Add(label2);
            Controls.Add(item_cat_txt);
            Controls.Add(label1);
            Controls.Add(upper_txt);
            Controls.Add(label3);
            Controls.Add(page_no_txt);
            Controls.Add(item_name_txt);
            Controls.Add(stock_txt);
            Controls.Add(label5);
            Controls.Add(label6);
            Controls.Add(label14);
            Font = new Font("Segoe UI", 10.2F);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Create";
            Text = "Insert Data";
            TransparencyKey = Color.FromArgb(255, 255, 128);
            ((System.ComponentModel.ISupportInitialize)fileSystemWatcher1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox item_cat_txt;
        private Label label3;
        private TextBox item_name_txt;
        private Label label4;
        private TextBox upper_txt;
        private Label label5;
        private TextBox lower_txt;
        private Label label6;
        private TextBox stock_txt;
        private FileSystemWatcher fileSystemWatcher1;
        private Panel panel4;
        private Label label14;
        private TextBox page_no_txt;
        private MaterialSkin.Controls.MaterialButton save_btn;
    }
}