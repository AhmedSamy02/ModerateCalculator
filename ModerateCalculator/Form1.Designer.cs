namespace ModerateCalculator
{
    partial class Form1
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.OperationsLog = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.Numbers = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.Clear = new ModerateCalculator.RoundButton();
            this.Dot = new System.Windows.Forms.Button();
            this.Plus = new ModerateCalculator.RoundButton();
            this.Minus = new ModerateCalculator.RoundButton();
            this.Divide = new ModerateCalculator.RoundButton();
            this.Multiply = new ModerateCalculator.RoundButton();
            this.Six = new ModerateCalculator.RoundButton();
            this.Three = new ModerateCalculator.RoundButton();
            this.Seven = new ModerateCalculator.RoundButton();
            this.Four = new ModerateCalculator.RoundButton();
            this.Five = new ModerateCalculator.RoundButton();
            this.Two = new ModerateCalculator.RoundButton();
            this.One = new ModerateCalculator.RoundButton();
            this.Zero = new ModerateCalculator.RoundButton();
            this.Nine = new ModerateCalculator.RoundButton();
            this.Eight = new ModerateCalculator.RoundButton();
            this.Equal = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.OperationsLog);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(434, 47);
            this.panel1.TabIndex = 0;
            // 
            // OperationsLog
            // 
            this.OperationsLog.ForeColor = System.Drawing.Color.White;
            this.OperationsLog.Location = new System.Drawing.Point(112, 0);
            this.OperationsLog.Name = "OperationsLog";
            this.OperationsLog.Size = new System.Drawing.Size(309, 43);
            this.OperationsLog.TabIndex = 1;
            this.OperationsLog.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(3, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Calculating";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.Numbers);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 47);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(434, 70);
            this.panel2.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Palatino Linotype", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(3, 2);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 67);
            this.label4.TabIndex = 3;
            this.label4.Text = "=";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Numbers
            // 
            this.Numbers.Font = new System.Drawing.Font("Palatino Linotype", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Numbers.ForeColor = System.Drawing.Color.White;
            this.Numbers.Location = new System.Drawing.Point(43, -1);
            this.Numbers.Name = "Numbers";
            this.Numbers.Size = new System.Drawing.Size(386, 67);
            this.Numbers.TabIndex = 2;
            this.Numbers.Text = "0";
            this.Numbers.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.Clear);
            this.panel3.Controls.Add(this.Dot);
            this.panel3.Controls.Add(this.Plus);
            this.panel3.Controls.Add(this.Minus);
            this.panel3.Controls.Add(this.Divide);
            this.panel3.Controls.Add(this.Multiply);
            this.panel3.Controls.Add(this.Six);
            this.panel3.Controls.Add(this.Three);
            this.panel3.Controls.Add(this.Seven);
            this.panel3.Controls.Add(this.Four);
            this.panel3.Controls.Add(this.Five);
            this.panel3.Controls.Add(this.Two);
            this.panel3.Controls.Add(this.One);
            this.panel3.Controls.Add(this.Zero);
            this.panel3.Controls.Add(this.Nine);
            this.panel3.Controls.Add(this.Eight);
            this.panel3.Controls.Add(this.Equal);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 117);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(434, 494);
            this.panel3.TabIndex = 1;
            // 
            // Clear
            // 
            this.Clear.BackColor = System.Drawing.Color.CadetBlue;
            this.Clear.FlatAppearance.BorderSize = 0;
            this.Clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Clear.Font = new System.Drawing.Font("DM Serif Text", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Clear.ForeColor = System.Drawing.Color.White;
            this.Clear.Location = new System.Drawing.Point(155, 160);
            this.Clear.Name = "Clear";
            this.Clear.Padding = new System.Windows.Forms.Padding(1, 0, 0, 0);
            this.Clear.Size = new System.Drawing.Size(119, 103);
            this.Clear.TabIndex = 18;
            this.Clear.Text = "C";
            this.Clear.UseVisualStyleBackColor = false;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // Dot
            // 
            this.Dot.BackColor = System.Drawing.Color.CadetBlue;
            this.Dot.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Dot.FlatAppearance.BorderSize = 0;
            this.Dot.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Dot.Font = new System.Drawing.Font("Palatino Linotype", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Dot.ForeColor = System.Drawing.Color.White;
            this.Dot.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Dot.Location = new System.Drawing.Point(0, 396);
            this.Dot.Name = "Dot";
            this.Dot.Size = new System.Drawing.Size(434, 47);
            this.Dot.TabIndex = 16;
            this.Dot.Text = ".";
            this.Dot.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Dot.UseVisualStyleBackColor = false;
            this.Dot.Click += new System.EventHandler(this.Dot_Click);
            // 
            // Plus
            // 
            this.Plus.BackColor = System.Drawing.Color.Gray;
            this.Plus.FlatAppearance.BorderSize = 0;
            this.Plus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Plus.Font = new System.Drawing.Font("DM Serif Text", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Plus.ForeColor = System.Drawing.Color.SeaShell;
            this.Plus.Location = new System.Drawing.Point(26, 59);
            this.Plus.Name = "Plus";
            this.Plus.Padding = new System.Windows.Forms.Padding(2, 0, 0, 0);
            this.Plus.Size = new System.Drawing.Size(50, 50);
            this.Plus.TabIndex = 15;
            this.Plus.Text = "+";
            this.Plus.UseVisualStyleBackColor = false;
            this.Plus.Click += new System.EventHandler(this.Plus_Click);
            // 
            // Minus
            // 
            this.Minus.BackColor = System.Drawing.Color.Gray;
            this.Minus.FlatAppearance.BorderSize = 0;
            this.Minus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Minus.Font = new System.Drawing.Font("DM Serif Text", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Minus.ForeColor = System.Drawing.Color.SeaShell;
            this.Minus.Location = new System.Drawing.Point(26, 305);
            this.Minus.Name = "Minus";
            this.Minus.Padding = new System.Windows.Forms.Padding(2, 0, 0, 0);
            this.Minus.Size = new System.Drawing.Size(50, 50);
            this.Minus.TabIndex = 14;
            this.Minus.Text = "-";
            this.Minus.UseVisualStyleBackColor = false;
            this.Minus.Click += new System.EventHandler(this.Minus_Click);
            // 
            // Divide
            // 
            this.Divide.BackColor = System.Drawing.Color.Gray;
            this.Divide.FlatAppearance.BorderSize = 0;
            this.Divide.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Divide.Font = new System.Drawing.Font("DM Serif Text", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Divide.ForeColor = System.Drawing.Color.SeaShell;
            this.Divide.Location = new System.Drawing.Point(359, 305);
            this.Divide.Name = "Divide";
            this.Divide.Padding = new System.Windows.Forms.Padding(2, 0, 0, 0);
            this.Divide.Size = new System.Drawing.Size(50, 50);
            this.Divide.TabIndex = 13;
            this.Divide.Text = "÷";
            this.Divide.UseVisualStyleBackColor = false;
            this.Divide.Click += new System.EventHandler(this.Divide_Click);
            // 
            // Multiply
            // 
            this.Multiply.BackColor = System.Drawing.Color.Gray;
            this.Multiply.FlatAppearance.BorderSize = 0;
            this.Multiply.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Multiply.Font = new System.Drawing.Font("DM Serif Text", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Multiply.ForeColor = System.Drawing.Color.SeaShell;
            this.Multiply.Location = new System.Drawing.Point(359, 59);
            this.Multiply.Name = "Multiply";
            this.Multiply.Padding = new System.Windows.Forms.Padding(2, 0, 0, 0);
            this.Multiply.Size = new System.Drawing.Size(50, 50);
            this.Multiply.TabIndex = 12;
            this.Multiply.Text = "×";
            this.Multiply.UseVisualStyleBackColor = false;
            this.Multiply.Click += new System.EventHandler(this.Multiply_Click);
            // 
            // Six
            // 
            this.Six.BackColor = System.Drawing.Color.CadetBlue;
            this.Six.FlatAppearance.BorderSize = 0;
            this.Six.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Six.Font = new System.Drawing.Font("DM Serif Text", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Six.ForeColor = System.Drawing.Color.White;
            this.Six.Location = new System.Drawing.Point(122, 285);
            this.Six.Name = "Six";
            this.Six.Padding = new System.Windows.Forms.Padding(1, 0, 0, 0);
            this.Six.Size = new System.Drawing.Size(40, 40);
            this.Six.TabIndex = 11;
            this.Six.Text = "6";
            this.Six.UseVisualStyleBackColor = false;
            this.Six.Click += new System.EventHandler(this.Six_Click);
            // 
            // Three
            // 
            this.Three.BackColor = System.Drawing.Color.CadetBlue;
            this.Three.FlatAppearance.BorderSize = 0;
            this.Three.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Three.Font = new System.Drawing.Font("DM Serif Text", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Three.ForeColor = System.Drawing.Color.White;
            this.Three.Location = new System.Drawing.Point(308, 227);
            this.Three.Name = "Three";
            this.Three.Padding = new System.Windows.Forms.Padding(1, 0, 0, 0);
            this.Three.Size = new System.Drawing.Size(40, 40);
            this.Three.TabIndex = 10;
            this.Three.Text = "3";
            this.Three.UseVisualStyleBackColor = false;
            this.Three.Click += new System.EventHandler(this.Three_Click);
            // 
            // Seven
            // 
            this.Seven.BackColor = System.Drawing.Color.CadetBlue;
            this.Seven.FlatAppearance.BorderSize = 0;
            this.Seven.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Seven.Font = new System.Drawing.Font("DM Serif Text", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Seven.ForeColor = System.Drawing.Color.White;
            this.Seven.Location = new System.Drawing.Point(80, 226);
            this.Seven.Name = "Seven";
            this.Seven.Padding = new System.Windows.Forms.Padding(1, 0, 0, 0);
            this.Seven.Size = new System.Drawing.Size(40, 40);
            this.Seven.TabIndex = 9;
            this.Seven.Text = "7";
            this.Seven.UseVisualStyleBackColor = false;
            this.Seven.Click += new System.EventHandler(this.Seven_Click);
            // 
            // Four
            // 
            this.Four.BackColor = System.Drawing.Color.CadetBlue;
            this.Four.FlatAppearance.BorderSize = 0;
            this.Four.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Four.Font = new System.Drawing.Font("DM Serif Text", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Four.ForeColor = System.Drawing.Color.White;
            this.Four.Location = new System.Drawing.Point(262, 285);
            this.Four.Name = "Four";
            this.Four.Padding = new System.Windows.Forms.Padding(1, 0, 0, 0);
            this.Four.Size = new System.Drawing.Size(40, 40);
            this.Four.TabIndex = 8;
            this.Four.Text = "4";
            this.Four.UseVisualStyleBackColor = false;
            this.Four.Click += new System.EventHandler(this.Four_Click);
            // 
            // Five
            // 
            this.Five.BackColor = System.Drawing.Color.CadetBlue;
            this.Five.FlatAppearance.BorderSize = 0;
            this.Five.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Five.Font = new System.Drawing.Font("DM Serif Text", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Five.ForeColor = System.Drawing.Color.White;
            this.Five.Location = new System.Drawing.Point(194, 299);
            this.Five.Name = "Five";
            this.Five.Padding = new System.Windows.Forms.Padding(1, 0, 0, 0);
            this.Five.Size = new System.Drawing.Size(40, 40);
            this.Five.TabIndex = 7;
            this.Five.Text = "5";
            this.Five.UseVisualStyleBackColor = false;
            this.Five.Click += new System.EventHandler(this.Five_Click);
            // 
            // Two
            // 
            this.Two.BackColor = System.Drawing.Color.CadetBlue;
            this.Two.FlatAppearance.BorderSize = 0;
            this.Two.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Two.Font = new System.Drawing.Font("DM Serif Text", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Two.ForeColor = System.Drawing.Color.White;
            this.Two.Location = new System.Drawing.Point(308, 164);
            this.Two.Name = "Two";
            this.Two.Padding = new System.Windows.Forms.Padding(1, 0, 0, 0);
            this.Two.Size = new System.Drawing.Size(40, 40);
            this.Two.TabIndex = 6;
            this.Two.Text = "2";
            this.Two.UseVisualStyleBackColor = false;
            this.Two.Click += new System.EventHandler(this.Two_Click);
            // 
            // One
            // 
            this.One.BackColor = System.Drawing.Color.CadetBlue;
            this.One.FlatAppearance.BorderSize = 0;
            this.One.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.One.Font = new System.Drawing.Font("DM Serif Text", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.One.ForeColor = System.Drawing.Color.White;
            this.One.Location = new System.Drawing.Point(265, 107);
            this.One.Name = "One";
            this.One.Padding = new System.Windows.Forms.Padding(1, 0, 0, 0);
            this.One.Size = new System.Drawing.Size(40, 40);
            this.One.TabIndex = 5;
            this.One.Text = "1";
            this.One.UseVisualStyleBackColor = false;
            this.One.Click += new System.EventHandler(this.One_Click);
            // 
            // Zero
            // 
            this.Zero.BackColor = System.Drawing.Color.CadetBlue;
            this.Zero.FlatAppearance.BorderSize = 0;
            this.Zero.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Zero.Font = new System.Drawing.Font("DM Serif Text", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Zero.ForeColor = System.Drawing.Color.White;
            this.Zero.Location = new System.Drawing.Point(193, 84);
            this.Zero.Name = "Zero";
            this.Zero.Padding = new System.Windows.Forms.Padding(1, 0, 0, 0);
            this.Zero.Size = new System.Drawing.Size(40, 40);
            this.Zero.TabIndex = 4;
            this.Zero.Text = "0";
            this.Zero.UseVisualStyleBackColor = false;
            this.Zero.Click += new System.EventHandler(this.Zero_Click);
            // 
            // Nine
            // 
            this.Nine.BackColor = System.Drawing.Color.CadetBlue;
            this.Nine.FlatAppearance.BorderSize = 0;
            this.Nine.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Nine.Font = new System.Drawing.Font("DM Serif Text", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Nine.ForeColor = System.Drawing.Color.White;
            this.Nine.Location = new System.Drawing.Point(121, 106);
            this.Nine.Name = "Nine";
            this.Nine.Padding = new System.Windows.Forms.Padding(1, 0, 0, 0);
            this.Nine.Size = new System.Drawing.Size(40, 40);
            this.Nine.TabIndex = 3;
            this.Nine.Text = "9";
            this.Nine.UseVisualStyleBackColor = false;
            this.Nine.Click += new System.EventHandler(this.Nine_Click);
            // 
            // Eight
            // 
            this.Eight.BackColor = System.Drawing.Color.CadetBlue;
            this.Eight.FlatAppearance.BorderSize = 0;
            this.Eight.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Eight.Font = new System.Drawing.Font("DM Serif Text", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Eight.ForeColor = System.Drawing.Color.White;
            this.Eight.Location = new System.Drawing.Point(77, 160);
            this.Eight.Name = "Eight";
            this.Eight.Padding = new System.Windows.Forms.Padding(1, 0, 0, 0);
            this.Eight.Size = new System.Drawing.Size(40, 40);
            this.Eight.TabIndex = 1;
            this.Eight.Text = "8";
            this.Eight.UseVisualStyleBackColor = false;
            this.Eight.Click += new System.EventHandler(this.Eight_Click);
            // 
            // Equal
            // 
            this.Equal.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.Equal.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Equal.FlatAppearance.BorderSize = 0;
            this.Equal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Equal.Font = new System.Drawing.Font("Segoe Print", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.Equal.ForeColor = System.Drawing.Color.White;
            this.Equal.Location = new System.Drawing.Point(0, 443);
            this.Equal.Name = "Equal";
            this.Equal.Size = new System.Drawing.Size(434, 51);
            this.Equal.TabIndex = 0;
            this.Equal.Text = "=";
            this.Equal.UseVisualStyleBackColor = false;
            this.Equal.Click += new System.EventHandler(this.Equal_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 611);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Form1";
            this.Text = "Moderate Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Button Equal;
        private Label OperationsLog;
        private Label label1;
        private Label label4;
        private Label Numbers;
        private RoundButton Eight;
        private RoundButton Six;
        private RoundButton Three;
        private RoundButton Seven;
        private RoundButton Four;
        private RoundButton Five;
        private RoundButton Two;
        private RoundButton One;
        private RoundButton Zero;
        private RoundButton Nine;
        private RoundButton Plus;
        private RoundButton Minus;
        private RoundButton Divide;
        private RoundButton Multiply;
        private Button Dot;
        private RoundButton Clear;
    }
}