
namespace project_calculator
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
            btnBS = new Button();
            txtresult = new TextBox();
            btnclearentry = new Button();
            btnclear = new Button();
            btnPM = new Button();
            btnplus = new Button();
            btn9 = new Button();
            btn8 = new Button();
            btn7 = new Button();
            btnminus = new Button();
            btn6 = new Button();
            btn5 = new Button();
            btn4 = new Button();
            btndivide = new Button();
            btnequal = new Button();
            btndot = new Button();
            btn0 = new Button();
            btnmultiply = new Button();
            btn3 = new Button();
            btn2 = new Button();
            btn1 = new Button();
            menuStrip1 = new MenuStrip();
            modeToolStripMenuItem = new ToolStripMenuItem();
            normalToolStripMenuItem = new ToolStripMenuItem();
            siceToolStripMenuItem = new ToolStripMenuItem();
            siceToolStripMenuItem1 = new ToolStripMenuItem();
            btnPi = new Button();
            btnLog = new Button();
            btnx2 = new Button();
            btnsqr = new Button();
            btnx3 = new Button();
            btnDec = new Button();
            btnSin = new Button();
            btnSinh = new Button();
            btnlnx = new Button();
            btnHex = new Button();
            btnTan = new Button();
            btnTanh = new Button();
            btn1x = new Button();
            btnBin = new Button();
            btnCos = new Button();
            btnCosh = new Button();
            btnpre = new Button();
            btnOct = new Button();
            btnMod = new Button();
            btnExp = new Button();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // btnBS
            // 
            btnBS.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnBS.Location = new Point(12, 106);
            btnBS.Name = "btnBS";
            btnBS.Size = new Size(85, 70);
            btnBS.TabIndex = 0;
            btnBS.Text = "⌫";
            btnBS.UseVisualStyleBackColor = true;
            btnBS.Click += btnBS_Click;
            // 
            // txtresult
            // 
            txtresult.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            txtresult.Location = new Point(12, 50);
            txtresult.Multiline = true;
            txtresult.Name = "txtresult";
            txtresult.Size = new Size(358, 50);
            txtresult.TabIndex = 1;
            txtresult.Text = "0";
            txtresult.TextAlign = HorizontalAlignment.Right;
            // 
            // btnclearentry
            // 
            btnclearentry.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnclearentry.Location = new Point(103, 106);
            btnclearentry.Name = "btnclearentry";
            btnclearentry.Size = new Size(85, 70);
            btnclearentry.TabIndex = 2;
            btnclearentry.Text = "CE";
            btnclearentry.UseVisualStyleBackColor = true;
            btnclearentry.Click += btnclearentry_Click;
            // 
            // btnclear
            // 
            btnclear.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnclear.Location = new Point(194, 106);
            btnclear.Name = "btnclear";
            btnclear.Size = new Size(85, 70);
            btnclear.TabIndex = 3;
            btnclear.Text = "C";
            btnclear.UseVisualStyleBackColor = true;
            btnclear.Click += btnclear_Click;
            // 
            // btnPM
            // 
            btnPM.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnPM.Location = new Point(285, 106);
            btnPM.Name = "btnPM";
            btnPM.Size = new Size(85, 70);
            btnPM.TabIndex = 4;
            btnPM.Text = "±";
            btnPM.UseVisualStyleBackColor = true;
            btnPM.Click += btnPM_Click;
            // 
            // btnplus
            // 
            btnplus.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnplus.Location = new Point(285, 182);
            btnplus.Name = "btnplus";
            btnplus.Size = new Size(85, 70);
            btnplus.TabIndex = 8;
            btnplus.Text = "+";
            btnplus.UseVisualStyleBackColor = true;
            btnplus.Click += NumOP;
            // 
            // btn9
            // 
            btn9.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btn9.Location = new Point(194, 182);
            btn9.Name = "btn9";
            btn9.Size = new Size(85, 70);
            btn9.TabIndex = 7;
            btn9.Text = "9";
            btn9.UseVisualStyleBackColor = true;
            btn9.Click += enternumbers;
            // 
            // btn8
            // 
            btn8.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btn8.Location = new Point(103, 182);
            btn8.Name = "btn8";
            btn8.Size = new Size(85, 70);
            btn8.TabIndex = 6;
            btn8.Text = "8";
            btn8.UseVisualStyleBackColor = true;
            btn8.Click += enternumbers;
            // 
            // btn7
            // 
            btn7.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btn7.Location = new Point(12, 182);
            btn7.Name = "btn7";
            btn7.Size = new Size(85, 70);
            btn7.TabIndex = 5;
            btn7.Text = "7";
            btn7.UseVisualStyleBackColor = true;
            btn7.Click += enternumbers;
            // 
            // btnminus
            // 
            btnminus.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnminus.Location = new Point(285, 258);
            btnminus.Name = "btnminus";
            btnminus.Size = new Size(85, 70);
            btnminus.TabIndex = 12;
            btnminus.Text = "-";
            btnminus.UseVisualStyleBackColor = true;
            btnminus.Click += NumOP;
            // 
            // btn6
            // 
            btn6.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btn6.Location = new Point(194, 258);
            btn6.Name = "btn6";
            btn6.Size = new Size(85, 70);
            btn6.TabIndex = 11;
            btn6.Text = "6";
            btn6.UseVisualStyleBackColor = true;
            btn6.Click += enternumbers;
            // 
            // btn5
            // 
            btn5.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btn5.Location = new Point(103, 258);
            btn5.Name = "btn5";
            btn5.Size = new Size(85, 70);
            btn5.TabIndex = 10;
            btn5.Text = "5";
            btn5.UseVisualStyleBackColor = true;
            btn5.Click += enternumbers;
            // 
            // btn4
            // 
            btn4.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btn4.Location = new Point(12, 258);
            btn4.Name = "btn4";
            btn4.Size = new Size(85, 70);
            btn4.TabIndex = 9;
            btn4.Text = "4";
            btn4.UseVisualStyleBackColor = true;
            btn4.Click += enternumbers;
            // 
            // btndivide
            // 
            btndivide.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btndivide.Location = new Point(285, 410);
            btndivide.Name = "btndivide";
            btndivide.Size = new Size(85, 70);
            btndivide.TabIndex = 20;
            btndivide.Text = "/";
            btndivide.UseVisualStyleBackColor = true;
            btndivide.Click += NumOP;
            // 
            // btnequal
            // 
            btnequal.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnequal.Location = new Point(194, 410);
            btnequal.Name = "btnequal";
            btnequal.Size = new Size(85, 70);
            btnequal.TabIndex = 19;
            btnequal.Text = "=";
            btnequal.UseVisualStyleBackColor = true;
            btnequal.Click += btnequal_Click;
            // 
            // btndot
            // 
            btndot.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btndot.Location = new Point(103, 410);
            btndot.Name = "btndot";
            btndot.Size = new Size(85, 70);
            btndot.TabIndex = 18;
            btndot.Text = ",";
            btndot.UseVisualStyleBackColor = true;
            btndot.Click += enternumbers;
            // 
            // btn0
            // 
            btn0.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btn0.Location = new Point(12, 410);
            btn0.Name = "btn0";
            btn0.Size = new Size(85, 70);
            btn0.TabIndex = 17;
            btn0.Text = "0";
            btn0.UseVisualStyleBackColor = true;
            btn0.Click += enternumbers;
            // 
            // btnmultiply
            // 
            btnmultiply.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnmultiply.Location = new Point(285, 334);
            btnmultiply.Name = "btnmultiply";
            btnmultiply.Size = new Size(85, 70);
            btnmultiply.TabIndex = 16;
            btnmultiply.Text = "*";
            btnmultiply.UseVisualStyleBackColor = true;
            btnmultiply.Click += NumOP;
            // 
            // btn3
            // 
            btn3.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btn3.Location = new Point(194, 334);
            btn3.Name = "btn3";
            btn3.Size = new Size(85, 70);
            btn3.TabIndex = 15;
            btn3.Text = "3";
            btn3.UseVisualStyleBackColor = true;
            btn3.Click += enternumbers;
            // 
            // btn2
            // 
            btn2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btn2.Location = new Point(103, 334);
            btn2.Name = "btn2";
            btn2.Size = new Size(85, 70);
            btn2.TabIndex = 14;
            btn2.Text = "2";
            btn2.UseVisualStyleBackColor = true;
            btn2.Click += enternumbers;
            // 
            // btn1
            // 
            btn1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btn1.Location = new Point(12, 334);
            btn1.Name = "btn1";
            btn1.Size = new Size(85, 70);
            btn1.TabIndex = 13;
            btn1.Text = "1";
            btn1.UseVisualStyleBackColor = true;
            btn1.Click += enternumbers;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { modeToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(772, 28);
            menuStrip1.TabIndex = 21;
            menuStrip1.Text = "menuStrip1";
            // 
            // modeToolStripMenuItem
            // 
            modeToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { normalToolStripMenuItem, siceToolStripMenuItem, siceToolStripMenuItem1 });
            modeToolStripMenuItem.Name = "modeToolStripMenuItem";
            modeToolStripMenuItem.Size = new Size(62, 24);
            modeToolStripMenuItem.Text = "mode";
            // 
            // normalToolStripMenuItem
            // 
            normalToolStripMenuItem.Name = "normalToolStripMenuItem";
            normalToolStripMenuItem.Size = new Size(143, 26);
            normalToolStripMenuItem.Text = "normal";
            normalToolStripMenuItem.Click += normalToolStripMenuItem_Click;
            // 
            // siceToolStripMenuItem
            // 
            siceToolStripMenuItem.Name = "siceToolStripMenuItem";
            siceToolStripMenuItem.Size = new Size(143, 26);
            siceToolStripMenuItem.Text = "sientific";
            siceToolStripMenuItem.Click += siceToolStripMenuItem_Click;
            // 
            // siceToolStripMenuItem1
            // 
            siceToolStripMenuItem1.Name = "siceToolStripMenuItem1";
            siceToolStripMenuItem1.Size = new Size(143, 26);
            siceToolStripMenuItem1.Text = "exit";
            siceToolStripMenuItem1.Click += siceToolStripMenuItem1_Click_1;
            // 
            // btnPi
            // 
            btnPi.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnPi.Location = new Point(402, 106);
            btnPi.Name = "btnPi";
            btnPi.Size = new Size(85, 70);
            btnPi.TabIndex = 22;
            btnPi.Text = "π";
            btnPi.UseVisualStyleBackColor = true;
            btnPi.Click += btnPi_Click;
            // 
            // btnLog
            // 
            btnLog.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnLog.Location = new Point(493, 106);
            btnLog.Name = "btnLog";
            btnLog.Size = new Size(85, 70);
            btnLog.TabIndex = 23;
            btnLog.Text = "Log";
            btnLog.UseVisualStyleBackColor = true;
            btnLog.Click += btnLog_Click;
            // 
            // btnx2
            // 
            btnx2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnx2.Location = new Point(675, 106);
            btnx2.Name = "btnx2";
            btnx2.Size = new Size(85, 70);
            btnx2.TabIndex = 25;
            btnx2.Text = "x²";
            btnx2.UseVisualStyleBackColor = true;
            btnx2.Click += btnx2_Click;
            // 
            // btnsqr
            // 
            btnsqr.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnsqr.Location = new Point(584, 106);
            btnsqr.Name = "btnsqr";
            btnsqr.Size = new Size(85, 70);
            btnsqr.TabIndex = 24;
            btnsqr.Text = "sqrt";
            btnsqr.UseVisualStyleBackColor = true;
            btnsqr.Click += btnsqr_Click;
            // 
            // btnx3
            // 
            btnx3.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnx3.Location = new Point(675, 182);
            btnx3.Name = "btnx3";
            btnx3.Size = new Size(85, 70);
            btnx3.TabIndex = 29;
            btnx3.Text = "x³";
            btnx3.UseVisualStyleBackColor = true;
            btnx3.Click += btnx3_Click;
            // 
            // btnDec
            // 
            btnDec.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnDec.Location = new Point(584, 182);
            btnDec.Name = "btnDec";
            btnDec.Size = new Size(85, 70);
            btnDec.TabIndex = 28;
            btnDec.Text = "Dec";
            btnDec.UseVisualStyleBackColor = true;
            btnDec.Click += btnDec_Click;
            // 
            // btnSin
            // 
            btnSin.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnSin.Location = new Point(493, 182);
            btnSin.Name = "btnSin";
            btnSin.Size = new Size(85, 70);
            btnSin.TabIndex = 27;
            btnSin.Text = "Sin";
            btnSin.UseVisualStyleBackColor = true;
            // 
            // btnSinh
            // 
            btnSinh.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnSinh.Location = new Point(402, 182);
            btnSinh.Name = "btnSinh";
            btnSinh.Size = new Size(85, 70);
            btnSinh.TabIndex = 26;
            btnSinh.Text = "Sinh";
            btnSinh.UseVisualStyleBackColor = true;
            btnSinh.Click += btnSinh_Click;
            // 
            // btnlnx
            // 
            btnlnx.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnlnx.Location = new Point(675, 334);
            btnlnx.Name = "btnlnx";
            btnlnx.Size = new Size(85, 70);
            btnlnx.TabIndex = 37;
            btnlnx.Text = "ln X";
            btnlnx.UseVisualStyleBackColor = true;
            btnlnx.Click += btnlnx_Click;
            // 
            // btnHex
            // 
            btnHex.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnHex.Location = new Point(584, 334);
            btnHex.Name = "btnHex";
            btnHex.Size = new Size(85, 70);
            btnHex.TabIndex = 36;
            btnHex.Text = "Hex";
            btnHex.UseVisualStyleBackColor = true;
            btnHex.Click += btnHex_Click;
            // 
            // btnTan
            // 
            btnTan.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnTan.Location = new Point(493, 334);
            btnTan.Name = "btnTan";
            btnTan.Size = new Size(85, 70);
            btnTan.TabIndex = 35;
            btnTan.Text = "Tan";
            btnTan.UseVisualStyleBackColor = true;
            btnTan.Click += btnTan_Click;
            // 
            // btnTanh
            // 
            btnTanh.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnTanh.Location = new Point(402, 334);
            btnTanh.Name = "btnTanh";
            btnTanh.Size = new Size(85, 70);
            btnTanh.TabIndex = 34;
            btnTanh.Text = "Tanh";
            btnTanh.UseVisualStyleBackColor = true;
            btnTanh.Click += btnTanh_Click;
            // 
            // btn1x
            // 
            btn1x.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btn1x.Location = new Point(675, 258);
            btn1x.Name = "btn1x";
            btn1x.Size = new Size(85, 70);
            btn1x.TabIndex = 33;
            btn1x.Text = "1/x";
            btn1x.UseVisualStyleBackColor = true;
            btn1x.Click += btn1x_Click;
            // 
            // btnBin
            // 
            btnBin.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnBin.Location = new Point(584, 258);
            btnBin.Name = "btnBin";
            btnBin.Size = new Size(85, 70);
            btnBin.TabIndex = 32;
            btnBin.Text = "Bin";
            btnBin.UseVisualStyleBackColor = true;
            btnBin.Click += btnBin_Click;
            // 
            // btnCos
            // 
            btnCos.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnCos.Location = new Point(493, 258);
            btnCos.Name = "btnCos";
            btnCos.Size = new Size(85, 70);
            btnCos.TabIndex = 31;
            btnCos.Text = "Cos";
            btnCos.UseVisualStyleBackColor = true;
            btnCos.Click += btnCos_Click;
            // 
            // btnCosh
            // 
            btnCosh.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnCosh.Location = new Point(402, 258);
            btnCosh.Name = "btnCosh";
            btnCosh.Size = new Size(85, 70);
            btnCosh.TabIndex = 30;
            btnCosh.Text = "Cosh";
            btnCosh.UseVisualStyleBackColor = true;
            btnCosh.Click += btnCosh_Click;
            // 
            // btnpre
            // 
            btnpre.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnpre.Location = new Point(675, 410);
            btnpre.Name = "btnpre";
            btnpre.Size = new Size(85, 70);
            btnpre.TabIndex = 41;
            btnpre.Text = "%";
            btnpre.UseVisualStyleBackColor = true;
            btnpre.Click += btnpre_Click;
            // 
            // btnOct
            // 
            btnOct.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnOct.Location = new Point(584, 410);
            btnOct.Name = "btnOct";
            btnOct.Size = new Size(85, 70);
            btnOct.TabIndex = 40;
            btnOct.Text = "Oct";
            btnOct.UseVisualStyleBackColor = true;
            btnOct.Click += btnOct_Click;
            // 
            // btnMod
            // 
            btnMod.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnMod.Location = new Point(493, 410);
            btnMod.Name = "btnMod";
            btnMod.Size = new Size(85, 70);
            btnMod.TabIndex = 39;
            btnMod.Text = "Mod";
            btnMod.UseVisualStyleBackColor = true;
            btnMod.Click += NumOP;
            // 
            // btnExp
            // 
            btnExp.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnExp.Location = new Point(402, 410);
            btnExp.Name = "btnExp";
            btnExp.Size = new Size(85, 70);
            btnExp.TabIndex = 38;
            btnExp.Text = "Exp";
            btnExp.UseVisualStyleBackColor = true;
            btnExp.Click += NumOP;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(772, 493);
            Controls.Add(btnpre);
            Controls.Add(btnOct);
            Controls.Add(btnMod);
            Controls.Add(btnExp);
            Controls.Add(btnlnx);
            Controls.Add(btnHex);
            Controls.Add(btnTan);
            Controls.Add(btnTanh);
            Controls.Add(btn1x);
            Controls.Add(btnBin);
            Controls.Add(btnCos);
            Controls.Add(btnCosh);
            Controls.Add(btnx3);
            Controls.Add(btnDec);
            Controls.Add(btnSin);
            Controls.Add(btnSinh);
            Controls.Add(btnx2);
            Controls.Add(btnsqr);
            Controls.Add(btnLog);
            Controls.Add(btnPi);
            Controls.Add(btndivide);
            Controls.Add(btnequal);
            Controls.Add(btndot);
            Controls.Add(btn0);
            Controls.Add(btnmultiply);
            Controls.Add(btn3);
            Controls.Add(btn2);
            Controls.Add(btn1);
            Controls.Add(btnminus);
            Controls.Add(btn6);
            Controls.Add(btn5);
            Controls.Add(btn4);
            Controls.Add(btnplus);
            Controls.Add(btn9);
            Controls.Add(btn8);
            Controls.Add(btn7);
            Controls.Add(btnPM);
            Controls.Add(btnclear);
            Controls.Add(btnclearentry);
            Controls.Add(txtresult);
            Controls.Add(btnBS);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "sientific calculator";
            Load += Form1_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }


        #endregion

        private Button btnBS;
        private TextBox txtresult;
        private Button btnclearentry;
        private Button btnclear;
        private Button btnPM;
        private Button btnplus;
        private Button btn9;
        private Button btn8;
        private Button btn7;
        private Button btnminus;
        private Button btn6;
        private Button btn5;
        private Button btn4;
        private Button btndivide;
        private Button btnequal;
        private Button btndot;
        private Button btn0;
        private Button btnmultiply;
        private Button btn3;
        private Button btn2;
        private Button btn1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem modeToolStripMenuItem;
        private ToolStripMenuItem normalToolStripMenuItem;
        private ToolStripMenuItem siceToolStripMenuItem;
        private ToolStripMenuItem siceToolStripMenuItem1;
        private Button btnPi;
        private Button btnLog;
        private Button btnx2;
        private Button btnsqr;
        private Button btnx3;
        private Button btnDec;
        private Button btnSin;
        private Button btnSinh;
        private Button btnlnx;
        private Button btnHex;
        private Button btnTan;
        private Button btnTanh;
        private Button btn1x;
        private Button btnBin;
        private Button btnCos;
        private Button btnCosh;
        private Button btnpre;
        private Button btnOct;
        private Button btnMod;
        private Button btnExp;
    }
}
