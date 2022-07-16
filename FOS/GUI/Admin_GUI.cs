using FOS.BL;
using FOS.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
        public Admin_GUI()
        {
            InitializeComponent();
            
            _additemDTO = new AddItem_DTO();
            _modratorBL = new Modrator_BL();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(!(txt_itemname.Text=="" || txt_itemPrice.Text=="" || cmb_itemtype.Text == ""))
            {
                _additemDTO.Name = txt_itemname.Text;
                _additemDTO.Price = txt_itemPrice.Text;
                _additemDTO.Type = cmb_itemtype.Text;
                if (_modratorBL.addItemin_BL(_additemDTO))
                {
                    MessageBox.Show("Done", "Done", MessageBoxButtons.OK);
                }
                else
                {
                    MessageBox.Show("Error", "Error", MessageBoxButtons.OK);
                }

            }
            else
            {
                MessageBox.Show("Please Input all feilds", "Error", MessageBoxButtons.OK);
            }
        }
    }
}
