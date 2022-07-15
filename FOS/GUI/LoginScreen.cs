using FOS.BL;
using FOS.DL;

namespace FOS
{
    public partial class LoginScreen : Form
    {
        private Login_DTO _lgDTO;
        private Login_BL _lgBL;
        public LoginScreen()
        {
            InitializeComponent();
            _lgDTO = new Login_DTO();
            _lgBL = new Login_BL();
        }
        private void btn_login_Click(object sender, EventArgs e)
        {
            _lgDTO.Username=txt_username.Text;
            _lgDTO.Password = txt_password.Text;
            _lgBL.VerifyUser(_lgDTO).ShowDialog();
        }
    }
}