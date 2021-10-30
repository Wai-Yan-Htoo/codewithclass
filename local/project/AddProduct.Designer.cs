
namespace project1.project
{
    partial class AddProduct
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddProduct));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Pannel_quantity = new System.Windows.Forms.Panel();
            this.btn_decrease = new System.Windows.Forms.Button();
            this.btn_increase = new System.Windows.Forms.Button();
            this.txt_quantity = new System.Windows.Forms.TextBox();
            this.btn_buynow = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.Pannel_quantity.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(35, 34);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(237, 185);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(337, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(407, 300);
            this.label1.TabIndex = 1;
            this.label1.Text = resources.GetString("label1.Text");
            // 
            // Pannel_quantity
            // 
            this.Pannel_quantity.Controls.Add(this.btn_decrease);
            this.Pannel_quantity.Controls.Add(this.txt_quantity);
            this.Pannel_quantity.Controls.Add(this.btn_increase);
            this.Pannel_quantity.Location = new System.Drawing.Point(327, 404);
            this.Pannel_quantity.Name = "Pannel_quantity";
            this.Pannel_quantity.Size = new System.Drawing.Size(145, 37);
            this.Pannel_quantity.TabIndex = 2;
            // 
            // btn_decrease
            // 
            this.btn_decrease.BackColor = System.Drawing.Color.White;
            this.btn_decrease.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_decrease.Location = new System.Drawing.Point(101, 0);
            this.btn_decrease.Name = "btn_decrease";
            this.btn_decrease.Size = new System.Drawing.Size(41, 37);
            this.btn_decrease.TabIndex = 2;
            this.btn_decrease.Text = "-";
            this.btn_decrease.UseVisualStyleBackColor = false;
            this.btn_decrease.Click += new System.EventHandler(this.btn_decrease_Click);
            // 
            // btn_increase
            // 
            this.btn_increase.BackColor = System.Drawing.Color.White;
            this.btn_increase.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_increase.Location = new System.Drawing.Point(0, 0);
            this.btn_increase.Name = "btn_increase";
            this.btn_increase.Size = new System.Drawing.Size(43, 37);
            this.btn_increase.TabIndex = 0;
            this.btn_increase.Text = "+";
            this.btn_increase.UseVisualStyleBackColor = false;
            this.btn_increase.Click += new System.EventHandler(this.btn_increase_Click);
            // 
            // txt_quantity
            // 
            this.txt_quantity.Dock = System.Windows.Forms.DockStyle.Left;
            this.txt_quantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_quantity.Location = new System.Drawing.Point(43, 0);
            this.txt_quantity.Name = "txt_quantity";
            this.txt_quantity.Size = new System.Drawing.Size(58, 35);
            this.txt_quantity.TabIndex = 1;
            this.txt_quantity.Text = "1";
            this.txt_quantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btn_buynow
            // 
            this.btn_buynow.Location = new System.Drawing.Point(548, 404);
            this.btn_buynow.Name = "btn_buynow";
            this.btn_buynow.Size = new System.Drawing.Size(165, 40);
            this.btn_buynow.TabIndex = 3;
            this.btn_buynow.Text = "Buy Now";
            this.btn_buynow.UseVisualStyleBackColor = true;
            this.btn_buynow.Click += new System.EventHandler(this.btn_buynow_Click);
            // 
            // AddProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1207, 687);
            this.Controls.Add(this.btn_buynow);
            this.Controls.Add(this.Pannel_quantity);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "AddProduct";
            this.Text = "AddProduct";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.Pannel_quantity.ResumeLayout(false);
            this.Pannel_quantity.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel Pannel_quantity;
        private System.Windows.Forms.Button btn_decrease;
        private System.Windows.Forms.Button btn_increase;
        private System.Windows.Forms.TextBox txt_quantity;
        private System.Windows.Forms.Button btn_buynow;
    }
}