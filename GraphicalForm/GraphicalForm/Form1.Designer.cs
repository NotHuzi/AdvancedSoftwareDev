namespace GraphicalForm
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
            this.SingleLine = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.SingleLineOutput = new System.Windows.Forms.RichTextBox();
            this.SingleLineInputEnter = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.MultiLineInputSaveBtn = new System.Windows.Forms.Button();
            this.MultiLineInputLoadBtn = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveImageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadImageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.commandsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SingleLine.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // SingleLine
            // 
            this.SingleLine.Controls.Add(this.tabPage1);
            this.SingleLine.Controls.Add(this.tabPage2);
            this.SingleLine.Location = new System.Drawing.Point(841, 81);
            this.SingleLine.Name = "SingleLine";
            this.SingleLine.SelectedIndex = 0;
            this.SingleLine.Size = new System.Drawing.Size(480, 403);
            this.SingleLine.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.SingleLineOutput);
            this.tabPage1.Controls.Add(this.SingleLineInputEnter);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(472, 377);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Single Input";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // SingleLineOutput
            // 
            this.SingleLineOutput.Location = new System.Drawing.Point(80, 100);
            this.SingleLineOutput.Name = "SingleLineOutput";
            this.SingleLineOutput.Size = new System.Drawing.Size(304, 244);
            this.SingleLineOutput.TabIndex = 1;
            this.SingleLineOutput.Text = "";
            // 
            // SingleLineInputEnter
            // 
            this.SingleLineInputEnter.Location = new System.Drawing.Point(80, 45);
            this.SingleLineInputEnter.Name = "SingleLineInputEnter";
            this.SingleLineInputEnter.Size = new System.Drawing.Size(304, 20);
            this.SingleLineInputEnter.TabIndex = 0;
            this.SingleLineInputEnter.TextChanged += new System.EventHandler(this.SingleLineInputTab_TextChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.MultiLineInputSaveBtn);
            this.tabPage2.Controls.Add(this.MultiLineInputLoadBtn);
            this.tabPage2.Controls.Add(this.richTextBox1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(472, 377);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Multi Input";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // MultiLineInputSaveBtn
            // 
            this.MultiLineInputSaveBtn.Location = new System.Drawing.Point(233, 6);
            this.MultiLineInputSaveBtn.Name = "MultiLineInputSaveBtn";
            this.MultiLineInputSaveBtn.Size = new System.Drawing.Size(104, 37);
            this.MultiLineInputSaveBtn.TabIndex = 3;
            this.MultiLineInputSaveBtn.Text = "Save";
            this.MultiLineInputSaveBtn.UseVisualStyleBackColor = true;
            // 
            // MultiLineInputLoadBtn
            // 
            this.MultiLineInputLoadBtn.Location = new System.Drawing.Point(115, 6);
            this.MultiLineInputLoadBtn.Name = "MultiLineInputLoadBtn";
            this.MultiLineInputLoadBtn.Size = new System.Drawing.Size(98, 37);
            this.MultiLineInputLoadBtn.TabIndex = 2;
            this.MultiLineInputLoadBtn.Text = "Load";
            this.MultiLineInputLoadBtn.UseVisualStyleBackColor = true;
            this.MultiLineInputLoadBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(75, 86);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(314, 219);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1522, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveImageToolStripMenuItem,
            this.loadImageToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // saveImageToolStripMenuItem
            // 
            this.saveImageToolStripMenuItem.Name = "saveImageToolStripMenuItem";
            this.saveImageToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.saveImageToolStripMenuItem.Text = "Save Image";
            // 
            // loadImageToolStripMenuItem
            // 
            this.loadImageToolStripMenuItem.Name = "loadImageToolStripMenuItem";
            this.loadImageToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.loadImageToolStripMenuItem.Text = "Load Image";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.commandsToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // commandsToolStripMenuItem
            // 
            this.commandsToolStripMenuItem.Name = "commandsToolStripMenuItem";
            this.commandsToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.commandsToolStripMenuItem.Text = "Commands";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1522, 694);
            this.Controls.Add(this.SingleLine);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.SingleLine.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl SingleLine;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.RichTextBox SingleLineOutput;
        private System.Windows.Forms.TextBox SingleLineInputEnter;
        private System.Windows.Forms.Button MultiLineInputSaveBtn;
        private System.Windows.Forms.Button MultiLineInputLoadBtn;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveImageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadImageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem commandsToolStripMenuItem;
    }
}

