
namespace MicroRestaurantFrontEnd
{
    partial class Bartender
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
            this.TableNum = new System.Windows.Forms.TextBox();
            this.ServeDrinkButton = new System.Windows.Forms.Button();
            this.OrdNum = new System.Windows.Forms.TextBox();
            this.DrinkOutput = new System.Windows.Forms.TextBox();
            this.DOrderBtn = new System.Windows.Forms.Button();
            this.DrinkName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TableNum
            // 
            this.TableNum.Location = new System.Drawing.Point(234, 75);
            this.TableNum.Name = "TableNum";
            this.TableNum.Size = new System.Drawing.Size(100, 20);
            this.TableNum.TabIndex = 14;
            // 
            // ServeDrinkButton
            // 
            this.ServeDrinkButton.BackColor = System.Drawing.Color.LightGreen;
            this.ServeDrinkButton.Location = new System.Drawing.Point(306, 101);
            this.ServeDrinkButton.Name = "ServeDrinkButton";
            this.ServeDrinkButton.Size = new System.Drawing.Size(165, 23);
            this.ServeDrinkButton.TabIndex = 13;
            this.ServeDrinkButton.Text = "Serve Drink";
            this.ServeDrinkButton.UseVisualStyleBackColor = false;
            this.ServeDrinkButton.Click += new System.EventHandler(this.ServeDrinkButton_Click);
            // 
            // OrdNum
            // 
            this.OrdNum.Location = new System.Drawing.Point(340, 75);
            this.OrdNum.Name = "OrdNum";
            this.OrdNum.Size = new System.Drawing.Size(100, 20);
            this.OrdNum.TabIndex = 12;
            // 
            // DrinkOutput
            // 
            this.DrinkOutput.Location = new System.Drawing.Point(270, 170);
            this.DrinkOutput.Multiline = true;
            this.DrinkOutput.Name = "DrinkOutput";
            this.DrinkOutput.Size = new System.Drawing.Size(257, 95);
            this.DrinkOutput.TabIndex = 16;
            // 
            // DOrderBtn
            // 
            this.DOrderBtn.BackColor = System.Drawing.Color.Gold;
            this.DOrderBtn.Location = new System.Drawing.Point(306, 283);
            this.DOrderBtn.Name = "DOrderBtn";
            this.DOrderBtn.Size = new System.Drawing.Size(165, 23);
            this.DOrderBtn.TabIndex = 17;
            this.DOrderBtn.Text = "Get Drink Order";
            this.DOrderBtn.UseVisualStyleBackColor = false;
            this.DOrderBtn.Click += new System.EventHandler(this.DOrderBtn_Click);
            // 
            // DrinkName
            // 
            this.DrinkName.Location = new System.Drawing.Point(446, 75);
            this.DrinkName.Name = "DrinkName";
            this.DrinkName.Size = new System.Drawing.Size(100, 20);
            this.DrinkName.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(247, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "Table Number";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(352, 59);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 13);
            this.label5.TabIndex = 20;
            this.label5.Text = "Order Number";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(453, 59);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 13);
            this.label6.TabIndex = 21;
            this.label6.Text = "Drink Name";
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Thistle;
            this.button5.Location = new System.Drawing.Point(12, 384);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(123, 39);
            this.button5.TabIndex = 22;
            this.button5.Text = "Back to Index";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // Bartender
            // 
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(797, 435);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.DrinkName);
            this.Controls.Add(this.DOrderBtn);
            this.Controls.Add(this.DrinkOutput);
            this.Controls.Add(this.TableNum);
            this.Controls.Add(this.ServeDrinkButton);
            this.Controls.Add(this.OrdNum);
            this.Name = "Bartender";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button IndexButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TN;
        private System.Windows.Forms.Button ServeDrink;
        private System.Windows.Forms.TextBox ON;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox DN;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox DOutput;
        private System.Windows.Forms.TextBox TableNum;
        private System.Windows.Forms.Button ServeDrinkButton;
        private System.Windows.Forms.TextBox OrdNum;
        private System.Windows.Forms.TextBox DrinkOutput;
        private System.Windows.Forms.Button DOrderBtn;
        private System.Windows.Forms.TextBox DrinkName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button5;
    }
}