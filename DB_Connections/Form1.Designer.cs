namespace DB_Connections
{
    partial class Form1
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textUsername = new System.Windows.Forms.TextBox();
            this.textStock = new System.Windows.Forms.TextBox();
            this.SearchButton = new System.Windows.Forms.Button();
            this.DTPExpiryDate = new System.Windows.Forms.DateTimePicker();
            this.DTPStockInDate = new System.Windows.Forms.DateTimePicker();
            this.textUsedStock = new System.Windows.Forms.TextBox();
            this.UpdateButton = new System.Windows.Forms.Button();
            this.textStockID = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 225);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(776, 268);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(75, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Bahan Makanan";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(75, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Stok Persediaan";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(75, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(149, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Tanggal Stok Masuk";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(75, 166);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Stok Terpakai";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label5.Location = new System.Drawing.Point(75, 196);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(158, 16);
            this.label5.TabIndex = 5;
            this.label5.Text = "Tanggal Kadaluwarsa";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // textUsername
            // 
            this.textUsername.Location = new System.Drawing.Point(248, 77);
            this.textUsername.Name = "textUsername";
            this.textUsername.Size = new System.Drawing.Size(173, 22);
            this.textUsername.TabIndex = 6;
            this.textUsername.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textStock
            // 
            this.textStock.Location = new System.Drawing.Point(248, 105);
            this.textStock.Name = "textStock";
            this.textStock.Size = new System.Drawing.Size(173, 22);
            this.textStock.TabIndex = 7;
            this.textStock.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // SearchButton
            // 
            this.SearchButton.Location = new System.Drawing.Point(653, 134);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(118, 51);
            this.SearchButton.TabIndex = 15;
            this.SearchButton.Text = "Search";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.button5_Click);
            // 
            // DTPExpiryDate
            // 
            this.DTPExpiryDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DTPExpiryDate.Location = new System.Drawing.Point(248, 191);
            this.DTPExpiryDate.Name = "DTPExpiryDate";
            this.DTPExpiryDate.Size = new System.Drawing.Size(95, 22);
            this.DTPExpiryDate.TabIndex = 17;
            this.DTPExpiryDate.ValueChanged += new System.EventHandler(this.dateTimePicker2_ValueChanged);
            // 
            // DTPStockInDate
            // 
            this.DTPStockInDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DTPStockInDate.Location = new System.Drawing.Point(248, 133);
            this.DTPStockInDate.Name = "DTPStockInDate";
            this.DTPStockInDate.Size = new System.Drawing.Size(95, 22);
            this.DTPStockInDate.TabIndex = 18;
            // 
            // textUsedStock
            // 
            this.textUsedStock.Location = new System.Drawing.Point(248, 161);
            this.textUsedStock.Name = "textUsedStock";
            this.textUsedStock.Size = new System.Drawing.Size(173, 22);
            this.textUsedStock.TabIndex = 19;
            this.textUsedStock.TextChanged += new System.EventHandler(this.textBox3_TextChanged_1);
            // 
            // UpdateButton
            // 
            this.UpdateButton.Location = new System.Drawing.Point(516, 134);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(118, 51);
            this.UpdateButton.TabIndex = 20;
            this.UpdateButton.Text = "Update";
            this.UpdateButton.UseVisualStyleBackColor = true;
            this.UpdateButton.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // textStockID
            // 
            this.textStockID.Location = new System.Drawing.Point(248, 36);
            this.textStockID.Name = "textStockID";
            this.textStockID.Size = new System.Drawing.Size(95, 22);
            this.textStockID.TabIndex = 21;
            this.textStockID.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label6.Location = new System.Drawing.Point(75, 39);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 16);
            this.label6.TabIndex = 22;
            this.label6.Text = "ID Makanan";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = global::DB_Connections.Properties.Resources.unklab12;
            this.ClientSize = new System.Drawing.Size(800, 505);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textStockID);
            this.Controls.Add(this.UpdateButton);
            this.Controls.Add(this.textUsedStock);
            this.Controls.Add(this.DTPStockInDate);
            this.Controls.Add(this.DTPExpiryDate);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.textStock);
            this.Controls.Add(this.textUsername);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "AdminForm";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textUsername;
        private System.Windows.Forms.TextBox textStock;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.DateTimePicker DTPExpiryDate;
        private System.Windows.Forms.DateTimePicker DTPStockInDate;
        private System.Windows.Forms.TextBox textUsedStock;
        private System.Windows.Forms.Button UpdateButton;
        private System.Windows.Forms.TextBox textStockID;
        private System.Windows.Forms.Label label6;
    }
}

