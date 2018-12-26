using System.Windows.Forms;

namespace FundManager.Desktop
{
    public partial class NotAuthorizedControl : UserControl
    {
        public NotAuthorizedControl()
        {
            InitializeComponent();
        }

        private void SignInLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var loginForm = new LoginForm();
            loginForm.OwnerForm = ParentForm as MainForm;
            loginForm.Show();
        }

        private void SignUpLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var registrationForm = new RegistrationForm();
            registrationForm.OwnerForm = ParentForm as MainForm;
            registrationForm.Show();
        }
    }
}
