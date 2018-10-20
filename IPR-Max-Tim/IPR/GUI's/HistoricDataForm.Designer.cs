namespace IPR.GUI_s
{
    partial class HistoricDataForm
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
            this.requestedPatientName = new System.Windows.Forms.TextBox();
            this.historicData = new System.Windows.Forms.RichTextBox();
            this.SearchButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // requestedPatientName
            // 
            this.requestedPatientName.Font = new System.Drawing.Font("Century Gothic", 10.2F);
            this.requestedPatientName.Location = new System.Drawing.Point(437, 27);
            this.requestedPatientName.Name = "requestedPatientName";
            this.requestedPatientName.Size = new System.Drawing.Size(310, 28);
            this.requestedPatientName.TabIndex = 0;
            // 
            // historicData
            // 
            this.historicData.Font = new System.Drawing.Font("Century Gothic", 10.2F);
            this.historicData.Location = new System.Drawing.Point(16, 73);
            this.historicData.Name = "historicData";
            this.historicData.ReadOnly = true;
            this.historicData.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.historicData.Size = new System.Drawing.Size(862, 364);
            this.historicData.TabIndex = 1;
            this.historicData.Text = "";
            // 
            // SearchButton
            // 
            this.SearchButton.BackColor = System.Drawing.Color.DarkGray;
            this.SearchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SearchButton.Font = new System.Drawing.Font("Century Gothic", 10.2F);
            this.SearchButton.Location = new System.Drawing.Point(776, 24);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(102, 33);
            this.SearchButton.TabIndex = 2;
            this.SearchButton.Text = "Search";
            this.SearchButton.UseVisualStyleBackColor = false;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10.2F);
            this.label1.Location = new System.Drawing.Point(12, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(380, 21);
            this.label1.TabIndex = 3;
            this.label1.Text = "Enter the name of the required patient here:";
            // 
            // HistoricDataForm
            // 
            this.AcceptButton = this.SearchButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(890, 453);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.historicData);
            this.Controls.Add(this.requestedPatientName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "HistoricDataForm";
            this.Text = "HistoricDataForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox requestedPatientName;
        private System.Windows.Forms.RichTextBox historicData;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.Label label1;
    }
}