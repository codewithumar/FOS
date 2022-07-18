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
            this.label1 = new System.Windows.Forms.Label();
            this.txt_itemPrice = new System.Windows.Forms.TextBox();
            this.txt_itemtype = new System.Windows.Forms.TextBox();
            this.txt_itemname = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.gdv_orderlist = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.txt_updateitemtype = new System.Windows.Forms.TextBox();
            this.btn_serach = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_updateprice = new System.Windows.Forms.TextBox();
            this.txt_updtitemname = new System.Windows.Forms.TextBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.txt_itemtypetodelete = new System.Windows.Forms.TextBox();
            this.btn_searchfordelete = new System.Windows.Forms.Button();
            this.btn_deleteItem = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_itempricetodelete = new System.Windows.Forms.TextBox();
            this.txt_itemnametodelete = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gdv_orderlist)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(1, 2);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(902, 501);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tabPage1.Controls.Add(this.label10);
            this.tabPage1.Controls.Add(this.btn_add);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.txt_itemPrice);
            this.tabPage1.Controls.Add(this.txt_itemtype);
            this.tabPage1.Controls.Add(this.txt_itemname);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage1.Size = new System.Drawing.Size(892, 472);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Add Item";
            // 
            // btn_add
            // 
            this.btn_add.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_add.Location = new System.Drawing.Point(465, 286);
            this.btn_add.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(131, 31);
            this.btn_add.TabIndex = 7;
            this.btn_add.Text = "Add Item";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Black", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(289, 212);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Item Price";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Black", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(289, 180);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Item Type";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(289, 139);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 21);
            this.label1.TabIndex = 3;
            this.label1.Text = "Item Name";
            // 
            // txt_itemPrice
            // 
            this.txt_itemPrice.Location = new System.Drawing.Point(385, 207);
            this.txt_itemPrice.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_itemPrice.Name = "txt_itemPrice";
            this.txt_itemPrice.Size = new System.Drawing.Size(211, 23);
            this.txt_itemPrice.TabIndex = 2;
            // 
            // txt_itemtype
            // 
            this.txt_itemtype.Location = new System.Drawing.Point(385, 172);
            this.txt_itemtype.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_itemtype.Name = "txt_itemtype";
            this.txt_itemtype.Size = new System.Drawing.Size(211, 23);
            this.txt_itemtype.TabIndex = 0;
            // 
            // txt_itemname
            // 
            this.txt_itemname.Location = new System.Drawing.Point(385, 137);
            this.txt_itemname.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_itemname.Name = "txt_itemname";
            this.txt_itemname.Size = new System.Drawing.Size(211, 23);
            this.txt_itemname.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Controls.Add(this.gdv_orderlist);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage2.Size = new System.Drawing.Size(894, 473);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "View orders";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // gdv_orderlist
            // 
            this.gdv_orderlist.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.gdv_orderlist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gdv_orderlist.Location = new System.Drawing.Point(2, 58);
            this.gdv_orderlist.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gdv_orderlist.Name = "gdv_orderlist";
            this.gdv_orderlist.RowHeadersWidth = 51;
            this.gdv_orderlist.RowTemplate.Height = 29;
            this.gdv_orderlist.Size = new System.Drawing.Size(894, 418);
            this.gdv_orderlist.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tabPage3.Controls.Add(this.txt_updateitemtype);
            this.tabPage3.Controls.Add(this.btn_serach);
            this.tabPage3.Controls.Add(this.btn_update);
            this.tabPage3.Controls.Add(this.label4);
            this.tabPage3.Controls.Add(this.label5);
            this.tabPage3.Controls.Add(this.label6);
            this.tabPage3.Controls.Add(this.txt_updateprice);
            this.tabPage3.Controls.Add(this.txt_updtitemname);
            this.tabPage3.Location = new System.Drawing.Point(4, 24);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage3.Size = new System.Drawing.Size(894, 473);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Update Items";
            // 
            // txt_updateitemtype
            // 
            this.txt_updateitemtype.Location = new System.Drawing.Point(322, 169);
            this.txt_updateitemtype.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_updateitemtype.Name = "txt_updateitemtype";
            this.txt_updateitemtype.Size = new System.Drawing.Size(211, 23);
            this.txt_updateitemtype.TabIndex = 15;
            this.txt_updateitemtype.TextChanged += new System.EventHandler(this.txt_updateitemtype_TextChanged);
            // 
            // btn_serach
            // 
            this.btn_serach.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_serach.Location = new System.Drawing.Point(568, 121);
            this.btn_serach.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_serach.Name = "btn_serach";
            this.btn_serach.Size = new System.Drawing.Size(114, 40);
            this.btn_serach.TabIndex = 14;
            this.btn_serach.Text = "Search";
            this.btn_serach.UseVisualStyleBackColor = true;
            this.btn_serach.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // btn_update
            // 
            this.btn_update.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_update.Location = new System.Drawing.Point(412, 259);
            this.btn_update.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(121, 45);
            this.btn_update.TabIndex = 14;
            this.btn_update.Text = "Update";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(165, 201);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(151, 21);
            this.label4.TabIndex = 13;
            this.label4.Text = "Update Item Price";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(163, 167);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(150, 21);
            this.label5.TabIndex = 12;
            this.label5.Text = "Update Item Type";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Black", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(171, 132);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(145, 20);
            this.label6.TabIndex = 10;
            this.label6.Text = "Update Item Name";
            // 
            // txt_updateprice
            // 
            this.txt_updateprice.Location = new System.Drawing.Point(322, 201);
            this.txt_updateprice.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_updateprice.Name = "txt_updateprice";
            this.txt_updateprice.Size = new System.Drawing.Size(211, 23);
            this.txt_updateprice.TabIndex = 9;
            // 
            // txt_updtitemname
            // 
            this.txt_updtitemname.Location = new System.Drawing.Point(322, 131);
            this.txt_updtitemname.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_updtitemname.Name = "txt_updtitemname";
            this.txt_updtitemname.Size = new System.Drawing.Size(211, 23);
            this.txt_updtitemname.TabIndex = 8;
            // 
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tabPage4.Controls.Add(this.txt_itemtypetodelete);
            this.tabPage4.Controls.Add(this.btn_searchfordelete);
            this.tabPage4.Controls.Add(this.btn_deleteItem);
            this.tabPage4.Controls.Add(this.label7);
            this.tabPage4.Controls.Add(this.label8);
            this.tabPage4.Controls.Add(this.label9);
            this.tabPage4.Controls.Add(this.txt_itempricetodelete);
            this.tabPage4.Controls.Add(this.txt_itemnametodelete);
            this.tabPage4.Location = new System.Drawing.Point(4, 24);
            this.tabPage4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(894, 473);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Delete items";
            // 
            // txt_itemtypetodelete
            // 
            this.txt_itemtypetodelete.Enabled = false;
            this.txt_itemtypetodelete.Location = new System.Drawing.Point(361, 183);
            this.txt_itemtypetodelete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_itemtypetodelete.Name = "txt_itemtypetodelete";
            this.txt_itemtypetodelete.Size = new System.Drawing.Size(224, 23);
            this.txt_itemtypetodelete.TabIndex = 23;
            // 
            // btn_searchfordelete
            // 
            this.btn_searchfordelete.Font = new System.Drawing.Font("Segoe UI Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_searchfordelete.Location = new System.Drawing.Point(609, 124);
            this.btn_searchfordelete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_searchfordelete.Name = "btn_searchfordelete";
            this.btn_searchfordelete.Size = new System.Drawing.Size(126, 42);
            this.btn_searchfordelete.TabIndex = 21;
            this.btn_searchfordelete.Text = "Search";
            this.btn_searchfordelete.UseVisualStyleBackColor = true;
            this.btn_searchfordelete.Click += new System.EventHandler(this.btn_searchfordelete_Click);
            // 
            // btn_deleteItem
            // 
            this.btn_deleteItem.Font = new System.Drawing.Font("Segoe UI Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_deleteItem.Location = new System.Drawing.Point(460, 273);
            this.btn_deleteItem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_deleteItem.Name = "btn_deleteItem";
            this.btn_deleteItem.Size = new System.Drawing.Size(125, 43);
            this.btn_deleteItem.TabIndex = 22;
            this.btn_deleteItem.Text = "Delete";
            this.btn_deleteItem.UseVisualStyleBackColor = true;
            this.btn_deleteItem.Click += new System.EventHandler(this.btn_deleteItem_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(294, 218);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 21);
            this.label7.TabIndex = 20;
            this.label7.Text = "Price";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(295, 185);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 21);
            this.label8.TabIndex = 19;
            this.label8.Text = "Type";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(79, 147);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(264, 21);
            this.label9.TabIndex = 18;
            this.label9.Text = "Please input dish name to delete";
            // 
            // txt_itempricetodelete
            // 
            this.txt_itempricetodelete.Enabled = false;
            this.txt_itempricetodelete.Location = new System.Drawing.Point(364, 216);
            this.txt_itempricetodelete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_itempricetodelete.Name = "txt_itempricetodelete";
            this.txt_itempricetodelete.Size = new System.Drawing.Size(221, 23);
            this.txt_itempricetodelete.TabIndex = 17;
            // 
            // txt_itemnametodelete
            // 
            this.txt_itemnametodelete.Location = new System.Drawing.Point(364, 145);
            this.txt_itemnametodelete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_itemnametodelete.Name = "txt_itemnametodelete";
            this.txt_itemnametodelete.Size = new System.Drawing.Size(221, 23);
            this.txt_itemnametodelete.TabIndex = 16;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI Black", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(184, 28);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(527, 65);
            this.label10.TabIndex = 8;
            this.label10.Text = "ADD ITEMS IN MENU";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI Black", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label11.Location = new System.Drawing.Point(7, 6);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(355, 50);
            this.label11.TabIndex = 1;
            this.label11.Text = "VIEW ALL ORDERS";
            // 
            // Admin_GUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(898, 500);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Admin_GUI";
            this.Text = "Admin Panel";
            this.Load += new System.EventHandler(this.Admin_GUI_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gdv_orderlist)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private Label label1;
        private TextBox txt_itemPrice;
        private TextBox txt_itemname;
        private TabPage tabPage2;
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
        private TextBox txt_itemtypetodelete;
        private Button btn_searchfordelete;
        private Button btn_deleteItem;
        private Label label7;
        private Label label8;
        private Label label9;
        private TextBox txt_itempricetodelete;
        private TextBox txt_itemnametodelete;
        private TextBox txt_itemtype;
        private Label label10;
        private Label label11;
        //  private TextBox txt_itemtype;
    }
}