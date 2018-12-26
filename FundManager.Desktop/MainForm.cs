using System.Windows.Forms;

namespace FundManager.Desktop
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            HeaderPanel.Controls.Add(new NotAuthorizedControl());
        }

        public void ChangeHeader(bool isAuthorized)
        {
            HeaderPanel.Controls.Clear();
            if (isAuthorized)
            {
                HeaderPanel.Controls.Add(new AuthorizedControl());
            }
            else
            {
                HeaderPanel.Controls.Add(new NotAuthorizedControl());
            }
        }
    }
}
