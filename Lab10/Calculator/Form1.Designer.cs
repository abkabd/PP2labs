namespace Calculator
{
    partial class CalculatorForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CalculatorForm));
            this.Screen = new System.Windows.Forms.TextBox();
            this.label = new System.Windows.Forms.Label();
            this.btnEquals = new Calculator.RoundedButton();
            this.btn0 = new Calculator.RoundedButton();
            this.btnDot = new Calculator.RoundButton();
            this.btn3 = new Calculator.RoundButton();
            this.btnSubtract = new Calculator.RoundButton();
            this.btnMemRecall = new Calculator.RoundButton();
            this.btnAdd = new Calculator.RoundButton();
            this.btnDiv = new Calculator.RoundButton();
            this.btnMult = new Calculator.RoundButton();
            this.btnMemStoreClear = new Calculator.RoundButton();
            this.btn6 = new Calculator.RoundButton();
            this.btn9 = new Calculator.RoundButton();
            this.btn2 = new Calculator.RoundButton();
            this.btnMemSubtract = new Calculator.RoundButton();
            this.btn5 = new Calculator.RoundButton();
            this.btnReciprocal = new Calculator.RoundButton();
            this.btn8 = new Calculator.RoundButton();
            this.btnClear = new Calculator.RoundButton();
            this.btn1 = new Calculator.RoundButton();
            this.btnSquare = new Calculator.RoundButton();
            this.btnMemAdd = new Calculator.RoundButton();
            this.btnPlusMinus = new Calculator.RoundButton();
            this.btnSqrt = new Calculator.RoundButton();
            this.btn4 = new Calculator.RoundButton();
            this.btn7 = new Calculator.RoundButton();
            this.roundedButton1 = new Calculator.RoundedButton();
            this.labelMemory = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Screen
            // 
            this.Screen.BackColor = System.Drawing.Color.Black;
            this.Screen.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Screen.Font = new System.Drawing.Font("Cambria", 19.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Screen.ForeColor = System.Drawing.Color.Transparent;
            this.Screen.Location = new System.Drawing.Point(10, 65);
            this.Screen.Multiline = true;
            this.Screen.Name = "Screen";
            this.Screen.ReadOnly = true;
            this.Screen.Size = new System.Drawing.Size(342, 56);
            this.Screen.TabIndex = 4;
            this.Screen.Text = "012345678912345678";
            this.Screen.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label.Location = new System.Drawing.Point(12, 37);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(53, 25);
            this.label.TabIndex = 5;
            this.label.Text = "label";
            // 
            // btnEquals
            // 
            this.btnEquals.BackColor = System.Drawing.Color.Gold;
            this.btnEquals.FlatAppearance.BorderSize = 0;
            this.btnEquals.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Yellow;
            this.btnEquals.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEquals.Font = new System.Drawing.Font("Cambria", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(204)));
            this.btnEquals.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnEquals.Location = new System.Drawing.Point(220, 430);
            this.btnEquals.Margin = new System.Windows.Forms.Padding(5);
            this.btnEquals.Name = "btnEquals";
            this.btnEquals.Size = new System.Drawing.Size(60, 60);
            this.btnEquals.TabIndex = 2;
            this.btnEquals.Text = "=";
            this.btnEquals.UseVisualStyleBackColor = false;
            this.btnEquals.Click += new System.EventHandler(this.Click);
            // 
            // btn0
            // 
            this.btn0.BackColor = System.Drawing.Color.DimGray;
            this.btn0.FlatAppearance.BorderSize = 0;
            this.btn0.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btn0.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn0.Font = new System.Drawing.Font("Cambria", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(204)));
            this.btn0.ForeColor = System.Drawing.Color.White;
            this.btn0.Location = new System.Drawing.Point(150, 430);
            this.btn0.Margin = new System.Windows.Forms.Padding(5);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(60, 60);
            this.btn0.TabIndex = 2;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = false;
            this.btn0.Click += new System.EventHandler(this.Click);
            // 
            // btnDot
            // 
            this.btnDot.BackColor = System.Drawing.Color.DimGray;
            this.btnDot.FlatAppearance.BorderSize = 0;
            this.btnDot.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnDot.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDot.Font = new System.Drawing.Font("Cambria", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(204)));
            this.btnDot.ForeColor = System.Drawing.Color.White;
            this.btnDot.Location = new System.Drawing.Point(80, 430);
            this.btnDot.Margin = new System.Windows.Forms.Padding(5);
            this.btnDot.Name = "btnDot";
            this.btnDot.Size = new System.Drawing.Size(60, 60);
            this.btnDot.TabIndex = 1;
            this.btnDot.Text = ",";
            this.btnDot.UseVisualStyleBackColor = false;
            this.btnDot.Click += new System.EventHandler(this.Click);
            // 
            // btn3
            // 
            this.btn3.BackColor = System.Drawing.Color.DimGray;
            this.btn3.FlatAppearance.BorderSize = 0;
            this.btn3.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btn3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn3.Font = new System.Drawing.Font("Cambria", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(204)));
            this.btn3.ForeColor = System.Drawing.Color.White;
            this.btn3.Location = new System.Drawing.Point(220, 360);
            this.btn3.Margin = new System.Windows.Forms.Padding(5);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(60, 60);
            this.btn3.TabIndex = 1;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = false;
            this.btn3.Click += new System.EventHandler(this.Click);
            // 
            // btnSubtract
            // 
            this.btnSubtract.BackColor = System.Drawing.Color.LightSalmon;
            this.btnSubtract.FlatAppearance.BorderSize = 0;
            this.btnSubtract.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Salmon;
            this.btnSubtract.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubtract.Font = new System.Drawing.Font("Cambria", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(204)));
            this.btnSubtract.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSubtract.Location = new System.Drawing.Point(290, 360);
            this.btnSubtract.Margin = new System.Windows.Forms.Padding(5);
            this.btnSubtract.Name = "btnSubtract";
            this.btnSubtract.Size = new System.Drawing.Size(60, 60);
            this.btnSubtract.TabIndex = 1;
            this.btnSubtract.Text = "-";
            this.btnSubtract.UseVisualStyleBackColor = false;
            this.btnSubtract.Click += new System.EventHandler(this.Click);
            // 
            // btnMemRecall
            // 
            this.btnMemRecall.BackColor = System.Drawing.Color.OliveDrab;
            this.btnMemRecall.FlatAppearance.BorderSize = 0;
            this.btnMemRecall.FlatAppearance.MouseOverBackColor = System.Drawing.Color.YellowGreen;
            this.btnMemRecall.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMemRecall.Font = new System.Drawing.Font("Cambria", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(204)));
            this.btnMemRecall.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnMemRecall.Location = new System.Drawing.Point(220, 150);
            this.btnMemRecall.Margin = new System.Windows.Forms.Padding(5);
            this.btnMemRecall.Name = "btnMemRecall";
            this.btnMemRecall.Size = new System.Drawing.Size(60, 60);
            this.btnMemRecall.TabIndex = 1;
            this.btnMemRecall.Text = "MR";
            this.btnMemRecall.UseVisualStyleBackColor = false;
            this.btnMemRecall.Click += new System.EventHandler(this.Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.LightSalmon;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Salmon;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Cambria", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(204)));
            this.btnAdd.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAdd.Location = new System.Drawing.Point(290, 430);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(5);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(60, 60);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "+";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.Click);
            // 
            // btnDiv
            // 
            this.btnDiv.BackColor = System.Drawing.Color.LightSalmon;
            this.btnDiv.FlatAppearance.BorderSize = 0;
            this.btnDiv.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Salmon;
            this.btnDiv.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDiv.Font = new System.Drawing.Font("Cambria", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(204)));
            this.btnDiv.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnDiv.Location = new System.Drawing.Point(290, 220);
            this.btnDiv.Margin = new System.Windows.Forms.Padding(5);
            this.btnDiv.Name = "btnDiv";
            this.btnDiv.Size = new System.Drawing.Size(60, 60);
            this.btnDiv.TabIndex = 1;
            this.btnDiv.Text = "÷";
            this.btnDiv.UseVisualStyleBackColor = false;
            this.btnDiv.Click += new System.EventHandler(this.Click);
            // 
            // btnMult
            // 
            this.btnMult.BackColor = System.Drawing.Color.LightSalmon;
            this.btnMult.FlatAppearance.BorderSize = 0;
            this.btnMult.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Salmon;
            this.btnMult.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMult.Font = new System.Drawing.Font("Cambria", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(204)));
            this.btnMult.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnMult.Location = new System.Drawing.Point(290, 290);
            this.btnMult.Margin = new System.Windows.Forms.Padding(5);
            this.btnMult.Name = "btnMult";
            this.btnMult.Size = new System.Drawing.Size(60, 60);
            this.btnMult.TabIndex = 1;
            this.btnMult.Text = "×";
            this.btnMult.UseVisualStyleBackColor = false;
            this.btnMult.Click += new System.EventHandler(this.Click);
            // 
            // btnMemStoreClear
            // 
            this.btnMemStoreClear.BackColor = System.Drawing.Color.OliveDrab;
            this.btnMemStoreClear.FlatAppearance.BorderSize = 0;
            this.btnMemStoreClear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.YellowGreen;
            this.btnMemStoreClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMemStoreClear.Font = new System.Drawing.Font("Cambria", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(204)));
            this.btnMemStoreClear.Location = new System.Drawing.Point(290, 150);
            this.btnMemStoreClear.Margin = new System.Windows.Forms.Padding(5);
            this.btnMemStoreClear.Name = "btnMemStoreClear";
            this.btnMemStoreClear.Size = new System.Drawing.Size(60, 60);
            this.btnMemStoreClear.TabIndex = 1;
            this.btnMemStoreClear.Text = "MS";
            this.btnMemStoreClear.UseVisualStyleBackColor = false;
            this.btnMemStoreClear.Click += new System.EventHandler(this.Click);
            // 
            // btn6
            // 
            this.btn6.BackColor = System.Drawing.Color.DimGray;
            this.btn6.FlatAppearance.BorderSize = 0;
            this.btn6.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btn6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn6.Font = new System.Drawing.Font("Cambria", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(204)));
            this.btn6.ForeColor = System.Drawing.Color.White;
            this.btn6.Location = new System.Drawing.Point(220, 290);
            this.btn6.Margin = new System.Windows.Forms.Padding(5);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(60, 60);
            this.btn6.TabIndex = 1;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = false;
            this.btn6.Click += new System.EventHandler(this.Click);
            // 
            // btn9
            // 
            this.btn9.BackColor = System.Drawing.Color.DimGray;
            this.btn9.FlatAppearance.BorderSize = 0;
            this.btn9.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btn9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn9.Font = new System.Drawing.Font("Cambria", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(204)));
            this.btn9.ForeColor = System.Drawing.Color.White;
            this.btn9.Location = new System.Drawing.Point(220, 220);
            this.btn9.Margin = new System.Windows.Forms.Padding(5);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(60, 60);
            this.btn9.TabIndex = 1;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = false;
            this.btn9.Click += new System.EventHandler(this.Click);
            // 
            // btn2
            // 
            this.btn2.BackColor = System.Drawing.Color.DimGray;
            this.btn2.FlatAppearance.BorderSize = 0;
            this.btn2.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btn2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn2.Font = new System.Drawing.Font("Cambria", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(204)));
            this.btn2.ForeColor = System.Drawing.Color.White;
            this.btn2.Location = new System.Drawing.Point(150, 360);
            this.btn2.Margin = new System.Windows.Forms.Padding(5);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(60, 60);
            this.btn2.TabIndex = 1;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = false;
            this.btn2.Click += new System.EventHandler(this.Click);
            // 
            // btnMemSubtract
            // 
            this.btnMemSubtract.BackColor = System.Drawing.Color.OliveDrab;
            this.btnMemSubtract.FlatAppearance.BorderSize = 0;
            this.btnMemSubtract.FlatAppearance.MouseOverBackColor = System.Drawing.Color.YellowGreen;
            this.btnMemSubtract.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMemSubtract.Font = new System.Drawing.Font("Cambria", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(204)));
            this.btnMemSubtract.Location = new System.Drawing.Point(150, 150);
            this.btnMemSubtract.Margin = new System.Windows.Forms.Padding(5);
            this.btnMemSubtract.Name = "btnMemSubtract";
            this.btnMemSubtract.Size = new System.Drawing.Size(60, 60);
            this.btnMemSubtract.TabIndex = 1;
            this.btnMemSubtract.Text = "M-";
            this.btnMemSubtract.UseVisualStyleBackColor = false;
            this.btnMemSubtract.Click += new System.EventHandler(this.Click);
            // 
            // btn5
            // 
            this.btn5.BackColor = System.Drawing.Color.DimGray;
            this.btn5.FlatAppearance.BorderSize = 0;
            this.btn5.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btn5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn5.Font = new System.Drawing.Font("Cambria", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(204)));
            this.btn5.ForeColor = System.Drawing.Color.White;
            this.btn5.Location = new System.Drawing.Point(150, 290);
            this.btn5.Margin = new System.Windows.Forms.Padding(5);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(60, 60);
            this.btn5.TabIndex = 1;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = false;
            this.btn5.Click += new System.EventHandler(this.Click);
            // 
            // btnReciprocal
            // 
            this.btnReciprocal.BackColor = System.Drawing.Color.LightSalmon;
            this.btnReciprocal.FlatAppearance.BorderSize = 0;
            this.btnReciprocal.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Salmon;
            this.btnReciprocal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReciprocal.Font = new System.Drawing.Font("Cambria", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(204)));
            this.btnReciprocal.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnReciprocal.Location = new System.Drawing.Point(10, 360);
            this.btnReciprocal.Margin = new System.Windows.Forms.Padding(5);
            this.btnReciprocal.Name = "btnReciprocal";
            this.btnReciprocal.Size = new System.Drawing.Size(60, 60);
            this.btnReciprocal.TabIndex = 1;
            this.btnReciprocal.Text = "1/x";
            this.btnReciprocal.UseVisualStyleBackColor = false;
            this.btnReciprocal.Click += new System.EventHandler(this.Click);
            // 
            // btn8
            // 
            this.btn8.BackColor = System.Drawing.Color.DimGray;
            this.btn8.FlatAppearance.BorderSize = 0;
            this.btn8.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btn8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn8.Font = new System.Drawing.Font("Cambria", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(204)));
            this.btn8.ForeColor = System.Drawing.Color.White;
            this.btn8.Location = new System.Drawing.Point(150, 220);
            this.btn8.Margin = new System.Windows.Forms.Padding(5);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(60, 60);
            this.btn8.TabIndex = 1;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = false;
            this.btn8.Click += new System.EventHandler(this.Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.OliveDrab;
            this.btnClear.FlatAppearance.BorderSize = 0;
            this.btnClear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.YellowGreen;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Cambria", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(204)));
            this.btnClear.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnClear.Location = new System.Drawing.Point(10, 150);
            this.btnClear.Margin = new System.Windows.Forms.Padding(5);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(60, 60);
            this.btnClear.TabIndex = 1;
            this.btnClear.Text = "C";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.Click);
            // 
            // btn1
            // 
            this.btn1.BackColor = System.Drawing.Color.DimGray;
            this.btn1.FlatAppearance.BorderSize = 0;
            this.btn1.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btn1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn1.Font = new System.Drawing.Font("Cambria", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(204)));
            this.btn1.ForeColor = System.Drawing.Color.White;
            this.btn1.Location = new System.Drawing.Point(80, 360);
            this.btn1.Margin = new System.Windows.Forms.Padding(5);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(60, 60);
            this.btn1.TabIndex = 1;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = false;
            this.btn1.Click += new System.EventHandler(this.Click);
            // 
            // btnSquare
            // 
            this.btnSquare.BackColor = System.Drawing.Color.LightSalmon;
            this.btnSquare.FlatAppearance.BorderSize = 0;
            this.btnSquare.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Salmon;
            this.btnSquare.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSquare.Font = new System.Drawing.Font("Cambria", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(204)));
            this.btnSquare.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSquare.Location = new System.Drawing.Point(10, 290);
            this.btnSquare.Margin = new System.Windows.Forms.Padding(5);
            this.btnSquare.Name = "btnSquare";
            this.btnSquare.Size = new System.Drawing.Size(60, 60);
            this.btnSquare.TabIndex = 1;
            this.btnSquare.Text = "χ²";
            this.btnSquare.UseVisualStyleBackColor = false;
            this.btnSquare.Click += new System.EventHandler(this.Click);
            // 
            // btnMemAdd
            // 
            this.btnMemAdd.BackColor = System.Drawing.Color.OliveDrab;
            this.btnMemAdd.FlatAppearance.BorderSize = 0;
            this.btnMemAdd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.YellowGreen;
            this.btnMemAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMemAdd.Font = new System.Drawing.Font("Cambria", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(204)));
            this.btnMemAdd.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnMemAdd.Location = new System.Drawing.Point(80, 150);
            this.btnMemAdd.Margin = new System.Windows.Forms.Padding(5);
            this.btnMemAdd.Name = "btnMemAdd";
            this.btnMemAdd.Size = new System.Drawing.Size(60, 60);
            this.btnMemAdd.TabIndex = 1;
            this.btnMemAdd.Text = "M+";
            this.btnMemAdd.UseVisualStyleBackColor = false;
            this.btnMemAdd.Click += new System.EventHandler(this.Click);
            // 
            // btnPlusMinus
            // 
            this.btnPlusMinus.BackColor = System.Drawing.Color.LightSalmon;
            this.btnPlusMinus.FlatAppearance.BorderSize = 0;
            this.btnPlusMinus.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Salmon;
            this.btnPlusMinus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlusMinus.Font = new System.Drawing.Font("Cambria", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(204)));
            this.btnPlusMinus.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnPlusMinus.Location = new System.Drawing.Point(10, 430);
            this.btnPlusMinus.Margin = new System.Windows.Forms.Padding(5);
            this.btnPlusMinus.Name = "btnPlusMinus";
            this.btnPlusMinus.Size = new System.Drawing.Size(60, 60);
            this.btnPlusMinus.TabIndex = 1;
            this.btnPlusMinus.Text = "±";
            this.btnPlusMinus.UseVisualStyleBackColor = false;
            this.btnPlusMinus.Click += new System.EventHandler(this.Click);
            // 
            // btnSqrt
            // 
            this.btnSqrt.BackColor = System.Drawing.Color.LightSalmon;
            this.btnSqrt.FlatAppearance.BorderSize = 0;
            this.btnSqrt.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Salmon;
            this.btnSqrt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSqrt.Font = new System.Drawing.Font("Cambria", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(204)));
            this.btnSqrt.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSqrt.Location = new System.Drawing.Point(10, 220);
            this.btnSqrt.Margin = new System.Windows.Forms.Padding(5);
            this.btnSqrt.Name = "btnSqrt";
            this.btnSqrt.Size = new System.Drawing.Size(60, 60);
            this.btnSqrt.TabIndex = 1;
            this.btnSqrt.Text = "√";
            this.btnSqrt.UseVisualStyleBackColor = false;
            this.btnSqrt.Click += new System.EventHandler(this.Click);
            // 
            // btn4
            // 
            this.btn4.BackColor = System.Drawing.Color.DimGray;
            this.btn4.FlatAppearance.BorderSize = 0;
            this.btn4.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btn4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn4.Font = new System.Drawing.Font("Cambria", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(204)));
            this.btn4.ForeColor = System.Drawing.Color.White;
            this.btn4.Location = new System.Drawing.Point(80, 290);
            this.btn4.Margin = new System.Windows.Forms.Padding(5);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(60, 60);
            this.btn4.TabIndex = 1;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = false;
            this.btn4.Click += new System.EventHandler(this.Click);
            // 
            // btn7
            // 
            this.btn7.BackColor = System.Drawing.Color.DimGray;
            this.btn7.FlatAppearance.BorderSize = 0;
            this.btn7.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btn7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn7.Font = new System.Drawing.Font("Cambria", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(204)));
            this.btn7.ForeColor = System.Drawing.Color.White;
            this.btn7.Location = new System.Drawing.Point(80, 220);
            this.btn7.Margin = new System.Windows.Forms.Padding(5);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(60, 60);
            this.btn7.TabIndex = 1;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = false;
            this.btn7.Click += new System.EventHandler(this.Click);
            // 
            // roundedButton1
            // 
            this.roundedButton1.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonShadow;
            this.roundedButton1.Font = new System.Drawing.Font("Cambria", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(204)));
            this.roundedButton1.Location = new System.Drawing.Point(21, 391);
            this.roundedButton1.Name = "roundedButton1";
            this.roundedButton1.Size = new System.Drawing.Size(106, 60);
            this.roundedButton1.TabIndex = 1;
            this.roundedButton1.Text = "roundedButton1";
            this.roundedButton1.UseVisualStyleBackColor = true;
            this.roundedButton1.Click += new System.EventHandler(this.Click);
            // 
            // labelMemory
            // 
            this.labelMemory.AutoSize = true;
            this.labelMemory.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.labelMemory.Location = new System.Drawing.Point(12, 111);
            this.labelMemory.Name = "labelMemory";
            this.labelMemory.Size = new System.Drawing.Size(53, 25);
            this.labelMemory.TabIndex = 5;
            this.labelMemory.Text = "label";
            // 
            // CalculatorForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(362, 507);
            this.Controls.Add(this.labelMemory);
            this.Controls.Add(this.label);
            this.Controls.Add(this.Screen);
            this.Controls.Add(this.btnEquals);
            this.Controls.Add(this.btn0);
            this.Controls.Add(this.btnDot);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btnSubtract);
            this.Controls.Add(this.btnMemRecall);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnDiv);
            this.Controls.Add(this.btnMult);
            this.Controls.Add(this.btnMemStoreClear);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.btn9);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btnMemSubtract);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btnReciprocal);
            this.Controls.Add(this.btn8);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.btnSquare);
            this.Controls.Add(this.btnMemAdd);
            this.Controls.Add(this.btnPlusMinus);
            this.Controls.Add(this.btnSqrt);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btn7);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "CalculatorForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MyCalculator";
            this.TransparencyKey = System.Drawing.Color.Maroon;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private RoundedButton roundedButton1;
        private System.Windows.Forms.TextBox Screen;
        private RoundButton btnSqrt;
        private RoundButton btnPlusMinus;
        private RoundButton btnMemAdd;
        private RoundButton btnSquare;
        private RoundButton btnClear;
        private RoundButton btnReciprocal;
        private RoundButton btnMemSubtract;
        private RoundButton btnMemStoreClear;
        private RoundButton btnMult;
        private RoundButton btnDiv;
        private RoundButton btnAdd;
        private RoundButton btnMemRecall;
        private RoundButton btnSubtract;
        private RoundButton btn7;
        private RoundButton btn8;
        private RoundButton btn9;
        private RoundButton btn6;
        private RoundButton btn5;
        private RoundButton btn4;
        private RoundButton btn1;
        private RoundButton btn2;
        private RoundButton btn3;
        private RoundedButton btnEquals;
        private RoundedButton btn0;
        private RoundButton btnDot;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label labelMemory;
    }
}

