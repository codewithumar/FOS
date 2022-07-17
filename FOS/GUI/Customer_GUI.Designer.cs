namespace FOS.GUI
{
    partial class Customer_GUI
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
            this.label1 = new System.Windows.Forms.Label();
            this.txt_totalBill = new System.Windows.Forms.TextBox();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_Calculatebill = new System.Windows.Forms.Button();
            this.btn_addtoorder = new System.Windows.Forms.Button();
            this.gdv_orderitems_temp = new System.Windows.Forms.DataGridView();
            this.lbl_welcome = new System.Windows.Forms.Label();
            this.gdv_menuItems = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gdv_orderitems_temp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdv_menuItems)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(0, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1380, 725);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.txt_totalBill);
            this.tabPage1.Controls.Add(this.btn_delete);
            this.tabPage1.Controls.Add(this.btn_Calculatebill);
            this.tabPage1.Controls.Add(this.btn_addtoorder);
            this.tabPage1.Controls.Add(this.gdv_orderitems_temp);
            this.tabPage1.Controls.Add(this.lbl_welcome);
            this.tabPage1.Controls.Add(this.gdv_menuItems);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1372, 692);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Order";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(596, 352);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Total Bill";
            // 
            // txt_totalBill
            // 
            this.txt_totalBill.Location = new System.Drawing.Point(689, 350);
            this.txt_totalBill.Name = "txt_totalBill";
            this.txt_totalBill.Size = new System.Drawing.Size(125, 27);
            this.txt_totalBill.TabIndex = 6;
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(465, 383);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(94, 29);
            this.btn_delete.TabIndex = 5;
            this.btn_delete.Text = "Delete";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_Calculatebill
            // 
            this.btn_Calculatebill.Location = new System.Drawing.Point(1005, 413);
            this.btn_Calculatebill.Name = "btn_Calculatebill";
            this.btn_Calculatebill.Size = new System.Drawing.Size(126, 29);
            this.btn_Calculatebill.TabIndex = 4;
            this.btn_Calculatebill.Text = "Calculate Bill";
            this.btn_Calculatebill.UseVisualStyleBackColor = true;
            // 
            // btn_addtoorder
            // 
            this.btn_addtoorder.Location = new System.Drawing.Point(465, 348);
            this.btn_addtoorder.Name = "btn_addtoorder";
            this.btn_addtoorder.Size = new System.Drawing.Size(94, 29);
            this.btn_addtoorder.TabIndex = 3;
            this.btn_addtoorder.Text = "Add";
            this.btn_addtoorder.UseVisualStyleBackColor = true;
            this.btn_addtoorder.Click += new System.EventHandler(this.btn_addtoorder_Click);
            // 
            // gdv_orderitems_temp
            // 
            this.gdv_orderitems_temp.AllowUserToAddRows = false;
            this.gdv_orderitems_temp.AllowUserToDeleteRows = false;
            this.gdv_orderitems_temp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gdv_orderitems_temp.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column2,
            this.Column3});
            this.gdv_orderitems_temp.Location = new System.Drawing.Point(436, 3);
            this.gdv_orderitems_temp.Name = "gdv_orderitems_temp";
            this.gdv_orderitems_temp.ReadOnly = true;
            this.gdv_orderitems_temp.RowHeadersWidth = 51;
            this.gdv_orderitems_temp.RowTemplate.Height = 29;
            this.gdv_orderitems_temp.Size = new System.Drawing.Size(428, 308);
            this.gdv_orderitems_temp.TabIndex = 2;
            // 
            // lbl_welcome
            // 
            this.lbl_welcome.AutoSize = true;
            this.lbl_welcome.Location = new System.Drawing.Point(1211, 6);
            this.lbl_welcome.Name = "lbl_welcome";
            this.lbl_welcome.Size = new System.Drawing.Size(76, 20);
            this.lbl_welcome.TabIndex = 1;
            this.lbl_welcome.Text = "WelCome:";
            this.lbl_welcome.Click += new System.EventHandler(this.lbl_welcome_Click);
            // 
            // gdv_menuItems
            // 
            this.gdv_menuItems.AllowUserToAddRows = false;
            this.gdv_menuItems.AllowUserToDeleteRows = false;
            this.gdv_menuItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gdv_menuItems.Location = new System.Drawing.Point(6, 4);
            this.gdv_menuItems.MultiSelect = false;
            this.gdv_menuItems.Name = "gdv_menuItems";
            this.gdv_menuItems.ReadOnly = true;
            this.gdv_menuItems.RowHeadersWidth = 51;
            this.gdv_menuItems.RowTemplate.Height = 29;
            this.gdv_menuItems.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gdv_menuItems.Size = new System.Drawing.Size(424, 521);
            this.gdv_menuItems.TabIndex = 0;
            this.gdv_menuItems.MouseClick += new System.Windows.Forms.MouseEventHandler(this.gdv_menuItems_MouseClick);
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1372, 692);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "History";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Name";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 125;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Price";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 125;
            // 
            // Customer_GUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1380, 726);
            this.Controls.Add(this.tabControl1);
            this.Name = "Customer_GUI";
            this.Text = "Customer_GUI";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Customer_GUI_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gdv_orderitems_temp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdv_menuItems)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private DataGridView gdv_menuItems;
        private Label lbl_welcome;
        private Button btn_addtoorder;
        private DataGridView gdv_orderitems_temp;
        private Button btn_delete;
        private Button btn_Calculatebill;
        private Label label1;
        private TextBox txt_totalBill;
        private DataGridViewCheckBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
    }
}