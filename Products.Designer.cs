
namespace Vending_Machine
{
    partial class products
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlmain = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnexit = new System.Windows.Forms.Button();
            this.btnBalance = new System.Windows.Forms.Button();
            this.btnFood = new System.Windows.Forms.Button();
            this.btnDrink = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlmain
            // 
            this.pnlmain.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pnlmain.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlmain.Location = new System.Drawing.Point(259, 0);
            this.pnlmain.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnlmain.Name = "pnlmain";
            this.pnlmain.Size = new System.Drawing.Size(767, 659);
            this.pnlmain.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Red;
            this.panel2.Controls.Add(this.btnexit);
            this.panel2.Controls.Add(this.btnBalance);
            this.panel2.Controls.Add(this.btnFood);
            this.panel2.Controls.Add(this.btnDrink);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(261, 659);
            this.panel2.TabIndex = 9;
            // 
            // btnexit
            // 
            this.btnexit.AutoSize = true;
            this.btnexit.FlatAppearance.BorderSize = 0;
            this.btnexit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnexit.Font = new System.Drawing.Font("Arial Narrow", 20F);
            this.btnexit.Location = new System.Drawing.Point(12, 498);
            this.btnexit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(223, 120);
            this.btnexit.TabIndex = 4;
            this.btnexit.Text = "👋  Exit";
            this.btnexit.UseVisualStyleBackColor = true;
            this.btnexit.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnBalance
            // 
            this.btnBalance.FlatAppearance.BorderSize = 0;
            this.btnBalance.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBalance.Font = new System.Drawing.Font("Arial Narrow", 20F);
            this.btnBalance.ForeColor = System.Drawing.SystemColors.Control;
            this.btnBalance.Location = new System.Drawing.Point(12, 359);
            this.btnBalance.Name = "btnBalance";
            this.btnBalance.Size = new System.Drawing.Size(223, 120);
            this.btnBalance.TabIndex = 3;
            this.btnBalance.Text = "🏦  Balance";
            this.btnBalance.UseVisualStyleBackColor = true;
            this.btnBalance.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btnFood
            // 
            this.btnFood.FlatAppearance.BorderSize = 0;
            this.btnFood.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFood.Font = new System.Drawing.Font("Arial Narrow", 20F);
            this.btnFood.ForeColor = System.Drawing.SystemColors.Control;
            this.btnFood.Location = new System.Drawing.Point(10, 60);
            this.btnFood.Name = "btnFood";
            this.btnFood.Size = new System.Drawing.Size(223, 124);
            this.btnFood.TabIndex = 1;
            this.btnFood.Text = "🍽️  Food";
            this.btnFood.UseVisualStyleBackColor = true;
            this.btnFood.Click += new System.EventHandler(this.btnFood_Click);
            // 
            // btnDrink
            // 
            this.btnDrink.FlatAppearance.BorderSize = 0;
            this.btnDrink.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDrink.Font = new System.Drawing.Font("Arial Narrow", 20F);
            this.btnDrink.ForeColor = System.Drawing.SystemColors.Control;
            this.btnDrink.Location = new System.Drawing.Point(12, 206);
            this.btnDrink.Name = "btnDrink";
            this.btnDrink.Size = new System.Drawing.Size(223, 120);
            this.btnDrink.TabIndex = 2;
            this.btnDrink.Text = "☕ Drink";
            this.btnDrink.UseVisualStyleBackColor = true;
            this.btnDrink.Click += new System.EventHandler(this.btnDrink_Click);
            // 
            // products
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(1026, 659);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pnlmain);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "products";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sair";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlmain;
        private System.Windows.Forms.Button btnexit;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnDrink;
        private System.Windows.Forms.Button btnFood;
        private System.Windows.Forms.Button btnBalance;
    }
}

