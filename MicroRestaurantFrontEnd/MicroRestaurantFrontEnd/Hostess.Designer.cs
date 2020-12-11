
namespace MicroRestaurantFrontEnd
{
    partial class Hostess
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
            this.CustomerName = new System.Windows.Forms.TextBox();
            this.ReservationOutputBox = new System.Windows.Forms.TextBox();
            this.CreateReservation = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.GuestCount = new System.Windows.Forms.TextBox();
            this.PhoneNumber = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.GuestToSeat = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.ReadyTableOutput = new System.Windows.Forms.TextBox();
            this.button5 = new System.Windows.Forms.Button();
            this.TableNumberSeat = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CustomerName
            // 
            this.CustomerName.Location = new System.Drawing.Point(156, 63);
            this.CustomerName.Name = "CustomerName";
            this.CustomerName.Size = new System.Drawing.Size(100, 20);
            this.CustomerName.TabIndex = 0;
            // 
            // ReservationOutputBox
            // 
            this.ReservationOutputBox.Location = new System.Drawing.Point(73, 204);
            this.ReservationOutputBox.Multiline = true;
            this.ReservationOutputBox.Name = "ReservationOutputBox";
            this.ReservationOutputBox.Size = new System.Drawing.Size(257, 95);
            this.ReservationOutputBox.TabIndex = 1;
            this.ReservationOutputBox.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // CreateReservation
            // 
            this.CreateReservation.BackColor = System.Drawing.Color.LightGreen;
            this.CreateReservation.Location = new System.Drawing.Point(121, 103);
            this.CreateReservation.Name = "CreateReservation";
            this.CreateReservation.Size = new System.Drawing.Size(165, 23);
            this.CreateReservation.TabIndex = 2;
            this.CreateReservation.Text = "Create Reservation";
            this.CreateReservation.UseVisualStyleBackColor = false;
            this.CreateReservation.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Gold;
            this.button2.Location = new System.Drawing.Point(86, 317);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(230, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Get Reservation";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // GuestCount
            // 
            this.GuestCount.Location = new System.Drawing.Point(38, 63);
            this.GuestCount.Name = "GuestCount";
            this.GuestCount.Size = new System.Drawing.Size(100, 20);
            this.GuestCount.TabIndex = 4;
            // 
            // PhoneNumber
            // 
            this.PhoneNumber.Location = new System.Drawing.Point(274, 63);
            this.PhoneNumber.Name = "PhoneNumber";
            this.PhoneNumber.Size = new System.Drawing.Size(100, 20);
            this.PhoneNumber.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Number of Guests";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(163, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Customer Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(287, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Phone Number";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(648, 47);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Number of Guests";
            // 
            // GuestToSeat
            // 
            this.GuestToSeat.Location = new System.Drawing.Point(640, 63);
            this.GuestToSeat.Name = "GuestToSeat";
            this.GuestToSeat.Size = new System.Drawing.Size(100, 20);
            this.GuestToSeat.TabIndex = 13;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Gold;
            this.button3.Location = new System.Drawing.Point(519, 317);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(230, 23);
            this.button3.TabIndex = 12;
            this.button3.Text = "Newly Readied Tables";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.LightGreen;
            this.button4.Location = new System.Drawing.Point(549, 103);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(165, 23);
            this.button4.TabIndex = 11;
            this.button4.Text = "Seat Customer";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // ReadyTableOutput
            // 
            this.ReadyTableOutput.Location = new System.Drawing.Point(506, 204);
            this.ReadyTableOutput.Multiline = true;
            this.ReadyTableOutput.Name = "ReadyTableOutput";
            this.ReadyTableOutput.Size = new System.Drawing.Size(257, 95);
            this.ReadyTableOutput.TabIndex = 10;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Thistle;
            this.button5.Location = new System.Drawing.Point(15, 399);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(123, 39);
            this.button5.TabIndex = 17;
            this.button5.Text = "Back to Index";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // TableNumberSeat
            // 
            this.TableNumberSeat.Location = new System.Drawing.Point(534, 63);
            this.TableNumberSeat.Name = "TableNumberSeat";
            this.TableNumberSeat.Size = new System.Drawing.Size(100, 20);
            this.TableNumberSeat.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(542, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "Table Number";
            // 
            // Hostess
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TableNumberSeat);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.GuestToSeat);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.ReadyTableOutput);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PhoneNumber);
            this.Controls.Add(this.GuestCount);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.CreateReservation);
            this.Controls.Add(this.ReservationOutputBox);
            this.Controls.Add(this.CustomerName);
            this.Name = "Hostess";
            this.Text = "Hostess";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox CustomerName;
        private System.Windows.Forms.TextBox ReservationOutputBox;
        private System.Windows.Forms.Button CreateReservation;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox GuestCount;
        private System.Windows.Forms.TextBox PhoneNumber;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox GuestToSeat;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox ReadyTableOutput;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TextBox TableNumberSeat;
        private System.Windows.Forms.Label label4;
    }
}