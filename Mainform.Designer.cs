namespace railway
{
    partial class Mainform
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
            this.Cancellation = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Reservation = new System.Windows.Forms.Button();
            this.TravelMaster = new System.Windows.Forms.Button();
            this.TrainMaster = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Cancellation
            // 
            this.Cancellation.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.Cancellation.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cancellation.Location = new System.Drawing.Point(453, 336);
            this.Cancellation.Name = "Cancellation";
            this.Cancellation.Size = new System.Drawing.Size(139, 102);
            this.Cancellation.TabIndex = 6;
            this.Cancellation.Text = "Cancellation";
            this.Cancellation.UseVisualStyleBackColor = false;
            this.Cancellation.Click += new System.EventHandler(this.Cancellation_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(363, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "Home";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Reservation
            // 
            this.Reservation.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.Reservation.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Reservation.Location = new System.Drawing.Point(453, 192);
            this.Reservation.Name = "Reservation";
            this.Reservation.Size = new System.Drawing.Size(139, 102);
            this.Reservation.TabIndex = 5;
            this.Reservation.Text = "Reservation";
            this.Reservation.UseVisualStyleBackColor = false;
            this.Reservation.Click += new System.EventHandler(this.Reservation_Click);
            // 
            // TravelMaster
            // 
            this.TravelMaster.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.TravelMaster.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TravelMaster.Location = new System.Drawing.Point(243, 336);
            this.TravelMaster.Name = "TravelMaster";
            this.TravelMaster.Size = new System.Drawing.Size(139, 102);
            this.TravelMaster.TabIndex = 4;
            this.TravelMaster.Text = "Travel Master";
            this.TravelMaster.UseVisualStyleBackColor = false;
            this.TravelMaster.Click += new System.EventHandler(this.TravelMaster_Click);
            // 
            // TrainMaster
            // 
            this.TrainMaster.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.TrainMaster.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TrainMaster.Location = new System.Drawing.Point(243, 192);
            this.TrainMaster.Name = "TrainMaster";
            this.TrainMaster.Size = new System.Drawing.Size(139, 102);
            this.TrainMaster.TabIndex = 2;
            this.TrainMaster.Text = "Train Master";
            this.TrainMaster.UseVisualStyleBackColor = false;
            this.TrainMaster.Click += new System.EventHandler(this.TrainMaster_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(243, 501);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(139, 106);
            this.button1.TabIndex = 8;
            this.button1.Text = "PassengerMaster";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkGray;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 670);
            this.panel1.TabIndex = 9;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(639, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(222, 670);
            this.panel2.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(0, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 23);
            this.label4.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(177, 19);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 29);
            this.label2.TabIndex = 10;
            this.label2.Text = "X";
            this.label2.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // Mainform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(861, 670);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Cancellation);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.TrainMaster);
            this.Controls.Add(this.TravelMaster);
            this.Controls.Add(this.Reservation);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Mainform";
            this.Text = "Mainform";
            this.Load += new System.EventHandler(this.Mainform_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Cancellation;
        private System.Windows.Forms.Button Reservation;
        private System.Windows.Forms.Button TravelMaster;
        private System.Windows.Forms.Button TrainMaster;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
    }
}