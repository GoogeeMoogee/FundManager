using System.Windows.Forms;
using FundManager.Core.Component;

namespace FundManager.Desktop
{
    public partial class AuthorizedControl : UserControl
    {
        public AuthorizedControl()
        {
            InitializeComponent();
        }

        private void LogOutLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            GlobalSession.EndDesktopSession();
        }
    }
}
