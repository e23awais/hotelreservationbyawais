namespace HotelReservationSystem
{
    partial class frmViewReservations
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
            this.dgvReservation = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtReservationID = new System.Windows.Forms.TextBox();
            this.btnViewSearch = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnViewCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReservation)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvReservation
            // 
            this.dgvReservation.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvReservation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReservation.Location = new System.Drawing.Point(1, 110);
            this.dgvReservation.Name = "dgvReservation";
            this.dgvReservation.Size = new System.Drawing.Size(926, 377);
            this.dgvReservation.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(318, -3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(280, 33);
            this.label1.TabIndex = 1;
            this.label1.Text = "Hotel Reservations";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(-3, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Reservation ID:";
            // 
            // txtReservationID
            // 
            this.txtReservationID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReservationID.Location = new System.Drawing.Point(171, 50);
            this.txtReservationID.Name = "txtReservationID";
            this.txtReservationID.Size = new System.Drawing.Size(142, 26);
            this.txtReservationID.TabIndex = 3;
            // 
            // btnViewSearch
            // 
            this.btnViewSearch.BackColor = System.Drawing.Color.Black;
            this.btnViewSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewSearch.ForeColor = System.Drawing.Color.White;
            this.btnViewSearch.Location = new System.Drawing.Point(608, 43);
            this.btnViewSearch.Name = "btnViewSearch";
            this.btnViewSearch.Size = new System.Drawing.Size(105, 39);
            this.btnViewSearch.TabIndex = 4;
            this.btnViewSearch.Text = "Search";
            this.btnViewSearch.UseVisualStyleBackColor = false;
            this.btnViewSearch.Click += new System.EventHandler(this.btnViewSearch_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.label3.Location = new System.Drawing.Point(-2, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(151, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Enter Id below to Search";
            // 
            // btnViewCancel
            // 
            this.btnViewCancel.BackColor = System.Drawing.Color.Black;
            this.btnViewCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewCancel.ForeColor = System.Drawing.Color.White;
            this.btnViewCancel.Location = new System.Drawing.Point(767, 43);
            this.btnViewCancel.Name = "btnViewCancel";
            this.btnViewCancel.Size = new System.Drawing.Size(105, 39);
            this.btnViewCancel.TabIndex = 7;
            this.btnViewCancel.Text = "Cancel";
            this.btnViewCancel.UseVisualStyleBackColor = false;
            this.btnViewCancel.Click += new System.EventHandler(this.btnViewCancel_Click);
            // 
            // frmViewReservations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(925, 489);
            this.Controls.Add(this.btnViewCancel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnViewSearch);
            this.Controls.Add(this.txtReservationID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvReservation);
            this.Name = "frmViewReservations";
            this.Text = "View Reservations";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.dgvReservation)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvReservation;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtReservationID;
        private System.Windows.Forms.Button btnViewSearch;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnViewCancel;
    }
}