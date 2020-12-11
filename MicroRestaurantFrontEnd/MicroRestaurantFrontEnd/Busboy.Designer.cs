
namespace MicroRestaurantFrontEnd
{
    partial class Busboy
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TableNum = new System.Windows.Forms.TextBox();
            this.CleanTable = new System.Windows.Forms.Button();
            this.SeatCount = new System.Windows.Forms.TextBox();
            this.IndexButton = new System.Windows.Forms.Button();
            this.CheckRetrieveBox = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(417, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Seat Count";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(309, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Table Number";
            // 
            // TableNum
            // 
            this.TableNum.Location = new System.Drawing.Point(292, 72);
            this.TableNum.Name = "TableNum";
            this.TableNum.Size = new System.Drawing.Size(100, 20);
            this.TableNum.TabIndex = 11;
            // 
            // CleanTable
            // 
            this.CleanTable.BackColor = System.Drawing.Color.LightGreen;
            this.CleanTable.Location = new System.Drawing.Point(312, 111);
            this.CleanTable.Name = "CleanTable";
            this.CleanTable.Size = new System.Drawing.Size(165, 23);
            this.CleanTable.TabIndex = 10;
            this.CleanTable.Text = "Clean Table";
            this.CleanTable.UseVisualStyleBackColor = false;
            this.CleanTable.Click += new System.EventHandler(this.CleanTable_Click);
            // 
            // SeatCount
            // 
            this.SeatCount.Location = new System.Drawing.Point(410, 72);
            this.SeatCount.Name = "SeatCount";
            this.SeatCount.Size = new System.Drawing.Size(100, 20);
            this.SeatCount.TabIndex = 9;
            // 
            // IndexButton
            // 
            this.IndexButton.BackColor = System.Drawing.Color.Thistle;
            this.IndexButton.Location = new System.Drawing.Point(12, 390);
            this.IndexButton.Name = "IndexButton";
            this.IndexButton.Size = new System.Drawing.Size(123, 39);
            this.IndexButton.TabIndex = 18;
            this.IndexButton.Text = "Back to Index";
            this.IndexButton.UseVisualStyleBackColor = false;
            this.IndexButton.Click += new System.EventHandler(this.IndexButton_Click);
            // 
            // CheckRetrieveBox
            // 
            this.CheckRetrieveBox.Location = new System.Drawing.Point(277, 210);
            this.CheckRetrieveBox.Multiline = true;
            this.CheckRetrieveBox.Name = "CheckRetrieveBox";
            this.CheckRetrieveBox.Size = new System.Drawing.Size(257, 95);
            this.CheckRetrieveBox.TabIndex = 15;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Gold;
            this.button2.Location = new System.Drawing.Point(290, 323);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(230, 23);
            this.button2.TabIndex = 16;
            this.button2.Text = "Retrieve Check";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Busboy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.IndexButton);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.CheckRetrieveBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TableNum);
            this.Controls.Add(this.CleanTable);
            this.Controls.Add(this.SeatCount);
            this.Name = "Busboy";
            this.Text = "Busboy";
            this.Load += new System.EventHandler(this.Busboy_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TableNum;
        private System.Windows.Forms.Button CleanTable;
        private System.Windows.Forms.TextBox SeatCount;
        private System.Windows.Forms.Button IndexButton;
        private System.Windows.Forms.TextBox CheckRetrieveBox;
        private System.Windows.Forms.Button button2;
    }
}