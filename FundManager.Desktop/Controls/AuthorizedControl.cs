using System.Windows.Forms;
using FundManager.Core.Component;
using FundManager.Desktop.Forms;

namespace FundManager.Desktop.Controls
{
    public partial class AuthorizedControl : UserControl
    {
        public AuthorizedControl()
        {
            InitializeComponent();
            var user = GlobalSession.GetDesktopCurrentUser();
            AuthorizedText.Text = string.Format(AuthorizedText.Text, user.UserName);
        }

        private void LogOutLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            GlobalSession.EndDesktopSession();
            var mainForm = ParentForm as MainForm;
            mainForm?.ChangeHeader(false);
        }
    }
}
