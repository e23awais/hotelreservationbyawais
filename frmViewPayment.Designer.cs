namespace HotelReservationSystem
{
    partial class frmViewPayment
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
            this.btnViewCancel = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnViewSearch = new System.Windows.Forms.Button();
            this.txtPaymentID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvPayment = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPayment)).BeginInit();
            this.SuspendLayout();
            // 
            // btnViewCancel
            // 
            this.btnViewCancel.BackColor = System.Drawing.Color.Black;
            this.btnViewCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewCancel.ForeColor = System.Drawing.Color.White;
            this.btnViewCancel.Location = new System.Drawing.Point(767, 45);
            this.btnViewCancel.Name = "btnViewCancel";
            this.btnViewCancel.Size = new System.Drawing.Size(105, 39);
            this.btnViewCancel.TabIndex = 14;
            this.btnViewCancel.Text = "Cancel";
            this.btnViewCancel.UseVisualStyleBackColor = false;
            this.btnViewCancel.Click += new System.EventHandler(this.btnViewCancel_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(-2, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(151, 16);
            this.label3.TabIndex = 13;
            this.label3.Text = "Enter Id below to Search";
            // 
            // btnViewSearch
            // 
            this.btnViewSearch.BackColor = System.Drawing.Color.Black;
            this.btnViewSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewSearch.ForeColor = System.Drawing.Color.White;
            this.btnViewSearch.Location = new System.Drawing.Point(608, 45);
            this.btnViewSearch.Name = "btnViewSearch";
            this.btnViewSearch.Size = new System.Drawing.Size(105, 39);
            this.btnViewSearch.TabIndex = 12;
            this.btnViewSearch.Text = "Search";
            this.btnViewSearch.UseVisualStyleBackColor = false;
            this.btnViewSearch.Click += new System.EventHandler(this.btnViewSearch_Click);
            // 
            // txtPaymentID
            // 
            this.txtPaymentID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPaymentID.Location = new System.Drawing.Point(171, 52);
            this.txtPaymentID.Name = "txtPaymentID";
            this.txtPaymentID.Size = new System.Drawing.Size(142, 26);
            this.txtPaymentID.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(-3, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 24);
            this.label2.TabIndex = 10;
            this.label2.Text = "Payment ID:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(302, -1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(321, 33);
            this.label1.TabIndex = 9;
            this.label1.Text = "View Payment History";
            // 
            // dgvPayment
            // 
            this.dgvPayment.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPayment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPayment.Location = new System.Drawing.Point(1, 97);
            this.dgvPayment.Name = "dgvPayment";
            this.dgvPayment.Size = new System.Drawing.Size(926, 392);
            this.dgvPayment.TabIndex = 8;
            // 
            // frmViewPayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(925, 489);
            this.Controls.Add(this.btnViewCancel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnViewSearch);
            this.Controls.Add(this.txtPaymentID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvPayment);
            this.Name = "frmViewPayment";
            this.Text = "View Payment";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.dgvPayment)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnViewCancel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnViewSearch;
        private System.Windows.Forms.TextBox txtPaymentID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvPayment;
    }
}