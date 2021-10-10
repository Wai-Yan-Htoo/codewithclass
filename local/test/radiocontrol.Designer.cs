
namespace project1.test
{
    partial class radiocontrol
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
            this.rdbtn_game = new System.Windows.Forms.RadioButton();
            this.rdbtn_pineapple = new System.Windows.Forms.RadioButton();
            this.rdbtn_mango = new System.Windows.Forms.RadioButton();
            this.btn_click = new System.Windows.Forms.Button();
            this.panel_apple = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.rdbtn_red = new System.Windows.Forms.RadioButton();
            this.rdbtn_green = new System.Windows.Forms.RadioButton();
            this.rdbtn_back = new System.Windows.Forms.RadioButton();
            this.rdbtn_white = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.rdbtn_workout = new System.Windows.Forms.RadioButton();
            this.rdbtn_food = new System.Windows.Forms.RadioButton();
            this.rdbtn_sleep = new System.Windows.Forms.RadioButton();
            this.panel_pineapple = new System.Windows.Forms.Panel();
            this.panel_mango = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.lb_score = new System.Windows.Forms.Label();
            this.panel_apple.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel_pineapple.SuspendLayout();
            this.panel_mango.SuspendLayout();
            this.SuspendLayout();
            // 
            // rdbtn_game
            // 
            this.rdbtn_game.AutoSize = true;
            this.rdbtn_game.Location = new System.Drawing.Point(81, 56);
            this.rdbtn_game.Name = "rdbtn_game";
            this.rdbtn_game.Size = new System.Drawing.Size(93, 24);
            this.rdbtn_game.TabIndex = 0;
            this.rdbtn_game.TabStop = true;
            this.rdbtn_game.Text = "A. game";
            this.rdbtn_game.UseVisualStyleBackColor = true;
            // 
            // rdbtn_pineapple
            // 
            this.rdbtn_pineapple.AutoSize = true;
            this.rdbtn_pineapple.Location = new System.Drawing.Point(153, 41);
            this.rdbtn_pineapple.Name = "rdbtn_pineapple";
            this.rdbtn_pineapple.Size = new System.Drawing.Size(104, 24);
            this.rdbtn_pineapple.TabIndex = 1;
            this.rdbtn_pineapple.TabStop = true;
            this.rdbtn_pineapple.Text = "Pineapple";
            this.rdbtn_pineapple.UseVisualStyleBackColor = true;
            // 
            // rdbtn_mango
            // 
            this.rdbtn_mango.AutoSize = true;
            this.rdbtn_mango.Location = new System.Drawing.Point(145, 41);
            this.rdbtn_mango.Name = "rdbtn_mango";
            this.rdbtn_mango.Size = new System.Drawing.Size(83, 24);
            this.rdbtn_mango.TabIndex = 2;
            this.rdbtn_mango.TabStop = true;
            this.rdbtn_mango.Text = "Mango";
            this.rdbtn_mango.UseVisualStyleBackColor = true;
            // 
            // btn_click
            // 
            this.btn_click.Location = new System.Drawing.Point(540, 538);
            this.btn_click.Name = "btn_click";
            this.btn_click.Size = new System.Drawing.Size(154, 44);
            this.btn_click.TabIndex = 3;
            this.btn_click.Text = "Click";
            this.btn_click.UseVisualStyleBackColor = true;
            this.btn_click.Click += new System.EventHandler(this.btn_click_Click);
            // 
            // panel_apple
            // 
            this.panel_apple.BackColor = System.Drawing.Color.White;
            this.panel_apple.Controls.Add(this.panel1);
            this.panel_apple.Controls.Add(this.label1);
            this.panel_apple.Controls.Add(this.rdbtn_workout);
            this.panel_apple.Controls.Add(this.rdbtn_food);
            this.panel_apple.Controls.Add(this.rdbtn_sleep);
            this.panel_apple.Controls.Add(this.rdbtn_game);
            this.panel_apple.Location = new System.Drawing.Point(12, 12);
            this.panel_apple.Name = "panel_apple";
            this.panel_apple.Size = new System.Drawing.Size(734, 151);
            this.panel_apple.TabIndex = 4;
            this.panel_apple.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_apple_Paint);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.rdbtn_red);
            this.panel1.Controls.Add(this.rdbtn_green);
            this.panel1.Controls.Add(this.rdbtn_back);
            this.panel1.Controls.Add(this.rdbtn_white);
            this.panel1.Location = new System.Drawing.Point(0, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(734, 151);
            this.panel1.TabIndex = 5;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(14, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(333, 29);
            this.label3.TabIndex = 4;
            this.label3.Text = "2. Which one is primary color?\r\n";
            // 
            // rdbtn_red
            // 
            this.rdbtn_red.AutoSize = true;
            this.rdbtn_red.Location = new System.Drawing.Point(247, 56);
            this.rdbtn_red.Name = "rdbtn_red";
            this.rdbtn_red.Size = new System.Drawing.Size(76, 24);
            this.rdbtn_red.TabIndex = 3;
            this.rdbtn_red.TabStop = true;
            this.rdbtn_red.Text = "B. red";
            this.rdbtn_red.UseVisualStyleBackColor = true;
            // 
            // rdbtn_green
            // 
            this.rdbtn_green.AutoSize = true;
            this.rdbtn_green.Location = new System.Drawing.Point(81, 103);
            this.rdbtn_green.Name = "rdbtn_green";
            this.rdbtn_green.Size = new System.Drawing.Size(94, 24);
            this.rdbtn_green.TabIndex = 2;
            this.rdbtn_green.TabStop = true;
            this.rdbtn_green.Text = "C. green";
            this.rdbtn_green.UseVisualStyleBackColor = true;
            // 
            // rdbtn_back
            // 
            this.rdbtn_back.AutoSize = true;
            this.rdbtn_back.Location = new System.Drawing.Point(247, 103);
            this.rdbtn_back.Name = "rdbtn_back";
            this.rdbtn_back.Size = new System.Drawing.Size(91, 24);
            this.rdbtn_back.TabIndex = 1;
            this.rdbtn_back.TabStop = true;
            this.rdbtn_back.Text = "D. black";
            this.rdbtn_back.UseVisualStyleBackColor = true;
            // 
            // rdbtn_white
            // 
            this.rdbtn_white.AutoSize = true;
            this.rdbtn_white.Location = new System.Drawing.Point(81, 56);
            this.rdbtn_white.Name = "rdbtn_white";
            this.rdbtn_white.Size = new System.Drawing.Size(90, 24);
            this.rdbtn_white.TabIndex = 0;
            this.rdbtn_white.TabStop = true;
            this.rdbtn_white.Text = "A. white";
            this.rdbtn_white.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(277, 29);
            this.label1.TabIndex = 4;
            this.label1.Text = "1. What is your favourite?\r\n";
            // 
            // rdbtn_workout
            // 
            this.rdbtn_workout.AutoSize = true;
            this.rdbtn_workout.Location = new System.Drawing.Point(247, 56);
            this.rdbtn_workout.Name = "rdbtn_workout";
            this.rdbtn_workout.Size = new System.Drawing.Size(109, 24);
            this.rdbtn_workout.TabIndex = 3;
            this.rdbtn_workout.TabStop = true;
            this.rdbtn_workout.Text = "B. workout";
            this.rdbtn_workout.UseVisualStyleBackColor = true;
            // 
            // rdbtn_food
            // 
            this.rdbtn_food.AutoSize = true;
            this.rdbtn_food.Location = new System.Drawing.Point(81, 103);
            this.rdbtn_food.Name = "rdbtn_food";
            this.rdbtn_food.Size = new System.Drawing.Size(85, 24);
            this.rdbtn_food.TabIndex = 2;
            this.rdbtn_food.TabStop = true;
            this.rdbtn_food.Text = "C. food";
            this.rdbtn_food.UseVisualStyleBackColor = true;
            // 
            // rdbtn_sleep
            // 
            this.rdbtn_sleep.AutoSize = true;
            this.rdbtn_sleep.Location = new System.Drawing.Point(247, 103);
            this.rdbtn_sleep.Name = "rdbtn_sleep";
            this.rdbtn_sleep.Size = new System.Drawing.Size(92, 24);
            this.rdbtn_sleep.TabIndex = 1;
            this.rdbtn_sleep.TabStop = true;
            this.rdbtn_sleep.Text = "D. sleep";
            this.rdbtn_sleep.UseVisualStyleBackColor = true;
            // 
            // panel_pineapple
            // 
            this.panel_pineapple.BackColor = System.Drawing.Color.White;
            this.panel_pineapple.Controls.Add(this.rdbtn_pineapple);
            this.panel_pineapple.Location = new System.Drawing.Point(12, 198);
            this.panel_pineapple.Name = "panel_pineapple";
            this.panel_pineapple.Size = new System.Drawing.Size(751, 100);
            this.panel_pineapple.TabIndex = 5;
            // 
            // panel_mango
            // 
            this.panel_mango.BackColor = System.Drawing.Color.White;
            this.panel_mango.Controls.Add(this.rdbtn_mango);
            this.panel_mango.Location = new System.Drawing.Point(12, 373);
            this.panel_mango.Name = "panel_mango";
            this.panel_mango.Size = new System.Drawing.Size(751, 100);
            this.panel_mango.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(43, 543);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 29);
            this.label2.TabIndex = 5;
            this.label2.Text = "Your score : ";
            // 
            // lb_score
            // 
            this.lb_score.AutoSize = true;
            this.lb_score.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_score.Location = new System.Drawing.Point(197, 543);
            this.lb_score.Name = "lb_score";
            this.lb_score.Size = new System.Drawing.Size(26, 29);
            this.lb_score.TabIndex = 6;
            this.lb_score.Text = "0";
            // 
            // radiocontrol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 621);
            this.Controls.Add(this.panel_apple);
            this.Controls.Add(this.lb_score);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel_mango);
            this.Controls.Add(this.panel_pineapple);
            this.Controls.Add(this.btn_click);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "radiocontrol";
            this.Text = "radiocontrol";
            this.panel_apple.ResumeLayout(false);
            this.panel_apple.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel_pineapple.ResumeLayout(false);
            this.panel_pineapple.PerformLayout();
            this.panel_mango.ResumeLayout(false);
            this.panel_mango.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rdbtn_game;
        private System.Windows.Forms.RadioButton rdbtn_pineapple;
        private System.Windows.Forms.RadioButton rdbtn_mango;
        private System.Windows.Forms.Button btn_click;
        private System.Windows.Forms.Panel panel_apple;
        private System.Windows.Forms.Panel panel_pineapple;
        private System.Windows.Forms.Panel panel_mango;
        private System.Windows.Forms.RadioButton rdbtn_workout;
        private System.Windows.Forms.RadioButton rdbtn_food;
        private System.Windows.Forms.RadioButton rdbtn_sleep;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lb_score;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton rdbtn_red;
        private System.Windows.Forms.RadioButton rdbtn_green;
        private System.Windows.Forms.RadioButton rdbtn_back;
        private System.Windows.Forms.RadioButton rdbtn_white;
    }
}