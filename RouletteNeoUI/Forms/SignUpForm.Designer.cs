namespace RouletteNeoUI.Forms
{
    partial class SignUpForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignUpForm));
            this.loginPasswordValue = new System.Windows.Forms.TextBox();
            this.loginUsernameValue = new System.Windows.Forms.TextBox();
            this.invalidCredentialsLabel = new System.Windows.Forms.Label();
            this.registerGroupBox = new System.Windows.Forms.GroupBox();
            this.confirmPasswordValue = new System.Windows.Forms.TextBox();
            this.confirmPasswordLabel = new System.Windows.Forms.Label();
            this.createAccountButton = new System.Windows.Forms.Button();
            this.signupPasswordValue = new System.Windows.Forms.TextBox();
            this.passwordLabel2 = new System.Windows.Forms.Label();
            this.signupUsernameValue = new System.Windows.Forms.TextBox();
            this.usernameLabel2 = new System.Windows.Forms.Label();
            this.emailAdressValue = new System.Windows.Forms.TextBox();
            this.emailAdressLabel = new System.Windows.Forms.Label();
            this.lastNameValue = new System.Windows.Forms.TextBox();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.firstNameValue = new System.Windows.Forms.TextBox();
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.orLabel = new System.Windows.Forms.Label();
            this.signInButton = new System.Windows.Forms.Button();
            this.rememberMeCheckBox = new System.Windows.Forms.CheckBox();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.registerGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // loginPasswordValue
            // 
            this.loginPasswordValue.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.loginPasswordValue.Location = new System.Drawing.Point(142, 51);
            this.loginPasswordValue.Name = "loginPasswordValue";
            this.loginPasswordValue.PasswordChar = '●';
            this.loginPasswordValue.Size = new System.Drawing.Size(184, 29);
            this.loginPasswordValue.TabIndex = 29;
            this.loginPasswordValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // loginUsernameValue
            // 
            this.loginUsernameValue.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.loginUsernameValue.Location = new System.Drawing.Point(142, 16);
            this.loginUsernameValue.Name = "loginUsernameValue";
            this.loginUsernameValue.Size = new System.Drawing.Size(184, 29);
            this.loginUsernameValue.TabIndex = 28;
            this.loginUsernameValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // invalidCredentialsLabel
            // 
            this.invalidCredentialsLabel.AutoSize = true;
            this.invalidCredentialsLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.invalidCredentialsLabel.ForeColor = System.Drawing.Color.Red;
            this.invalidCredentialsLabel.Location = new System.Drawing.Point(136, 124);
            this.invalidCredentialsLabel.Name = "invalidCredentialsLabel";
            this.invalidCredentialsLabel.Size = new System.Drawing.Size(190, 17);
            this.invalidCredentialsLabel.TabIndex = 27;
            this.invalidCredentialsLabel.Text = "Invalid credentials: Login failed.";
            this.invalidCredentialsLabel.Visible = false;
            // 
            // registerGroupBox
            // 
            this.registerGroupBox.Controls.Add(this.confirmPasswordValue);
            this.registerGroupBox.Controls.Add(this.confirmPasswordLabel);
            this.registerGroupBox.Controls.Add(this.createAccountButton);
            this.registerGroupBox.Controls.Add(this.signupPasswordValue);
            this.registerGroupBox.Controls.Add(this.passwordLabel2);
            this.registerGroupBox.Controls.Add(this.signupUsernameValue);
            this.registerGroupBox.Controls.Add(this.usernameLabel2);
            this.registerGroupBox.Controls.Add(this.emailAdressValue);
            this.registerGroupBox.Controls.Add(this.emailAdressLabel);
            this.registerGroupBox.Controls.Add(this.lastNameValue);
            this.registerGroupBox.Controls.Add(this.lastNameLabel);
            this.registerGroupBox.Controls.Add(this.firstNameValue);
            this.registerGroupBox.Controls.Add(this.firstNameLabel);
            this.registerGroupBox.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.registerGroupBox.Location = new System.Drawing.Point(12, 195);
            this.registerGroupBox.Name = "registerGroupBox";
            this.registerGroupBox.Size = new System.Drawing.Size(314, 314);
            this.registerGroupBox.TabIndex = 26;
            this.registerGroupBox.TabStop = false;
            this.registerGroupBox.Text = "Sign Up";
            // 
            // confirmPasswordValue
            // 
            this.confirmPasswordValue.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.confirmPasswordValue.Location = new System.Drawing.Point(120, 215);
            this.confirmPasswordValue.Name = "confirmPasswordValue";
            this.confirmPasswordValue.PasswordChar = '●';
            this.confirmPasswordValue.Size = new System.Drawing.Size(180, 29);
            this.confirmPasswordValue.TabIndex = 19;
            this.confirmPasswordValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // confirmPasswordLabel
            // 
            this.confirmPasswordLabel.AutoSize = true;
            this.confirmPasswordLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.confirmPasswordLabel.Location = new System.Drawing.Point(6, 218);
            this.confirmPasswordLabel.Name = "confirmPasswordLabel";
            this.confirmPasswordLabel.Size = new System.Drawing.Size(104, 21);
            this.confirmPasswordLabel.TabIndex = 18;
            this.confirmPasswordLabel.Text = "Confirm Pass:";
            // 
            // createAccountButton
            // 
            this.createAccountButton.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.createAccountButton.Location = new System.Drawing.Point(82, 256);
            this.createAccountButton.Name = "createAccountButton";
            this.createAccountButton.Size = new System.Drawing.Size(150, 44);
            this.createAccountButton.TabIndex = 17;
            this.createAccountButton.Text = "Create Account";
            this.createAccountButton.UseVisualStyleBackColor = true;
            this.createAccountButton.Click += new System.EventHandler(this.createAccountButton_Click);
            // 
            // signupPasswordValue
            // 
            this.signupPasswordValue.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.signupPasswordValue.Location = new System.Drawing.Point(120, 181);
            this.signupPasswordValue.Name = "signupPasswordValue";
            this.signupPasswordValue.PasswordChar = '●';
            this.signupPasswordValue.Size = new System.Drawing.Size(180, 29);
            this.signupPasswordValue.TabIndex = 15;
            this.signupPasswordValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // passwordLabel2
            // 
            this.passwordLabel2.AutoSize = true;
            this.passwordLabel2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.passwordLabel2.Location = new System.Drawing.Point(6, 184);
            this.passwordLabel2.Name = "passwordLabel2";
            this.passwordLabel2.Size = new System.Drawing.Size(79, 21);
            this.passwordLabel2.TabIndex = 14;
            this.passwordLabel2.Text = "Password:";
            // 
            // signupUsernameValue
            // 
            this.signupUsernameValue.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.signupUsernameValue.Location = new System.Drawing.Point(120, 146);
            this.signupUsernameValue.Name = "signupUsernameValue";
            this.signupUsernameValue.Size = new System.Drawing.Size(180, 29);
            this.signupUsernameValue.TabIndex = 13;
            this.signupUsernameValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // usernameLabel2
            // 
            this.usernameLabel2.AutoSize = true;
            this.usernameLabel2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.usernameLabel2.Location = new System.Drawing.Point(6, 149);
            this.usernameLabel2.Name = "usernameLabel2";
            this.usernameLabel2.Size = new System.Drawing.Size(84, 21);
            this.usernameLabel2.TabIndex = 12;
            this.usernameLabel2.Text = "Username:";
            // 
            // emailAdressValue
            // 
            this.emailAdressValue.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.emailAdressValue.Location = new System.Drawing.Point(120, 111);
            this.emailAdressValue.Name = "emailAdressValue";
            this.emailAdressValue.Size = new System.Drawing.Size(180, 29);
            this.emailAdressValue.TabIndex = 11;
            this.emailAdressValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // emailAdressLabel
            // 
            this.emailAdressLabel.AutoSize = true;
            this.emailAdressLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.emailAdressLabel.Location = new System.Drawing.Point(6, 114);
            this.emailAdressLabel.Name = "emailAdressLabel";
            this.emailAdressLabel.Size = new System.Drawing.Size(51, 21);
            this.emailAdressLabel.TabIndex = 10;
            this.emailAdressLabel.Text = "Email:";
            // 
            // lastNameValue
            // 
            this.lastNameValue.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lastNameValue.Location = new System.Drawing.Point(120, 76);
            this.lastNameValue.Name = "lastNameValue";
            this.lastNameValue.Size = new System.Drawing.Size(180, 29);
            this.lastNameValue.TabIndex = 9;
            this.lastNameValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lastNameLabel.Location = new System.Drawing.Point(6, 79);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(87, 21);
            this.lastNameLabel.TabIndex = 2;
            this.lastNameLabel.Text = "Last Name:";
            // 
            // firstNameValue
            // 
            this.firstNameValue.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.firstNameValue.Location = new System.Drawing.Point(120, 41);
            this.firstNameValue.Name = "firstNameValue";
            this.firstNameValue.Size = new System.Drawing.Size(180, 29);
            this.firstNameValue.TabIndex = 1;
            this.firstNameValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.AutoSize = true;
            this.firstNameLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.firstNameLabel.Location = new System.Drawing.Point(6, 44);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(89, 21);
            this.firstNameLabel.TabIndex = 0;
            this.firstNameLabel.Text = "First Name:";
            // 
            // orLabel
            // 
            this.orLabel.AutoSize = true;
            this.orLabel.Font = new System.Drawing.Font("Segoe UI", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.orLabel.Location = new System.Drawing.Point(146, 154);
            this.orLabel.Name = "orLabel";
            this.orLabel.Size = new System.Drawing.Size(48, 32);
            this.orLabel.TabIndex = 25;
            this.orLabel.Text = "OR";
            // 
            // signInButton
            // 
            this.signInButton.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.signInButton.Location = new System.Drawing.Point(241, 87);
            this.signInButton.Name = "signInButton";
            this.signInButton.Size = new System.Drawing.Size(85, 34);
            this.signInButton.TabIndex = 24;
            this.signInButton.Text = "Sign In";
            this.signInButton.UseVisualStyleBackColor = true;
            this.signInButton.Click += new System.EventHandler(this.signInButton_Click);
            // 
            // rememberMeCheckBox
            // 
            this.rememberMeCheckBox.AutoSize = true;
            this.rememberMeCheckBox.Checked = true;
            this.rememberMeCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.rememberMeCheckBox.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.rememberMeCheckBox.Location = new System.Drawing.Point(22, 93);
            this.rememberMeCheckBox.Name = "rememberMeCheckBox";
            this.rememberMeCheckBox.Size = new System.Drawing.Size(127, 24);
            this.rememberMeCheckBox.TabIndex = 23;
            this.rememberMeCheckBox.Text = "Remember me";
            this.rememberMeCheckBox.UseVisualStyleBackColor = true;
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.passwordLabel.Location = new System.Drawing.Point(18, 55);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(77, 20);
            this.passwordLabel.TabIndex = 22;
            this.passwordLabel.Text = "Password:";
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.usernameLabel.Location = new System.Drawing.Point(18, 20);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(83, 20);
            this.usernameLabel.TabIndex = 21;
            this.usernameLabel.Text = "Username:";
            // 
            // SignUpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(344, 525);
            this.Controls.Add(this.loginPasswordValue);
            this.Controls.Add(this.loginUsernameValue);
            this.Controls.Add(this.invalidCredentialsLabel);
            this.Controls.Add(this.registerGroupBox);
            this.Controls.Add(this.orLabel);
            this.Controls.Add(this.signInButton);
            this.Controls.Add(this.rememberMeCheckBox);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.usernameLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "SignUpForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sign In / Sign Up";
            this.registerGroupBox.ResumeLayout(false);
            this.registerGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox loginPasswordValue;
        private System.Windows.Forms.TextBox loginUsernameValue;
        private System.Windows.Forms.Label invalidCredentialsLabel;
        private System.Windows.Forms.GroupBox registerGroupBox;
        private System.Windows.Forms.TextBox confirmPasswordValue;
        private System.Windows.Forms.Label confirmPasswordLabel;
        private System.Windows.Forms.Button createAccountButton;
        private System.Windows.Forms.TextBox signupPasswordValue;
        private System.Windows.Forms.Label passwordLabel2;
        private System.Windows.Forms.TextBox signupUsernameValue;
        private System.Windows.Forms.Label usernameLabel2;
        private System.Windows.Forms.TextBox emailAdressValue;
        private System.Windows.Forms.Label emailAdressLabel;
        private System.Windows.Forms.TextBox lastNameValue;
        private System.Windows.Forms.Label lastNameLabel;
        private System.Windows.Forms.TextBox firstNameValue;
        private System.Windows.Forms.Label firstNameLabel;
        private System.Windows.Forms.Label orLabel;
        private System.Windows.Forms.Button signInButton;
        private System.Windows.Forms.CheckBox rememberMeCheckBox;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.Label usernameLabel;
    }
}