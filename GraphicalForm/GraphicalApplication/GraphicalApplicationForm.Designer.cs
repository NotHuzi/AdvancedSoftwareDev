namespace GraphicalProgrammingLanguage
{
	partial class GraphicalProgrammingLanguageForm
	{
		
		/// Required designer variable
		
		private System.ComponentModel.IContainer components = null;


        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

		#region Windows Form Designer generated code
         
		
		private void InitializeComponent()
		{
            this.TopMenuStrip = new System.Windows.Forms.MenuStrip();
            this.homeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveImageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadImageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CodeInputTabControl = new System.Windows.Forms.TabControl();
            this.SingleLineInputTab = new System.Windows.Forms.TabPage();
            this.SingleLineOutput = new System.Windows.Forms.RichTextBox();
            this.SingleLineInputTextbox = new System.Windows.Forms.TextBox();
            this.LoadFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.SaveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.GraphicsPictureBox = new System.Windows.Forms.PictureBox();
            this.DrawingPanel = new System.Windows.Forms.Panel();
            this.TopMenuStrip.SuspendLayout();
            this.CodeInputTabControl.SuspendLayout();
            this.SingleLineInputTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GraphicsPictureBox)).BeginInit();
            this.DrawingPanel.SuspendLayout();
            this.SuspendLayout();
        
            // Top menu
            
            this.TopMenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.TopMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.homeToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.TopMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.TopMenuStrip.Name = "TopMenuStrip";
            this.TopMenuStrip.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.TopMenuStrip.Size = new System.Drawing.Size(1105, 24);
            this.TopMenuStrip.TabIndex = 0;
            this.TopMenuStrip.Text = "menuStrip1";
   
            // homeToolStripMenuItem
     
            this.homeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveImageToolStripMenuItem,
            this.loadImageToolStripMenuItem});
            this.homeToolStripMenuItem.Name = "homeToolStripMenuItem";
            this.homeToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.homeToolStripMenuItem.Text = "File";
            this.homeToolStripMenuItem.Click += new System.EventHandler(this.HomeToolStripMenuItem_Click);
          
            // saveImageToolStripMenuItem
      
            this.saveImageToolStripMenuItem.Name = "saveImageToolStripMenuItem";
            this.saveImageToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.saveImageToolStripMenuItem.Text = "Save Image";
            this.saveImageToolStripMenuItem.Click += new System.EventHandler(this.saveImageToolStripMenuItem_Click);
         
            // loadImageToolStripMenuItem
       
            this.loadImageToolStripMenuItem.Name = "loadImageToolStripMenuItem";
            this.loadImageToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.loadImageToolStripMenuItem.Text = "Load Image";
          
            // helpToolStripMenuItem
          
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
         
            // CodeInputTabControl
          
            this.CodeInputTabControl.Controls.Add(this.SingleLineInputTab);
            this.CodeInputTabControl.Dock = System.Windows.Forms.DockStyle.Right;
            this.CodeInputTabControl.Location = new System.Drawing.Point(533, 0);
            this.CodeInputTabControl.Margin = new System.Windows.Forms.Padding(2);
            this.CodeInputTabControl.Name = "CodeInputTabControl";
            this.CodeInputTabControl.SelectedIndex = 0;
            this.CodeInputTabControl.Size = new System.Drawing.Size(509, 488);
            this.CodeInputTabControl.TabIndex = 2;
         
            // SingleLineInputTab
        
            this.SingleLineInputTab.Controls.Add(this.SingleLineOutput);
            this.SingleLineInputTab.Controls.Add(this.SingleLineInputTextbox);
            this.SingleLineInputTab.Location = new System.Drawing.Point(4, 22);
            this.SingleLineInputTab.Margin = new System.Windows.Forms.Padding(2);
            this.SingleLineInputTab.Name = "SingleLineInputTab";
            this.SingleLineInputTab.Padding = new System.Windows.Forms.Padding(2);
            this.SingleLineInputTab.Size = new System.Drawing.Size(501, 462);
            this.SingleLineInputTab.TabIndex = 0;
            this.SingleLineInputTab.Text = "Assignment Part 1";
            this.SingleLineInputTab.UseVisualStyleBackColor = true;
        
            // SingleLineOutput
       
            this.SingleLineOutput.BackColor = System.Drawing.Color.White;
            this.SingleLineOutput.Enabled = false;
            this.SingleLineOutput.Location = new System.Drawing.Point(14, 79);
            this.SingleLineOutput.Margin = new System.Windows.Forms.Padding(2);
            this.SingleLineOutput.Name = "SingleLineOutput";
            this.SingleLineOutput.Size = new System.Drawing.Size(468, 366);
            this.SingleLineOutput.TabIndex = 1;
            this.SingleLineOutput.Text = "";
      
            // SingleLineInputTextbox
         
            this.SingleLineInputTextbox.Location = new System.Drawing.Point(14, 15);
            this.SingleLineInputTextbox.Margin = new System.Windows.Forms.Padding(2);
            this.SingleLineInputTextbox.Multiline = true;
            this.SingleLineInputTextbox.Name = "SingleLineInputTextbox";
            this.SingleLineInputTextbox.Size = new System.Drawing.Size(468, 55);
            this.SingleLineInputTextbox.TabIndex = 0;
            this.SingleLineInputTextbox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.SingleLineInputEnter);
         
            // LoadFileDialog
           
            this.LoadFileDialog.FileName = "openFileDialog1";
         
            // GraphicsPictureBox
         
            this.GraphicsPictureBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.GraphicsPictureBox.Location = new System.Drawing.Point(0, 0);
            this.GraphicsPictureBox.Margin = new System.Windows.Forms.Padding(2);
            this.GraphicsPictureBox.Name = "GraphicsPictureBox";
            this.GraphicsPictureBox.Size = new System.Drawing.Size(531, 488);
            this.GraphicsPictureBox.TabIndex = 3;
            this.GraphicsPictureBox.TabStop = false;
            this.GraphicsPictureBox.Paint += new System.Windows.Forms.PaintEventHandler(this.GraphicsPictureBoxPaint);
      
            // DrawingPanel
      
            this.DrawingPanel.Controls.Add(this.GraphicsPictureBox);
            this.DrawingPanel.Controls.Add(this.CodeInputTabControl);
            this.DrawingPanel.Location = new System.Drawing.Point(0, 35);
            this.DrawingPanel.Margin = new System.Windows.Forms.Padding(2);
            this.DrawingPanel.Name = "DrawingPanel";
            this.DrawingPanel.Size = new System.Drawing.Size(1042, 488);
            this.DrawingPanel.TabIndex = 4;
   
            // GraphicalApplicationForm
     
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1105, 540);
            this.Controls.Add(this.TopMenuStrip);
            this.Controls.Add(this.DrawingPanel);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "GraphicalAppplicationForm";
            this.Text = "GraphicalApplicationInterface";
            this.TopMenuStrip.ResumeLayout(false);
            this.TopMenuStrip.PerformLayout();
            this.CodeInputTabControl.ResumeLayout(false);
            this.SingleLineInputTab.ResumeLayout(false);
            this.SingleLineInputTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GraphicsPictureBox)).EndInit();
            this.DrawingPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip TopMenuStrip;
		private System.Windows.Forms.ToolStripMenuItem homeToolStripMenuItem;
		private System.Windows.Forms.TabControl CodeInputTabControl;
		private System.Windows.Forms.TabPage SingleLineInputTab;
		private System.Windows.Forms.RichTextBox SingleLineOutput;
		private System.Windows.Forms.TextBox SingleLineInputTextbox;
		private System.Windows.Forms.OpenFileDialog LoadFileDialog;
		private System.Windows.Forms.SaveFileDialog SaveFileDialog;
		private System.Windows.Forms.PictureBox GraphicsPictureBox;
		private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
		private System.Windows.Forms.Panel DrawingPanel;
		private System.Windows.Forms.ToolStripMenuItem saveImageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadImageToolStripMenuItem;
    }
}