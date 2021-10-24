namespace FormApplication
{
    partial class newUser
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
            this.Username = new System.Windows.Forms.Label();
            this.password = new System.Windows.Forms.Label();
            this.Password2 = new System.Windows.Forms.Label();
            this.firstName = new System.Windows.Forms.Label();
            this.lastName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.usernameInput = new System.Windows.Forms.RichTextBox();
            this.passwordInput = new System.Windows.Forms.RichTextBox();
            this.passwordInput2 = new System.Windows.Forms.RichTextBox();
            this.firstNameInput = new System.Windows.Forms.RichTextBox();
            this.lastNameInput = new System.Windows.Forms.RichTextBox();
            this.dobInput = new System.Windows.Forms.DateTimePicker();
            this.userTypeInput = new System.Windows.Forms.ComboBox();
            this.submitButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Username
            // 
            this.Username.AutoSize = true;
            this.Username.Location = new System.Drawing.Point(89, 120);
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(110, 25);
            this.Username.TabIndex = 0;
            this.Username.Text = "Username";
            // 
            // password
            // 
            this.password.AutoSize = true;
            this.password.Location = new System.Drawing.Point(89, 183);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(106, 25);
            this.password.TabIndex = 1;
            this.password.Text = "Password";
            // 
            // Password2
            // 
            this.Password2.AutoSize = true;
            this.Password2.Location = new System.Drawing.Point(89, 239);
            this.Password2.Name = "Password2";
            this.Password2.Size = new System.Drawing.Size(197, 25);
            this.Password2.TabIndex = 2;
            this.Password2.Text = "Re-Enter Password";
            this.Password2.Click += new System.EventHandler(this.label1_Click);
            // 
            // firstName
            // 
            this.firstName.AutoSize = true;
            this.firstName.Location = new System.Drawing.Point(89, 308);
            this.firstName.Name = "firstName";
            this.firstName.Size = new System.Drawing.Size(116, 25);
            this.firstName.TabIndex = 3;
            this.firstName.Text = "First Name";
            this.firstName.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // lastName
            // 
            this.lastName.AutoSize = true;
            this.lastName.Location = new System.Drawing.Point(89, 372);
            this.lastName.Name = "lastName";
            this.lastName.Size = new System.Drawing.Size(115, 25);
            this.lastName.TabIndex = 4;
            this.lastName.Text = "Last Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(89, 444);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "Date of Birth";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(267, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(262, 33);
            this.label2.TabIndex = 6;
            this.label2.Text = "Create a New User";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(89, 511);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 25);
            this.label3.TabIndex = 7;
            this.label3.Text = "User-Type";
            // 
            // usernameInput
            // 
            this.usernameInput.Location = new System.Drawing.Point(302, 108);
            this.usernameInput.Name = "usernameInput";
            this.usernameInput.Size = new System.Drawing.Size(385, 37);
            this.usernameInput.TabIndex = 8;
            this.usernameInput.Text = "";
            // 
            // passwordInput
            // 
            this.passwordInput.Location = new System.Drawing.Point(302, 162);
            this.passwordInput.Name = "passwordInput";
            this.passwordInput.Size = new System.Drawing.Size(385, 46);
            this.passwordInput.TabIndex = 9;
            this.passwordInput.Text = "";
            // 
            // passwordInput2
            // 
            this.passwordInput2.Location = new System.Drawing.Point(302, 218);
            this.passwordInput2.Name = "passwordInput2";
            this.passwordInput2.Size = new System.Drawing.Size(385, 46);
            this.passwordInput2.TabIndex = 10;
            this.passwordInput2.Text = "";
            this.passwordInput2.TextChanged += new System.EventHandler(this.richTextBox2_TextChanged);
            // 
            // firstNameInput
            // 
            this.firstNameInput.Location = new System.Drawing.Point(302, 287);
            this.firstNameInput.Name = "firstNameInput";
            this.firstNameInput.Size = new System.Drawing.Size(385, 46);
            this.firstNameInput.TabIndex = 11;
            this.firstNameInput.Text = "";
            // 
            // lastNameInput
            // 
            this.lastNameInput.Location = new System.Drawing.Point(302, 351);
            this.lastNameInput.Name = "lastNameInput";
            this.lastNameInput.Size = new System.Drawing.Size(385, 46);
            this.lastNameInput.TabIndex = 12;
            this.lastNameInput.Text = "";
            // 
            // dobInput
            // 
            this.dobInput.Location = new System.Drawing.Point(302, 438);
            this.dobInput.Name = "dobInput";
            this.dobInput.Size = new System.Drawing.Size(200, 31);
            this.dobInput.TabIndex = 13;
            // 
            // userTypeInput
            // 
            this.userTypeInput.FormattingEnabled = true;
            this.userTypeInput.Items.AddRange(new object[] {
            "View",
            "Edit"});
            this.userTypeInput.Location = new System.Drawing.Point(302, 511);
            this.userTypeInput.Name = "userTypeInput";
            this.userTypeInput.Size = new System.Drawing.Size(121, 33);
            this.userTypeInput.TabIndex = 14;
            // 
            // submitButton
            // 
            this.submitButton.BackColor = System.Drawing.SystemColors.Highlight;
            this.submitButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.submitButton.Location = new System.Drawing.Point(455, 570);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(171, 61);
            this.submitButton.TabIndex = 15;
            this.submitButton.Text = "Submit";
            this.submitButton.UseVisualStyleBackColor = false;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.cancelButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.cancelButton.Location = new System.Drawing.Point(212, 570);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(159, 61);
            this.cancelButton.TabIndex = 16;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = false;
            // 
            // newUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 710);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.userTypeInput);
            this.Controls.Add(this.dobInput);
            this.Controls.Add(this.lastNameInput);
            this.Controls.Add(this.firstNameInput);
            this.Controls.Add(this.passwordInput2);
            this.Controls.Add(this.passwordInput);
            this.Controls.Add(this.usernameInput);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lastName);
            this.Controls.Add(this.firstName);
            this.Controls.Add(this.Password2);
            this.Controls.Add(this.password);
            this.Controls.Add(this.Username);
            this.Name = "newUser";
            this.Text = "newUser";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Username;
        private System.Windows.Forms.Label password;
        private System.Windows.Forms.Label Password2;
        private System.Windows.Forms.Label firstName;
        private System.Windows.Forms.Label lastName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox usernameInput;
        private System.Windows.Forms.RichTextBox passwordInput;
        private System.Windows.Forms.RichTextBox passwordInput2;
        private System.Windows.Forms.RichTextBox firstNameInput;
        private System.Windows.Forms.RichTextBox lastNameInput;
        private System.Windows.Forms.DateTimePicker dobInput;
        private System.Windows.Forms.ComboBox userTypeInput;
        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.Button cancelButton;
    }
}