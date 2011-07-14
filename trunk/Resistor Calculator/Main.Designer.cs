namespace EqReCa
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.lblResult = new System.Windows.Forms.Label();
            this.tbResult = new System.Windows.Forms.TextBox();
            this.lblPercent = new System.Windows.Forms.Label();
            this.lbResults = new System.Windows.Forms.ListBox();
            this.tbValue = new System.Windows.Forms.TextBox();
            this.lblValue = new System.Windows.Forms.Label();
            this.lblParallelCount = new System.Windows.Forms.Label();
            this.cbParallelCount = new System.Windows.Forms.ComboBox();
            this.lblStdRows = new System.Windows.Forms.Label();
            this.cbStdRows = new System.Windows.Forms.ComboBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbParResult = new System.Windows.Forms.TextBox();
            this.tbRes6 = new System.Windows.Forms.TextBox();
            this.tbRes5 = new System.Windows.Forms.TextBox();
            this.tbRes4 = new System.Windows.Forms.TextBox();
            this.tbRes3 = new System.Windows.Forms.TextBox();
            this.tbRes2 = new System.Windows.Forms.TextBox();
            this.tbRes1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.menuStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(556, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clearAllToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(35, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // clearAllToolStripMenuItem
            // 
            this.clearAllToolStripMenuItem.Name = "clearAllToolStripMenuItem";
            this.clearAllToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.clearAllToolStripMenuItem.Text = "Clear All";
            this.clearAllToolStripMenuItem.Click += new System.EventHandler(this.clearAllToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem1});
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
            this.aboutToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem1
            // 
            this.aboutToolStripMenuItem1.Name = "aboutToolStripMenuItem1";
            this.aboutToolStripMenuItem1.Size = new System.Drawing.Size(114, 22);
            this.aboutToolStripMenuItem1.Text = "About";
            this.aboutToolStripMenuItem1.Click += new System.EventHandler(this.aboutToolStripMenuItem1_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(0, 27);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(556, 386);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.lblResult);
            this.tabPage1.Controls.Add(this.tbResult);
            this.tabPage1.Controls.Add(this.lblPercent);
            this.tabPage1.Controls.Add(this.lbResults);
            this.tabPage1.Controls.Add(this.tbValue);
            this.tabPage1.Controls.Add(this.lblValue);
            this.tabPage1.Controls.Add(this.lblParallelCount);
            this.tabPage1.Controls.Add(this.cbParallelCount);
            this.tabPage1.Controls.Add(this.lblStdRows);
            this.tabPage1.Controls.Add(this.cbStdRows);
            this.tabPage1.Controls.Add(this.btnCalculate);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(548, 360);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Parallel replacement";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(181, 30);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(37, 13);
            this.lblResult.TabIndex = 10;
            this.lblResult.Text = "Result";
            // 
            // tbResult
            // 
            this.tbResult.Location = new System.Drawing.Point(184, 46);
            this.tbResult.Name = "tbResult";
            this.tbResult.Size = new System.Drawing.Size(121, 20);
            this.tbResult.TabIndex = 9;
            this.tbResult.Text = "100";
            // 
            // lblPercent
            // 
            this.lblPercent.AutoSize = true;
            this.lblPercent.Location = new System.Drawing.Point(270, 157);
            this.lblPercent.Name = "lblPercent";
            this.lblPercent.Size = new System.Drawing.Size(35, 13);
            this.lblPercent.TabIndex = 8;
            this.lblPercent.Text = "label1";
            // 
            // lbResults
            // 
            this.lbResults.FormattingEnabled = true;
            this.lbResults.Location = new System.Drawing.Point(184, 72);
            this.lbResults.Name = "lbResults";
            this.lbResults.Size = new System.Drawing.Size(121, 82);
            this.lbResults.TabIndex = 7;
            // 
            // tbValue
            // 
            this.tbValue.Location = new System.Drawing.Point(29, 46);
            this.tbValue.Name = "tbValue";
            this.tbValue.Size = new System.Drawing.Size(121, 20);
            this.tbValue.TabIndex = 6;
            this.tbValue.Text = "100";
            // 
            // lblValue
            // 
            this.lblValue.AutoSize = true;
            this.lblValue.Location = new System.Drawing.Point(26, 30);
            this.lblValue.Name = "lblValue";
            this.lblValue.Size = new System.Drawing.Size(108, 13);
            this.lblValue.TabIndex = 5;
            this.lblValue.Text = "Equivalent resistance";
            // 
            // lblParallelCount
            // 
            this.lblParallelCount.AutoSize = true;
            this.lblParallelCount.Location = new System.Drawing.Point(26, 109);
            this.lblParallelCount.Name = "lblParallelCount";
            this.lblParallelCount.Size = new System.Drawing.Size(82, 13);
            this.lblParallelCount.TabIndex = 4;
            this.lblParallelCount.Text = "Resistors to use";
            // 
            // cbParallelCount
            // 
            this.cbParallelCount.FormattingEnabled = true;
            this.cbParallelCount.Items.AddRange(new object[] {
            "2",
            "3",
            "4"});
            this.cbParallelCount.Location = new System.Drawing.Point(29, 125);
            this.cbParallelCount.Name = "cbParallelCount";
            this.cbParallelCount.Size = new System.Drawing.Size(121, 21);
            this.cbParallelCount.TabIndex = 3;
            this.cbParallelCount.Text = "2";
            this.cbParallelCount.SelectedIndexChanged += new System.EventHandler(this.cbParallelCount_SelectedIndexChanged);
            // 
            // lblStdRows
            // 
            this.lblStdRows.AutoSize = true;
            this.lblStdRows.Location = new System.Drawing.Point(26, 69);
            this.lblStdRows.Name = "lblStdRows";
            this.lblStdRows.Size = new System.Drawing.Size(116, 13);
            this.lblStdRows.TabIndex = 2;
            this.lblStdRows.Text = "Standard Resistor Row";
            // 
            // cbStdRows
            // 
            this.cbStdRows.FormattingEnabled = true;
            this.cbStdRows.Items.AddRange(new object[] {
            "E12",
            "E24",
            "E48",
            "E96"});
            this.cbStdRows.Location = new System.Drawing.Point(29, 85);
            this.cbStdRows.Name = "cbStdRows";
            this.cbStdRows.Size = new System.Drawing.Size(121, 21);
            this.cbStdRows.TabIndex = 1;
            this.cbStdRows.Text = "E12";
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(29, 152);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(121, 23);
            this.btnCalculate.TabIndex = 0;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.tbParResult);
            this.tabPage2.Controls.Add(this.tbRes6);
            this.tabPage2.Controls.Add(this.tbRes5);
            this.tabPage2.Controls.Add(this.tbRes4);
            this.tabPage2.Controls.Add(this.tbRes3);
            this.tabPage2.Controls.Add(this.tbRes2);
            this.tabPage2.Controls.Add(this.tbRes1);
            this.tabPage2.Controls.Add(this.button1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(548, 360);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Parallel resistor calculator";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(179, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Equivalent resistance";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Enter resistor values";
            // 
            // tbParResult
            // 
            this.tbParResult.Location = new System.Drawing.Point(182, 36);
            this.tbParResult.Name = "tbParResult";
            this.tbParResult.Size = new System.Drawing.Size(100, 20);
            this.tbParResult.TabIndex = 7;
            // 
            // tbRes6
            // 
            this.tbRes6.Location = new System.Drawing.Point(55, 166);
            this.tbRes6.Name = "tbRes6";
            this.tbRes6.Size = new System.Drawing.Size(100, 20);
            this.tbRes6.TabIndex = 6;
            // 
            // tbRes5
            // 
            this.tbRes5.Location = new System.Drawing.Point(55, 140);
            this.tbRes5.Name = "tbRes5";
            this.tbRes5.Size = new System.Drawing.Size(100, 20);
            this.tbRes5.TabIndex = 5;
            // 
            // tbRes4
            // 
            this.tbRes4.Location = new System.Drawing.Point(55, 114);
            this.tbRes4.Name = "tbRes4";
            this.tbRes4.Size = new System.Drawing.Size(100, 20);
            this.tbRes4.TabIndex = 4;
            // 
            // tbRes3
            // 
            this.tbRes3.Location = new System.Drawing.Point(55, 88);
            this.tbRes3.Name = "tbRes3";
            this.tbRes3.Size = new System.Drawing.Size(100, 20);
            this.tbRes3.TabIndex = 3;
            // 
            // tbRes2
            // 
            this.tbRes2.Location = new System.Drawing.Point(55, 62);
            this.tbRes2.Name = "tbRes2";
            this.tbRes2.Size = new System.Drawing.Size(100, 20);
            this.tbRes2.TabIndex = 2;
            // 
            // tbRes1
            // 
            this.tbRes1.Location = new System.Drawing.Point(55, 36);
            this.tbRes1.Name = "tbRes1";
            this.tbRes1.Size = new System.Drawing.Size(100, 20);
            this.tbRes1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(55, 192);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Calculate";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(556, 425);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Main";
            this.Text = "Equivalent Resistor Calculator (by René Haunstrup)";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.ComboBox cbStdRows;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label lblParallelCount;
        private System.Windows.Forms.ComboBox cbParallelCount;
        private System.Windows.Forms.Label lblStdRows;
        private System.Windows.Forms.TextBox tbValue;
        private System.Windows.Forms.Label lblValue;
        private System.Windows.Forms.ListBox lbResults;
        private System.Windows.Forms.Label lblPercent;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.TextBox tbResult;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox tbRes6;
        private System.Windows.Forms.TextBox tbRes5;
        private System.Windows.Forms.TextBox tbRes4;
        private System.Windows.Forms.TextBox tbRes3;
        private System.Windows.Forms.TextBox tbRes2;
        private System.Windows.Forms.TextBox tbRes1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox tbParResult;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;


    }
}

