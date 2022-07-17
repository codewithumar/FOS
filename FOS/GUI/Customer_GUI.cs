﻿using FOS.BL;
using FOS.DTO;
using System.Data.SqlClient;

namespace FOS.GUI
{
    public partial class Customer_GUI : Form
    {
        Modrator_BL _modratorBL;
        User_DTO user;
        public Customer_GUI(User_DTO ud)
        {
            InitializeComponent();
            user = ud;
            _modratorBL=new Modrator_BL();
            
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
                MessageBox.Show("No Items Available");
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

                
        }

        private void gdv_menuItems_MouseClick(object sender, MouseEventArgs e)
        {
           /*if ((bool)gdv_menuItems.SelectedRows[0].Cells[0].Value == false)
            {
                gdv_menuItems.SelectedRows[0].Cells[0].Value = true;
            }
            else
            {
                gdv_menuItems.SelectedRows[0].Cells[0].Value = false;
            }*/
        }
    }
}
