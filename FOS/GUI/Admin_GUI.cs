using FOS.BL;
using FOS.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FOS.GUI
{
    public partial class Admin_GUI : Form
    {
        Modrator_BL _modratorBL;
        AddItem_DTO _additemDTO;
        User_DTO userDTO;
        public Admin_GUI(User_DTO ud)
        {
            InitializeComponent();

            _additemDTO = new AddItem_DTO();
            _modratorBL = new Modrator_BL();
            userDTO = ud;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (!(txt_itemname.Text == "" || txt_itemPrice.Text == "" || cmb_itemtype.Text == ""))
                {
                    _additemDTO.Name = txt_itemname.Text;
                    _additemDTO.Price = txt_itemPrice.Text;
                    _additemDTO.Type = cmb_itemtype.Text;
                    if (_modratorBL.addItemin_BL(_additemDTO))
                    {
                        MessageBox.Show("Done", "Done", MessageBoxButtons.OK);
                    }

                }
                else
                {
                    MessageBox.Show("Please Input all feilds", "Error", MessageBoxButtons.OK);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Dish With Same name already Exsists", "Error", MessageBoxButtons.OK);
            }
        }

        private void Admin_GUI_Load(object sender, EventArgs e)
        {
            this.Size = new Size(800, 500);
            try
            {

                gdv_orderlist.DataSource = _modratorBL.getorderlistINBL();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("No Items Available" + ex.Message);
            }
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            if (!(txt_updtitemname.Text == ""))
            {
                try
                {
                    txt_itemname.Text = "";


                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Record not found due to exception");
                }
            }
        }
    }
}
