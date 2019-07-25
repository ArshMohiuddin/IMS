namespace IMS
{
    partial class Settings
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
            this.label4 = new System.Windows.Forms.Label();
            this.ServerTxt = new System.Windows.Forms.TextBox();
            this.databaseTxt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.UserIdTxt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.passTxt = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.isCB = new System.Windows.Forms.CheckBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.RightPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.LeftPanel.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // RightPanel
            // 
            this.RightPanel.Size = new System.Drawing.Size(953, 642);
            // 
            // LeftPanel
            // 
            this.LeftPanel.Controls.Add(this.btnSave);
            this.LeftPanel.Controls.Add(this.isCB);
            this.LeftPanel.Controls.Add(this.passTxt);
            this.LeftPanel.Controls.Add(this.label7);
            this.LeftPanel.Controls.Add(this.UserIdTxt);
            this.LeftPanel.Controls.Add(this.label6);
            this.LeftPanel.Controls.Add(this.databaseTxt);
            this.LeftPanel.Controls.Add(this.label5);
            this.LeftPanel.Controls.Add(this.ServerTxt);
            this.LeftPanel.Controls.Add(this.label4);
            this.LeftPanel.Size = new System.Drawing.Size(250, 642);
            this.LeftPanel.Controls.SetChildIndex(this.panel2, 0);
            this.LeftPanel.Controls.SetChildIndex(this.label4, 0);
            this.LeftPanel.Controls.SetChildIndex(this.ServerTxt, 0);
            this.LeftPanel.Controls.SetChildIndex(this.label5, 0);
            this.LeftPanel.Controls.SetChildIndex(this.databaseTxt, 0);
            this.LeftPanel.Controls.SetChildIndex(this.label6, 0);
            this.LeftPanel.Controls.SetChildIndex(this.UserIdTxt, 0);
            this.LeftPanel.Controls.SetChildIndex(this.label7, 0);
            this.LeftPanel.Controls.SetChildIndex(this.passTxt, 0);
            this.LeftPanel.Controls.SetChildIndex(this.isCB, 0);
            this.LeftPanel.Controls.SetChildIndex(this.btnSave, 0);
            // 
            // btnLogout
            // 
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 188);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 15);
            this.label4.TabIndex = 2;
            this.label4.Text = "Server";
            // 
            // ServerTxt
            // 
            this.ServerTxt.Location = new System.Drawing.Point(9, 206);
            this.ServerTxt.MaxLength = 50;
            this.ServerTxt.Name = "ServerTxt";
            this.ServerTxt.Size = new System.Drawing.Size(232, 23);
            this.ServerTxt.TabIndex = 3;
            // 
            // databaseTxt
            // 
            this.databaseTxt.Location = new System.Drawing.Point(9, 250);
            this.databaseTxt.MaxLength = 50;
            this.databaseTxt.Name = "databaseTxt";
            this.databaseTxt.Size = new System.Drawing.Size(232, 23);
            this.databaseTxt.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 232);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "Database";
            // 
            // UserIdTxt
            // 
            this.UserIdTxt.Location = new System.Drawing.Point(9, 293);
            this.UserIdTxt.MaxLength = 30;
            this.UserIdTxt.Name = "UserIdTxt";
            this.UserIdTxt.Size = new System.Drawing.Size(232, 23);
            this.UserIdTxt.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 275);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 15);
            this.label6.TabIndex = 6;
            this.label6.Text = "User ID";
            // 
            // passTxt
            // 
            this.passTxt.Location = new System.Drawing.Point(9, 337);
            this.passTxt.MaxLength = 30;
            this.passTxt.Name = "passTxt";
            this.passTxt.Size = new System.Drawing.Size(232, 23);
            this.passTxt.TabIndex = 9;
            this.passTxt.UseSystemPasswordChar = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 319);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 15);
            this.label7.TabIndex = 8;
            this.label7.Text = "Password";
            // 
            // isCB
            // 
            this.isCB.AutoSize = true;
            this.isCB.Location = new System.Drawing.Point(9, 366);
            this.isCB.Name = "isCB";
            this.isCB.Size = new System.Drawing.Size(125, 19);
            this.isCB.TabIndex = 10;
            this.isCB.Text = "Integrated Security";
            this.isCB.UseVisualStyleBackColor = true;
            this.isCB.CheckedChanged += new System.EventHandler(this.isCB_CheckedChanged);
            // 
            // btnSave
            // 
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.FlatAppearance.BorderSize = 2;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Location = new System.Drawing.Point(9, 392);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(232, 38);
            this.btnSave.TabIndex = 11;
            this.btnSave.Text = "SAVE";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1203, 642);
            this.Name = "Settings";
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.Settings_Load);
            this.RightPanel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.LeftPanel.ResumeLayout(false);
            this.LeftPanel.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.CheckBox isCB;
        private System.Windows.Forms.TextBox passTxt;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox UserIdTxt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox databaseTxt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox ServerTxt;
    }
}