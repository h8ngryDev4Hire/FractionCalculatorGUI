namespace FractionCalculatorGUI
{
    partial class FracCalcGUI
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
            this.TextBoxDisplay = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button0 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.buttonDivide = new System.Windows.Forms.Button();
            this.buttonMultiply = new System.Windows.Forms.Button();
            this.buttonMinus = new System.Windows.Forms.Button();
            this.buttonPlus = new System.Windows.Forms.Button();
            this.buttonClearAll = new System.Windows.Forms.Button();
            this.buttonClearScreen = new System.Windows.Forms.Button();
            this.labelFractionMode = new System.Windows.Forms.Label();
            this.labelFractionDisplay = new System.Windows.Forms.Label();
            this.buttonFractionMode = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TextBoxDisplay
            // 
            this.TextBoxDisplay.Location = new System.Drawing.Point(12, 28);
            this.TextBoxDisplay.Name = "TextBoxDisplay";
            this.TextBoxDisplay.ReadOnly = true;
            this.TextBoxDisplay.Size = new System.Drawing.Size(180, 23);
            this.TextBoxDisplay.TabIndex = 0;
            this.TextBoxDisplay.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.TextBoxDisplay.TextChanged += new System.EventHandler(this.TextBoxDisplay_TextChanged);
            // 
            // button1
            // 
            this.button1.Enabled = false;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(12, 189);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(56, 51);
            this.button1.TabIndex = 1;
            this.button1.Text = "1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.Enabled = false;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button2.Location = new System.Drawing.Point(74, 189);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(56, 51);
            this.button2.TabIndex = 2;
            this.button2.Text = "2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // button0
            // 
            this.button0.Enabled = false;
            this.button0.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button0.Location = new System.Drawing.Point(74, 246);
            this.button0.Name = "button0";
            this.button0.Size = new System.Drawing.Size(56, 51);
            this.button0.TabIndex = 3;
            this.button0.Text = "0";
            this.button0.UseVisualStyleBackColor = true;
            this.button0.Click += new System.EventHandler(this.button0_Click_1);
            // 
            // button7
            // 
            this.button7.Enabled = false;
            this.button7.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button7.Location = new System.Drawing.Point(12, 75);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(56, 51);
            this.button7.TabIndex = 4;
            this.button7.Text = "7";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click_1);
            // 
            // button8
            // 
            this.button8.Enabled = false;
            this.button8.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button8.Location = new System.Drawing.Point(74, 75);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(56, 51);
            this.button8.TabIndex = 5;
            this.button8.Text = "8";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click_1);
            // 
            // button9
            // 
            this.button9.Enabled = false;
            this.button9.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button9.Location = new System.Drawing.Point(136, 75);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(56, 51);
            this.button9.TabIndex = 6;
            this.button9.Text = "9";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click_1);
            // 
            // button6
            // 
            this.button6.Enabled = false;
            this.button6.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button6.Location = new System.Drawing.Point(136, 132);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(56, 51);
            this.button6.TabIndex = 7;
            this.button6.Text = "6";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click_1);
            // 
            // button5
            // 
            this.button5.Enabled = false;
            this.button5.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button5.Location = new System.Drawing.Point(74, 132);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(56, 51);
            this.button5.TabIndex = 8;
            this.button5.Text = "5";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.Enabled = false;
            this.button4.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button4.Location = new System.Drawing.Point(12, 132);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(56, 51);
            this.button4.TabIndex = 9;
            this.button4.Text = "4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click_1);
            // 
            // button3
            // 
            this.button3.Enabled = false;
            this.button3.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button3.Location = new System.Drawing.Point(136, 189);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(56, 51);
            this.button3.TabIndex = 10;
            this.button3.Text = "3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // buttonDivide
            // 
            this.buttonDivide.Enabled = false;
            this.buttonDivide.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonDivide.Location = new System.Drawing.Point(198, 246);
            this.buttonDivide.Name = "buttonDivide";
            this.buttonDivide.Size = new System.Drawing.Size(56, 51);
            this.buttonDivide.TabIndex = 11;
            this.buttonDivide.Text = "/";
            this.buttonDivide.UseVisualStyleBackColor = true;
            this.buttonDivide.Click += new System.EventHandler(this.buttonDivide_Click);
            // 
            // buttonMultiply
            // 
            this.buttonMultiply.Enabled = false;
            this.buttonMultiply.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonMultiply.Location = new System.Drawing.Point(198, 189);
            this.buttonMultiply.Name = "buttonMultiply";
            this.buttonMultiply.Size = new System.Drawing.Size(56, 51);
            this.buttonMultiply.TabIndex = 12;
            this.buttonMultiply.Text = "*";
            this.buttonMultiply.UseVisualStyleBackColor = true;
            this.buttonMultiply.Click += new System.EventHandler(this.buttonMultiply_Click);
            // 
            // buttonMinus
            // 
            this.buttonMinus.Enabled = false;
            this.buttonMinus.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonMinus.Location = new System.Drawing.Point(198, 132);
            this.buttonMinus.Name = "buttonMinus";
            this.buttonMinus.Size = new System.Drawing.Size(56, 51);
            this.buttonMinus.TabIndex = 13;
            this.buttonMinus.Text = "-";
            this.buttonMinus.UseVisualStyleBackColor = true;
            this.buttonMinus.Click += new System.EventHandler(this.buttonMinus_Click);
            // 
            // buttonPlus
            // 
            this.buttonPlus.Enabled = false;
            this.buttonPlus.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonPlus.Location = new System.Drawing.Point(198, 75);
            this.buttonPlus.Name = "buttonPlus";
            this.buttonPlus.Size = new System.Drawing.Size(56, 51);
            this.buttonPlus.TabIndex = 14;
            this.buttonPlus.Text = "+";
            this.buttonPlus.UseVisualStyleBackColor = true;
            this.buttonPlus.Click += new System.EventHandler(this.buttonPlus_Click);
            // 
            // buttonClearAll
            // 
            this.buttonClearAll.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonClearAll.Location = new System.Drawing.Point(260, 189);
            this.buttonClearAll.Name = "buttonClearAll";
            this.buttonClearAll.Size = new System.Drawing.Size(56, 108);
            this.buttonClearAll.TabIndex = 15;
            this.buttonClearAll.Text = "AC";
            this.buttonClearAll.UseVisualStyleBackColor = true;
            this.buttonClearAll.Click += new System.EventHandler(this.buttonClearAll_Click_1);
            // 
            // buttonClearScreen
            // 
            this.buttonClearScreen.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonClearScreen.Location = new System.Drawing.Point(260, 75);
            this.buttonClearScreen.Name = "buttonClearScreen";
            this.buttonClearScreen.Size = new System.Drawing.Size(56, 108);
            this.buttonClearScreen.TabIndex = 16;
            this.buttonClearScreen.Text = "C";
            this.buttonClearScreen.UseVisualStyleBackColor = true;
            this.buttonClearScreen.Click += new System.EventHandler(this.ButtonClearScreen_Click);
            // 
            // labelFractionMode
            // 
            this.labelFractionMode.AutoSize = true;
            this.labelFractionMode.Location = new System.Drawing.Point(12, 9);
            this.labelFractionMode.Name = "labelFractionMode";
            this.labelFractionMode.Size = new System.Drawing.Size(99, 15);
            this.labelFractionMode.TabIndex = 18;
            this.labelFractionMode.Text = "Numerator Mode";
            // 
            // labelFractionDisplay
            // 
            this.labelFractionDisplay.AutoSize = true;
            this.labelFractionDisplay.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelFractionDisplay.Location = new System.Drawing.Point(231, 23);
            this.labelFractionDisplay.Name = "labelFractionDisplay";
            this.labelFractionDisplay.Size = new System.Drawing.Size(23, 28);
            this.labelFractionDisplay.TabIndex = 19;
            this.labelFractionDisplay.Text = "0";
            // 
            // buttonFractionMode
            // 
            this.buttonFractionMode.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonFractionMode.Location = new System.Drawing.Point(136, 246);
            this.buttonFractionMode.Name = "buttonFractionMode";
            this.buttonFractionMode.Size = new System.Drawing.Size(56, 51);
            this.buttonFractionMode.TabIndex = 20;
            this.buttonFractionMode.Text = "START";
            this.buttonFractionMode.UseVisualStyleBackColor = true;
            this.buttonFractionMode.Click += new System.EventHandler(this.button10_Click);
            // 
            // FracCalcGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(327, 305);
            this.Controls.Add(this.buttonFractionMode);
            this.Controls.Add(this.labelFractionDisplay);
            this.Controls.Add(this.labelFractionMode);
            this.Controls.Add(this.buttonClearScreen);
            this.Controls.Add(this.buttonClearAll);
            this.Controls.Add(this.buttonPlus);
            this.Controls.Add(this.buttonMinus);
            this.Controls.Add(this.buttonMultiply);
            this.Controls.Add(this.buttonDivide);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button0);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.TextBoxDisplay);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FracCalcGUI";
            this.Text = "Fraction Calculator";
            this.Load += new System.EventHandler(this.FracCalcGUI_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox TextBoxDisplay;
        private Button button1;
        private Button button2;
        private Button button0;
        private Button button7;
        private Button button8;
        private Button button9;
        private Button button6;
        private Button button5;
        private Button button4;
        private Button button3;
        private Button buttonDivide;
        private Button buttonMultiply;
        private Button buttonMinus;
        private Button buttonPlus;
        private Button buttonClearAll;
        private Button buttonClearScreen;
        private EventHandler button17_Click;
        private EventHandler buttonClearAll_Click;
        private EventHandler button1_Click;
        private EventHandler button3_Click;
        private EventHandler button4_Click;
        private EventHandler button6_Click;
        private EventHandler button9_Click;
        private EventHandler button8_Click;
        private EventHandler button7_Click;
        private EventHandler button0_Click;
        private EventHandler button2_Click;
        private EventHandler buttonEqual_Click;
        private Label labelFractionMode;
        private Label labelFractionDisplay;
        private Button buttonFractionMode;

        public EventHandler buttonClearScreen_Click { get; private set; }
    }
}