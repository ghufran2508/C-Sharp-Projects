namespace MyCalculator
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
            this.txtPrmry = new System.Windows.Forms.TextBox();
            this.txtScndry = new System.Windows.Forms.TextBox();
            this.btnErase = new System.Windows.Forms.Button();
            this.btnMultiply = new System.Windows.Forms.Button();
            this.btnDivide = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.btnDot = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.btnpm = new System.Windows.Forms.Button();
            this.btnMinus = new System.Windows.Forms.Button();
            this.btnEqual = new System.Windows.Forms.Button();
            this.btnClr = new System.Windows.Forms.Button();
            this.btnPlus = new System.Windows.Forms.Button();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportAProblemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lightModeOnOffToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.historyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearHistoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtPrmry
            // 
            this.txtPrmry.BackColor = System.Drawing.Color.LightBlue;
            this.txtPrmry.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPrmry.Font = new System.Drawing.Font("Poor Richard", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrmry.ForeColor = System.Drawing.SystemColors.InfoText;
            this.txtPrmry.Location = new System.Drawing.Point(12, 50);
            this.txtPrmry.MaxLength = 20;
            this.txtPrmry.Multiline = true;
            this.txtPrmry.Name = "txtPrmry";
            this.txtPrmry.ReadOnly = true;
            this.txtPrmry.Size = new System.Drawing.Size(256, 25);
            this.txtPrmry.TabIndex = 100;
            this.txtPrmry.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtScndry
            // 
            this.txtScndry.BackColor = System.Drawing.Color.LightBlue;
            this.txtScndry.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtScndry.Font = new System.Drawing.Font("Poor Richard", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtScndry.ForeColor = System.Drawing.SystemColors.InfoText;
            this.txtScndry.Location = new System.Drawing.Point(12, 72);
            this.txtScndry.MaxLength = 20;
            this.txtScndry.Multiline = true;
            this.txtScndry.Name = "txtScndry";
            this.txtScndry.ReadOnly = true;
            this.txtScndry.Size = new System.Drawing.Size(256, 25);
            this.txtScndry.TabIndex = 99;
            this.txtScndry.Text = "0";
            this.txtScndry.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnErase
            // 
            this.btnErase.BackColor = System.Drawing.Color.Red;
            this.btnErase.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnErase.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.btnErase.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnErase.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnErase.Font = new System.Drawing.Font("SimSun", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnErase.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnErase.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnErase.Location = new System.Drawing.Point(12, 113);
            this.btnErase.Name = "btnErase";
            this.btnErase.Size = new System.Drawing.Size(57, 31);
            this.btnErase.TabIndex = 17;
            this.btnErase.Text = "->";
            this.btnErase.UseVisualStyleBackColor = false;
            this.btnErase.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnErase_MouseClick);
            // 
            // btnMultiply
            // 
            this.btnMultiply.BackColor = System.Drawing.Color.SteelBlue;
            this.btnMultiply.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnMultiply.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.btnMultiply.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnMultiply.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnMultiply.Font = new System.Drawing.Font("SimSun", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMultiply.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnMultiply.Location = new System.Drawing.Point(75, 113);
            this.btnMultiply.Name = "btnMultiply";
            this.btnMultiply.Size = new System.Drawing.Size(58, 31);
            this.btnMultiply.TabIndex = 11;
            this.btnMultiply.Text = "*";
            this.btnMultiply.UseVisualStyleBackColor = false;
            this.btnMultiply.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnMultiply_MouseClick);
            // 
            // btnDivide
            // 
            this.btnDivide.BackColor = System.Drawing.Color.SteelBlue;
            this.btnDivide.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnDivide.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.btnDivide.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnDivide.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnDivide.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDivide.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnDivide.Location = new System.Drawing.Point(139, 113);
            this.btnDivide.Name = "btnDivide";
            this.btnDivide.Size = new System.Drawing.Size(61, 31);
            this.btnDivide.TabIndex = 12;
            this.btnDivide.Text = "/";
            this.btnDivide.UseVisualStyleBackColor = false;
            this.btnDivide.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnMultiply_MouseClick);
            // 
            // btn9
            // 
            this.btn9.BackColor = System.Drawing.Color.White;
            this.btn9.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn9.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.btn9.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btn9.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btn9.Font = new System.Drawing.Font("MS Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn9.Location = new System.Drawing.Point(139, 150);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(61, 31);
            this.btn9.TabIndex = 2;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = false;
            this.btn9.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btn7_MouseClick);
            // 
            // btn8
            // 
            this.btn8.BackColor = System.Drawing.Color.White;
            this.btn8.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn8.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.btn8.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btn8.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btn8.Font = new System.Drawing.Font("MS Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn8.Location = new System.Drawing.Point(75, 150);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(58, 31);
            this.btn8.TabIndex = 1;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = false;
            this.btn8.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btn7_MouseClick);
            // 
            // btn7
            // 
            this.btn7.BackColor = System.Drawing.Color.White;
            this.btn7.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn7.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.btn7.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btn7.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btn7.Font = new System.Drawing.Font("MS Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn7.Location = new System.Drawing.Point(12, 150);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(57, 31);
            this.btn7.TabIndex = 0;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = false;
            this.btn7.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btn7_MouseClick);
            // 
            // btn6
            // 
            this.btn6.BackColor = System.Drawing.Color.White;
            this.btn6.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn6.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.btn6.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btn6.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btn6.Font = new System.Drawing.Font("MS Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn6.Location = new System.Drawing.Point(139, 187);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(61, 31);
            this.btn6.TabIndex = 5;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = false;
            this.btn6.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btn7_MouseClick);
            // 
            // btn5
            // 
            this.btn5.BackColor = System.Drawing.Color.White;
            this.btn5.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn5.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.btn5.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btn5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btn5.Font = new System.Drawing.Font("MS Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn5.Location = new System.Drawing.Point(75, 187);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(58, 31);
            this.btn5.TabIndex = 4;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = false;
            this.btn5.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btn7_MouseClick);
            // 
            // btn4
            // 
            this.btn4.BackColor = System.Drawing.Color.White;
            this.btn4.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn4.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.btn4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btn4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btn4.Font = new System.Drawing.Font("MS Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn4.Location = new System.Drawing.Point(12, 187);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(57, 31);
            this.btn4.TabIndex = 3;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = false;
            this.btn4.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btn7_MouseClick);
            // 
            // btn3
            // 
            this.btn3.BackColor = System.Drawing.Color.White;
            this.btn3.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn3.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.btn3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btn3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btn3.Font = new System.Drawing.Font("MS Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn3.Location = new System.Drawing.Point(139, 224);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(61, 31);
            this.btn3.TabIndex = 8;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = false;
            this.btn3.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btn7_MouseClick);
            // 
            // btn2
            // 
            this.btn2.BackColor = System.Drawing.Color.White;
            this.btn2.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn2.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.btn2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btn2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btn2.Font = new System.Drawing.Font("MS Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn2.Location = new System.Drawing.Point(75, 224);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(58, 31);
            this.btn2.TabIndex = 7;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = false;
            this.btn2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btn7_MouseClick);
            // 
            // btn1
            // 
            this.btn1.BackColor = System.Drawing.Color.White;
            this.btn1.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn1.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.btn1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btn1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btn1.Font = new System.Drawing.Font("MS Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn1.Location = new System.Drawing.Point(12, 224);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(57, 31);
            this.btn1.TabIndex = 6;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = false;
            this.btn1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btn7_MouseClick);
            // 
            // btnDot
            // 
            this.btnDot.BackColor = System.Drawing.Color.White;
            this.btnDot.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnDot.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.btnDot.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnDot.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnDot.Font = new System.Drawing.Font("SimSun", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDot.Location = new System.Drawing.Point(139, 261);
            this.btnDot.Name = "btnDot";
            this.btnDot.Size = new System.Drawing.Size(61, 31);
            this.btnDot.TabIndex = 10;
            this.btnDot.Text = ".";
            this.btnDot.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnDot.UseVisualStyleBackColor = false;
            this.btnDot.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnDot_MouseClick);
            // 
            // btn0
            // 
            this.btn0.BackColor = System.Drawing.Color.White;
            this.btn0.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn0.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.btn0.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btn0.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btn0.Font = new System.Drawing.Font("MS Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn0.Location = new System.Drawing.Point(75, 261);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(58, 31);
            this.btn0.TabIndex = 9;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = false;
            this.btn0.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btn0_MouseClick);
            // 
            // btnpm
            // 
            this.btnpm.BackColor = System.Drawing.Color.SteelBlue;
            this.btnpm.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnpm.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.btnpm.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnpm.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnpm.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnpm.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnpm.Location = new System.Drawing.Point(12, 261);
            this.btnpm.Name = "btnpm";
            this.btnpm.Size = new System.Drawing.Size(57, 31);
            this.btnpm.TabIndex = 15;
            this.btnpm.Text = "+/-";
            this.btnpm.UseVisualStyleBackColor = false;
            this.btnpm.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnpm_MouseClick);
            // 
            // btnMinus
            // 
            this.btnMinus.BackColor = System.Drawing.Color.SteelBlue;
            this.btnMinus.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnMinus.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.btnMinus.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnMinus.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnMinus.Font = new System.Drawing.Font("SimSun", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinus.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnMinus.Location = new System.Drawing.Point(206, 113);
            this.btnMinus.Name = "btnMinus";
            this.btnMinus.Size = new System.Drawing.Size(61, 31);
            this.btnMinus.TabIndex = 13;
            this.btnMinus.Text = "-";
            this.btnMinus.UseVisualStyleBackColor = false;
            this.btnMinus.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnMultiply_MouseClick);
            // 
            // btnEqual
            // 
            this.btnEqual.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnEqual.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEqual.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnEqual.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.btnEqual.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnEqual.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnEqual.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnEqual.Location = new System.Drawing.Point(207, 224);
            this.btnEqual.Name = "btnEqual";
            this.btnEqual.Size = new System.Drawing.Size(61, 68);
            this.btnEqual.TabIndex = 16;
            this.btnEqual.Text = "=";
            this.btnEqual.UseVisualStyleBackColor = false;
            this.btnEqual.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnEqual_MouseClick);
            // 
            // btnClr
            // 
            this.btnClr.Location = new System.Drawing.Point(207, 30);
            this.btnClr.Name = "btnClr";
            this.btnClr.Size = new System.Drawing.Size(61, 20);
            this.btnClr.TabIndex = 18;
            this.btnClr.Text = "Clear";
            this.btnClr.UseVisualStyleBackColor = true;
            this.btnClr.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnClr_MouseClick);
            // 
            // btnPlus
            // 
            this.btnPlus.BackColor = System.Drawing.Color.SteelBlue;
            this.btnPlus.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnPlus.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.btnPlus.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnPlus.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnPlus.Font = new System.Drawing.Font("SimSun", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlus.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnPlus.Location = new System.Drawing.Point(207, 150);
            this.btnPlus.Name = "btnPlus";
            this.btnPlus.Size = new System.Drawing.Size(61, 68);
            this.btnPlus.TabIndex = 14;
            this.btnPlus.Text = "+";
            this.btnPlus.UseVisualStyleBackColor = false;
            this.btnPlus.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnMultiply_MouseClick);
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.reportAProblemToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.newToolStripMenuItem.Text = "New  (Duplicate)";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // reportAProblemToolStripMenuItem
            // 
            this.reportAProblemToolStripMenuItem.Name = "reportAProblemToolStripMenuItem";
            this.reportAProblemToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.reportAProblemToolStripMenuItem.Text = "Report a Problem...";
            this.reportAProblemToolStripMenuItem.Click += new System.EventHandler(this.reportAProblemToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lightModeOnOffToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // lightModeOnOffToolStripMenuItem
            // 
            this.lightModeOnOffToolStripMenuItem.Name = "lightModeOnOffToolStripMenuItem";
            this.lightModeOnOffToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.lightModeOnOffToolStripMenuItem.Text = "Light Mode On/Off";
            this.lightModeOnOffToolStripMenuItem.Click += new System.EventHandler(this.lightModeOnOffToolStripMenuItem_Click);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.historyToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // historyToolStripMenuItem
            // 
            this.historyToolStripMenuItem.Name = "historyToolStripMenuItem";
            this.historyToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.historyToolStripMenuItem.Text = "History";
            this.historyToolStripMenuItem.Click += new System.EventHandler(this.historyToolStripMenuItem_Click);
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clearHistoryToolStripMenuItem});
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.toolsToolStripMenuItem.Text = "Tools";
            // 
            // clearHistoryToolStripMenuItem
            // 
            this.clearHistoryToolStripMenuItem.Name = "clearHistoryToolStripMenuItem";
            this.clearHistoryToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.clearHistoryToolStripMenuItem.Text = "Clear History";
            this.clearHistoryToolStripMenuItem.Click += new System.EventHandler(this.clearHistoryToolStripMenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.AutoSize = false;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.toolsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(281, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // Form1
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(281, 305);
            this.Controls.Add(this.btnPlus);
            this.Controls.Add(this.btnClr);
            this.Controls.Add(this.btnEqual);
            this.Controls.Add(this.btnMinus);
            this.Controls.Add(this.btnDot);
            this.Controls.Add(this.btn0);
            this.Controls.Add(this.btnpm);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btn9);
            this.Controls.Add(this.btn8);
            this.Controls.Add(this.btn7);
            this.Controls.Add(this.btnDivide);
            this.Controls.Add(this.btnMultiply);
            this.Controls.Add(this.btnErase);
            this.Controls.Add(this.txtScndry);
            this.Controls.Add(this.txtPrmry);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(297, 344);
            this.MinimumSize = new System.Drawing.Size(297, 344);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculator";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing_1);
            this.Load += new System.EventHandler(this.Form1_Load_1);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtPrmry;
        private System.Windows.Forms.TextBox txtScndry;
        private System.Windows.Forms.Button btnErase;
        private System.Windows.Forms.Button btnMultiply;
        private System.Windows.Forms.Button btnDivide;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btnDot;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.Button btnpm;
        private System.Windows.Forms.Button btnMinus;
        private System.Windows.Forms.Button btnEqual;
        private System.Windows.Forms.Button btnClr;
        private System.Windows.Forms.Button btnPlus;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportAProblemToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lightModeOnOffToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem historyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearHistoryToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
    }
}

