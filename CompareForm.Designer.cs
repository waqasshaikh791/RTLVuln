namespace RTLVuln
{
    partial class CompareForm
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.rtbVunerableResponse = new System.Windows.Forms.RichTextBox();
            this.rtbResponse = new System.Windows.Forms.RichTextBox();
            this.btnReason = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.rtbVunerableResponse, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.rtbResponse, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnReason, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 54F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(916, 478);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // rtbVunerableResponse
            // 
            this.rtbVunerableResponse.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbVunerableResponse.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbVunerableResponse.Location = new System.Drawing.Point(461, 2);
            this.rtbVunerableResponse.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rtbVunerableResponse.Name = "rtbVunerableResponse";
            this.rtbVunerableResponse.Size = new System.Drawing.Size(452, 420);
            this.rtbVunerableResponse.TabIndex = 1;
            this.rtbVunerableResponse.Text = "";
            // 
            // rtbResponse
            // 
            this.rtbResponse.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbResponse.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbResponse.Location = new System.Drawing.Point(3, 2);
            this.rtbResponse.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rtbResponse.Name = "rtbResponse";
            this.rtbResponse.Size = new System.Drawing.Size(452, 420);
            this.rtbResponse.TabIndex = 0;
            this.rtbResponse.Text = "";
            // 
            // btnReason
            // 
            this.btnReason.BackColor = System.Drawing.Color.DimGray;
            this.btnReason.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnReason.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReason.ForeColor = System.Drawing.Color.White;
            this.btnReason.Location = new System.Drawing.Point(461, 426);
            this.btnReason.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnReason.Name = "btnReason";
            this.btnReason.Size = new System.Drawing.Size(452, 50);
            this.btnReason.TabIndex = 2;
            this.btnReason.Text = "Reason";
            this.btnReason.UseVisualStyleBackColor = false;
            this.btnReason.Click += new System.EventHandler(this.btnReason_Click);
            // 
            // CompareForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(916, 478);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "CompareForm";
            this.Text = "RTLVUL - Compare";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.CompareForm_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.RichTextBox rtbVunerableResponse;
        private System.Windows.Forms.RichTextBox rtbResponse;
        private System.Windows.Forms.Button btnReason;
    }
}