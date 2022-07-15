using FOS.DL;
using FOS.DTO;
using FOS.GUI;


namespace FOS.BL
{
    class Login_BL
    {
         Login_DL _lgDL;

        public Login_BL()
        {
            _lgDL = new Login_DL();
        }

        public Form VerifyUser(Login_DTO lgDTO)
        {
            User_DTO ud = _lgDL.verifyuserfromDb(lgDTO);
            if (ud == null)
            {
                return new WrongUser_GUI();
            }
            if (ud.Role=="admin")
            {
                return new Admin_GUI();
            }
            else if (ud.Role=="Customer")
            {
                return new Customer_GUI();
            }
            else
            {
                return new WrongUser_GUI();
            }
            return new WrongUser_GUI();

        }
    }
}
    

