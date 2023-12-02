namespace DB_Connections
{
    partial class CRForm
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
            this.CrystalReport1 = new DB_Connections.CrystalReport();
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.viewbutton = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Backbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = -1;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystalReportViewer1.Location = new System.Drawing.Point(0, 0);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.Size = new System.Drawing.Size(800, 450);
            this.crystalReportViewer1.TabIndex = 3;
            // 
            // viewbutton
            // 
            this.viewbutton.Location = new System.Drawing.Point(704, 5);
            this.viewbutton.Name = "viewbutton";
            this.viewbutton.Size = new System.Drawing.Size(84, 26);
            this.viewbutton.TabIndex = 6;
            this.viewbutton.Text = "View";
            this.viewbutton.UseVisualStyleBackColor = true;
            this.viewbutton.Click += new System.EventHandler(this.viewbutton_Click_1);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(598, 9);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 5;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(513, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Food Name";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // Backbutton
            // 
            this.Backbutton.BackColor = System.Drawing.Color.Maroon;
            this.Backbutton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Backbutton.Location = new System.Drawing.Point(716, 424);
            this.Backbutton.Name = "Backbutton";
            this.Backbutton.Size = new System.Drawing.Size(84, 26);
            this.Backbutton.TabIndex = 7;
            this.Backbutton.Text = "Back";
            this.Backbutton.UseVisualStyleBackColor = false;
            this.Backbutton.Click += new System.EventHandler(this.Backbutton_Click);
            // 
            // CRForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Backbutton);
            this.Controls.Add(this.viewbutton);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.crystalReportViewer1);
            this.Name = "CRForm";
            this.Text = "CRForm";
            this.Load += new System.EventHandler(this.CRForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CrystalReport CrystalReport1;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
        private System.Windows.Forms.Button viewbutton;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Backbutton;
    }
}