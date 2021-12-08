namespace My_vending_machine.Controls
{
    partial class FoodUserControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FoodUserControl));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnBuyPizza = new System.Windows.Forms.Button();
            this.btnBuyHam = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.btnBuySalad1 = new System.Windows.Forms.Button();
            this.btnBuySalad2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(105, 78);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(178, 183);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(508, 78);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(178, 183);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(105, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(178, 29);
            this.label4.TabIndex = 10;
            this.label4.Text = "Hamburguer";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(508, 45);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(178, 29);
            this.label5.TabIndex = 11;
            this.label5.Text = "Pizza ";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnBuyPizza
            // 
            this.btnBuyPizza.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnBuyPizza.FlatAppearance.BorderSize = 2;
            this.btnBuyPizza.Location = new System.Drawing.Point(554, 268);
            this.btnBuyPizza.Name = "btnBuyPizza";
            this.btnBuyPizza.Size = new System.Drawing.Size(75, 39);
            this.btnBuyPizza.TabIndex = 2;
            this.btnBuyPizza.Text = "7,9€";
            this.btnBuyPizza.UseVisualStyleBackColor = false;
            this.btnBuyPizza.Click += new System.EventHandler(this.btnBuyPizza_Click);
            // 
            // btnBuyHam
            // 
            this.btnBuyHam.AutoSize = true;
            this.btnBuyHam.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnBuyHam.Location = new System.Drawing.Point(164, 268);
            this.btnBuyHam.Name = "btnBuyHam";
            this.btnBuyHam.Size = new System.Drawing.Size(75, 39);
            this.btnBuyHam.TabIndex = 3;
            this.btnBuyHam.Text = "3,5€";
            this.btnBuyHam.UseVisualStyleBackColor = false;
            this.btnBuyHam.Click += new System.EventHandler(this.btnBuyHam_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(105, 410);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(178, 183);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 4;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(508, 410);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(178, 183);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 5;
            this.pictureBox4.TabStop = false;
            // 
            // btnBuySalad1
            // 
            this.btnBuySalad1.AutoSize = true;
            this.btnBuySalad1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnBuySalad1.Location = new System.Drawing.Point(164, 365);
            this.btnBuySalad1.Name = "btnBuySalad1";
            this.btnBuySalad1.Size = new System.Drawing.Size(75, 39);
            this.btnBuySalad1.TabIndex = 6;
            this.btnBuySalad1.Text = "6,2€";
            this.btnBuySalad1.UseVisualStyleBackColor = false;
            this.btnBuySalad1.Click += new System.EventHandler(this.btnBuySalad1_Click);
            // 
            // btnBuySalad2
            // 
            this.btnBuySalad2.AutoSize = true;
            this.btnBuySalad2.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnBuySalad2.Location = new System.Drawing.Point(554, 365);
            this.btnBuySalad2.Name = "btnBuySalad2";
            this.btnBuySalad2.Size = new System.Drawing.Size(75, 39);
            this.btnBuySalad2.TabIndex = 7;
            this.btnBuySalad2.Text = "5,5€";
            this.btnBuySalad2.UseVisualStyleBackColor = false;
            this.btnBuySalad2.Click += new System.EventHandler(this.btnBuySalad2_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(105, 596);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 29);
            this.label1.TabIndex = 8;
            this.label1.Text = "Vegetarian salad";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(508, 596);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(178, 29);
            this.label2.TabIndex = 9;
            this.label2.Text = "Vegetarian salad";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FoodUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBuySalad2);
            this.Controls.Add(this.btnBuySalad1);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.btnBuyHam);
            this.Controls.Add(this.btnBuyPizza);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FoodUserControl";
            this.Size = new System.Drawing.Size(767, 659);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnBuyPizza;
        private System.Windows.Forms.Button btnBuyHam;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Button btnBuySalad1;
        private System.Windows.Forms.Button btnBuySalad2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}
