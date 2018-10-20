namespace IPR.GUI_s
{
    partial class SpecialistForm
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
            this.MenuPanel = new System.Windows.Forms.Panel();
            this.RefreshButton = new System.Windows.Forms.Button();
            this.AddPatientButton = new System.Windows.Forms.Button();
            this.HistoricalDataButton = new System.Windows.Forms.Button();
            this.PatientsButton = new System.Windows.Forms.Button();
            this.SpecialistTitleOfFormLabel = new System.Windows.Forms.Label();
            this.TopPanel = new System.Windows.Forms.Panel();
            this.ByciclePanel = new System.Windows.Forms.Panel();
            this.startTest = new System.Windows.Forms.Button();
            this.MenuPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // MenuPanel
            // 
            this.MenuPanel.BackColor = System.Drawing.Color.DimGray;
            this.MenuPanel.Controls.Add(this.startTest);
            this.MenuPanel.Controls.Add(this.RefreshButton);
            this.MenuPanel.Controls.Add(this.AddPatientButton);
            this.MenuPanel.Controls.Add(this.HistoricalDataButton);
            this.MenuPanel.Controls.Add(this.PatientsButton);
            this.MenuPanel.Controls.Add(this.SpecialistTitleOfFormLabel);
            this.MenuPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.MenuPanel.ForeColor = System.Drawing.SystemColors.Control;
            this.MenuPanel.Location = new System.Drawing.Point(0, 0);
            this.MenuPanel.Name = "MenuPanel";
            this.MenuPanel.Size = new System.Drawing.Size(272, 641);
            this.MenuPanel.TabIndex = 0;
            // 
            // RefreshButton
            // 
            this.RefreshButton.BackColor = System.Drawing.Color.Silver;
            this.RefreshButton.FlatAppearance.BorderSize = 0;
            this.RefreshButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RefreshButton.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RefreshButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.RefreshButton.Location = new System.Drawing.Point(0, 269);
            this.RefreshButton.Name = "RefreshButton";
            this.RefreshButton.Size = new System.Drawing.Size(272, 38);
            this.RefreshButton.TabIndex = 4;
            this.RefreshButton.Text = "Refresh";
            this.RefreshButton.UseVisualStyleBackColor = false;
            // 
            // AddPatientButton
            // 
            this.AddPatientButton.BackColor = System.Drawing.Color.Silver;
            this.AddPatientButton.FlatAppearance.BorderSize = 0;
            this.AddPatientButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddPatientButton.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddPatientButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.AddPatientButton.Location = new System.Drawing.Point(0, 221);
            this.AddPatientButton.Name = "AddPatientButton";
            this.AddPatientButton.Size = new System.Drawing.Size(272, 42);
            this.AddPatientButton.TabIndex = 3;
            this.AddPatientButton.Text = "Add Patient";
            this.AddPatientButton.UseVisualStyleBackColor = false;
            this.AddPatientButton.Click += new System.EventHandler(this.AddPatientButton_Click);
            // 
            // HistoricalDataButton
            // 
            this.HistoricalDataButton.BackColor = System.Drawing.Color.Silver;
            this.HistoricalDataButton.FlatAppearance.BorderSize = 0;
            this.HistoricalDataButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HistoricalDataButton.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HistoricalDataButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.HistoricalDataButton.Location = new System.Drawing.Point(0, 176);
            this.HistoricalDataButton.Name = "HistoricalDataButton";
            this.HistoricalDataButton.Size = new System.Drawing.Size(272, 39);
            this.HistoricalDataButton.TabIndex = 2;
            this.HistoricalDataButton.Text = "Historical Data";
            this.HistoricalDataButton.UseVisualStyleBackColor = false;
            this.HistoricalDataButton.Click += new System.EventHandler(this.HistoricalDataButton_Click);
            // 
            // PatientsButton
            // 
            this.PatientsButton.BackColor = System.Drawing.Color.Silver;
            this.PatientsButton.FlatAppearance.BorderSize = 0;
            this.PatientsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PatientsButton.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PatientsButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.PatientsButton.Location = new System.Drawing.Point(0, 134);
            this.PatientsButton.Name = "PatientsButton";
            this.PatientsButton.Size = new System.Drawing.Size(272, 36);
            this.PatientsButton.TabIndex = 1;
            this.PatientsButton.Text = "Patients";
            this.PatientsButton.UseVisualStyleBackColor = false;
            // 
            // SpecialistTitleOfFormLabel
            // 
            this.SpecialistTitleOfFormLabel.AutoSize = true;
            this.SpecialistTitleOfFormLabel.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SpecialistTitleOfFormLabel.Location = new System.Drawing.Point(38, 33);
            this.SpecialistTitleOfFormLabel.Name = "SpecialistTitleOfFormLabel";
            this.SpecialistTitleOfFormLabel.Size = new System.Drawing.Size(193, 22);
            this.SpecialistTitleOfFormLabel.TabIndex = 0;
            this.SpecialistTitleOfFormLabel.Text = "Avans-Ästrand  Test";
            // 
            // TopPanel
            // 
            this.TopPanel.BackColor = System.Drawing.Color.Firebrick;
            this.TopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopPanel.Location = new System.Drawing.Point(272, 0);
            this.TopPanel.Name = "TopPanel";
            this.TopPanel.Size = new System.Drawing.Size(1079, 19);
            this.TopPanel.TabIndex = 1;
            // 
            // ByciclePanel
            // 
            this.ByciclePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ByciclePanel.Location = new System.Drawing.Point(272, 19);
            this.ByciclePanel.Name = "ByciclePanel";
            this.ByciclePanel.Size = new System.Drawing.Size(1079, 622);
            this.ByciclePanel.TabIndex = 2;
            // 
            // startTest
            // 
            this.startTest.BackColor = System.Drawing.Color.Silver;
            this.startTest.FlatAppearance.BorderSize = 0;
            this.startTest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.startTest.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startTest.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.startTest.Location = new System.Drawing.Point(0, 367);
            this.startTest.Name = "startTest";
            this.startTest.Size = new System.Drawing.Size(272, 38);
            this.startTest.TabIndex = 5;
            this.startTest.Text = "Start Test";
            this.startTest.UseVisualStyleBackColor = false;
            // 
            // SpecialistForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1351, 641);
            this.Controls.Add(this.ByciclePanel);
            this.Controls.Add(this.TopPanel);
            this.Controls.Add(this.MenuPanel);
            this.Name = "SpecialistForm";
            this.Text = "SpecialistForm";
            this.MenuPanel.ResumeLayout(false);
            this.MenuPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel MenuPanel;
        private System.Windows.Forms.Button RefreshButton;
        private System.Windows.Forms.Button AddPatientButton;
        private System.Windows.Forms.Button HistoricalDataButton;
        private System.Windows.Forms.Button PatientsButton;
        private System.Windows.Forms.Label SpecialistTitleOfFormLabel;
        private System.Windows.Forms.Panel TopPanel;
        private System.Windows.Forms.Panel ByciclePanel;
        private System.Windows.Forms.Button startTest;
    }
}