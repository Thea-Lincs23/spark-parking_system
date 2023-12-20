namespace SparkSystem
{
    partial class Frm_Admin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Admin));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnParkinglogs = new System.Windows.Forms.Button();
            this.btnuserlogs = new System.Windows.Forms.Button();
            this.dgv_View = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_View)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::SparkSystem.Properties.Resources.Logo;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(236, 96);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // btnParkinglogs
            // 
            this.btnParkinglogs.BackColor = System.Drawing.Color.LimeGreen;
            this.btnParkinglogs.FlatAppearance.BorderSize = 0;
            this.btnParkinglogs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnParkinglogs.Font = new System.Drawing.Font("Gill Sans MT", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnParkinglogs.ForeColor = System.Drawing.Color.White;
            this.btnParkinglogs.Location = new System.Drawing.Point(34, 208);
            this.btnParkinglogs.Name = "btnParkinglogs";
            this.btnParkinglogs.Size = new System.Drawing.Size(177, 40);
            this.btnParkinglogs.TabIndex = 4;
            this.btnParkinglogs.Text = "Parking Logs";
            this.btnParkinglogs.UseVisualStyleBackColor = false;
            this.btnParkinglogs.Click += new System.EventHandler(this.btnParkinglogs_Click);
            // 
            // btnuserlogs
            // 
            this.btnuserlogs.BackColor = System.Drawing.Color.LimeGreen;
            this.btnuserlogs.FlatAppearance.BorderSize = 0;
            this.btnuserlogs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnuserlogs.Font = new System.Drawing.Font("Gill Sans MT", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnuserlogs.ForeColor = System.Drawing.Color.White;
            this.btnuserlogs.Location = new System.Drawing.Point(34, 127);
            this.btnuserlogs.Name = "btnuserlogs";
            this.btnuserlogs.Size = new System.Drawing.Size(177, 40);
            this.btnuserlogs.TabIndex = 3;
            this.btnuserlogs.Text = "User Logs";
            this.btnuserlogs.UseVisualStyleBackColor = false;
            this.btnuserlogs.Click += new System.EventHandler(this.btnuserlogs_Click);
            // 
            // dgv_View
            // 
            this.dgv_View.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_View.Location = new System.Drawing.Point(299, 12);
            this.dgv_View.Name = "dgv_View";
            this.dgv_View.Size = new System.Drawing.Size(476, 361);
            this.dgv_View.TabIndex = 5;
            // 
            // Frm_Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SparkSystem.Properties.Resources.backgorund;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgv_View);
            this.Controls.Add(this.btnParkinglogs);
            this.Controls.Add(this.btnuserlogs);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Frm_Admin";
            this.Text = "Frm_Admin";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_View)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnParkinglogs;
        private System.Windows.Forms.Button btnuserlogs;
        private System.Windows.Forms.DataGridView dgv_View;
    }
}