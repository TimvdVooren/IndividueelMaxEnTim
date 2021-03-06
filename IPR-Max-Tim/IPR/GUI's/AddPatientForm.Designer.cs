﻿namespace IPR.GUI_s
{
    partial class AddPatientForm
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
            this.CancelButton = new System.Windows.Forms.Button();
            this.AddPatientButton = new System.Windows.Forms.Button();
            this.gender = new System.Windows.Forms.TextBox();
            this.age = new System.Windows.Forms.TextBox();
            this.name = new System.Windows.Forms.TextBox();
            this.weight = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CancelButton
            // 
            this.CancelButton.BackColor = System.Drawing.Color.Silver;
            this.CancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CancelButton.FlatAppearance.BorderSize = 0;
            this.CancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CancelButton.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancelButton.Location = new System.Drawing.Point(168, 207);
            this.CancelButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(109, 27);
            this.CancelButton.TabIndex = 6;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = false;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // AddPatientButton
            // 
            this.AddPatientButton.BackColor = System.Drawing.Color.Silver;
            this.AddPatientButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.AddPatientButton.FlatAppearance.BorderSize = 0;
            this.AddPatientButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddPatientButton.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddPatientButton.Location = new System.Drawing.Point(44, 207);
            this.AddPatientButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.AddPatientButton.Name = "AddPatientButton";
            this.AddPatientButton.Size = new System.Drawing.Size(116, 27);
            this.AddPatientButton.TabIndex = 5;
            this.AddPatientButton.Text = "Add Patient";
            this.AddPatientButton.UseVisualStyleBackColor = false;
            this.AddPatientButton.Click += new System.EventHandler(this.AddPatientButton_Click);
            // 
            // gender
            // 
            this.gender.Font = new System.Drawing.Font("Century Gothic", 10.2F);
            this.gender.Location = new System.Drawing.Point(168, 119);
            this.gender.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gender.Name = "gender";
            this.gender.Size = new System.Drawing.Size(110, 24);
            this.gender.TabIndex = 3;
            // 
            // age
            // 
            this.age.Font = new System.Drawing.Font("Century Gothic", 10.2F);
            this.age.Location = new System.Drawing.Point(168, 80);
            this.age.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.age.Name = "age";
            this.age.Size = new System.Drawing.Size(110, 24);
            this.age.TabIndex = 2;
            // 
            // name
            // 
            this.name.Font = new System.Drawing.Font("Century Gothic", 10.2F);
            this.name.Location = new System.Drawing.Point(168, 40);
            this.name.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(110, 24);
            this.name.TabIndex = 1;
            // 
            // weight
            // 
            this.weight.Font = new System.Drawing.Font("Century Gothic", 10.2F);
            this.weight.Location = new System.Drawing.Point(168, 156);
            this.weight.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.weight.Name = "weight";
            this.weight.Size = new System.Drawing.Size(110, 24);
            this.weight.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(40, 41);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 19);
            this.label1.TabIndex = 6;
            this.label1.Text = "Patient Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(40, 80);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 19);
            this.label2.TabIndex = 7;
            this.label2.Text = "Patient Age:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(40, 119);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 19);
            this.label3.TabIndex = 8;
            this.label3.Text = "Patient Gender:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(40, 157);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 19);
            this.label4.TabIndex = 9;
            this.label4.Text = "Patient Weight:";
            // 
            // AddPatientForm
            // 
            this.AcceptButton = this.AddPatientButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(308, 287);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.weight);
            this.Controls.Add(this.name);
            this.Controls.Add(this.age);
            this.Controls.Add(this.gender);
            this.Controls.Add(this.AddPatientButton);
            this.Controls.Add(this.CancelButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddPatientForm";
            this.Text = "AddPatientForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button AddPatientButton;
        private System.Windows.Forms.TextBox gender;
        private System.Windows.Forms.TextBox age;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.TextBox weight;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}