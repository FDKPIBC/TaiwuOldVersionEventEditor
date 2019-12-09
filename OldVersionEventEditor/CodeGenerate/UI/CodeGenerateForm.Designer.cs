namespace OldVersionEventEditor.CodeGenerate.UI
{
    partial class CodeGenerateForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CodeGenerateForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tsmiCreate = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiLoadFile = new System.Windows.Forms.ToolStripMenuItem();
            this.输出ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.输出ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.tcMod = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.menuStrip1.SuspendLayout();
            this.tcMod.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiCreate,
            this.tsmiLoadFile,
            this.输出ToolStripMenuItem,
            this.输出ToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(608, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tsmiCreate
            // 
            this.tsmiCreate.Name = "tsmiCreate";
            this.tsmiCreate.Size = new System.Drawing.Size(44, 21);
            this.tsmiCreate.Text = "新建";
            // 
            // tsmiLoadFile
            // 
            this.tsmiLoadFile.Name = "tsmiLoadFile";
            this.tsmiLoadFile.Size = new System.Drawing.Size(44, 21);
            this.tsmiLoadFile.Text = "读取";
            // 
            // 输出ToolStripMenuItem
            // 
            this.输出ToolStripMenuItem.Name = "输出ToolStripMenuItem";
            this.输出ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.输出ToolStripMenuItem.Text = "保存";
            // 
            // 输出ToolStripMenuItem1
            // 
            this.输出ToolStripMenuItem1.Name = "输出ToolStripMenuItem1";
            this.输出ToolStripMenuItem1.Size = new System.Drawing.Size(44, 21);
            this.输出ToolStripMenuItem1.Text = "输出";
            // 
            // tcMod
            // 
            this.tcMod.Controls.Add(this.tabPage1);
            this.tcMod.Controls.Add(this.tabPage2);
            this.tcMod.Controls.Add(this.tabPage3);
            this.tcMod.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcMod.Location = new System.Drawing.Point(0, 25);
            this.tcMod.Name = "tcMod";
            this.tcMod.SelectedIndex = 0;
            this.tcMod.Size = new System.Drawing.Size(608, 445);
            this.tcMod.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(600, 419);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Mod信息";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(600, 419);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Mod设置";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(600, 419);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "代码";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // CodeGenerateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(608, 470);
            this.Controls.Add(this.tcMod);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "CodeGenerateForm";
            this.Text = "事件代码生成器";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tcMod.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmiCreate;
        private System.Windows.Forms.ToolStripMenuItem tsmiLoadFile;
        private System.Windows.Forms.ToolStripMenuItem 输出ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 输出ToolStripMenuItem1;
        private System.Windows.Forms.TabControl tcMod;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
    }
}