using FOS.DL;
using FOS.GUI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FOS.BL
{
    class Login_BL
    {
        private Login_DL _lgDL;

        public Login_BL()
        {
            _lgDL = new Login_DL();
        }

        public Form VerifyUser(Login_DTO lgDTO)
        {
            if (_lgDL.verifyuserfromDb(lgDTO).Role.Equals("admin"))
            {
                return new Admin_GUI();
            }
            else if (_lgDL.verifyuserfromDb(lgDTO).Role.Equals("Customer"))
            {
                return new Customer_GUI();
            }
            return new WrongUser_GUI();

        }
    }
}
    

