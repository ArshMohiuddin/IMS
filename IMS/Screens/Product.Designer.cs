namespace IMS
{
    partial class Product
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label3 = new System.Windows.Forms.Label();
            this.proNameTxt = new System.Windows.Forms.TextBox();
            this.proNameErrorLabel = new System.Windows.Forms.Label();
            this.barCodeTxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.BarcodeErrorLabel = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.ExpiryErrorLabel = new System.Windows.Forms.Label();
            this.ExpiryPicker = new System.Windows.Forms.DateTimePicker();
            this.PriceTxt = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.PriceErrorLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.CatDD = new System.Windows.Forms.ComboBox();
            this.catErrorLabel = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.proIDGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.proNameGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.barcodeGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.expiryGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.catGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.catIDGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RightPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.LeftPanel.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.FlatAppearance.BorderSize = 0;
            // 
            // RightPanel
            // 
            this.RightPanel.Controls.Add(this.dataGridView1);
            this.RightPanel.Controls.SetChildIndex(this.panel1, 0);
            this.RightPanel.Controls.SetChildIndex(this.panel3, 0);
            this.RightPanel.Controls.SetChildIndex(this.dataGridView1, 0);
            // 
            // LeftPanel
            // 
            this.LeftPanel.Controls.Add(this.CatDD);
            this.LeftPanel.Controls.Add(this.label5);
            this.LeftPanel.Controls.Add(this.PriceTxt);
            this.LeftPanel.Controls.Add(this.label8);
            this.LeftPanel.Controls.Add(this.ExpiryPicker);
            this.LeftPanel.Controls.Add(this.barCodeTxt);
            this.LeftPanel.Controls.Add(this.label4);
            this.LeftPanel.Controls.Add(this.proNameTxt);
            this.LeftPanel.Controls.Add(this.label3);
            this.LeftPanel.Controls.Add(this.proNameErrorLabel);
            this.LeftPanel.Controls.Add(this.BarcodeErrorLabel);
            this.LeftPanel.Controls.Add(this.label6);
            this.LeftPanel.Controls.Add(this.ExpiryErrorLabel);
            this.LeftPanel.Controls.Add(this.PriceErrorLabel);
            this.LeftPanel.Controls.Add(this.catErrorLabel);
            this.LeftPanel.Controls.SetChildIndex(this.catErrorLabel, 0);
            this.LeftPanel.Controls.SetChildIndex(this.PriceErrorLabel, 0);
            this.LeftPanel.Controls.SetChildIndex(this.ExpiryErrorLabel, 0);
            this.LeftPanel.Controls.SetChildIndex(this.label6, 0);
            this.LeftPanel.Controls.SetChildIndex(this.BarcodeErrorLabel, 0);
            this.LeftPanel.Controls.SetChildIndex(this.proNameErrorLabel, 0);
            this.LeftPanel.Controls.SetChildIndex(this.panel2, 0);
            this.LeftPanel.Controls.SetChildIndex(this.panel4, 0);
            this.LeftPanel.Controls.SetChildIndex(this.label3, 0);
            this.LeftPanel.Controls.SetChildIndex(this.proNameTxt, 0);
            this.LeftPanel.Controls.SetChildIndex(this.label4, 0);
            this.LeftPanel.Controls.SetChildIndex(this.barCodeTxt, 0);
            this.LeftPanel.Controls.SetChildIndex(this.ExpiryPicker, 0);
            this.LeftPanel.Controls.SetChildIndex(this.label8, 0);
            this.LeftPanel.Controls.SetChildIndex(this.PriceTxt, 0);
            this.LeftPanel.Controls.SetChildIndex(this.label5, 0);
            this.LeftPanel.Controls.SetChildIndex(this.CatDD, 0);
            // 
            // btnLogout
            // 
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Product Name";
            // 
            // proNameTxt
            // 
            this.proNameTxt.Location = new System.Drawing.Point(4, 114);
            this.proNameTxt.Name = "proNameTxt";
            this.proNameTxt.Size = new System.Drawing.Size(240, 23);
            this.proNameTxt.TabIndex = 4;
            // 
            // proNameErrorLabel
            // 
            this.proNameErrorLabel.AutoSize = true;
            this.proNameErrorLabel.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.proNameErrorLabel.ForeColor = System.Drawing.Color.Salmon;
            this.proNameErrorLabel.Location = new System.Drawing.Point(99, 89);
            this.proNameErrorLabel.Name = "proNameErrorLabel";
            this.proNameErrorLabel.Size = new System.Drawing.Size(20, 28);
            this.proNameErrorLabel.TabIndex = 14;
            this.proNameErrorLabel.Text = "*";
            this.proNameErrorLabel.Visible = false;
            // 
            // barCodeTxt
            // 
            this.barCodeTxt.Location = new System.Drawing.Point(4, 159);
            this.barCodeTxt.Name = "barCodeTxt";
            this.barCodeTxt.Size = new System.Drawing.Size(240, 23);
            this.barCodeTxt.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 15);
            this.label4.TabIndex = 15;
            this.label4.Text = "Barcode";
            // 
            // BarcodeErrorLabel
            // 
            this.BarcodeErrorLabel.AutoSize = true;
            this.BarcodeErrorLabel.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BarcodeErrorLabel.ForeColor = System.Drawing.Color.Salmon;
            this.BarcodeErrorLabel.Location = new System.Drawing.Point(99, 134);
            this.BarcodeErrorLabel.Name = "BarcodeErrorLabel";
            this.BarcodeErrorLabel.Size = new System.Drawing.Size(20, 28);
            this.BarcodeErrorLabel.TabIndex = 17;
            this.BarcodeErrorLabel.Text = "*";
            this.BarcodeErrorLabel.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 184);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 15);
            this.label6.TabIndex = 18;
            this.label6.Text = "Expiry Date";
            // 
            // ExpiryErrorLabel
            // 
            this.ExpiryErrorLabel.AutoSize = true;
            this.ExpiryErrorLabel.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExpiryErrorLabel.ForeColor = System.Drawing.Color.Salmon;
            this.ExpiryErrorLabel.Location = new System.Drawing.Point(99, 178);
            this.ExpiryErrorLabel.Name = "ExpiryErrorLabel";
            this.ExpiryErrorLabel.Size = new System.Drawing.Size(20, 28);
            this.ExpiryErrorLabel.TabIndex = 20;
            this.ExpiryErrorLabel.Text = "*";
            this.ExpiryErrorLabel.Visible = false;
            // 
            // ExpiryPicker
            // 
            this.ExpiryPicker.CustomFormat = "dd-MMM-yyyy";
            this.ExpiryPicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.ExpiryPicker.Location = new System.Drawing.Point(4, 202);
            this.ExpiryPicker.Name = "ExpiryPicker";
            this.ExpiryPicker.Size = new System.Drawing.Size(240, 23);
            this.ExpiryPicker.TabIndex = 21;
            // 
            // PriceTxt
            // 
            this.PriceTxt.Location = new System.Drawing.Point(4, 247);
            this.PriceTxt.Name = "PriceTxt";
            this.PriceTxt.Size = new System.Drawing.Size(240, 23);
            this.PriceTxt.TabIndex = 23;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 229);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(33, 15);
            this.label8.TabIndex = 22;
            this.label8.Text = "Price";
            // 
            // PriceErrorLabel
            // 
            this.PriceErrorLabel.AutoSize = true;
            this.PriceErrorLabel.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PriceErrorLabel.ForeColor = System.Drawing.Color.Salmon;
            this.PriceErrorLabel.Location = new System.Drawing.Point(99, 221);
            this.PriceErrorLabel.Name = "PriceErrorLabel";
            this.PriceErrorLabel.Size = new System.Drawing.Size(20, 28);
            this.PriceErrorLabel.TabIndex = 24;
            this.PriceErrorLabel.Text = "*";
            this.PriceErrorLabel.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 273);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 15);
            this.label5.TabIndex = 25;
            this.label5.Text = "Category";
            // 
            // CatDD
            // 
            this.CatDD.BackColor = System.Drawing.Color.White;
            this.CatDD.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CatDD.FormattingEnabled = true;
            this.CatDD.Location = new System.Drawing.Point(4, 290);
            this.CatDD.Name = "CatDD";
            this.CatDD.Size = new System.Drawing.Size(240, 23);
            this.CatDD.TabIndex = 26;
            // 
            // catErrorLabel
            // 
            this.catErrorLabel.AutoSize = true;
            this.catErrorLabel.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.catErrorLabel.ForeColor = System.Drawing.Color.Salmon;
            this.catErrorLabel.Location = new System.Drawing.Point(99, 266);
            this.catErrorLabel.Name = "catErrorLabel";
            this.catErrorLabel.Size = new System.Drawing.Size(20, 28);
            this.catErrorLabel.TabIndex = 27;
            this.catErrorLabel.Text = "*";
            this.catErrorLabel.Visible = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.proIDGV,
            this.proNameGV,
            this.barcodeGV,
            this.expiryGV,
            this.priceGV,
            this.catGV,
            this.catIDGV});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 92);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.RowHeadersVisible = false;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(953, 573);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // proIDGV
            // 
            this.proIDGV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.proIDGV.HeaderText = "proID";
            this.proIDGV.Name = "proIDGV";
            this.proIDGV.ReadOnly = true;
            this.proIDGV.Visible = false;
            // 
            // proNameGV
            // 
            this.proNameGV.HeaderText = "Product";
            this.proNameGV.Name = "proNameGV";
            this.proNameGV.ReadOnly = true;
            // 
            // barcodeGV
            // 
            this.barcodeGV.HeaderText = "Barcode";
            this.barcodeGV.Name = "barcodeGV";
            this.barcodeGV.ReadOnly = true;
            // 
            // expiryGV
            // 
            this.expiryGV.HeaderText = "Expiry Date";
            this.expiryGV.Name = "expiryGV";
            this.expiryGV.ReadOnly = true;
            // 
            // priceGV
            // 
            dataGridViewCellStyle2.Format = "N2";
            dataGridViewCellStyle2.NullValue = "0";
            this.priceGV.DefaultCellStyle = dataGridViewCellStyle2;
            this.priceGV.HeaderText = "Price";
            this.priceGV.Name = "priceGV";
            this.priceGV.ReadOnly = true;
            // 
            // catGV
            // 
            this.catGV.HeaderText = "Category";
            this.catGV.Name = "catGV";
            this.catGV.ReadOnly = true;
            // 
            // catIDGV
            // 
            this.catIDGV.HeaderText = "CatID";
            this.catIDGV.Name = "catIDGV";
            this.catIDGV.ReadOnly = true;
            this.catIDGV.Visible = false;
            // 
            // Product
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1203, 665);
            this.Name = "Product";
            this.Text = "Product";
            this.Load += new System.EventHandler(this.Product_Load);
            this.RightPanel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.LeftPanel.ResumeLayout(false);
            this.LeftPanel.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox proNameTxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox barCodeTxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label proNameErrorLabel;
        private System.Windows.Forms.Label BarcodeErrorLabel;
        private System.Windows.Forms.TextBox PriceTxt;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker ExpiryPicker;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label ExpiryErrorLabel;
        private System.Windows.Forms.Label PriceErrorLabel;
        private System.Windows.Forms.ComboBox CatDD;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label catErrorLabel;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn proIDGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn proNameGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn barcodeGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn expiryGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn catGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn catIDGV;
    }
}