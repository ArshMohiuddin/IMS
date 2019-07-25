namespace IMS
{
    partial class categories
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label4 = new System.Windows.Forms.Label();
            this.categoryNameTxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.catNameErrorLabel = new System.Windows.Forms.Label();
            this.IsActiveErrorLabel = new System.Windows.Forms.Label();
            this.isActiveCB = new System.Windows.Forms.ComboBox();
            this.CatDataGridView = new System.Windows.Forms.DataGridView();
            this.catIDGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StatusGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RightPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.LeftPanel.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CatDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.FlatAppearance.BorderSize = 0;
            // 
            // RightPanel
            // 
            this.RightPanel.Controls.Add(this.CatDataGridView);
            this.RightPanel.Controls.SetChildIndex(this.panel1, 0);
            this.RightPanel.Controls.SetChildIndex(this.panel3, 0);
            this.RightPanel.Controls.SetChildIndex(this.CatDataGridView, 0);
            // 
            // LeftPanel
            // 
            this.LeftPanel.Controls.Add(this.isActiveCB);
            this.LeftPanel.Controls.Add(this.label4);
            this.LeftPanel.Controls.Add(this.categoryNameTxt);
            this.LeftPanel.Controls.Add(this.label3);
            this.LeftPanel.Controls.Add(this.catNameErrorLabel);
            this.LeftPanel.Controls.Add(this.IsActiveErrorLabel);
            this.LeftPanel.Controls.SetChildIndex(this.IsActiveErrorLabel, 0);
            this.LeftPanel.Controls.SetChildIndex(this.catNameErrorLabel, 0);
            this.LeftPanel.Controls.SetChildIndex(this.label3, 0);
            this.LeftPanel.Controls.SetChildIndex(this.categoryNameTxt, 0);
            this.LeftPanel.Controls.SetChildIndex(this.label4, 0);
            this.LeftPanel.Controls.SetChildIndex(this.panel2, 0);
            this.LeftPanel.Controls.SetChildIndex(this.panel4, 0);
            this.LeftPanel.Controls.SetChildIndex(this.isActiveCB, 0);
            // 
            // btnLogout
            // 
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 15);
            this.label4.TabIndex = 21;
            this.label4.Text = "Is-Active";
            // 
            // categoryNameTxt
            // 
            this.categoryNameTxt.Location = new System.Drawing.Point(4, 114);
            this.categoryNameTxt.Name = "categoryNameTxt";
            this.categoryNameTxt.Size = new System.Drawing.Size(240, 23);
            this.categoryNameTxt.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 15);
            this.label3.TabIndex = 18;
            this.label3.Text = "Category Name";
            // 
            // catNameErrorLabel
            // 
            this.catNameErrorLabel.AutoSize = true;
            this.catNameErrorLabel.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.catNameErrorLabel.ForeColor = System.Drawing.Color.Salmon;
            this.catNameErrorLabel.Location = new System.Drawing.Point(99, 89);
            this.catNameErrorLabel.Name = "catNameErrorLabel";
            this.catNameErrorLabel.Size = new System.Drawing.Size(20, 28);
            this.catNameErrorLabel.TabIndex = 20;
            this.catNameErrorLabel.Text = "*";
            this.catNameErrorLabel.Visible = false;
            // 
            // IsActiveErrorLabel
            // 
            this.IsActiveErrorLabel.AutoSize = true;
            this.IsActiveErrorLabel.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IsActiveErrorLabel.ForeColor = System.Drawing.Color.Salmon;
            this.IsActiveErrorLabel.Location = new System.Drawing.Point(99, 134);
            this.IsActiveErrorLabel.Name = "IsActiveErrorLabel";
            this.IsActiveErrorLabel.Size = new System.Drawing.Size(20, 28);
            this.IsActiveErrorLabel.TabIndex = 23;
            this.IsActiveErrorLabel.Text = "*";
            this.IsActiveErrorLabel.Visible = false;
            // 
            // isActiveCB
            // 
            this.isActiveCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.isActiveCB.FormattingEnabled = true;
            this.isActiveCB.Items.AddRange(new object[] {
            "Yes",
            "No"});
            this.isActiveCB.Location = new System.Drawing.Point(4, 158);
            this.isActiveCB.Name = "isActiveCB";
            this.isActiveCB.Size = new System.Drawing.Size(240, 23);
            this.isActiveCB.TabIndex = 24;
            // 
            // CatDataGridView
            // 
            this.CatDataGridView.AllowUserToAddRows = false;
            this.CatDataGridView.AllowUserToDeleteRows = false;
            this.CatDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.CatDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.CatDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.CatDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.CatDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CatDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.catIDGV,
            this.NameGV,
            this.StatusGV});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.CatDataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.CatDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CatDataGridView.Location = new System.Drawing.Point(0, 92);
            this.CatDataGridView.Name = "CatDataGridView";
            this.CatDataGridView.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.CatDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.CatDataGridView.RowHeadersVisible = false;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.CatDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.CatDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.CatDataGridView.Size = new System.Drawing.Size(953, 573);
            this.CatDataGridView.TabIndex = 3;
            this.CatDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CatDataGridView_CellClick);
            // 
            // catIDGV
            // 
            this.catIDGV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.catIDGV.HeaderText = "CatID";
            this.catIDGV.Name = "catIDGV";
            this.catIDGV.ReadOnly = true;
            this.catIDGV.Visible = false;
            // 
            // NameGV
            // 
            this.NameGV.HeaderText = "Name";
            this.NameGV.Name = "NameGV";
            this.NameGV.ReadOnly = true;
            // 
            // StatusGV
            // 
            this.StatusGV.HeaderText = "Status";
            this.StatusGV.Name = "StatusGV";
            this.StatusGV.ReadOnly = true;
            // 
            // categories
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1203, 665);
            this.Name = "categories";
            this.Text = "categories";
            this.Load += new System.EventHandler(this.categories_Load);
            this.RightPanel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.LeftPanel.ResumeLayout(false);
            this.LeftPanel.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.CatDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox categoryNameTxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label catNameErrorLabel;
        private System.Windows.Forms.Label IsActiveErrorLabel;
        private System.Windows.Forms.ComboBox isActiveCB;
        private System.Windows.Forms.DataGridView CatDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn catIDGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn StatusGV;
    }
}