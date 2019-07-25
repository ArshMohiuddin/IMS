namespace IMS
{
    partial class Login
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
            this.usernameTxt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.passtxt = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.nameErrorLabel = new System.Windows.Forms.Label();
            this.PassErrorLabel = new System.Windows.Forms.Label();
            this.RightPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.LeftPanel.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // RightPanel
            // 
            this.RightPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.RightPanel.Cursor = System.Windows.Forms.Cursors.Default;
            // 
            // LeftPanel
            // 
            this.LeftPanel.Controls.Add(this.btnLogin);
            this.LeftPanel.Controls.Add(this.passtxt);
            this.LeftPanel.Controls.Add(this.label5);
            this.LeftPanel.Controls.Add(this.usernameTxt);
            this.LeftPanel.Controls.Add(this.label4);
            this.LeftPanel.Controls.Add(this.nameErrorLabel);
            this.LeftPanel.Controls.Add(this.PassErrorLabel);
            this.LeftPanel.Controls.SetChildIndex(this.PassErrorLabel, 0);
            this.LeftPanel.Controls.SetChildIndex(this.nameErrorLabel, 0);
            this.LeftPanel.Controls.SetChildIndex(this.panel2, 0);
            this.LeftPanel.Controls.SetChildIndex(this.label4, 0);
            this.LeftPanel.Controls.SetChildIndex(this.usernameTxt, 0);
            this.LeftPanel.Controls.SetChildIndex(this.label5, 0);
            this.LeftPanel.Controls.SetChildIndex(this.passtxt, 0);
            this.LeftPanel.Controls.SetChildIndex(this.btnLogin, 0);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 277);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 15);
            this.label4.TabIndex = 2;
            this.label4.Text = "Username";
            // 
            // usernameTxt
            // 
            this.usernameTxt.Location = new System.Drawing.Point(12, 295);
            this.usernameTxt.MaxLength = 30;
            this.usernameTxt.Name = "usernameTxt";
            this.usernameTxt.Size = new System.Drawing.Size(224, 23);
            this.usernameTxt.TabIndex = 3;
            this.usernameTxt.TextChanged += new System.EventHandler(this.usernameTxt_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 323);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 15);
            this.label5.TabIndex = 2;
            this.label5.Text = "Password";
            // 
            // passtxt
            // 
            this.passtxt.Location = new System.Drawing.Point(12, 341);
            this.passtxt.MaxLength = 30;
            this.passtxt.Name = "passtxt";
            this.passtxt.Size = new System.Drawing.Size(224, 23);
            this.passtxt.TabIndex = 6;
            this.passtxt.UseSystemPasswordChar = true;
            this.passtxt.TextChanged += new System.EventHandler(this.passtxt_TextChanged);
            // 
            // btnLogin
            // 
            this.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogin.FlatAppearance.BorderSize = 2;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Location = new System.Drawing.Point(12, 370);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(224, 38);
            this.btnLogin.TabIndex = 9;
            this.btnLogin.Text = "LOGIN";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // nameErrorLabel
            // 
            this.nameErrorLabel.AutoSize = true;
            this.nameErrorLabel.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameErrorLabel.ForeColor = System.Drawing.Color.Salmon;
            this.nameErrorLabel.Location = new System.Drawing.Point(221, 271);
            this.nameErrorLabel.Name = "nameErrorLabel";
            this.nameErrorLabel.Size = new System.Drawing.Size(20, 28);
            this.nameErrorLabel.TabIndex = 14;
            this.nameErrorLabel.Text = "*";
            this.nameErrorLabel.Visible = false;
            // 
            // PassErrorLabel
            // 
            this.PassErrorLabel.AutoSize = true;
            this.PassErrorLabel.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PassErrorLabel.ForeColor = System.Drawing.Color.Salmon;
            this.PassErrorLabel.Location = new System.Drawing.Point(221, 319);
            this.PassErrorLabel.Name = "PassErrorLabel";
            this.PassErrorLabel.Size = new System.Drawing.Size(20, 28);
            this.PassErrorLabel.TabIndex = 15;
            this.PassErrorLabel.Text = "*";
            this.PassErrorLabel.Visible = false;
            // 
            // Login
            // 
            this.AcceptButton = this.btnLogin;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1203, 619);
            this.Name = "Login";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.RightPanel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.LeftPanel.ResumeLayout(false);
            this.LeftPanel.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.TextBox passtxt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox usernameTxt;
        private System.Windows.Forms.Label nameErrorLabel;
        private System.Windows.Forms.Label PassErrorLabel;
    }
}