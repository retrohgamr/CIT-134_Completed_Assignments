
namespace Chapter_7_Excercise_1
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
            this.checkAnsBtn = new System.Windows.Forms.Button();
            this.importBtn = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.scoreBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // checkAnsBtn
            // 
            this.checkAnsBtn.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.checkAnsBtn.FlatAppearance.BorderSize = 0;
            this.checkAnsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkAnsBtn.Location = new System.Drawing.Point(12, 68);
            this.checkAnsBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkAnsBtn.Name = "checkAnsBtn";
            this.checkAnsBtn.Size = new System.Drawing.Size(116, 32);
            this.checkAnsBtn.TabIndex = 2;
            this.checkAnsBtn.Text = "Grade";
            this.checkAnsBtn.UseVisualStyleBackColor = false;
            this.checkAnsBtn.Click += new System.EventHandler(this.checkAnsBtn_Click);
            // 
            // importBtn
            // 
            this.importBtn.BackColor = System.Drawing.Color.LightSteelBlue;
            this.importBtn.FlatAppearance.BorderSize = 0;
            this.importBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.importBtn.Location = new System.Drawing.Point(12, 11);
            this.importBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.importBtn.Name = "importBtn";
            this.importBtn.Padding = new System.Windows.Forms.Padding(3);
            this.importBtn.Size = new System.Drawing.Size(116, 30);
            this.importBtn.TabIndex = 3;
            this.importBtn.Text = "Import Quiz";
            this.importBtn.UseVisualStyleBackColor = false;
            this.importBtn.Click += new System.EventHandler(this.importBtn_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.listBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBox1.ForeColor = System.Drawing.SystemColors.Window;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(141, 11);
            this.listBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(250, 320);
            this.listBox1.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightCoral;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.button1.Location = new System.Drawing.Point(53, 299);
            this.button1.Name = "button1";
            this.button1.Padding = new System.Windows.Forms.Padding(3);
            this.button1.Size = new System.Drawing.Size(75, 32);
            this.button1.TabIndex = 5;
            this.button1.Text = "Clear";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // scoreBox
            // 
            this.scoreBox.BackColor = System.Drawing.Color.LightGray;
            this.scoreBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.scoreBox.ForeColor = System.Drawing.SystemColors.ControlText;
            this.scoreBox.Location = new System.Drawing.Point(12, 106);
            this.scoreBox.Margin = new System.Windows.Forms.Padding(4);
            this.scoreBox.Name = "scoreBox";
            this.scoreBox.ReadOnly = true;
            this.scoreBox.Size = new System.Drawing.Size(116, 15);
            this.scoreBox.TabIndex = 6;
            this.scoreBox.Text = "  Score:    __ / 20";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(403, 340);
            this.Controls.Add(this.scoreBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.importBtn);
            this.Controls.Add(this.checkAnsBtn);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Driver\'s Exam Grading Application";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button checkAnsBtn;
        private System.Windows.Forms.Button importBtn;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox scoreBox;
    }
}

