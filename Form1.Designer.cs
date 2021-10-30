
namespace Calculator
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btn_plus = new System.Windows.Forms.Button();
            this.btn_minus = new System.Windows.Forms.Button();
            this.btn_multi = new System.Windows.Forms.Button();
            this.btn_divide = new System.Windows.Forms.Button();
            this.btnEQ = new System.Windows.Forms.Button();
            this.btn_dot = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.btnC = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnPM = new System.Windows.Forms.Button();
            this.btnSin = new System.Windows.Forms.Button();
            this.btnCos = new System.Windows.Forms.Button();
            this.btnTan = new System.Windows.Forms.Button();
            this.btnNf = new System.Windows.Forms.Button();
            this.btnSqu = new System.Windows.Forms.Button();
            this.btnY = new System.Windows.Forms.Button();
            this.btnExp = new System.Windows.Forms.Button();
            this.btnLog = new System.Windows.Forms.Button();
            this.btnLn = new System.Windows.Forms.Button();
            this.btnSqrt = new System.Windows.Forms.Button();
            this.btnSinh = new System.Windows.Forms.Button();
            this.btnCosh = new System.Windows.Forms.Button();
            this.btnTanh = new System.Windows.Forms.Button();
            this.btnPi = new System.Windows.Forms.Button();
            this.btnYroot = new System.Windows.Forms.Button();
            this.btnMp = new System.Windows.Forms.Button();
            this.btnMn = new System.Windows.Forms.Button();
            this.btnMC = new System.Windows.Forms.Button();
            this.btnMR = new System.Windows.Forms.Button();
            this.btnMS = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rbGRAD = new System.Windows.Forms.RadioButton();
            this.rbRAD = new System.Windows.Forms.RadioButton();
            this.rbDEG = new System.Windows.Forms.RadioButton();
            this.btnDown = new System.Windows.Forms.Button();
            this.btnMOD = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Consolas", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(808, 70);
            this.label1.TabIndex = 0;
            this.label1.Text = "0";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btn1
            // 
            this.btn1.Font = new System.Drawing.Font("新細明體", 19F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn1.Location = new System.Drawing.Point(16, 193);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(53, 42);
            this.btn1.TabIndex = 1;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.show_num);
            // 
            // btn2
            // 
            this.btn2.Font = new System.Drawing.Font("新細明體", 19F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn2.Location = new System.Drawing.Point(93, 193);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(53, 42);
            this.btn2.TabIndex = 2;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.show_num);
            // 
            // btn3
            // 
            this.btn3.Font = new System.Drawing.Font("新細明體", 19F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn3.Location = new System.Drawing.Point(171, 193);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(53, 42);
            this.btn3.TabIndex = 3;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.show_num);
            // 
            // btn4
            // 
            this.btn4.Font = new System.Drawing.Font("新細明體", 19F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn4.Location = new System.Drawing.Point(16, 136);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(53, 42);
            this.btn4.TabIndex = 4;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = true;
            this.btn4.Click += new System.EventHandler(this.show_num);
            // 
            // btn5
            // 
            this.btn5.Font = new System.Drawing.Font("新細明體", 19F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn5.Location = new System.Drawing.Point(93, 134);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(53, 42);
            this.btn5.TabIndex = 5;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = true;
            this.btn5.Click += new System.EventHandler(this.show_num);
            // 
            // btn6
            // 
            this.btn6.Font = new System.Drawing.Font("新細明體", 19F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn6.Location = new System.Drawing.Point(171, 134);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(53, 42);
            this.btn6.TabIndex = 6;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = true;
            this.btn6.Click += new System.EventHandler(this.show_num);
            // 
            // btn7
            // 
            this.btn7.Font = new System.Drawing.Font("新細明體", 19F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn7.Location = new System.Drawing.Point(16, 86);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(53, 42);
            this.btn7.TabIndex = 7;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = true;
            this.btn7.Click += new System.EventHandler(this.show_num);
            // 
            // btn8
            // 
            this.btn8.Font = new System.Drawing.Font("新細明體", 19F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn8.Location = new System.Drawing.Point(93, 86);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(53, 42);
            this.btn8.TabIndex = 8;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = true;
            this.btn8.Click += new System.EventHandler(this.show_num);
            // 
            // btn9
            // 
            this.btn9.Font = new System.Drawing.Font("新細明體", 19F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn9.Location = new System.Drawing.Point(171, 86);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(53, 42);
            this.btn9.TabIndex = 9;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = true;
            this.btn9.Click += new System.EventHandler(this.show_num);
            // 
            // btn_plus
            // 
            this.btn_plus.Font = new System.Drawing.Font("新細明體", 19F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_plus.Location = new System.Drawing.Point(247, 193);
            this.btn_plus.Name = "btn_plus";
            this.btn_plus.Size = new System.Drawing.Size(53, 42);
            this.btn_plus.TabIndex = 10;
            this.btn_plus.Text = "+";
            this.btn_plus.UseVisualStyleBackColor = true;
            this.btn_plus.Click += new System.EventHandler(this.operational_function);
            // 
            // btn_minus
            // 
            this.btn_minus.Font = new System.Drawing.Font("新細明體", 19F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_minus.Location = new System.Drawing.Point(247, 134);
            this.btn_minus.Name = "btn_minus";
            this.btn_minus.Size = new System.Drawing.Size(53, 42);
            this.btn_minus.TabIndex = 11;
            this.btn_minus.Text = "-";
            this.btn_minus.UseVisualStyleBackColor = true;
            this.btn_minus.Click += new System.EventHandler(this.operational_function);
            // 
            // btn_multi
            // 
            this.btn_multi.Font = new System.Drawing.Font("新細明體", 19F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_multi.Location = new System.Drawing.Point(247, 86);
            this.btn_multi.Name = "btn_multi";
            this.btn_multi.Size = new System.Drawing.Size(53, 42);
            this.btn_multi.TabIndex = 12;
            this.btn_multi.Text = "*";
            this.btn_multi.UseVisualStyleBackColor = true;
            this.btn_multi.Click += new System.EventHandler(this.operational_function);
            // 
            // btn_divide
            // 
            this.btn_divide.Font = new System.Drawing.Font("新細明體", 19F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_divide.Location = new System.Drawing.Point(247, 29);
            this.btn_divide.Name = "btn_divide";
            this.btn_divide.Size = new System.Drawing.Size(53, 42);
            this.btn_divide.TabIndex = 13;
            this.btn_divide.Text = "/";
            this.btn_divide.UseVisualStyleBackColor = true;
            this.btn_divide.Click += new System.EventHandler(this.operational_function);
            // 
            // btnEQ
            // 
            this.btnEQ.Font = new System.Drawing.Font("新細明體", 19F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnEQ.Location = new System.Drawing.Point(247, 241);
            this.btnEQ.Name = "btnEQ";
            this.btnEQ.Size = new System.Drawing.Size(53, 42);
            this.btnEQ.TabIndex = 14;
            this.btnEQ.Text = "=";
            this.btnEQ.UseVisualStyleBackColor = true;
            this.btnEQ.Click += new System.EventHandler(this.btnEQ_click);
            // 
            // btn_dot
            // 
            this.btn_dot.Font = new System.Drawing.Font("新細明體", 19F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_dot.Location = new System.Drawing.Point(171, 241);
            this.btn_dot.Name = "btn_dot";
            this.btn_dot.Size = new System.Drawing.Size(53, 42);
            this.btn_dot.TabIndex = 15;
            this.btn_dot.Text = ".";
            this.btn_dot.UseVisualStyleBackColor = true;
            this.btn_dot.Click += new System.EventHandler(this.show_num);
            // 
            // btn0
            // 
            this.btn0.Font = new System.Drawing.Font("新細明體", 19F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn0.Location = new System.Drawing.Point(16, 241);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(130, 42);
            this.btn0.TabIndex = 16;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = true;
            this.btn0.Click += new System.EventHandler(this.show_num);
            // 
            // btnC
            // 
            this.btnC.Font = new System.Drawing.Font("新細明體", 19F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnC.Location = new System.Drawing.Point(93, 29);
            this.btnC.Name = "btnC";
            this.btnC.Size = new System.Drawing.Size(53, 42);
            this.btnC.TabIndex = 18;
            this.btnC.Text = "C";
            this.btnC.UseVisualStyleBackColor = true;
            this.btnC.Click += new System.EventHandler(this.btnC_click);
            // 
            // btnDel
            // 
            this.btnDel.BackgroundImage = global::Calculator.Properties.Resources.刪除;
            this.btnDel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDel.Font = new System.Drawing.Font("新細明體", 19F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnDel.Location = new System.Drawing.Point(16, 29);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(53, 42);
            this.btnDel.TabIndex = 19;
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_click);
            // 
            // btnPM
            // 
            this.btnPM.Font = new System.Drawing.Font("新細明體", 19F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnPM.Location = new System.Drawing.Point(171, 29);
            this.btnPM.Name = "btnPM";
            this.btnPM.Size = new System.Drawing.Size(53, 42);
            this.btnPM.TabIndex = 20;
            this.btnPM.Text = "±";
            this.btnPM.UseVisualStyleBackColor = true;
            this.btnPM.Click += new System.EventHandler(this.btnPM_click);
            // 
            // btnSin
            // 
            this.btnSin.Font = new System.Drawing.Font("新細明體", 19F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnSin.Location = new System.Drawing.Point(206, 6);
            this.btnSin.Name = "btnSin";
            this.btnSin.Size = new System.Drawing.Size(53, 42);
            this.btnSin.TabIndex = 21;
            this.btnSin.Text = "sin";
            this.btnSin.UseVisualStyleBackColor = true;
            this.btnSin.Click += new System.EventHandler(this.special_function);
            // 
            // btnCos
            // 
            this.btnCos.Font = new System.Drawing.Font("新細明體", 19F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnCos.Location = new System.Drawing.Point(275, 6);
            this.btnCos.Name = "btnCos";
            this.btnCos.Size = new System.Drawing.Size(53, 42);
            this.btnCos.TabIndex = 22;
            this.btnCos.Text = "cos";
            this.btnCos.UseVisualStyleBackColor = true;
            this.btnCos.Click += new System.EventHandler(this.special_function);
            // 
            // btnTan
            // 
            this.btnTan.Font = new System.Drawing.Font("新細明體", 19F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnTan.Location = new System.Drawing.Point(346, 6);
            this.btnTan.Name = "btnTan";
            this.btnTan.Size = new System.Drawing.Size(53, 42);
            this.btnTan.TabIndex = 23;
            this.btnTan.Text = "tan";
            this.btnTan.UseVisualStyleBackColor = true;
            this.btnTan.Click += new System.EventHandler(this.special_function);
            // 
            // btnNf
            // 
            this.btnNf.Font = new System.Drawing.Font("新細明體", 19F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnNf.Location = new System.Drawing.Point(346, 54);
            this.btnNf.Name = "btnNf";
            this.btnNf.Size = new System.Drawing.Size(53, 42);
            this.btnNf.TabIndex = 24;
            this.btnNf.Text = "n!";
            this.btnNf.UseVisualStyleBackColor = true;
            this.btnNf.Click += new System.EventHandler(this.special_function);
            // 
            // btnSqu
            // 
            this.btnSqu.Font = new System.Drawing.Font("新細明體", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnSqu.Location = new System.Drawing.Point(206, 102);
            this.btnSqu.Name = "btnSqu";
            this.btnSqu.Size = new System.Drawing.Size(53, 42);
            this.btnSqu.TabIndex = 25;
            this.btnSqu.Text = "x^2";
            this.btnSqu.UseVisualStyleBackColor = true;
            this.btnSqu.Click += new System.EventHandler(this.special_function);
            // 
            // btnY
            // 
            this.btnY.Font = new System.Drawing.Font("新細明體", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnY.Location = new System.Drawing.Point(275, 102);
            this.btnY.Name = "btnY";
            this.btnY.Size = new System.Drawing.Size(53, 42);
            this.btnY.TabIndex = 26;
            this.btnY.Text = "x^y";
            this.btnY.UseVisualStyleBackColor = true;
            this.btnY.Click += new System.EventHandler(this.operational_function);
            // 
            // btnExp
            // 
            this.btnExp.Font = new System.Drawing.Font("新細明體", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnExp.Location = new System.Drawing.Point(62, 51);
            this.btnExp.Name = "btnExp";
            this.btnExp.Size = new System.Drawing.Size(53, 42);
            this.btnExp.TabIndex = 27;
            this.btnExp.Text = "Exp";
            this.btnExp.UseVisualStyleBackColor = true;
            this.btnExp.Click += new System.EventHandler(this.special_function);
            // 
            // btnLog
            // 
            this.btnLog.Font = new System.Drawing.Font("新細明體", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnLog.Location = new System.Drawing.Point(135, 54);
            this.btnLog.Name = "btnLog";
            this.btnLog.Size = new System.Drawing.Size(53, 42);
            this.btnLog.TabIndex = 28;
            this.btnLog.Text = "log";
            this.btnLog.UseVisualStyleBackColor = true;
            this.btnLog.Click += new System.EventHandler(this.special_function);
            // 
            // btnLn
            // 
            this.btnLn.Font = new System.Drawing.Font("新細明體", 19F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnLn.Location = new System.Drawing.Point(0, 52);
            this.btnLn.Name = "btnLn";
            this.btnLn.Size = new System.Drawing.Size(53, 42);
            this.btnLn.TabIndex = 29;
            this.btnLn.Text = "ln";
            this.btnLn.UseVisualStyleBackColor = true;
            this.btnLn.Click += new System.EventHandler(this.special_function);
            // 
            // btnSqrt
            // 
            this.btnSqrt.Font = new System.Drawing.Font("新細明體", 19F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnSqrt.Location = new System.Drawing.Point(62, 102);
            this.btnSqrt.Name = "btnSqrt";
            this.btnSqrt.Size = new System.Drawing.Size(53, 42);
            this.btnSqrt.TabIndex = 30;
            this.btnSqrt.Text = "√";
            this.btnSqrt.UseVisualStyleBackColor = true;
            this.btnSqrt.Click += new System.EventHandler(this.special_function);
            // 
            // btnSinh
            // 
            this.btnSinh.Font = new System.Drawing.Font("新細明體", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnSinh.Location = new System.Drawing.Point(0, 6);
            this.btnSinh.Name = "btnSinh";
            this.btnSinh.Size = new System.Drawing.Size(53, 42);
            this.btnSinh.TabIndex = 31;
            this.btnSinh.Text = "sinh";
            this.btnSinh.UseVisualStyleBackColor = true;
            this.btnSinh.Click += new System.EventHandler(this.special_function);
            // 
            // btnCosh
            // 
            this.btnCosh.Font = new System.Drawing.Font("新細明體", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnCosh.Location = new System.Drawing.Point(59, 6);
            this.btnCosh.Name = "btnCosh";
            this.btnCosh.Size = new System.Drawing.Size(53, 42);
            this.btnCosh.TabIndex = 32;
            this.btnCosh.Text = "cosh";
            this.btnCosh.UseVisualStyleBackColor = true;
            this.btnCosh.Click += new System.EventHandler(this.special_function);
            // 
            // btnTanh
            // 
            this.btnTanh.Font = new System.Drawing.Font("新細明體", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnTanh.Location = new System.Drawing.Point(135, 6);
            this.btnTanh.Name = "btnTanh";
            this.btnTanh.Size = new System.Drawing.Size(55, 42);
            this.btnTanh.TabIndex = 33;
            this.btnTanh.Text = "tanh";
            this.btnTanh.UseVisualStyleBackColor = true;
            this.btnTanh.Click += new System.EventHandler(this.special_function);
            // 
            // btnPi
            // 
            this.btnPi.Font = new System.Drawing.Font("新細明體", 19F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnPi.Location = new System.Drawing.Point(346, 102);
            this.btnPi.Name = "btnPi";
            this.btnPi.Size = new System.Drawing.Size(53, 42);
            this.btnPi.TabIndex = 34;
            this.btnPi.Text = "π";
            this.btnPi.UseVisualStyleBackColor = true;
            this.btnPi.Click += new System.EventHandler(this.show_num);
            // 
            // btnYroot
            // 
            this.btnYroot.Font = new System.Drawing.Font("新細明體", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnYroot.Location = new System.Drawing.Point(137, 102);
            this.btnYroot.Name = "btnYroot";
            this.btnYroot.Size = new System.Drawing.Size(53, 42);
            this.btnYroot.TabIndex = 35;
            this.btnYroot.Text = "y√";
            this.btnYroot.UseVisualStyleBackColor = true;
            this.btnYroot.Click += new System.EventHandler(this.operational_function);
            // 
            // btnMp
            // 
            this.btnMp.Font = new System.Drawing.Font("新細明體", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnMp.Location = new System.Drawing.Point(12, 3);
            this.btnMp.Name = "btnMp";
            this.btnMp.Size = new System.Drawing.Size(53, 42);
            this.btnMp.TabIndex = 36;
            this.btnMp.Text = "M+";
            this.btnMp.UseVisualStyleBackColor = true;
            this.btnMp.Click += new System.EventHandler(this.btnMs_click);
            // 
            // btnMn
            // 
            this.btnMn.Font = new System.Drawing.Font("新細明體", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnMn.Location = new System.Drawing.Point(88, 3);
            this.btnMn.Name = "btnMn";
            this.btnMn.Size = new System.Drawing.Size(53, 42);
            this.btnMn.TabIndex = 37;
            this.btnMn.Text = "M-";
            this.btnMn.UseVisualStyleBackColor = true;
            this.btnMn.Click += new System.EventHandler(this.btnMs_click);
            // 
            // btnMC
            // 
            this.btnMC.Font = new System.Drawing.Font("新細明體", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnMC.Location = new System.Drawing.Point(159, 3);
            this.btnMC.Name = "btnMC";
            this.btnMC.Size = new System.Drawing.Size(53, 42);
            this.btnMC.TabIndex = 38;
            this.btnMC.Text = "MC";
            this.btnMC.UseVisualStyleBackColor = true;
            this.btnMC.Click += new System.EventHandler(this.btnMs_click);
            // 
            // btnMR
            // 
            this.btnMR.Font = new System.Drawing.Font("新細明體", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnMR.Location = new System.Drawing.Point(228, 3);
            this.btnMR.Name = "btnMR";
            this.btnMR.Size = new System.Drawing.Size(53, 42);
            this.btnMR.TabIndex = 39;
            this.btnMR.Text = "MR";
            this.btnMR.UseVisualStyleBackColor = true;
            this.btnMR.Click += new System.EventHandler(this.btnMs_click);
            // 
            // btnMS
            // 
            this.btnMS.Font = new System.Drawing.Font("新細明體", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnMS.Location = new System.Drawing.Point(299, 3);
            this.btnMS.Name = "btnMS";
            this.btnMS.Size = new System.Drawing.Size(53, 42);
            this.btnMS.TabIndex = 40;
            this.btnMS.Text = "MS";
            this.btnMS.UseVisualStyleBackColor = true;
            this.btnMS.Click += new System.EventHandler(this.btnMs_click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.MenuBar;
            this.panel1.Controls.Add(this.rbGRAD);
            this.panel1.Controls.Add(this.rbRAD);
            this.panel1.Controls.Add(this.rbDEG);
            this.panel1.Location = new System.Drawing.Point(10, 83);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(252, 32);
            this.panel1.TabIndex = 41;
            // 
            // rbGRAD
            // 
            this.rbGRAD.AutoSize = true;
            this.rbGRAD.Font = new System.Drawing.Font("Gill Sans MT", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.rbGRAD.Location = new System.Drawing.Point(163, 3);
            this.rbGRAD.Name = "rbGRAD";
            this.rbGRAD.Size = new System.Drawing.Size(73, 22);
            this.rbGRAD.TabIndex = 2;
            this.rbGRAD.Text = "GRAD";
            this.rbGRAD.UseVisualStyleBackColor = true;
            // 
            // rbRAD
            // 
            this.rbRAD.AutoSize = true;
            this.rbRAD.Font = new System.Drawing.Font("Gill Sans MT", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.rbRAD.Location = new System.Drawing.Point(85, 3);
            this.rbRAD.Name = "rbRAD";
            this.rbRAD.Size = new System.Drawing.Size(61, 22);
            this.rbRAD.TabIndex = 1;
            this.rbRAD.Text = "RAD";
            this.rbRAD.UseVisualStyleBackColor = true;
            // 
            // rbDEG
            // 
            this.rbDEG.AutoSize = true;
            this.rbDEG.Checked = true;
            this.rbDEG.Font = new System.Drawing.Font("Gill Sans MT", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.rbDEG.Location = new System.Drawing.Point(5, 3);
            this.rbDEG.Name = "rbDEG";
            this.rbDEG.Size = new System.Drawing.Size(60, 22);
            this.rbDEG.TabIndex = 0;
            this.rbDEG.TabStop = true;
            this.rbDEG.Text = "DEG";
            this.rbDEG.UseVisualStyleBackColor = true;
            // 
            // btnDown
            // 
            this.btnDown.Font = new System.Drawing.Font("新細明體", 19F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnDown.Location = new System.Drawing.Point(275, 54);
            this.btnDown.Name = "btnDown";
            this.btnDown.Size = new System.Drawing.Size(53, 42);
            this.btnDown.TabIndex = 42;
            this.btnDown.Text = "1/x";
            this.btnDown.UseVisualStyleBackColor = true;
            this.btnDown.Click += new System.EventHandler(this.special_function);
            // 
            // btnMOD
            // 
            this.btnMOD.Font = new System.Drawing.Font("新細明體", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnMOD.Location = new System.Drawing.Point(206, 54);
            this.btnMOD.Name = "btnMOD";
            this.btnMOD.Size = new System.Drawing.Size(53, 42);
            this.btnMOD.TabIndex = 43;
            this.btnMOD.Text = "Mod";
            this.btnMOD.UseVisualStyleBackColor = true;
            this.btnMOD.Click += new System.EventHandler(this.operational_function);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnPM);
            this.panel2.Controls.Add(this.btn_divide);
            this.panel2.Controls.Add(this.btn_multi);
            this.panel2.Controls.Add(this.btn_minus);
            this.panel2.Controls.Add(this.btn_plus);
            this.panel2.Controls.Add(this.btn1);
            this.panel2.Controls.Add(this.btn2);
            this.panel2.Controls.Add(this.btn3);
            this.panel2.Controls.Add(this.btn4);
            this.panel2.Controls.Add(this.btn5);
            this.panel2.Controls.Add(this.btn6);
            this.panel2.Controls.Add(this.btn7);
            this.panel2.Controls.Add(this.btn8);
            this.panel2.Controls.Add(this.btn9);
            this.panel2.Controls.Add(this.btnC);
            this.panel2.Controls.Add(this.btnDel);
            this.panel2.Controls.Add(this.btn0);
            this.panel2.Controls.Add(this.btn_dot);
            this.panel2.Controls.Add(this.btnEQ);
            this.panel2.Location = new System.Drawing.Point(458, 146);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(312, 292);
            this.panel2.TabIndex = 44;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnMS);
            this.panel3.Controls.Add(this.btnMp);
            this.panel3.Controls.Add(this.btnMR);
            this.panel3.Controls.Add(this.btnMn);
            this.panel3.Controls.Add(this.btnMC);
            this.panel3.Location = new System.Drawing.Point(408, 83);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(362, 56);
            this.panel3.TabIndex = 45;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnSinh);
            this.panel4.Controls.Add(this.btnCosh);
            this.panel4.Controls.Add(this.btnTanh);
            this.panel4.Controls.Add(this.btnDown);
            this.panel4.Controls.Add(this.btnPi);
            this.panel4.Controls.Add(this.btnYroot);
            this.panel4.Controls.Add(this.btnSqrt);
            this.panel4.Controls.Add(this.btnMOD);
            this.panel4.Controls.Add(this.btnY);
            this.panel4.Controls.Add(this.btnSin);
            this.panel4.Controls.Add(this.btnSqu);
            this.panel4.Controls.Add(this.btnCos);
            this.panel4.Controls.Add(this.btnNf);
            this.panel4.Controls.Add(this.btnTan);
            this.panel4.Controls.Add(this.btnLn);
            this.panel4.Controls.Add(this.btnExp);
            this.panel4.Controls.Add(this.btnLog);
            this.panel4.Location = new System.Drawing.Point(15, 146);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(411, 152);
            this.panel4.TabIndex = 46;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 450);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "計算機";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btn_plus;
        private System.Windows.Forms.Button btn_minus;
        private System.Windows.Forms.Button btn_multi;
        private System.Windows.Forms.Button btn_divide;
        private System.Windows.Forms.Button btnEQ;
        private System.Windows.Forms.Button btn_dot;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.Button btnC;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnPM;
        private System.Windows.Forms.Button btnSin;
        private System.Windows.Forms.Button btnCos;
        private System.Windows.Forms.Button btnTan;
        private System.Windows.Forms.Button btnNf;
        private System.Windows.Forms.Button btnSqu;
        private System.Windows.Forms.Button btnY;
        private System.Windows.Forms.Button btnExp;
        private System.Windows.Forms.Button btnLog;
        private System.Windows.Forms.Button btnLn;
        private System.Windows.Forms.Button btnSqrt;
        private System.Windows.Forms.Button btnSinh;
        private System.Windows.Forms.Button btnCosh;
        private System.Windows.Forms.Button btnTanh;
        private System.Windows.Forms.Button btnPi;
        private System.Windows.Forms.Button btnYroot;
        private System.Windows.Forms.Button btnMp;
        private System.Windows.Forms.Button btnMn;
        private System.Windows.Forms.Button btnMC;
        private System.Windows.Forms.Button btnMR;
        private System.Windows.Forms.Button btnMS;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rbGRAD;
        private System.Windows.Forms.RadioButton rbRAD;
        private System.Windows.Forms.RadioButton rbDEG;
        private System.Windows.Forms.Button btnDown;
        private System.Windows.Forms.Button btnMOD;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
    }
}

