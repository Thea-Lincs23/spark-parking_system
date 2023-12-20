namespace SparkSystem.Forms
{
    partial class Booking_Teacher
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
            this.components = new System.ComponentModel.Container();
            this.button1 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtResult = new System.Windows.Forms.RichTextBox();
            this.rdGate8Car = new System.Windows.Forms.RadioButton();
            this.rdGate5Motor = new System.Windows.Forms.RadioButton();
            this.rdGate4Car = new System.Windows.Forms.RadioButton();
            this.rdGate3Motor = new System.Windows.Forms.RadioButton();
            this.rdGate3Car = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnBook = new System.Windows.Forms.Button();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.txtGateNum = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtVecType = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtParkNum = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPlatenum = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.PictureBox = new System.Windows.Forms.PictureBox();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(15, 18);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(35, 33);
            this.button1.TabIndex = 20;
            this.button1.Text = "<";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Gill Sans MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label6.Location = new System.Drawing.Point(876, 14);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 23);
            this.label6.TabIndex = 19;
            this.label6.Text = "Receipt";
            // 
            // txtResult
            // 
            this.txtResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResult.Location = new System.Drawing.Point(861, 40);
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(301, 436);
            this.txtResult.TabIndex = 18;
            this.txtResult.Text = "";
            // 
            // rdGate8Car
            // 
            this.rdGate8Car.AutoSize = true;
            this.rdGate8Car.BackColor = System.Drawing.Color.Transparent;
            this.rdGate8Car.Font = new System.Drawing.Font("Gill Sans MT", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdGate8Car.Location = new System.Drawing.Point(639, 331);
            this.rdGate8Car.Name = "rdGate8Car";
            this.rdGate8Car.Size = new System.Drawing.Size(91, 22);
            this.rdGate8Car.TabIndex = 17;
            this.rdGate8Car.TabStop = true;
            this.rdGate8Car.Text = "Gate 8 car";
            this.rdGate8Car.UseVisualStyleBackColor = false;
            this.rdGate8Car.CheckedChanged += new System.EventHandler(this.rdGate8Car_CheckedChanged);
            // 
            // rdGate5Motor
            // 
            this.rdGate5Motor.AutoSize = true;
            this.rdGate5Motor.BackColor = System.Drawing.Color.Transparent;
            this.rdGate5Motor.Font = new System.Drawing.Font("Gill Sans MT", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdGate5Motor.Location = new System.Drawing.Point(523, 331);
            this.rdGate5Motor.Name = "rdGate5Motor";
            this.rdGate5Motor.Size = new System.Drawing.Size(110, 22);
            this.rdGate5Motor.TabIndex = 16;
            this.rdGate5Motor.TabStop = true;
            this.rdGate5Motor.Text = "Gate 5 motor";
            this.rdGate5Motor.UseVisualStyleBackColor = false;
            this.rdGate5Motor.CheckedChanged += new System.EventHandler(this.rdGate5Motor_CheckedChanged);
            // 
            // rdGate4Car
            // 
            this.rdGate4Car.AutoSize = true;
            this.rdGate4Car.BackColor = System.Drawing.Color.Transparent;
            this.rdGate4Car.Font = new System.Drawing.Font("Gill Sans MT", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdGate4Car.Location = new System.Drawing.Point(696, 303);
            this.rdGate4Car.Name = "rdGate4Car";
            this.rdGate4Car.Size = new System.Drawing.Size(91, 22);
            this.rdGate4Car.TabIndex = 15;
            this.rdGate4Car.TabStop = true;
            this.rdGate4Car.Text = "Gate 4 car";
            this.rdGate4Car.UseVisualStyleBackColor = false;
            this.rdGate4Car.CheckedChanged += new System.EventHandler(this.rdGate4Car_CheckedChanged);
            // 
            // rdGate3Motor
            // 
            this.rdGate3Motor.AutoSize = true;
            this.rdGate3Motor.BackColor = System.Drawing.Color.Transparent;
            this.rdGate3Motor.Font = new System.Drawing.Font("Gill Sans MT", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdGate3Motor.Location = new System.Drawing.Point(585, 303);
            this.rdGate3Motor.Name = "rdGate3Motor";
            this.rdGate3Motor.Size = new System.Drawing.Size(110, 22);
            this.rdGate3Motor.TabIndex = 14;
            this.rdGate3Motor.TabStop = true;
            this.rdGate3Motor.Text = "Gate 3 motor";
            this.rdGate3Motor.UseVisualStyleBackColor = false;
            this.rdGate3Motor.CheckedChanged += new System.EventHandler(this.rdGate3Motor_CheckedChanged);
            // 
            // rdGate3Car
            // 
            this.rdGate3Car.AutoSize = true;
            this.rdGate3Car.BackColor = System.Drawing.Color.Transparent;
            this.rdGate3Car.Font = new System.Drawing.Font("Gill Sans MT", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdGate3Car.Location = new System.Drawing.Point(484, 303);
            this.rdGate3Car.Name = "rdGate3Car";
            this.rdGate3Car.Size = new System.Drawing.Size(91, 22);
            this.rdGate3Car.TabIndex = 13;
            this.rdGate3Car.TabStop = true;
            this.rdGate3Car.Text = "Gate 3 car";
            this.rdGate3Car.UseVisualStyleBackColor = false;
            this.rdGate3Car.CheckedChanged += new System.EventHandler(this.rdGate3Car_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.btnReset);
            this.panel1.Controls.Add(this.btnPrint);
            this.panel1.Controls.Add(this.btnBook);
            this.panel1.Controls.Add(this.btnGenerate);
            this.panel1.Controls.Add(this.txtGateNum);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtVecType);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtParkNum);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtPlatenum);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtName);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Location = new System.Drawing.Point(68, 18);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(360, 458);
            this.panel1.TabIndex = 12;
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(89, 403);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(169, 38);
            this.btnReset.TabIndex = 14;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(238, 345);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(106, 38);
            this.btnPrint.TabIndex = 13;
            this.btnPrint.Text = "Print receipt";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnBook
            // 
            this.btnBook.Location = new System.Drawing.Point(126, 345);
            this.btnBook.Name = "btnBook";
            this.btnBook.Size = new System.Drawing.Size(106, 38);
            this.btnBook.TabIndex = 12;
            this.btnBook.Text = "Book";
            this.btnBook.UseVisualStyleBackColor = true;
            this.btnBook.Click += new System.EventHandler(this.btnBook_Click);
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(14, 345);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(106, 38);
            this.btnGenerate.TabIndex = 8;
            this.btnGenerate.Text = "Generate receipt";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // txtGateNum
            // 
            this.txtGateNum.Location = new System.Drawing.Point(155, 274);
            this.txtGateNum.Multiline = true;
            this.txtGateNum.Name = "txtGateNum";
            this.txtGateNum.Size = new System.Drawing.Size(114, 31);
            this.txtGateNum.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Gill Sans MT", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.LimeGreen;
            this.label5.Location = new System.Drawing.Point(152, 253);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 18);
            this.label5.TabIndex = 10;
            this.label5.Text = "Gate number";
            // 
            // txtVecType
            // 
            this.txtVecType.Location = new System.Drawing.Point(19, 274);
            this.txtVecType.Multiline = true;
            this.txtVecType.Name = "txtVecType";
            this.txtVecType.Size = new System.Drawing.Size(114, 31);
            this.txtVecType.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Gill Sans MT", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.LimeGreen;
            this.label4.Location = new System.Drawing.Point(16, 253);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 18);
            this.label4.TabIndex = 8;
            this.label4.Text = "Vechile Type";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Gill Sans MT", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.LimeGreen;
            this.label3.Location = new System.Drawing.Point(195, 184);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 18);
            this.label3.TabIndex = 6;
            this.label3.Text = "Parking number";
            // 
            // txtParkNum
            // 
            this.txtParkNum.Location = new System.Drawing.Point(198, 205);
            this.txtParkNum.Multiline = true;
            this.txtParkNum.Name = "txtParkNum";
            this.txtParkNum.Size = new System.Drawing.Size(130, 31);
            this.txtParkNum.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Gill Sans MT", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.LimeGreen;
            this.label2.Location = new System.Drawing.Point(16, 184);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "Plate number";
            // 
            // txtPlatenum
            // 
            this.txtPlatenum.Location = new System.Drawing.Point(19, 205);
            this.txtPlatenum.Multiline = true;
            this.txtPlatenum.Name = "txtPlatenum";
            this.txtPlatenum.Size = new System.Drawing.Size(164, 31);
            this.txtPlatenum.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Gill Sans MT", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.LimeGreen;
            this.label1.Location = new System.Drawing.Point(16, 128);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Name";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(19, 149);
            this.txtName.Multiline = true;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(164, 31);
            this.txtName.TabIndex = 1;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::SparkSystem.Properties.Resources.Logo;
            this.pictureBox2.Location = new System.Drawing.Point(72, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(216, 95);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // PictureBox
            // 
            this.PictureBox.Location = new System.Drawing.Point(455, 61);
            this.PictureBox.Name = "PictureBox";
            this.PictureBox.Size = new System.Drawing.Size(379, 205);
            this.PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBox.TabIndex = 11;
            this.PictureBox.TabStop = false;
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // Booking_Teacher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SparkSystem.Properties.Resources.backgorund;
            this.ClientSize = new System.Drawing.Size(1176, 491);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.rdGate8Car);
            this.Controls.Add(this.rdGate5Motor);
            this.Controls.Add(this.rdGate4Car);
            this.Controls.Add(this.rdGate3Motor);
            this.Controls.Add(this.rdGate3Car);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.PictureBox);
            this.Name = "Booking_Teacher";
            this.Text = "Booking_Teacher";
            this.Load += new System.EventHandler(this.Booking_Teacher_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RichTextBox txtResult;
        private System.Windows.Forms.RadioButton rdGate8Car;
        private System.Windows.Forms.RadioButton rdGate5Motor;
        private System.Windows.Forms.RadioButton rdGate4Car;
        private System.Windows.Forms.RadioButton rdGate3Motor;
        private System.Windows.Forms.RadioButton rdGate3Car;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button btnBook;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.TextBox txtGateNum;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtVecType;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtParkNum;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPlatenum;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox PictureBox;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintDialog printDialog1;
    }
}