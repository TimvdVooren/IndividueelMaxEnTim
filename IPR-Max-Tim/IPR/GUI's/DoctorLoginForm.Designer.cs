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
            this.UsernameTextBox.Location = new System.Drawing.Point(166, 32);
            this.UsernameTextBox.Name = "UsernameTextBox";
            this.UsernameTextBox.Size = new System.Drawing.Size(155, 22);
            this.UsernameTextBox.TabIndex = 0;
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.Location = new System.Drawing.Point(166, 73);
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.Size = new System.Drawing.Size(155, 22);
            this.PasswordTextBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(74, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Username";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(74, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Password:";
            // 
            // CancelLoginButton
            // 
            this.CancelLoginButton.BackColor = System.Drawing.Color.Silver;
            this.CancelLoginButton.FlatAppearance.BorderSize = 0;
            this.CancelLoginButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CancelLoginButton.Location = new System.Drawing.Point(283, 165);
            this.CancelLoginButton.Name = "CancelLoginButton";
            this.CancelLoginButton.Size = new System.Drawing.Size(97, 35);
            this.CancelLoginButton.TabIndex = 4;
            this.CancelLoginButton.Text = "Cancel";
            this.CancelLoginButton.UseVisualStyleBackColor = false;
            // 
            // CreateAccButton
            // 
            this.CreateAccButton.BackColor = System.Drawing.Color.Silver;
            this.CreateAccButton.FlatAppearance.BorderSize = 0;
            this.CreateAccButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CreateAccButton.Location = new System.Drawing.Point(186, 121);
            this.CreateAccButton.Name = "CreateAccButton";
            this.CreateAccButton.Size = new System.Drawing.Size(194, 38);
            this.CreateAccButton.TabIndex = 5;
            this.CreateAccButton.Text = "Create new account";
            this.CreateAccButton.UseVisualStyleBackColor = false;
            // 
            // LoginButton
            // 
            this.LoginButton.BackColor = System.Drawing.Color.Silver;
            this.LoginButton.FlatAppearance.BorderSize = 0;
            this.LoginButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LoginButton.Location = new System.Drawing.Point(55, 121);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(125, 38);
            this.LoginButton.TabIndex = 6;
            this.LoginButton.Text = "Login";
            this.LoginButton.UseVisualStyleBackColor = false;
            // 
            // DoctorLoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(418, 240);
            this.Controls.Add(this.LoginButton);
            this.Controls.Add(this.CreateAccButton);
            this.Controls.Add(this.CancelLoginButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PasswordTextBox);
            this.Controls.Add(this.UsernameTextBox);
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