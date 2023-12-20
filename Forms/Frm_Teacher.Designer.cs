namespace SparkSystem
{
    partial class Frm_Teacher
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Teacher));
            this.btnReservation = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnManage = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnReservation
            // 
            this.btnReservation.BackColor = System.Drawing.Color.White;
            this.btnReservation.FlatAppearance.BorderSize = 0;
            this.btnReservation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReservation.Font = new System.Drawing.Font("Gill Sans MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReservation.ForeColor = System.Drawing.Color.LimeGreen;
            this.btnReservation.Image = global::SparkSystem.Properties.Resources.transaction;
            this.btnReservation.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnReservation.Location = new System.Drawing.Point(123, 236);
            this.btnReservation.Name = "btnReservation";
            this.btnReservation.Size = new System.Drawing.Size(216, 161);
            this.btnReservation.TabIndex = 5;
            this.btnReservation.Text = "Book Reservation";
            this.btnReservation.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnReservation.UseVisualStyleBackColor = false;
            this.btnReservation.Click += new System.EventHandler(this.btnReservation_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::SparkSystem.Properties.Resources.Logo;
            this.pictureBox1.Location = new System.Drawing.Point(251, 54);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(308, 132);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // btnManage
            // 
            this.btnManage.BackColor = System.Drawing.Color.White;
            this.btnManage.FlatAppearance.BorderSize = 0;
            this.btnManage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManage.Font = new System.Drawing.Font("Gill Sans MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManage.ForeColor = System.Drawing.Color.LimeGreen;
            this.btnManage.Image = global::SparkSystem.Properties.Resources.manage;
            this.btnManage.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnManage.Location = new System.Drawing.Point(469, 236);
            this.btnManage.Name = "btnManage";
            this.btnManage.Size = new System.Drawing.Size(216, 161);
            this.btnManage.TabIndex = 6;
            this.btnManage.Text = "Manage Parking";
            this.btnManage.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnManage.UseVisualStyleBackColor = false;
            this.btnManage.Click += new System.EventHandler(this.btnProfile_Click);
            // 
            // Frm_Teacher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SparkSystem.Properties.Resources.backgorund;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnManage);
            this.Controls.Add(this.btnReservation);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Frm_Teacher";
            this.Text = "Frm_Teacher";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnReservation;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnManage;
    }
}