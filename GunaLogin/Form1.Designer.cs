namespace GunaLogin
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            this._borderlessForm = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.cimg_ProfilePicture = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.tb_Mail = new Guna.UI2.WinForms.Guna2TextBox();
            this.tb_Password = new Guna.UI2.WinForms.Guna2TextBox();
            this.btn_Login = new Guna.UI2.WinForms.Guna2Button();
            this.btn_Cancel = new Guna.UI2.WinForms.Guna2Button();
            this._CancelDialog = new Guna.UI2.WinForms.Guna2MessageDialog();
            this._LoginDialog = new Guna.UI2.WinForms.Guna2MessageDialog();
            this._EasterEgg = new Guna.UI2.WinForms.Guna2MessageDialog();
            ((System.ComponentModel.ISupportInitialize)(this.cimg_ProfilePicture)).BeginInit();
            this.SuspendLayout();
            // 
            // _borderlessForm
            // 
            this._borderlessForm.AnimateWindow = true;
            this._borderlessForm.AnimationInterval = 250;
            this._borderlessForm.AnimationType = Guna.UI2.WinForms.Guna2BorderlessForm.AnimateWindowType.AW_VER_POSITIVE;
            this._borderlessForm.BorderRadius = 12;
            this._borderlessForm.ContainerControl = this;
            this._borderlessForm.DockIndicatorColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(46)))), ((int)(((byte)(162)))));
            this._borderlessForm.DockIndicatorTransparencyValue = 0.6D;
            this._borderlessForm.TransparentWhileDrag = true;
            // 
            // cimg_ProfilePicture
            // 
            this.cimg_ProfilePicture.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cimg_ProfilePicture.BackColor = System.Drawing.Color.Transparent;
            this.cimg_ProfilePicture.FillColor = System.Drawing.Color.DarkGray;
            this.cimg_ProfilePicture.Image = ((System.Drawing.Image)(resources.GetObject("cimg_ProfilePicture.Image")));
            this.cimg_ProfilePicture.ImageRotate = 0F;
            this.cimg_ProfilePicture.Location = new System.Drawing.Point(63, 9);
            this.cimg_ProfilePicture.Margin = new System.Windows.Forms.Padding(5);
            this.cimg_ProfilePicture.Name = "cimg_ProfilePicture";
            this.cimg_ProfilePicture.ShadowDecoration.CustomizableEdges = customizableEdges9;
            this.cimg_ProfilePicture.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.cimg_ProfilePicture.Size = new System.Drawing.Size(130, 130);
            this.cimg_ProfilePicture.TabIndex = 0;
            this.cimg_ProfilePicture.TabStop = false;
            this.cimg_ProfilePicture.UseTransparentBackground = true;
            this.cimg_ProfilePicture.DoubleClick += new System.EventHandler(this.onProfilePictureDoubleClick);
            // 
            // tb_Mail
            // 
            this.tb_Mail.Animated = true;
            this.tb_Mail.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.tb_Mail.BorderRadius = 12;
            this.tb_Mail.CustomizableEdges = customizableEdges7;
            this.tb_Mail.DefaultText = "";
            this.tb_Mail.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tb_Mail.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tb_Mail.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tb_Mail.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tb_Mail.FillColor = System.Drawing.Color.WhiteSmoke;
            this.tb_Mail.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tb_Mail.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_Mail.HoverState.BorderColor = System.Drawing.Color.Blue;
            this.tb_Mail.Location = new System.Drawing.Point(28, 151);
            this.tb_Mail.Margin = new System.Windows.Forms.Padding(5, 5, 5, 3);
            this.tb_Mail.Name = "tb_Mail";
            this.tb_Mail.PasswordChar = '\0';
            this.tb_Mail.PlaceholderText = "E-Mail";
            this.tb_Mail.SelectedText = "";
            this.tb_Mail.ShadowDecoration.CustomizableEdges = customizableEdges8;
            this.tb_Mail.Size = new System.Drawing.Size(200, 36);
            this.tb_Mail.TabIndex = 1;
            // 
            // tb_Password
            // 
            this.tb_Password.AcceptsReturn = true;
            this.tb_Password.Animated = true;
            this.tb_Password.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.tb_Password.BorderRadius = 12;
            this.tb_Password.CustomizableEdges = customizableEdges5;
            this.tb_Password.DefaultText = "";
            this.tb_Password.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tb_Password.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tb_Password.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tb_Password.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tb_Password.FillColor = System.Drawing.Color.WhiteSmoke;
            this.tb_Password.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tb_Password.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_Password.HoverState.BorderColor = System.Drawing.Color.Blue;
            this.tb_Password.Location = new System.Drawing.Point(28, 195);
            this.tb_Password.Margin = new System.Windows.Forms.Padding(5, 3, 5, 5);
            this.tb_Password.Name = "tb_Password";
            this.tb_Password.PasswordChar = '●';
            this.tb_Password.PlaceholderText = "Passwort";
            this.tb_Password.SelectedText = "";
            this.tb_Password.ShadowDecoration.CustomizableEdges = customizableEdges6;
            this.tb_Password.Size = new System.Drawing.Size(200, 36);
            this.tb_Password.TabIndex = 2;
            this.tb_Password.UseSystemPasswordChar = true;
            // 
            // btn_Login
            // 
            this.btn_Login.Animated = true;
            this.btn_Login.BorderRadius = 12;
            this.btn_Login.CustomizableEdges = customizableEdges3;
            this.btn_Login.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btn_Login.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Login.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_Login.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Login.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_Login.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_Login.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_Login.ForeColor = System.Drawing.Color.Black;
            this.btn_Login.Location = new System.Drawing.Point(28, 240);
            this.btn_Login.Margin = new System.Windows.Forms.Padding(5, 5, 5, 3);
            this.btn_Login.Name = "btn_Login";
            this.btn_Login.ShadowDecoration.CustomizableEdges = customizableEdges4;
            this.btn_Login.Size = new System.Drawing.Size(200, 36);
            this.btn_Login.TabIndex = 3;
            this.btn_Login.Text = "Login";
            this.btn_Login.Click += new System.EventHandler(this.onLogin);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Animated = true;
            this.btn_Cancel.BorderRadius = 12;
            this.btn_Cancel.CustomizableEdges = customizableEdges1;
            this.btn_Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_Cancel.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Cancel.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_Cancel.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Cancel.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_Cancel.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_Cancel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_Cancel.ForeColor = System.Drawing.Color.Black;
            this.btn_Cancel.Location = new System.Drawing.Point(28, 284);
            this.btn_Cancel.Margin = new System.Windows.Forms.Padding(5, 3, 5, 5);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.ShadowDecoration.CustomizableEdges = customizableEdges2;
            this.btn_Cancel.Size = new System.Drawing.Size(200, 39);
            this.btn_Cancel.TabIndex = 4;
            this.btn_Cancel.Text = "Cancel";
            this.btn_Cancel.Click += new System.EventHandler(this.onCancel);
            // 
            // _CancelDialog
            // 
            this._CancelDialog.Buttons = Guna.UI2.WinForms.MessageDialogButtons.YesNo;
            this._CancelDialog.Caption = "Bist du dir Sicher?";
            this._CancelDialog.Icon = Guna.UI2.WinForms.MessageDialogIcon.Question;
            this._CancelDialog.Parent = null;
            this._CancelDialog.Style = Guna.UI2.WinForms.MessageDialogStyle.Dark;
            this._CancelDialog.Text = "Möchtest du den Login Vorgang wirklich abbrechen?";
            // 
            // _LoginDialog
            // 
            this._LoginDialog.Buttons = Guna.UI2.WinForms.MessageDialogButtons.OK;
            this._LoginDialog.Caption = "Erfolgreich Eingeloggt!";
            this._LoginDialog.Icon = Guna.UI2.WinForms.MessageDialogIcon.Information;
            this._LoginDialog.Parent = null;
            this._LoginDialog.Style = Guna.UI2.WinForms.MessageDialogStyle.Dark;
            this._LoginDialog.Text = "Du wurdest erfolgreich eingeloggt. ";
            // 
            // _EasterEgg
            // 
            this._EasterEgg.Buttons = Guna.UI2.WinForms.MessageDialogButtons.OK;
            this._EasterEgg.Caption = "Yuhuu!";
            this._EasterEgg.Icon = Guna.UI2.WinForms.MessageDialogIcon.Error;
            this._EasterEgg.Parent = null;
            this._EasterEgg.Style = Guna.UI2.WinForms.MessageDialogStyle.Light;
            this._EasterEgg.Text = "You found an EasterEgg!";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(256, 351);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_Login);
            this.Controls.Add(this.tb_Password);
            this.Controls.Add(this.tb_Mail);
            this.Controls.Add(this.cimg_ProfilePicture);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.cimg_ProfilePicture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2BorderlessForm _borderlessForm;
        private Guna.UI2.WinForms.Guna2Button btn_Cancel;
        private Guna.UI2.WinForms.Guna2Button btn_Login;
        private Guna.UI2.WinForms.Guna2TextBox tb_Password;
        private Guna.UI2.WinForms.Guna2TextBox tb_Mail;
        private Guna.UI2.WinForms.Guna2CirclePictureBox cimg_ProfilePicture;
        private Guna.UI2.WinForms.Guna2MessageDialog _CancelDialog;
        private Guna.UI2.WinForms.Guna2MessageDialog _LoginDialog;
        private Guna.UI2.WinForms.Guna2MessageDialog _EasterEgg;
    }
}