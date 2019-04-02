namespace IPR.GUI_s
{
    partial class DoctorLoginForm
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
            this.UsernameTextBox = new System.Windows.Forms.TextBox();
            this.PasswordTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.CancelLoginButton = new System.Windows.Forms.Button();
            this.CreateAccButton = new System.Windows.Forms.Button();
            this.LoginButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // UsernameTextBox
            // 
            this.UsernameTextBox.Font = new System.Drawing.Font("Century Gothic", 10.2F);
            this.UsernameTextBox.Location = new System.Drawing.Point(138, 35);
            this.UsernameTextBox.Name = "UsernameTextBox";
            this.UsernameTextBox.Size = new System.Drawing.Size(197, 28);
            this.UsernameTextBox.TabIndex = 0;
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.Font = new System.Drawing.Font("Century Gothic", 10.2F);
            this.PasswordTextBox.Location = new System.Drawing.Point(138, 77);
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.PasswordChar = '*';
            this.PasswordTextBox.Size = new System.Drawing.Size(197, 28);
            this.PasswordTextBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10.2F);
            this.label1.Location = new System.Drawing.Point(23, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "Username:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10.2F);
            this.label2.Location = new System.Drawing.Point(23, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 21);
            this.label2.TabIndex = 3;
            this.label2.Text = "Password:";
            // 
            // CancelLoginButton
            // 
            this.CancelLoginButton.BackColor = System.Drawing.Color.Silver;
            this.CancelLoginButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CancelLoginButton.FlatAppearance.BorderSize = 0;
            this.CancelLoginButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CancelLoginButton.Font = new System.Drawing.Font("Century Gothic", 10.2F);
            this.CancelLoginButton.Location = new System.Drawing.Point(138, 165);
            this.CancelLoginButton.Name = "CancelLoginButton";
            this.CancelLoginButton.Size = new System.Drawing.Size(97, 35);
            this.CancelLoginButton.TabIndex = 4;
            this.CancelLoginButton.Text = "Cancel";
            this.CancelLoginButton.UseVisualStyleBackColor = false;
            this.CancelLoginButton.Click += new System.EventHandler(this.CancelLoginButton_Click);
            // 
            // CreateAccButton
            // 
            this.CreateAccButton.BackColor = System.Drawing.Color.Silver;
            this.CreateAccButton.FlatAppearance.BorderSize = 0;
            this.CreateAccButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CreateAccButton.Font = new System.Drawing.Font("Century Gothic", 10.2F);
            this.CreateAccButton.Location = new System.Drawing.Point(138, 121);
            this.CreateAccButton.Name = "CreateAccButton";
            this.CreateAccButton.Size = new System.Drawing.Size(240, 38);
            this.CreateAccButton.TabIndex = 5;
            this.CreateAccButton.Text = "Create new account";
            this.CreateAccButton.UseVisualStyleBackColor = false;
            this.CreateAccButton.Click += new System.EventHandler(this.CreateAccButton_Click);
            // 
            // LoginButton
            // 
            this.LoginButton.BackColor = System.Drawing.Color.Silver;
            this.LoginButton.FlatAppearance.BorderSize = 0;
            this.LoginButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LoginButton.Font = new System.Drawing.Font("Century Gothic", 10.2F);
            this.LoginButton.Location = new System.Drawing.Point(27, 121);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(105, 38);
            this.LoginButton.TabIndex = 6;
            this.LoginButton.Text = "Login";
            this.LoginButton.UseVisualStyleBackColor = false;
            this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // DoctorLoginForm
            // 
            this.AcceptButton = this.LoginButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.CancelButton = this.CancelLoginButton;
            this.ClientSize = new System.Drawing.Size(389, 238);
            this.Controls.Add(this.LoginButton);
            this.Controls.Add(this.CreateAccButton);
            this.Controls.Add(this.CancelLoginButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PasswordTextBox);
            this.Controls.Add(this.UsernameTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DoctorLoginForm";
            this.Text = "DoctorLoginForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox UsernameTextBox;
        private System.Windows.Forms.TextBox PasswordTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button CancelLoginButton;
        private System.Windows.Forms.Button CreateAccButton;
        private System.Windows.Forms.Button LoginButton;
    }
}