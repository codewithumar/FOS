﻿using FOS.BL;
using FOS.DTO;
using System.Data.SqlClient;

namespace FOS.GUI
{
    public partial class Customer_GUI : Form
    {
        Modrator_BL _modratorBL;
        User_DTO user;
        GenrateOrderBill_DTO genrateorderbill;
        AddItem_DTO additem;
        private int _totalPrice=0;
        public Customer_GUI(User_DTO ud)
        {
            InitializeComponent();
            user = ud;
            _modratorBL=new Modrator_BL();
            genrateorderbill = new GenrateOrderBill_DTO(); 
        }

        private void Customer_GUI_Load(object sender, EventArgs e)
        {
            this.Size = new Size(800, 500);
            try
            {
                
                gdv_menuItems.DataSource = _modratorBL.getMenuitems_BL();
                
                lbl_welcome.Text += user.UserID;
            }
            catch (SqlException ex)
            {
                MessageBox.Show("No Items Available"+ex.Message);
            }
            
        }

        private void lbl_welcome_Click(object sender, EventArgs e)
        {

        }

        private void btn_addtoorder_Click(object sender, EventArgs e)
        {
            int n = gdv_orderitems_temp.Rows.Add();
            gdv_orderitems_temp.Rows[n].Cells[0].Value = gdv_menuItems.CurrentRow.Cells[1].Value.ToString();
            gdv_orderitems_temp.Rows[n].Cells[1].Value = gdv_menuItems.CurrentRow.Cells[2].Value.ToString();
            _totalPrice += Convert.ToInt32(gdv_menuItems.CurrentRow.Cells[2].Value.ToString());
            txt_totalBill.Text = _totalPrice.ToString();
            gdv_orderitems_temp.ClearSelection();


                
        }
       private void btn_delete_Click(object sender, EventArgs e)
        {
            
            if (gdv_orderitems_temp.RowCount.Equals(0))
            {
                txt_totalBill.Text = 0.ToString();
                _totalPrice = 0;
            }
            else
            {
                _totalPrice -= Convert.ToInt32(gdv_orderitems_temp.CurrentRow.Cells[1].Value.ToString());
                txt_totalBill.Text = _totalPrice.ToString();
                gdv_orderitems_temp.Rows.Remove(gdv_orderitems_temp.CurrentRow);
            }
        }

        private void btn_Calculatebill_Click(object sender, EventArgs e)
        {
            genrateorderbill.Totalbill = _totalPrice.ToString();
            genrateorderbill.Username = user.UserID;
            genrateorderbill.Quantity = 5.ToString();
            genrateorderbill.ItemName = "test";

        }
    }
}
