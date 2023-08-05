namespace Nahom_s_App
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            first_tab = new TabPage();
            btnEqual = new Button();
            button8 = new Button();
            textBox1 = new TextBox();
            DarkMode = new CheckBox();
            Scientific = new RadioButton();
            radioButton1 = new RadioButton();
            btnClear = new Button();
            btnSub = new Button();
            btnPlus = new Button();
            btnRoot = new Button();
            btnMod = new Button();
            btnMul = new Button();
            btnDiv = new Button();
            btn9 = new Button();
            btn8 = new Button();
            btn7 = new Button();
            btn6 = new Button();
            btn5 = new Button();
            btn4 = new Button();
            btnPoint = new Button();
            btn0 = new Button();
            btn3 = new Button();
            btn2 = new Button();
            btn1 = new Button();
            tab1 = new TabControl();
            second_tab = new TabPage();
            pictureBox2 = new PictureBox();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            first_tab.SuspendLayout();
            tab1.SuspendLayout();
            second_tab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // first_tab
            // 
            first_tab.BackColor = Color.White;
            first_tab.Controls.Add(btnEqual);
            first_tab.Controls.Add(button8);
            first_tab.Controls.Add(textBox1);
            first_tab.Controls.Add(DarkMode);
            first_tab.Controls.Add(Scientific);
            first_tab.Controls.Add(radioButton1);
            first_tab.Controls.Add(btnClear);
            first_tab.Controls.Add(btnSub);
            first_tab.Controls.Add(btnPlus);
            first_tab.Controls.Add(btnRoot);
            first_tab.Controls.Add(btnMod);
            first_tab.Controls.Add(btnMul);
            first_tab.Controls.Add(btnDiv);
            first_tab.Controls.Add(btn9);
            first_tab.Controls.Add(btn8);
            first_tab.Controls.Add(btn7);
            first_tab.Controls.Add(btn6);
            first_tab.Controls.Add(btn5);
            first_tab.Controls.Add(btn4);
            first_tab.Controls.Add(btnPoint);
            first_tab.Controls.Add(btn0);
            first_tab.Controls.Add(btn3);
            first_tab.Controls.Add(btn2);
            first_tab.Controls.Add(btn1);
            first_tab.Cursor = Cursors.Hand;
            first_tab.Location = new Point(4, 34);
            first_tab.Name = "first_tab";
            first_tab.Padding = new Padding(3);
            first_tab.Size = new Size(597, 593);
            first_tab.TabIndex = 0;
            first_tab.Text = "Calculator";
            first_tab.Click += first_tab_Click;
            // 
            // btnEqual
            // 
            btnEqual.BackColor = Color.PaleGreen;
            btnEqual.Font = new Font("Bernard MT Condensed", 21F, FontStyle.Bold, GraphicsUnit.Point);
            btnEqual.Location = new Point(492, 300);
            btnEqual.Name = "btnEqual";
            btnEqual.Size = new Size(79, 279);
            btnEqual.TabIndex = 48;
            btnEqual.Text = "=";
            btnEqual.UseVisualStyleBackColor = false;
            btnEqual.Click += btnEqual_Click;
            // 
            // button8
            // 
            button8.BackColor = Color.Black;
            button8.Font = new Font("Bernard MT Condensed", 21F, FontStyle.Regular, GraphicsUnit.Point);
            button8.ForeColor = Color.White;
            button8.Location = new Point(193, 488);
            button8.Name = "button8";
            button8.Size = new Size(80, 88);
            button8.TabIndex = 45;
            button8.Text = "π";
            button8.UseVisualStyleBackColor = false;
            button8.Click += button8_Click_1;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Bernard MT Condensed", 21F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(21, 17);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(550, 97);
            textBox1.TabIndex = 24;
            textBox1.TextAlign = HorizontalAlignment.Right;
            // 
            // DarkMode
            // 
            DarkMode.AutoSize = true;
            DarkMode.Location = new Point(338, 155);
            DarkMode.Name = "DarkMode";
            DarkMode.Size = new Size(127, 29);
            DarkMode.TabIndex = 27;
            DarkMode.Text = "&Dark Mode";
            DarkMode.UseVisualStyleBackColor = true;
            DarkMode.CheckedChanged += DarkMode_CheckedChanged_1;
            // 
            // Scientific
            // 
            Scientific.AutoSize = true;
            Scientific.Location = new Point(183, 153);
            Scientific.Name = "Scientific";
            Scientific.Size = new Size(106, 29);
            Scientific.TabIndex = 26;
            Scientific.Text = "Scie&ntific";
            Scientific.UseVisualStyleBackColor = true;
            Scientific.CheckedChanged += Scientific_CheckedChanged;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Checked = true;
            radioButton1.Location = new Point(21, 153);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(108, 29);
            radioButton1.TabIndex = 25;
            radioButton1.TabStop = true;
            radioButton1.Text = "&Standard";
            radioButton1.UseVisualStyleBackColor = true;
            radioButton1.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.SkyBlue;
            btnClear.Font = new Font("Bernard MT Condensed", 21F, FontStyle.Regular, GraphicsUnit.Point);
            btnClear.Location = new Point(318, 207);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(251, 88);
            btnClear.TabIndex = 31;
            btnClear.Text = "&Clear";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click_1;
            // 
            // btnSub
            // 
            btnSub.BackColor = Color.Gold;
            btnSub.Font = new Font("Bernard MT Condensed", 20F, FontStyle.Regular, GraphicsUnit.Point);
            btnSub.ForeColor = SystemColors.ActiveCaptionText;
            btnSub.Location = new Point(406, 300);
            btnSub.Name = "btnSub";
            btnSub.Size = new Size(80, 88);
            btnSub.TabIndex = 36;
            btnSub.Text = "−";
            btnSub.UseVisualStyleBackColor = false;
            btnSub.Click += btnSub_Click_1;
            // 
            // btnPlus
            // 
            btnPlus.BackColor = Color.Gold;
            btnPlus.Font = new Font("Bernard MT Condensed", 16F, FontStyle.Regular, GraphicsUnit.Point);
            btnPlus.ForeColor = SystemColors.ActiveCaptionText;
            btnPlus.Location = new Point(318, 300);
            btnPlus.Name = "btnPlus";
            btnPlus.Size = new Size(80, 88);
            btnPlus.TabIndex = 35;
            btnPlus.Text = "+";
            btnPlus.UseVisualStyleBackColor = false;
            btnPlus.Click += btnPlus_Click_1;
            // 
            // btnRoot
            // 
            btnRoot.BackColor = Color.YellowGreen;
            btnRoot.Font = new Font("Bernard MT Condensed", 21F, FontStyle.Bold, GraphicsUnit.Point);
            btnRoot.ForeColor = Color.Black;
            btnRoot.Location = new Point(406, 488);
            btnRoot.Name = "btnRoot";
            btnRoot.Size = new Size(80, 88);
            btnRoot.TabIndex = 47;
            btnRoot.Text = "√";
            btnRoot.UseVisualStyleBackColor = false;
            btnRoot.Click += btnRoot_Click_1;
            // 
            // btnMod
            // 
            btnMod.BackColor = Color.YellowGreen;
            btnMod.Font = new Font("Bernard MT Condensed", 17F, FontStyle.Regular, GraphicsUnit.Point);
            btnMod.ForeColor = Color.Black;
            btnMod.Location = new Point(318, 488);
            btnMod.Name = "btnMod";
            btnMod.Size = new Size(80, 88);
            btnMod.TabIndex = 46;
            btnMod.Text = "Mod";
            btnMod.UseVisualStyleBackColor = false;
            btnMod.Click += btnMod_Click_1;
            // 
            // btnMul
            // 
            btnMul.BackColor = Color.Gold;
            btnMul.Font = new Font("Bernard MT Condensed", 15F, FontStyle.Regular, GraphicsUnit.Point);
            btnMul.ForeColor = SystemColors.ActiveCaptionText;
            btnMul.Location = new Point(406, 393);
            btnMul.Name = "btnMul";
            btnMul.Size = new Size(80, 88);
            btnMul.TabIndex = 42;
            btnMul.Text = "x";
            btnMul.UseVisualStyleBackColor = false;
            btnMul.Click += btnMul_Click_1;
            // 
            // btnDiv
            // 
            btnDiv.BackColor = Color.Gold;
            btnDiv.Font = new Font("Bernard MT Condensed", 14F, FontStyle.Regular, GraphicsUnit.Point);
            btnDiv.ForeColor = SystemColors.ActiveCaptionText;
            btnDiv.Location = new Point(318, 393);
            btnDiv.Name = "btnDiv";
            btnDiv.Size = new Size(80, 88);
            btnDiv.TabIndex = 41;
            btnDiv.Text = "/";
            btnDiv.UseVisualStyleBackColor = false;
            btnDiv.Click += btnDiv_Click_1;
            // 
            // btn9
            // 
            btn9.BackColor = SystemColors.ActiveCaptionText;
            btn9.Font = new Font("Bernard MT Condensed", 21F, FontStyle.Regular, GraphicsUnit.Point);
            btn9.ForeColor = SystemColors.ButtonFace;
            btn9.Location = new Point(193, 207);
            btn9.Name = "btn9";
            btn9.Size = new Size(80, 88);
            btn9.TabIndex = 30;
            btn9.Text = "9";
            btn9.UseVisualStyleBackColor = false;
            btn9.Click += btn9_Click_1;
            // 
            // btn8
            // 
            btn8.BackColor = SystemColors.ActiveCaptionText;
            btn8.Font = new Font("Bernard MT Condensed", 21F, FontStyle.Regular, GraphicsUnit.Point);
            btn8.ForeColor = SystemColors.ButtonFace;
            btn8.Location = new Point(107, 207);
            btn8.Name = "btn8";
            btn8.Size = new Size(80, 88);
            btn8.TabIndex = 29;
            btn8.Text = "8";
            btn8.UseVisualStyleBackColor = false;
            btn8.Click += btn8_Click_1;
            // 
            // btn7
            // 
            btn7.BackColor = SystemColors.ActiveCaptionText;
            btn7.Font = new Font("Bernard MT Condensed", 21F, FontStyle.Regular, GraphicsUnit.Point);
            btn7.ForeColor = SystemColors.ButtonFace;
            btn7.Location = new Point(21, 207);
            btn7.Name = "btn7";
            btn7.Size = new Size(80, 88);
            btn7.TabIndex = 28;
            btn7.Text = "7";
            btn7.UseVisualStyleBackColor = false;
            btn7.Click += btn7_Click_1;
            // 
            // btn6
            // 
            btn6.BackColor = SystemColors.ActiveCaptionText;
            btn6.Font = new Font("Bernard MT Condensed", 21F, FontStyle.Regular, GraphicsUnit.Point);
            btn6.ForeColor = SystemColors.ButtonFace;
            btn6.Location = new Point(193, 300);
            btn6.Name = "btn6";
            btn6.Size = new Size(80, 88);
            btn6.TabIndex = 34;
            btn6.Text = "6";
            btn6.UseVisualStyleBackColor = false;
            btn6.Click += btn6_Click_1;
            // 
            // btn5
            // 
            btn5.BackColor = SystemColors.ActiveCaptionText;
            btn5.Font = new Font("Bernard MT Condensed", 21F, FontStyle.Regular, GraphicsUnit.Point);
            btn5.ForeColor = SystemColors.ButtonFace;
            btn5.Location = new Point(107, 300);
            btn5.Name = "btn5";
            btn5.Size = new Size(80, 88);
            btn5.TabIndex = 33;
            btn5.Text = "5";
            btn5.UseVisualStyleBackColor = false;
            btn5.Click += btn5_Click_1;
            // 
            // btn4
            // 
            btn4.BackColor = SystemColors.ActiveCaptionText;
            btn4.Font = new Font("Bernard MT Condensed", 21F, FontStyle.Regular, GraphicsUnit.Point);
            btn4.ForeColor = SystemColors.ButtonFace;
            btn4.Location = new Point(21, 300);
            btn4.Name = "btn4";
            btn4.Size = new Size(80, 88);
            btn4.TabIndex = 32;
            btn4.Text = "4";
            btn4.UseVisualStyleBackColor = false;
            btn4.Click += btn4_Click_1;
            // 
            // btnPoint
            // 
            btnPoint.BackColor = SystemColors.ActiveCaptionText;
            btnPoint.Font = new Font("Bernard MT Condensed", 21F, FontStyle.Regular, GraphicsUnit.Point);
            btnPoint.ForeColor = SystemColors.ButtonFace;
            btnPoint.Location = new Point(107, 488);
            btnPoint.Name = "btnPoint";
            btnPoint.Size = new Size(80, 88);
            btnPoint.TabIndex = 44;
            btnPoint.Text = ".";
            btnPoint.UseVisualStyleBackColor = false;
            btnPoint.Click += btnPoint_Click_1;
            // 
            // btn0
            // 
            btn0.BackColor = SystemColors.ActiveCaptionText;
            btn0.Font = new Font("Bernard MT Condensed", 21F, FontStyle.Regular, GraphicsUnit.Point);
            btn0.ForeColor = SystemColors.ButtonFace;
            btn0.Location = new Point(21, 488);
            btn0.Name = "btn0";
            btn0.Size = new Size(80, 88);
            btn0.TabIndex = 43;
            btn0.Text = "0";
            btn0.UseVisualStyleBackColor = false;
            btn0.Click += btn0_Click_1;
            // 
            // btn3
            // 
            btn3.BackColor = SystemColors.ActiveCaptionText;
            btn3.Font = new Font("Bernard MT Condensed", 21F, FontStyle.Regular, GraphicsUnit.Point);
            btn3.ForeColor = SystemColors.ButtonFace;
            btn3.Location = new Point(193, 393);
            btn3.Name = "btn3";
            btn3.Size = new Size(80, 88);
            btn3.TabIndex = 40;
            btn3.Text = "3";
            btn3.UseVisualStyleBackColor = false;
            btn3.Click += btn3_Click_1;
            // 
            // btn2
            // 
            btn2.BackColor = SystemColors.ActiveCaptionText;
            btn2.Font = new Font("Bernard MT Condensed", 21F, FontStyle.Regular, GraphicsUnit.Point);
            btn2.ForeColor = SystemColors.ButtonFace;
            btn2.Location = new Point(107, 393);
            btn2.Name = "btn2";
            btn2.Size = new Size(80, 88);
            btn2.TabIndex = 39;
            btn2.Text = "2";
            btn2.UseVisualStyleBackColor = false;
            btn2.Click += btn2_Click_1;
            // 
            // btn1
            // 
            btn1.BackColor = SystemColors.ActiveCaptionText;
            btn1.Font = new Font("Bernard MT Condensed", 21F, FontStyle.Regular, GraphicsUnit.Point);
            btn1.ForeColor = SystemColors.ButtonFace;
            btn1.Location = new Point(21, 393);
            btn1.Name = "btn1";
            btn1.Size = new Size(80, 88);
            btn1.TabIndex = 38;
            btn1.Text = "1";
            btn1.UseVisualStyleBackColor = false;
            btn1.Click += btn1_Click_1;
            // 
            // tab1
            // 
            tab1.Controls.Add(first_tab);
            tab1.Controls.Add(second_tab);
            tab1.Location = new Point(0, 0);
            tab1.Name = "tab1";
            tab1.SelectedIndex = 0;
            tab1.Size = new Size(605, 631);
            tab1.TabIndex = 0;
            // 
            // second_tab
            // 
            second_tab.Controls.Add(pictureBox2);
            second_tab.Controls.Add(label1);
            second_tab.Controls.Add(pictureBox1);
            second_tab.Location = new Point(4, 34);
            second_tab.Name = "second_tab";
            second_tab.Padding = new Padding(3);
            second_tab.Size = new Size(597, 593);
            second_tab.TabIndex = 1;
            second_tab.Text = "About me";
            second_tab.UseVisualStyleBackColor = true;
            second_tab.Click += second_tab_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.c521b2661c88b5302934b7a31a8a5e36_prev_ui;
            pictureBox2.Location = new Point(311, 158);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(354, 534);
            pictureBox2.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Constantia", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(-4, 175);
            label1.Name = "label1";
            label1.Size = new Size(321, 132);
            label1.TabIndex = 1;
            label1.Text = resources.GetString("label1.Text");
            label1.Click += label1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.cent;
            pictureBox1.Location = new Point(-14, -67);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(615, 286);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(602, 625);
            Controls.Add(tab1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form1";
            Text = "Nahom's Calculator";
            TransparencyKey = Color.Fuchsia;
            Load += Form1_Load;
            first_tab.ResumeLayout(false);
            first_tab.PerformLayout();
            tab1.ResumeLayout(false);
            second_tab.ResumeLayout(false);
            second_tab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private TabPage first_tab;
        private Button button8;
        private TextBox textBox1;
        private CheckBox DarkMode;
        private RadioButton Scientific;
        private RadioButton radioButton1;
        private Button btnClear;
        private Button btnSub;
        private Button btnPlus;
        private Button btnRoot;
        private Button btnMod;
        private Button btnMul;
        private Button btnDiv;
        private Button btn9;
        private Button btn8;
        private Button btn7;
        private Button btn6;
        private Button btn5;
        private Button btn4;
        private Button btnPoint;
        private Button btn0;
        private Button btn3;
        private Button btn2;
        private Button btn1;
        private TabControl tab1;
        private Button btnEqual;
        private TabPage second_tab;
        private Label label1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
    }
}