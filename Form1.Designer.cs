
namespace MobyDick
{
    partial class MobyDickWordCount
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
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ExitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.CmdSwitch = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.CmdExecute = new System.Windows.Forms.Button();
            this.tbBook = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbStopWords = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tsMessage = new System.Windows.Forms.ToolStripStatusLabel();
            this.cbCase = new System.Windows.Forms.CheckBox();
            this.cbTop100 = new System.Windows.Forms.CheckBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ExitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // ExitToolStripMenuItem
            // 
            this.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem";
            this.ExitToolStripMenuItem.Size = new System.Drawing.Size(93, 22);
            this.ExitToolStripMenuItem.Text = "E&xit";
            this.ExitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 162);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(553, 268);
            this.dataGridView1.TabIndex = 1;
            // 
            // CmdSwitch
            // 
            this.CmdSwitch.Location = new System.Drawing.Point(12, 133);
            this.CmdSwitch.Name = "CmdSwitch";
            this.CmdSwitch.Size = new System.Drawing.Size(75, 23);
            this.CmdSwitch.TabIndex = 7;
            this.CmdSwitch.Text = "Book Words";
            this.CmdSwitch.UseVisualStyleBackColor = true;
            this.CmdSwitch.Click += new System.EventHandler(this.CmdSwitch_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbTop100);
            this.groupBox1.Controls.Add(this.cbCase);
            this.groupBox1.Controls.Add(this.CmdExecute);
            this.groupBox1.Controls.Add(this.tbBook);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tbStopWords);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(413, 103);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            // 
            // CmdExecute
            // 
            this.CmdExecute.Location = new System.Drawing.Point(96, 55);
            this.CmdExecute.Name = "CmdExecute";
            this.CmdExecute.Size = new System.Drawing.Size(75, 23);
            this.CmdExecute.TabIndex = 11;
            this.CmdExecute.Text = "Execute";
            this.CmdExecute.UseVisualStyleBackColor = true;
            this.CmdExecute.Click += new System.EventHandler(this.CmdExecute_Click);
            // 
            // tbBook
            // 
            this.tbBook.Location = new System.Drawing.Point(96, 29);
            this.tbBook.Name = "tbBook";
            this.tbBook.Size = new System.Drawing.Size(214, 20);
            this.tbBook.TabIndex = 10;
            this.tbBook.Text = "C:\\Temp\\mobydick.txt";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Book Text File";
            // 
            // tbStopWords
            // 
            this.tbStopWords.Location = new System.Drawing.Point(96, 3);
            this.tbStopWords.Name = "tbStopWords";
            this.tbStopWords.Size = new System.Drawing.Size(214, 20);
            this.tbStopWords.TabIndex = 8;
            this.tbStopWords.Text = "C:\\Temp\\stop-words.txt";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Stop Words File";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsMessage});
            this.statusStrip1.Location = new System.Drawing.Point(0, 442);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 22);
            this.statusStrip1.TabIndex = 9;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tsMessage
            // 
            this.tsMessage.ForeColor = System.Drawing.Color.Red;
            this.tsMessage.Name = "tsMessage";
            this.tsMessage.Size = new System.Drawing.Size(0, 17);
            // 
            // cbCase
            // 
            this.cbCase.AutoSize = true;
            this.cbCase.Location = new System.Drawing.Point(294, 57);
            this.cbCase.Name = "cbCase";
            this.cbCase.Size = new System.Drawing.Size(96, 17);
            this.cbCase.TabIndex = 12;
            this.cbCase.Text = "Case Sensitive";
            this.cbCase.UseVisualStyleBackColor = true;
            // 
            // cbTop100
            // 
            this.cbTop100.AutoSize = true;
            this.cbTop100.Checked = true;
            this.cbTop100.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbTop100.Location = new System.Drawing.Point(294, 80);
            this.cbTop100.Name = "cbTop100";
            this.cbTop100.Size = new System.Drawing.Size(66, 17);
            this.cbTop100.TabIndex = 13;
            this.cbTop100.Text = "Top 100";
            this.cbTop100.UseVisualStyleBackColor = true;
            // 
            // MobyDickWordCount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 464);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.CmdSwitch);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MobyDickWordCount";
            this.Text = "Moby Dick Word Count";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ExitToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button CmdSwitch;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button CmdExecute;
        private System.Windows.Forms.TextBox tbBook;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbStopWords;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel tsMessage;
        private System.Windows.Forms.CheckBox cbCase;
        private System.Windows.Forms.CheckBox cbTop100;
    }
}

