
namespace project1
{
    partial class Form1
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
            this.btn_click = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_phno = new System.Windows.Forms.TextBox();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_age = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_open = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_click
            // 
            this.btn_click.Location = new System.Drawing.Point(166, 322);
            this.btn_click.Name = "btn_click";
            this.btn_click.Size = new System.Drawing.Size(118, 36);
            this.btn_click.TabIndex = 0;
            this.btn_click.Text = "click";
            this.btn_click.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(207, 124);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "phno";
            // 
            // txt_phno
            // 
            this.txt_phno.Location = new System.Drawing.Point(364, 118);
            this.txt_phno.Name = "txt_phno";
            this.txt_phno.Size = new System.Drawing.Size(225, 26);
            this.txt_phno.TabIndex = 2;
            this.txt_phno.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_phno_KeyDown);
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(364, 50);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(225, 26);
            this.txt_name.TabIndex = 4;
            this.txt_name.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_name_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(207, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Name";
            // 
            // txt_age
            // 
            this.txt_age.Location = new System.Drawing.Point(364, 185);
            this.txt_age.Name = "txt_age";
            this.txt_age.Size = new System.Drawing.Size(225, 26);
            this.txt_age.TabIndex = 6;
            this.txt_age.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_age_KeyDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(207, 191);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "age";
            // 
            // txt_password
            // 
            this.txt_password.Location = new System.Drawing.Point(364, 240);
            this.txt_password.Name = "txt_password";
            this.txt_password.Size = new System.Drawing.Size(225, 26);
            this.txt_password.TabIndex = 8;
            this.txt_password.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_password_KeyDown);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(207, 246);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "password";
            // 
            // btn_open
            // 
            this.btn_open.Location = new System.Drawing.Point(364, 322);
            this.btn_open.Name = "btn_open";
            this.btn_open.Size = new System.Drawing.Size(118, 36);
            this.btn_open.TabIndex = 9;
            this.btn_open.Text = "Open";
            this.btn_open.UseVisualStyleBackColor = true;
            this.btn_open.Click += new System.EventHandler(this.btn_open_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_open);
            this.Controls.Add(this.txt_password);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_age);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_name);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_phno);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_click);
            this.Name = "Form1";
            this.Text = "Home";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_click;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_phno;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_age;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_password;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_open;
    }
}

