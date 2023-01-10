using System.Drawing.Text;

namespace GunaLogin
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void onCancel(object sender, EventArgs e)
        {
            if (_CancelDialog.Show() == DialogResult.Yes)
                Application.Exit();
        }

        private void onLogin(object sender, EventArgs e)
        {
            String mailAddress = tb_Mail.Text;
            String password = tb_Password.Text;

            if (mailAddress == "admin@example.com" && password == "superadmin")
            {
                _LoginDialog.Text = "Du wurdest erfolgreich angemeldet!";
                _LoginDialog.Caption = "Login Erfolgreich!";
                _LoginDialog.Icon = Guna.UI2.WinForms.MessageDialogIcon.Information;
                _LoginDialog.Buttons = Guna.UI2.WinForms.MessageDialogButtons.OK;
                _LoginDialog.Show();
            }
            else
            {
                _LoginDialog.Text = "Die eingegebenen Daten sind leider nicht richtig!";
                _LoginDialog.Caption = "Fehler beim Login!";
                _LoginDialog.Icon = Guna.UI2.WinForms.MessageDialogIcon.Warning;
                _LoginDialog.Buttons = Guna.UI2.WinForms.MessageDialogButtons.RetryCancel;
                if (_LoginDialog.Show() == DialogResult.Cancel)
                    Application.Exit();
            }
        }

        private void onProfilePictureDoubleClick(object sender, EventArgs e)
        {
            _EasterEgg.Show();
        }
    }
}