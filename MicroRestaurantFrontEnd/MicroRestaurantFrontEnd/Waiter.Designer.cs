
namespace MicroRestaurantFrontEnd
{
    partial class Waiter
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
            this.OrderNumber = new System.Windows.Forms.TextBox();
            this.FoodName = new System.Windows.Forms.TextBox();
            this.TableNumber = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.FoodOutput = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.FoodOutBtn = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.DTableNum = new System.Windows.Forms.TextBox();
            this.DrinkName = new System.Windows.Forms.TextBox();
            this.DOrderNum = new System.Windows.Forms.TextBox();
            this.RecentDrinkBtn = new System.Windows.Forms.Button();
            this.DrinkOutput = new System.Windows.Forms.TextBox();
            this.button5 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.CheckTableNum = new System.Windows.Forms.TextBox();
            this.button6 = new System.Windows.Forms.Button();
            this.ReadyOutput = new System.Windows.Forms.TextBox();
            this.ReadyBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // OrderNumber
            // 
            this.OrderNumber.Location = new System.Drawing.Point(20, 64);
            this.OrderNumber.Name = "OrderNumber";
            this.OrderNumber.Size = new System.Drawing.Size(100, 20);
            this.OrderNumber.TabIndex = 0;
            // 
            // FoodName
            // 
            this.FoodName.Location = new System.Drawing.Point(137, 64);
            this.FoodName.Name = "FoodName";
            this.FoodName.Size = new System.Drawing.Size(100, 20);
            this.FoodName.TabIndex = 1;
            // 
            // TableNumber
            // 
            this.TableNumber.Location = new System.Drawing.Point(254, 64);
            this.TableNumber.Name = "TableNumber";
            this.TableNumber.Size = new System.Drawing.Size(100, 20);
            this.TableNumber.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Order Number";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(157, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "FoodName";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(280, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Table Number";
            // 
            // FoodOutput
            // 
            this.FoodOutput.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.FoodOutput.Location = new System.Drawing.Point(77, 179);
            this.FoodOutput.Multiline = true;
            this.FoodOutput.Name = "FoodOutput";
            this.FoodOutput.Size = new System.Drawing.Size(217, 149);
            this.FoodOutput.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Gold;
            this.button1.Location = new System.Drawing.Point(77, 99);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(204, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Submit Food Order";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FoodOutBtn
            // 
            this.FoodOutBtn.BackColor = System.Drawing.Color.Gold;
            this.FoodOutBtn.Location = new System.Drawing.Point(77, 353);
            this.FoodOutBtn.Name = "FoodOutBtn";
            this.FoodOutBtn.Size = new System.Drawing.Size(217, 23);
            this.FoodOutBtn.TabIndex = 8;
            this.FoodOutBtn.Text = "Get Recent Completed Food Order";
            this.FoodOutBtn.UseVisualStyleBackColor = false;
            this.FoodOutBtn.Click += new System.EventHandler(this.FoodOutBtn_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Gold;
            this.button3.Location = new System.Drawing.Point(474, 99);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(204, 23);
            this.button3.TabIndex = 15;
            this.button3.Text = "Submit Drink Order";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(677, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Table Number";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(554, 45);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Drink Name";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(425, 45);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Order Number";
            // 
            // DTableNum
            // 
            this.DTableNum.Location = new System.Drawing.Point(651, 64);
            this.DTableNum.Name = "DTableNum";
            this.DTableNum.Size = new System.Drawing.Size(100, 20);
            this.DTableNum.TabIndex = 11;
            // 
            // DrinkName
            // 
            this.DrinkName.Location = new System.Drawing.Point(534, 64);
            this.DrinkName.Name = "DrinkName";
            this.DrinkName.Size = new System.Drawing.Size(100, 20);
            this.DrinkName.TabIndex = 10;
            // 
            // DOrderNum
            // 
            this.DOrderNum.Location = new System.Drawing.Point(417, 64);
            this.DOrderNum.Name = "DOrderNum";
            this.DOrderNum.Size = new System.Drawing.Size(100, 20);
            this.DOrderNum.TabIndex = 9;
            // 
            // RecentDrinkBtn
            // 
            this.RecentDrinkBtn.BackColor = System.Drawing.Color.Gold;
            this.RecentDrinkBtn.Location = new System.Drawing.Point(474, 353);
            this.RecentDrinkBtn.Name = "RecentDrinkBtn";
            this.RecentDrinkBtn.Size = new System.Drawing.Size(217, 23);
            this.RecentDrinkBtn.TabIndex = 17;
            this.RecentDrinkBtn.Text = "Get Recent Completed Drink Order";
            this.RecentDrinkBtn.UseVisualStyleBackColor = false;
            this.RecentDrinkBtn.Click += new System.EventHandler(this.button4_Click);
            // 
            // DrinkOutput
            // 
            this.DrinkOutput.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.DrinkOutput.Location = new System.Drawing.Point(474, 179);
            this.DrinkOutput.Multiline = true;
            this.DrinkOutput.Name = "DrinkOutput";
            this.DrinkOutput.Size = new System.Drawing.Size(217, 149);
            this.DrinkOutput.TabIndex = 16;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Gold;
            this.button5.Location = new System.Drawing.Point(826, 99);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(204, 23);
            this.button5.TabIndex = 24;
            this.button5.Text = "Tender Check";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(883, 45);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(74, 13);
            this.label9.TabIndex = 21;
            this.label9.Text = "Table Number";
            // 
            // CheckTableNum
            // 
            this.CheckTableNum.Location = new System.Drawing.Point(873, 64);
            this.CheckTableNum.Name = "CheckTableNum";
            this.CheckTableNum.Size = new System.Drawing.Size(100, 20);
            this.CheckTableNum.TabIndex = 18;
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.Thistle;
            this.button6.Location = new System.Drawing.Point(12, 409);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(123, 39);
            this.button6.TabIndex = 26;
            this.button6.Text = "Back to Index";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // ReadyOutput
            // 
            this.ReadyOutput.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.ReadyOutput.Location = new System.Drawing.Point(784, 190);
            this.ReadyOutput.Multiline = true;
            this.ReadyOutput.Name = "ReadyOutput";
            this.ReadyOutput.Size = new System.Drawing.Size(217, 149);
            this.ReadyOutput.TabIndex = 27;
            // 
            // ReadyBtn
            // 
            this.ReadyBtn.BackColor = System.Drawing.Color.Gold;
            this.ReadyBtn.Location = new System.Drawing.Point(784, 353);
            this.ReadyBtn.Name = "ReadyBtn";
            this.ReadyBtn.Size = new System.Drawing.Size(217, 23);
            this.ReadyBtn.TabIndex = 28;
            this.ReadyBtn.Text = "Customers Ready";
            this.ReadyBtn.UseVisualStyleBackColor = false;
            this.ReadyBtn.Click += new System.EventHandler(this.ReadyBtn_Click);
            // 
            // Waiter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(1075, 450);
            this.Controls.Add(this.ReadyBtn);
            this.Controls.Add(this.ReadyOutput);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.CheckTableNum);
            this.Controls.Add(this.RecentDrinkBtn);
            this.Controls.Add(this.DrinkOutput);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.DTableNum);
            this.Controls.Add(this.DrinkName);
            this.Controls.Add(this.DOrderNum);
            this.Controls.Add(this.FoodOutBtn);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.FoodOutput);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TableNumber);
            this.Controls.Add(this.FoodName);
            this.Controls.Add(this.OrderNumber);
            this.Name = "Waiter";
            this.Text = "Waiter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox OrderNumber;
        private System.Windows.Forms.TextBox FoodName;
        private System.Windows.Forms.TextBox TableNumber;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox FoodOutput;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button FoodOutBtn;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox DTableNum;
        private System.Windows.Forms.TextBox DrinkName;
        private System.Windows.Forms.TextBox DOrderNum;
        private System.Windows.Forms.Button RecentDrinkBtn;
        private System.Windows.Forms.TextBox DrinkOutput;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox CheckTableNum;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.TextBox ReadyOutput;
        private System.Windows.Forms.Button ReadyBtn;
    }
}