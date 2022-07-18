namespace FOS.GUI
{
    partial class Admin_GUI
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btn_add = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmb_itemtype = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_itemPrice = new System.Windows.Forms.TextBox();
            this.txt_itemname = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.gdv_orderlist = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btn_serach = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_updateprice = new System.Windows.Forms.TextBox();
            this.txt_updtitemname = new System.Windows.Forms.TextBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.txt_updateitemtype = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gdv_orderlist)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(1, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1434, 667);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btn_add);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.cmb_itemtype);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.txt_itemPrice);
            this.tabPage1.Controls.Add(this.txt_itemname);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1426, 634);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Add Item";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(320, 236);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(94, 29);
            this.btn_add.TabIndex = 7;
            this.btn_add.Text = "Add";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(166, 165);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Item Price";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(166, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Item Type";
            // 
            // cmb_itemtype
            // 
            this.cmb_itemtype.FormattingEnabled = true;
            this.cmb_itemtype.Items.AddRange(new object[] {
            "Desi",
            "Italian",
            "Arabic"});
            this.cmb_itemtype.Location = new System.Drawing.Point(275, 115);
            this.cmb_itemtype.Name = "cmb_itemtype";
            this.cmb_itemtype.Size = new System.Drawing.Size(151, 28);
            this.cmb_itemtype.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(166, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Item Name";
            // 
            // txt_itemPrice
            // 
            this.txt_itemPrice.Location = new System.Drawing.Point(275, 159);
            this.txt_itemPrice.Name = "txt_itemPrice";
            this.txt_itemPrice.Size = new System.Drawing.Size(151, 27);
            this.txt_itemPrice.TabIndex = 2;
            // 
            // txt_itemname
            // 
            this.txt_itemname.Location = new System.Drawing.Point(275, 65);
            this.txt_itemname.Name = "txt_itemname";
            this.txt_itemname.Size = new System.Drawing.Size(151, 27);
            this.txt_itemname.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.gdv_orderlist);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1426, 634);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "View orders";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // gdv_orderlist
            // 
            this.gdv_orderlist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gdv_orderlist.Location = new System.Drawing.Point(2, 3);
            this.gdv_orderlist.Name = "gdv_orderlist";
            this.gdv_orderlist.RowHeadersWidth = 51;
            this.gdv_orderlist.RowTemplate.Height = 29;
            this.gdv_orderlist.Size = new System.Drawing.Size(1419, 339);
            this.gdv_orderlist.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.txt_updateitemtype);
            this.tabPage3.Controls.Add(this.btn_serach);
            this.tabPage3.Controls.Add(this.btn_update);
            this.tabPage3.Controls.Add(this.label4);
            this.tabPage3.Controls.Add(this.label5);
            this.tabPage3.Controls.Add(this.label6);
            this.tabPage3.Controls.Add(this.txt_updateprice);
            this.tabPage3.Controls.Add(this.txt_updtitemname);
            this.tabPage3.Location = new System.Drawing.Point(4, 29);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1426, 634);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Update Items";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // btn_serach
            // 
            this.btn_serach.Location = new System.Drawing.Point(634, 123);
            this.btn_serach.Name = "btn_serach";
            this.btn_serach.Size = new System.Drawing.Size(94, 29);
            this.btn_serach.TabIndex = 14;
            this.btn_serach.Text = "Search";
            this.btn_serach.UseVisualStyleBackColor = true;
            this.btn_serach.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // btn_update
            // 
            this.btn_update.Location = new System.Drawing.Point(473, 292);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(94, 29);
            this.btn_update.TabIndex = 14;
            this.btn_update.Text = "Update";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(285, 222);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 20);
            this.label4.TabIndex = 13;
            this.label4.Text = "Update Item Price";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(286, 179);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(127, 20);
            this.label5.TabIndex = 12;
            this.label5.Text = "Update Item Type";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(285, 124);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(136, 20);
            this.label6.TabIndex = 10;
            this.label6.Text = "Update Item Name";
            // 
            // txt_updateprice
            // 
            this.txt_updateprice.Location = new System.Drawing.Point(427, 215);
            this.txt_updateprice.Name = "txt_updateprice";
            this.txt_updateprice.Size = new System.Drawing.Size(151, 27);
            this.txt_updateprice.TabIndex = 9;
            // 
            // txt_updtitemname
            // 
            this.txt_updtitemname.Location = new System.Drawing.Point(427, 121);
            this.txt_updtitemname.Name = "txt_updtitemname";
            this.txt_updtitemname.Size = new System.Drawing.Size(151, 27);
            this.txt_updtitemname.TabIndex = 8;
            // 
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(4, 29);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(1426, 634);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Delete items";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // txt_updateitemtype
            // 
            this.txt_updateitemtype.Location = new System.Drawing.Point(424, 172);
            this.txt_updateitemtype.Name = "txt_updateitemtype";
            this.txt_updateitemtype.Size = new System.Drawing.Size(154, 27);
            this.txt_updateitemtype.TabIndex = 15;
            // 
            // Admin_GUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 671);
            this.Controls.Add(this.tabControl1);
            this.Name = "Admin_GUI";
            this.Text = "Admin_GUI";
            this.Load += new System.EventHandler(this.Admin_GUI_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gdv_orderlist)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private Label label1;
        private TextBox txt_itemPrice;
        private TextBox txt_itemname;
        private TabPage tabPage2;
        private ComboBox cmb_itemtype;
        private Button btn_add;
        private Label label3;
        private Label label2;

        private DataGridView gdv_orderlist;
        private TabPage tabPage3;
        private Button btn_update;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox txt_updateprice;
        private TextBox txt_updtitemname;
        private TabPage tabPage4;
        private Button btn_serach;
        private TextBox txt_updateitemtype;
    }
}