using System.Windows.Forms;

namespace Calculator
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button_1 = new System.Windows.Forms.Button();
            this.button_2 = new System.Windows.Forms.Button();
            this.button_3 = new System.Windows.Forms.Button();
            this.button_addition = new System.Windows.Forms.Button();
            this.button_answer = new System.Windows.Forms.Button();
            this.button_back = new System.Windows.Forms.Button();
            this.button_0 = new System.Windows.Forms.Button();
            this.button_dot = new System.Windows.Forms.Button();
            this.button_subtraction = new System.Windows.Forms.Button();
            this.button_6 = new System.Windows.Forms.Button();
            this.button_5 = new System.Windows.Forms.Button();
            this.button_4 = new System.Windows.Forms.Button();
            this.button_multiplication = new System.Windows.Forms.Button();
            this.button_9 = new System.Windows.Forms.Button();
            this.button_8 = new System.Windows.Forms.Button();
            this.button_7 = new System.Windows.Forms.Button();
            this.mainTextBox = new System.Windows.Forms.TextBox();
            this.button_division = new System.Windows.Forms.Button();
            this.button_power = new System.Windows.Forms.Button();
            this.button_clear_all = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button_one_over = new System.Windows.Forms.Button();
            this.button_sqrt = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button_clear = new System.Windows.Forms.Button();
            this.button_mem_c = new System.Windows.Forms.Button();
            this.button_mem_read = new System.Windows.Forms.Button();
            this.button_mem_add = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.memoryTxtBx = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button_1
            // 
            this.button_1.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_1.Location = new System.Drawing.Point(3, 425);
            this.button_1.Name = "button_1";
            this.button_1.Size = new System.Drawing.Size(82, 69);
            this.button_1.TabIndex = 2;
            this.button_1.Text = "1";
            this.button_1.UseVisualStyleBackColor = true;
            this.button_1.Click += new System.EventHandler(this.button_Click);
            // 
            // button_2
            // 
            this.button_2.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_2.Location = new System.Drawing.Point(89, 425);
            this.button_2.Name = "button_2";
            this.button_2.Size = new System.Drawing.Size(82, 69);
            this.button_2.TabIndex = 5;
            this.button_2.Text = "2";
            this.button_2.UseVisualStyleBackColor = true;
            this.button_2.Click += new System.EventHandler(this.button_Click);
            // 
            // button_3
            // 
            this.button_3.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_3.Location = new System.Drawing.Point(178, 425);
            this.button_3.Name = "button_3";
            this.button_3.Size = new System.Drawing.Size(82, 69);
            this.button_3.TabIndex = 8;
            this.button_3.Text = "3";
            this.button_3.UseVisualStyleBackColor = true;
            this.button_3.Click += new System.EventHandler(this.button_Click);
            // 
            // button_addition
            // 
            this.button_addition.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_addition.Location = new System.Drawing.Point(265, 425);
            this.button_addition.Name = "button_addition";
            this.button_addition.Size = new System.Drawing.Size(82, 69);
            this.button_addition.TabIndex = 11;
            this.button_addition.Text = "+";
            this.button_addition.UseVisualStyleBackColor = true;
            this.button_addition.Click += new System.EventHandler(this.button_Click);
            // 
            // button_answer
            // 
            this.button_answer.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_answer.Location = new System.Drawing.Point(265, 499);
            this.button_answer.Name = "button_answer";
            this.button_answer.Size = new System.Drawing.Size(82, 69);
            this.button_answer.TabIndex = 15;
            this.button_answer.Text = "=";
            this.button_answer.UseVisualStyleBackColor = true;
            this.button_answer.Click += new System.EventHandler(this.button_Click);
            // 
            // button_back
            // 
            this.button_back.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_back.Location = new System.Drawing.Point(178, 499);
            this.button_back.Name = "button_back";
            this.button_back.Size = new System.Drawing.Size(82, 69);
            this.button_back.TabIndex = 14;
            this.button_back.Text = "<-";
            this.button_back.UseVisualStyleBackColor = true;
            this.button_back.Click += new System.EventHandler(this.button_Click);
            // 
            // button_0
            // 
            this.button_0.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_0.Location = new System.Drawing.Point(89, 499);
            this.button_0.Name = "button_0";
            this.button_0.Size = new System.Drawing.Size(82, 69);
            this.button_0.TabIndex = 13;
            this.button_0.Text = "0";
            this.button_0.UseVisualStyleBackColor = true;
            this.button_0.Click += new System.EventHandler(this.button_Click);
            // 
            // button_dot
            // 
            this.button_dot.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_dot.Location = new System.Drawing.Point(3, 499);
            this.button_dot.Name = "button_dot";
            this.button_dot.Size = new System.Drawing.Size(82, 69);
            this.button_dot.TabIndex = 12;
            this.button_dot.Text = ".";
            this.button_dot.UseVisualStyleBackColor = true;
            this.button_dot.Click += new System.EventHandler(this.button_Click);
            // 
            // button_subtraction
            // 
            this.button_subtraction.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_subtraction.Location = new System.Drawing.Point(265, 350);
            this.button_subtraction.Name = "button_subtraction";
            this.button_subtraction.Size = new System.Drawing.Size(82, 69);
            this.button_subtraction.TabIndex = 19;
            this.button_subtraction.Text = "-";
            this.button_subtraction.UseVisualStyleBackColor = true;
            this.button_subtraction.Click += new System.EventHandler(this.button_Click);
            // 
            // button_6
            // 
            this.button_6.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_6.Location = new System.Drawing.Point(178, 350);
            this.button_6.Name = "button_6";
            this.button_6.Size = new System.Drawing.Size(82, 69);
            this.button_6.TabIndex = 18;
            this.button_6.Text = "6";
            this.button_6.UseVisualStyleBackColor = true;
            this.button_6.Click += new System.EventHandler(this.button_Click);
            // 
            // button_5
            // 
            this.button_5.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_5.Location = new System.Drawing.Point(89, 350);
            this.button_5.Name = "button_5";
            this.button_5.Size = new System.Drawing.Size(82, 69);
            this.button_5.TabIndex = 17;
            this.button_5.Text = "5";
            this.button_5.UseVisualStyleBackColor = true;
            this.button_5.Click += new System.EventHandler(this.button_Click);
            // 
            // button_4
            // 
            this.button_4.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_4.Location = new System.Drawing.Point(3, 350);
            this.button_4.Name = "button_4";
            this.button_4.Size = new System.Drawing.Size(82, 69);
            this.button_4.TabIndex = 16;
            this.button_4.Text = "4";
            this.button_4.UseVisualStyleBackColor = true;
            this.button_4.Click += new System.EventHandler(this.button_Click);
            // 
            // button_multiplication
            // 
            this.button_multiplication.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_multiplication.Location = new System.Drawing.Point(265, 275);
            this.button_multiplication.Name = "button_multiplication";
            this.button_multiplication.Size = new System.Drawing.Size(82, 69);
            this.button_multiplication.TabIndex = 23;
            this.button_multiplication.Text = "*";
            this.button_multiplication.UseVisualStyleBackColor = true;
            this.button_multiplication.Click += new System.EventHandler(this.button_Click);
            // 
            // button_9
            // 
            this.button_9.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_9.Location = new System.Drawing.Point(178, 275);
            this.button_9.Name = "button_9";
            this.button_9.Size = new System.Drawing.Size(82, 69);
            this.button_9.TabIndex = 22;
            this.button_9.Text = "9";
            this.button_9.UseVisualStyleBackColor = true;
            this.button_9.Click += new System.EventHandler(this.button_Click);
            // 
            // button_8
            // 
            this.button_8.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_8.Location = new System.Drawing.Point(89, 275);
            this.button_8.Name = "button_8";
            this.button_8.Size = new System.Drawing.Size(82, 69);
            this.button_8.TabIndex = 21;
            this.button_8.Text = "8";
            this.button_8.UseVisualStyleBackColor = true;
            this.button_8.Click += new System.EventHandler(this.button_Click);
            // 
            // button_7
            // 
            this.button_7.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_7.Location = new System.Drawing.Point(3, 275);
            this.button_7.Name = "button_7";
            this.button_7.Size = new System.Drawing.Size(82, 69);
            this.button_7.TabIndex = 20;
            this.button_7.Text = "7";
            this.button_7.UseVisualStyleBackColor = true;
            this.button_7.Click += new System.EventHandler(this.button_Click);
            // 
            // mainTextBox
            // 
            this.mainTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.mainTextBox.Font = new System.Drawing.Font("Segoe UI", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.mainTextBox.Location = new System.Drawing.Point(3, 27);
            this.mainTextBox.Name = "mainTextBox";
            this.mainTextBox.ReadOnly = true;
            this.mainTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.mainTextBox.Size = new System.Drawing.Size(344, 70);
            this.mainTextBox.TabIndex = 24;
            this.mainTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // button_division
            // 
            this.button_division.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_division.Location = new System.Drawing.Point(178, 233);
            this.button_division.Name = "button_division";
            this.button_division.Size = new System.Drawing.Size(82, 38);
            this.button_division.TabIndex = 28;
            this.button_division.Text = "÷";
            this.button_division.UseVisualStyleBackColor = true;
            this.button_division.Click += new System.EventHandler(this.button_Click);
            // 
            // button_power
            // 
            this.button_power.Font = new System.Drawing.Font("Segoe UI", 19F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_power.Location = new System.Drawing.Point(89, 234);
            this.button_power.Name = "button_power";
            this.button_power.Size = new System.Drawing.Size(82, 38);
            this.button_power.TabIndex = 27;
            this.button_power.Text = "x^2";
            this.button_power.UseVisualStyleBackColor = true;
            this.button_power.Click += new System.EventHandler(this.button_Click);
            // 
            // button_clear_all
            // 
            this.button_clear_all.Font = new System.Drawing.Font("Segoe UI", 19F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_clear_all.Location = new System.Drawing.Point(3, 232);
            this.button_clear_all.Name = "button_clear_all";
            this.button_clear_all.Size = new System.Drawing.Size(82, 38);
            this.button_clear_all.TabIndex = 25;
            this.button_clear_all.Text = "C";
            this.button_clear_all.UseVisualStyleBackColor = true;
            this.button_clear_all.Click += new System.EventHandler(this.button_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(350, 24);
            this.menuStrip1.TabIndex = 29;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(93, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem.Text = "&About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // button_one_over
            // 
            this.button_one_over.Font = new System.Drawing.Font("Segoe UI", 19F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_one_over.Location = new System.Drawing.Point(265, 234);
            this.button_one_over.Name = "button_one_over";
            this.button_one_over.Size = new System.Drawing.Size(82, 38);
            this.button_one_over.TabIndex = 35;
            this.button_one_over.Text = "1/x";
            this.button_one_over.UseVisualStyleBackColor = true;
            this.button_one_over.Click += new System.EventHandler(this.button_Click);
            // 
            // button_sqrt
            // 
            this.button_sqrt.Font = new System.Drawing.Font("Segoe UI", 19F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_sqrt.Location = new System.Drawing.Point(178, 189);
            this.button_sqrt.Name = "button_sqrt";
            this.button_sqrt.Size = new System.Drawing.Size(82, 38);
            this.button_sqrt.TabIndex = 34;
            this.button_sqrt.Text = "√";
            this.button_sqrt.UseVisualStyleBackColor = true;
            this.button_sqrt.Click += new System.EventHandler(this.button_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Segoe UI", 19F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button3.Location = new System.Drawing.Point(89, 189);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(82, 38);
            this.button3.TabIndex = 33;
            this.button3.Text = "%";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button_Click);
            // 
            // button_clear
            // 
            this.button_clear.Font = new System.Drawing.Font("Segoe UI", 19F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_clear.Location = new System.Drawing.Point(3, 189);
            this.button_clear.Name = "button_clear";
            this.button_clear.Size = new System.Drawing.Size(82, 38);
            this.button_clear.TabIndex = 32;
            this.button_clear.Text = "CE";
            this.button_clear.UseVisualStyleBackColor = true;
            this.button_clear.Click += new System.EventHandler(this.button_Click);
            // 
            // button_mem_c
            // 
            this.button_mem_c.Font = new System.Drawing.Font("Segoe UI", 19F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_mem_c.Location = new System.Drawing.Point(3, 145);
            this.button_mem_c.Name = "button_mem_c";
            this.button_mem_c.Size = new System.Drawing.Size(82, 38);
            this.button_mem_c.TabIndex = 36;
            this.button_mem_c.Text = "MC";
            this.button_mem_c.UseVisualStyleBackColor = true;
            this.button_mem_c.Click += new System.EventHandler(this.button_Click);
            // 
            // button_mem_read
            // 
            this.button_mem_read.Font = new System.Drawing.Font("Segoe UI", 19F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_mem_read.Location = new System.Drawing.Point(178, 145);
            this.button_mem_read.Name = "button_mem_read";
            this.button_mem_read.Size = new System.Drawing.Size(82, 38);
            this.button_mem_read.TabIndex = 37;
            this.button_mem_read.Text = "MR";
            this.button_mem_read.UseVisualStyleBackColor = true;
            this.button_mem_read.Click += new System.EventHandler(this.button_Click);
            // 
            // button_mem_add
            // 
            this.button_mem_add.Font = new System.Drawing.Font("Segoe UI", 19F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_mem_add.Location = new System.Drawing.Point(89, 145);
            this.button_mem_add.Name = "button_mem_add";
            this.button_mem_add.Size = new System.Drawing.Size(82, 38);
            this.button_mem_add.TabIndex = 39;
            this.button_mem_add.Text = "M+";
            this.button_mem_add.UseVisualStyleBackColor = true;
            this.button_mem_add.Click += new System.EventHandler(this.button_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(265, 145);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(82, 82);
            this.pictureBox1.TabIndex = 40;
            this.pictureBox1.TabStop = false;
            // 
            // memoryTxtBx
            // 
            this.memoryTxtBx.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.memoryTxtBx.Location = new System.Drawing.Point(3, 100);
            this.memoryTxtBx.Name = "memoryTxtBx";
            this.memoryTxtBx.ReadOnly = true;
            this.memoryTxtBx.Size = new System.Drawing.Size(344, 39);
            this.memoryTxtBx.TabIndex = 41;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 571);
            this.Controls.Add(this.memoryTxtBx);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button_mem_add);
            this.Controls.Add(this.button_mem_read);
            this.Controls.Add(this.button_mem_c);
            this.Controls.Add(this.button_one_over);
            this.Controls.Add(this.button_sqrt);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button_clear);
            this.Controls.Add(this.button_division);
            this.Controls.Add(this.button_power);
            this.Controls.Add(this.button_clear_all);
            this.Controls.Add(this.mainTextBox);
            this.Controls.Add(this.button_multiplication);
            this.Controls.Add(this.button_9);
            this.Controls.Add(this.button_8);
            this.Controls.Add(this.button_7);
            this.Controls.Add(this.button_subtraction);
            this.Controls.Add(this.button_6);
            this.Controls.Add(this.button_5);
            this.Controls.Add(this.button_4);
            this.Controls.Add(this.button_answer);
            this.Controls.Add(this.button_back);
            this.Controls.Add(this.button_0);
            this.Controls.Add(this.button_dot);
            this.Controls.Add(this.button_addition);
            this.Controls.Add(this.button_3);
            this.Controls.Add(this.button_2);
            this.Controls.Add(this.button_1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainForm_KeyDown);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button button_1;
        private Button button_2;
        private Button button_3;
        private Button button_addition;
        private Button button_answer;
        private Button button_back;
        private Button button_0;
        private Button button_dot;
        private Button button_subtraction;
        private Button button_6;
        private Button button_5;
        private Button button_4;
        private Button button_multiplication;
        private Button button_9;
        private Button button_8;
        private Button button_7;
        private TextBox mainTextBox;
        private Button button_division;
        private Button button_power;
        private Button button_clear_all;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem helpToolStripMenuItem;
        private ToolStripMenuItem aboutToolStripMenuItem;
        private Button button_one_over;
        private Button button_sqrt;
        private Button button3;
        private Button button_clear;
        private Button button_mem_c;
        private Button button_mem_read;
        private Button button_mem_add;
        private PictureBox pictureBox1;
        private TextBox memoryTxtBx;
    }
}