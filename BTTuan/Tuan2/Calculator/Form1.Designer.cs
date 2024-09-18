namespace Calculator_ver0._0
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
            DisplayScreen = new TextBox();
            ButtonSqrt2 = new Button();
            ButtonPow2 = new Button();
            ButtonPercentage = new Button();
            ButtonDEL = new Button();
            ButtonAC = new Button();
            ButtonDIV = new Button();
            Num9 = new Button();
            Num8 = new Button();
            Num7 = new Button();
            ButtonDivide = new Button();
            Num6 = new Button();
            ButtonMult = new Button();
            Num5 = new Button();
            Num4 = new Button();
            ButtonMinus = new Button();
            Num3 = new Button();
            ButtonPlus = new Button();
            Num2 = new Button();
            Num1 = new Button();
            ButtonEqual = new Button();
            ButtonAns = new Button();
            ButtonDot = new Button();
            Num0 = new Button();
            SuspendLayout();
            // 
            // DisplayScreen
            // 
            DisplayScreen.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            DisplayScreen.Location = new Point(0, 0);
            DisplayScreen.Multiline = true;
            DisplayScreen.Name = "DisplayScreen";
            DisplayScreen.RightToLeft = RightToLeft.No;
            DisplayScreen.Size = new Size(347, 56);
            DisplayScreen.TabIndex = 0;
            DisplayScreen.TextChanged += DisplayScreen_TextChanged;
            // 
            // ButtonSqrt2
            // 
            ButtonSqrt2.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold);
            ButtonSqrt2.Location = new Point(1, 62);
            ButtonSqrt2.Name = "ButtonSqrt2";
            ButtonSqrt2.Size = new Size(64, 60);
            ButtonSqrt2.TabIndex = 1;
            ButtonSqrt2.Text = "√2";
            ButtonSqrt2.UseVisualStyleBackColor = true;
            ButtonSqrt2.Click += ButtonSqrt2_Click;
            // 
            // ButtonPow2
            // 
            ButtonPow2.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold);
            ButtonPow2.Location = new Point(71, 62);
            ButtonPow2.Name = "ButtonPow2";
            ButtonPow2.Size = new Size(64, 60);
            ButtonPow2.TabIndex = 2;
            ButtonPow2.Text = "^2";
            ButtonPow2.UseVisualStyleBackColor = true;
            ButtonPow2.Click += ButtonPow2_Click;
            // 
            // ButtonPercentage
            // 
            ButtonPercentage.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold);
            ButtonPercentage.Location = new Point(141, 62);
            ButtonPercentage.Name = "ButtonPercentage";
            ButtonPercentage.Size = new Size(64, 60);
            ButtonPercentage.TabIndex = 4;
            ButtonPercentage.Text = "%";
            ButtonPercentage.UseVisualStyleBackColor = true;
            ButtonPercentage.Click += ButtonPercentage_Click;
            // 
            // ButtonDEL
            // 
            ButtonDEL.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            ButtonDEL.Location = new Point(211, 62);
            ButtonDEL.Name = "ButtonDEL";
            ButtonDEL.Size = new Size(64, 60);
            ButtonDEL.TabIndex = 3;
            ButtonDEL.Text = "DEL";
            ButtonDEL.UseVisualStyleBackColor = true;
            ButtonDEL.Click += ButtonDEL_Click;
            // 
            // ButtonAC
            // 
            ButtonAC.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            ButtonAC.Location = new Point(281, 62);
            ButtonAC.Name = "ButtonAC";
            ButtonAC.Size = new Size(64, 60);
            ButtonAC.TabIndex = 5;
            ButtonAC.Text = "AC";
            ButtonAC.UseVisualStyleBackColor = true;
            ButtonAC.Click += ButtonAC_Click;
            // 
            // ButtonDIV
            // 
            ButtonDIV.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            ButtonDIV.Location = new Point(214, 128);
            ButtonDIV.Name = "ButtonDIV";
            ButtonDIV.Size = new Size(134, 60);
            ButtonDIV.TabIndex = 10;
            ButtonDIV.Text = "DIV";
            ButtonDIV.UseVisualStyleBackColor = true;
            ButtonDIV.Click += ButtonDIV_Click;
            // 
            // Num9
            // 
            Num9.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            Num9.Location = new Point(144, 128);
            Num9.Name = "Num9";
            Num9.Size = new Size(64, 60);
            Num9.TabIndex = 9;
            Num9.Text = "9";
            Num9.UseVisualStyleBackColor = true;
            Num9.Click += Num9_Click;
            // 
            // Num8
            // 
            Num8.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            Num8.Location = new Point(74, 128);
            Num8.Name = "Num8";
            Num8.Size = new Size(64, 60);
            Num8.TabIndex = 7;
            Num8.Text = "8";
            Num8.UseVisualStyleBackColor = true;
            Num8.Click += Num8_Click;
            // 
            // Num7
            // 
            Num7.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            Num7.Location = new Point(4, 128);
            Num7.Name = "Num7";
            Num7.Size = new Size(64, 60);
            Num7.TabIndex = 6;
            Num7.Text = "7";
            Num7.UseVisualStyleBackColor = true;
            Num7.Click += Num7_Click;
            // 
            // ButtonDivide
            // 
            ButtonDivide.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold);
            ButtonDivide.Location = new Point(281, 194);
            ButtonDivide.Name = "ButtonDivide";
            ButtonDivide.Size = new Size(64, 60);
            ButtonDivide.TabIndex = 15;
            ButtonDivide.Text = "/";
            ButtonDivide.UseVisualStyleBackColor = true;
            ButtonDivide.Click += ButtonDivide_Click;
            // 
            // Num6
            // 
            Num6.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            Num6.Location = new Point(141, 194);
            Num6.Name = "Num6";
            Num6.Size = new Size(64, 60);
            Num6.TabIndex = 14;
            Num6.Text = "6";
            Num6.UseVisualStyleBackColor = true;
            Num6.Click += Num6_Click;
            // 
            // ButtonMult
            // 
            ButtonMult.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold);
            ButtonMult.Location = new Point(211, 194);
            ButtonMult.Name = "ButtonMult";
            ButtonMult.Size = new Size(64, 60);
            ButtonMult.TabIndex = 13;
            ButtonMult.Text = "*";
            ButtonMult.UseVisualStyleBackColor = true;
            ButtonMult.Click += ButtonMult_Click;
            // 
            // Num5
            // 
            Num5.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            Num5.Location = new Point(71, 194);
            Num5.Name = "Num5";
            Num5.Size = new Size(64, 60);
            Num5.TabIndex = 12;
            Num5.Text = "5";
            Num5.UseVisualStyleBackColor = true;
            Num5.Click += Num5_Click;
            // 
            // Num4
            // 
            Num4.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            Num4.Location = new Point(1, 194);
            Num4.Name = "Num4";
            Num4.Size = new Size(64, 60);
            Num4.TabIndex = 11;
            Num4.Text = "4";
            Num4.UseVisualStyleBackColor = true;
            Num4.Click += Num4_Click;
            // 
            // ButtonMinus
            // 
            ButtonMinus.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold);
            ButtonMinus.Location = new Point(284, 260);
            ButtonMinus.Name = "ButtonMinus";
            ButtonMinus.Size = new Size(64, 60);
            ButtonMinus.TabIndex = 20;
            ButtonMinus.Text = "-";
            ButtonMinus.UseVisualStyleBackColor = true;
            ButtonMinus.Click += ButtonMinus_Click;
            // 
            // Num3
            // 
            Num3.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            Num3.Location = new Point(144, 260);
            Num3.Name = "Num3";
            Num3.Size = new Size(64, 60);
            Num3.TabIndex = 19;
            Num3.Text = "3";
            Num3.UseVisualStyleBackColor = true;
            Num3.Click += Num3_Click;
            // 
            // ButtonPlus
            // 
            ButtonPlus.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold);
            ButtonPlus.Location = new Point(214, 260);
            ButtonPlus.Name = "ButtonPlus";
            ButtonPlus.Size = new Size(64, 60);
            ButtonPlus.TabIndex = 18;
            ButtonPlus.Text = "+";
            ButtonPlus.UseVisualStyleBackColor = true;
            ButtonPlus.Click += ButtonPlus_Click;
            // 
            // Num2
            // 
            Num2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            Num2.Location = new Point(74, 260);
            Num2.Name = "Num2";
            Num2.Size = new Size(64, 60);
            Num2.TabIndex = 17;
            Num2.Text = "2";
            Num2.UseVisualStyleBackColor = true;
            Num2.Click += Num2_Click;
            // 
            // Num1
            // 
            Num1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            Num1.Location = new Point(4, 260);
            Num1.Name = "Num1";
            Num1.Size = new Size(64, 60);
            Num1.TabIndex = 16;
            Num1.Text = "1";
            Num1.UseVisualStyleBackColor = true;
            Num1.Click += button20_Click;
            // 
            // ButtonEqual
            // 
            ButtonEqual.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ButtonEqual.Location = new Point(214, 326);
            ButtonEqual.Name = "ButtonEqual";
            ButtonEqual.Size = new Size(134, 60);
            ButtonEqual.TabIndex = 25;
            ButtonEqual.Text = "=";
            ButtonEqual.UseVisualStyleBackColor = true;
            ButtonEqual.Click += ButtonEqual_Click;
            // 
            // ButtonAns
            // 
            ButtonAns.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ButtonAns.Location = new Point(144, 326);
            ButtonAns.Name = "ButtonAns";
            ButtonAns.Size = new Size(64, 60);
            ButtonAns.TabIndex = 24;
            ButtonAns.Text = "Ans";
            ButtonAns.UseVisualStyleBackColor = true;
            ButtonAns.Click += ButtonAns_Click;
            // 
            // ButtonDot
            // 
            ButtonDot.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ButtonDot.Location = new Point(74, 326);
            ButtonDot.Name = "ButtonDot";
            ButtonDot.Size = new Size(64, 60);
            ButtonDot.TabIndex = 22;
            ButtonDot.Text = ".";
            ButtonDot.UseVisualStyleBackColor = true;
            ButtonDot.Click += ButtonDot_Click;
            // 
            // Num0
            // 
            Num0.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Num0.Location = new Point(4, 326);
            Num0.Name = "Num0";
            Num0.Size = new Size(64, 60);
            Num0.TabIndex = 21;
            Num0.Text = "0";
            Num0.UseVisualStyleBackColor = true;
            Num0.Click += Num0_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(347, 388);
            Controls.Add(ButtonEqual);
            Controls.Add(ButtonAns);
            Controls.Add(ButtonDot);
            Controls.Add(Num0);
            Controls.Add(ButtonMinus);
            Controls.Add(Num3);
            Controls.Add(ButtonPlus);
            Controls.Add(Num2);
            Controls.Add(Num1);
            Controls.Add(ButtonDivide);
            Controls.Add(Num6);
            Controls.Add(ButtonMult);
            Controls.Add(Num5);
            Controls.Add(Num4);
            Controls.Add(ButtonDIV);
            Controls.Add(Num9);
            Controls.Add(Num8);
            Controls.Add(Num7);
            Controls.Add(ButtonAC);
            Controls.Add(ButtonPercentage);
            Controls.Add(ButtonDEL);
            Controls.Add(ButtonPow2);
            Controls.Add(ButtonSqrt2);
            Controls.Add(DisplayScreen);
            Name = "Form1";
            Text = "Calculator";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox DisplayScreen;
        private Button ButtonSqrt2;
        private Button ButtonPow2;
        private Button ButtonPercentage;
        private Button ButtonDEL;
        private Button ButtonAC;
        private Button ButtonDIV;
        private Button Num9;
        private Button Num8;
        private Button Num7;
        private Button ButtonDivide;
        private Button Num6;
        private Button ButtonMult;
        private Button Num5;
        private Button Num4;
        private Button ButtonMinus;
        private Button Num3;
        private Button ButtonPlus;
        private Button Num2;
        private Button Num1;
        private Button ButtonEqual;
        private Button ButtonAns;
        private Button ButtonDot;
        private Button Num0;
    }
}
