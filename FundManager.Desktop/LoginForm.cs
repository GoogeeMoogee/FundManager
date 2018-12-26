using System;
using System.Windows.Forms;
using FundManager.Core.Component;
using FundManager.Core.Model;
using FundManager.Core.Services;

namespace FundManager.Desktop
{
    public partial class LoginForm : Form
    {
        private readonly AuthenticationService _authenticationService;

        public MainForm OwnerForm { get; set; }

        public LoginForm()
        {
            InitializeComponent();
            _authenticationService = new AuthenticationService();
        }

        private async void LoginButton_Click(object sender, EventArgs e)
        {
            var userName = UserNameTextBox.Text;
            var password = PasswordTextBox.Text;

            var loginModel = new LoginModel
            {
                UserName = userName,
                Password = password
            };

            var loginResult = await _authenticationService.LoginUser(loginModel);
            if (loginResult.IsSuccessful)
            {
                GlobalSession.StartDesktopSession(loginResult.Data);
                OwnerForm.ChangeHeader(true);
                Close();
            }
        }
    }
}
