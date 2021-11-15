
namespace Chapter_5_Exercise_3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiNew = new System.Windows.Forms.ToolStripMenuItem();
            this.tmsiOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.tmsiSave = new System.Windows.Forms.ToolStripMenuItem();
            this.tmsiAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.tmsiExit = new System.Windows.Forms.ToolStripMenuItem();
            this.richTextBox = new System.Windows.Forms.RichTextBox();
            this.saveFile = new System.Windows.Forms.SaveFileDialog();
            this.openFile = new System.Windows.Forms.OpenFileDialog();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.optionsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(655, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiNew,
            this.tmsiOpen,
            this.tmsiSave,
            this.tmsiAbout,
            this.tmsiExit});
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(75, 24);
            this.optionsToolStripMenuItem.Text = "Options";
            // 
            // tsmiNew
            // 
            this.tsmiNew.Name = "tsmiNew";
            this.tsmiNew.Size = new System.Drawing.Size(224, 26);
            this.tsmiNew.Text = "New";
            this.tsmiNew.Click += new System.EventHandler(this.tsmiNew_Click);
            // 
            // tmsiOpen
            // 
            this.tmsiOpen.Name = "tmsiOpen";
            this.tmsiOpen.Size = new System.Drawing.Size(224, 26);
            this.tmsiOpen.Text = "Open";
            this.tmsiOpen.Click += new System.EventHandler(this.tmsiOpen_Click);
            // 
            // tmsiSave
            // 
            this.tmsiSave.Name = "tmsiSave";
            this.tmsiSave.Size = new System.Drawing.Size(224, 26);
            this.tmsiSave.Text = "Save";
            this.tmsiSave.Click += new System.EventHandler(this.tmsiSave_Click);
            // 
            // tmsiAbout
            // 
            this.tmsiAbout.Name = "tmsiAbout";
            this.tmsiAbout.Size = new System.Drawing.Size(224, 26);
            this.tmsiAbout.Text = "About";
            this.tmsiAbout.Click += new System.EventHandler(this.tmsiAbout_Click);
            // 
            // tmsiExit
            // 
            this.tmsiExit.Name = "tmsiExit";
            this.tmsiExit.Size = new System.Drawing.Size(224, 26);
            this.tmsiExit.Text = "Exit";
            this.tmsiExit.Click += new System.EventHandler(this.tmsiExit_Click);
            // 
            // richTextBox
            // 
            this.richTextBox.BackColor = System.Drawing.SystemColors.Menu;
            this.richTextBox.Location = new System.Drawing.Point(16, 33);
            this.richTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.richTextBox.Name = "richTextBox";
            this.richTextBox.Size = new System.Drawing.Size(621, 479);
            this.richTextBox.TabIndex = 1;
            this.richTextBox.Text = "";
            // 
            // openFile
            // 
            this.openFile.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(655, 528);
            this.Controls.Add(this.richTextBox);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "retrohGamr\'s NotePad";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmiNew;
        private System.Windows.Forms.ToolStripMenuItem tmsiOpen;
        private System.Windows.Forms.ToolStripMenuItem tmsiSave;
        private System.Windows.Forms.ToolStripMenuItem tmsiAbout;
        private System.Windows.Forms.ToolStripMenuItem tmsiExit;
        private System.Windows.Forms.RichTextBox richTextBox;
        private System.Windows.Forms.SaveFileDialog saveFile;
        private System.Windows.Forms.OpenFileDialog openFile;
    }
}

