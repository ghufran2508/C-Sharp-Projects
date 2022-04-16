namespace Basic_Notepad
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openCtrlOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newCtrlNToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveCtrlSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveASToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.boldToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.italicToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.iDEViewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.darkModeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.txtFilePath = new System.Windows.Forms.TextBox();
            this.txtFileSIze = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblSize = new System.Windows.Forms.Label();
            this.rtxtSuggestion = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnUndo = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem,
            this.helpToolStripMenuItem,
            this.helpToolStripMenuItem1,
            this.iDEViewToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(726, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openCtrlOToolStripMenuItem,
            this.newCtrlNToolStripMenuItem,
            this.saveCtrlSToolStripMenuItem,
            this.saveASToolStripMenuItem,
            this.closeToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // openCtrlOToolStripMenuItem
            // 
            this.openCtrlOToolStripMenuItem.Name = "openCtrlOToolStripMenuItem";
            this.openCtrlOToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.openCtrlOToolStripMenuItem.Text = "Open    Ctrl+O";
            this.openCtrlOToolStripMenuItem.Click += new System.EventHandler(this.openCtrlOToolStripMenuItem_Click);
            // 
            // newCtrlNToolStripMenuItem
            // 
            this.newCtrlNToolStripMenuItem.Name = "newCtrlNToolStripMenuItem";
            this.newCtrlNToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.newCtrlNToolStripMenuItem.Text = "New     Ctrl+N";
            this.newCtrlNToolStripMenuItem.Click += new System.EventHandler(this.newCtrlNToolStripMenuItem_Click);
            // 
            // saveCtrlSToolStripMenuItem
            // 
            this.saveCtrlSToolStripMenuItem.Name = "saveCtrlSToolStripMenuItem";
            this.saveCtrlSToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.saveCtrlSToolStripMenuItem.Text = "Save     Ctrl+S";
            this.saveCtrlSToolStripMenuItem.Click += new System.EventHandler(this.saveCtrlSToolStripMenuItem_Click);
            // 
            // saveASToolStripMenuItem
            // 
            this.saveASToolStripMenuItem.Name = "saveASToolStripMenuItem";
            this.saveASToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.saveASToolStripMenuItem.Text = "Save As";
            this.saveASToolStripMenuItem.Click += new System.EventHandler(this.saveASToolStripMenuItem_Click);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.closeToolStripMenuItem.Text = "Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.boldToolStripMenuItem,
            this.italicToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.helpToolStripMenuItem.Text = "Tools";
            // 
            // boldToolStripMenuItem
            // 
            this.boldToolStripMenuItem.Name = "boldToolStripMenuItem";
            this.boldToolStripMenuItem.Size = new System.Drawing.Size(99, 22);
            this.boldToolStripMenuItem.Text = "Bold";
            this.boldToolStripMenuItem.Click += new System.EventHandler(this.boldToolStripMenuItem_Click);
            // 
            // italicToolStripMenuItem
            // 
            this.italicToolStripMenuItem.Name = "italicToolStripMenuItem";
            this.italicToolStripMenuItem.Size = new System.Drawing.Size(99, 22);
            this.italicToolStripMenuItem.Text = "Italic";
            this.italicToolStripMenuItem.Click += new System.EventHandler(this.italicToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem1
            // 
            this.helpToolStripMenuItem1.Name = "helpToolStripMenuItem1";
            this.helpToolStripMenuItem1.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem1.Text = "Help";
            // 
            // iDEViewToolStripMenuItem
            // 
            this.iDEViewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.darkModeToolStripMenuItem});
            this.iDEViewToolStripMenuItem.Name = "iDEViewToolStripMenuItem";
            this.iDEViewToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.iDEViewToolStripMenuItem.Text = "IDE View";
            // 
            // darkModeToolStripMenuItem
            // 
            this.darkModeToolStripMenuItem.Name = "darkModeToolStripMenuItem";
            this.darkModeToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.darkModeToolStripMenuItem.Text = "Dark Mode";
            this.darkModeToolStripMenuItem.Click += new System.EventHandler(this.darkModeToolStripMenuItem_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.SystemColors.Control;
            this.richTextBox1.ForeColor = System.Drawing.SystemColors.MenuText;
            this.richTextBox1.Location = new System.Drawing.Point(130, 92);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(579, 346);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            this.richTextBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.richTextBox1_KeyDown);
            // 
            // txtFilePath
            // 
            this.txtFilePath.BackColor = System.Drawing.SystemColors.Control;
            this.txtFilePath.ForeColor = System.Drawing.SystemColors.MenuText;
            this.txtFilePath.Location = new System.Drawing.Point(130, 43);
            this.txtFilePath.Name = "txtFilePath";
            this.txtFilePath.Size = new System.Drawing.Size(579, 20);
            this.txtFilePath.TabIndex = 2;
            // 
            // txtFileSIze
            // 
            this.txtFileSIze.BackColor = System.Drawing.SystemColors.Control;
            this.txtFileSIze.ForeColor = System.Drawing.SystemColors.MenuText;
            this.txtFileSIze.Location = new System.Drawing.Point(12, 73);
            this.txtFileSIze.Name = "txtFileSIze";
            this.txtFileSIze.ReadOnly = true;
            this.txtFileSIze.Size = new System.Drawing.Size(109, 20);
            this.txtFileSIze.TabIndex = 3;
            this.txtFileSIze.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(126, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "File Path:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(127, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Content: ";
            // 
            // lblSize
            // 
            this.lblSize.AutoSize = true;
            this.lblSize.Location = new System.Drawing.Point(12, 50);
            this.lblSize.Name = "lblSize";
            this.lblSize.Size = new System.Drawing.Size(73, 13);
            this.lblSize.TabIndex = 6;
            this.lblSize.Text = "Content Size: ";
            // 
            // rtxtSuggestion
            // 
            this.rtxtSuggestion.BackColor = System.Drawing.SystemColors.Control;
            this.rtxtSuggestion.ForeColor = System.Drawing.SystemColors.MenuText;
            this.rtxtSuggestion.Location = new System.Drawing.Point(12, 135);
            this.rtxtSuggestion.Name = "rtxtSuggestion";
            this.rtxtSuggestion.Size = new System.Drawing.Size(109, 214);
            this.rtxtSuggestion.TabIndex = 7;
            this.rtxtSuggestion.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Suggestions";
            // 
            // btnUndo
            // 
            this.btnUndo.BackColor = System.Drawing.Color.Lime;
            this.btnUndo.Font = new System.Drawing.Font("Ravie", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUndo.Location = new System.Drawing.Point(12, 377);
            this.btnUndo.Name = "btnUndo";
            this.btnUndo.Size = new System.Drawing.Size(109, 45);
            this.btnUndo.TabIndex = 9;
            this.btnUndo.Text = "Undo All Changes";
            this.btnUndo.UseVisualStyleBackColor = false;
            this.btnUndo.Click += new System.EventHandler(this.btnUndo_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(726, 450);
            this.Controls.Add(this.btnUndo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.rtxtSuggestion);
            this.Controls.Add(this.lblSize);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtFileSIze);
            this.Controls.Add(this.txtFilePath);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Notepad";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openCtrlOToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newCtrlNToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveCtrlSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveASToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.TextBox txtFilePath;
        private System.Windows.Forms.TextBox txtFileSIze;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblSize;
        private System.Windows.Forms.RichTextBox rtxtSuggestion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnUndo;
        private System.Windows.Forms.ToolStripMenuItem boldToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem italicToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem iDEViewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem darkModeToolStripMenuItem;
    }
}

