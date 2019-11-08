namespace OldVersionEventEditor
{
    partial class Editor
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Editor));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.文件ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newTsmi = new System.Windows.Forms.ToolStripMenuItem();
            this.loadTsmi = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.saveTsmi = new System.Windows.Forms.ToolStripMenuItem();
            this.设置ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.语言ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.中文ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.英文ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.关于ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiAboutEditor = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiAboutConfig = new System.Windows.Forms.ToolStripMenuItem();
            this.EventPG = new System.Windows.Forms.PropertyGrid();
            this.eventTC = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnAddEvent = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.lbEvent = new System.Windows.Forms.ListBox();
            this.tbxSearchEvent = new System.Windows.Forms.TextBox();
            this.btnRefreshEvent = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.ChoicePG = new System.Windows.Forms.PropertyGrid();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btnAddChoice = new System.Windows.Forms.Button();
            this.btnRemoveChoice = new System.Windows.Forms.Button();
            this.lbChoice = new System.Windows.Forms.ListBox();
            this.tbxSearchChoice = new System.Windows.Forms.TextBox();
            this.btnRefreshChoice = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.eventTC.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.文件ToolStripMenuItem,
            this.设置ToolStripMenuItem,
            this.关于ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(701, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 文件ToolStripMenuItem
            // 
            this.文件ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newTsmi,
            this.loadTsmi,
            this.toolStripSeparator1,
            this.saveTsmi});
            this.文件ToolStripMenuItem.Name = "文件ToolStripMenuItem";
            this.文件ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.文件ToolStripMenuItem.Text = "文件";
            // 
            // newTsmi
            // 
            this.newTsmi.Name = "newTsmi";
            this.newTsmi.Size = new System.Drawing.Size(100, 22);
            this.newTsmi.Text = "新建";
            this.newTsmi.Click += new System.EventHandler(this.newTsmi_Click);
            // 
            // loadTsmi
            // 
            this.loadTsmi.Name = "loadTsmi";
            this.loadTsmi.Size = new System.Drawing.Size(100, 22);
            this.loadTsmi.Text = "读取";
            this.loadTsmi.Click += new System.EventHandler(this.loadTsmi_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(97, 6);
            // 
            // saveTsmi
            // 
            this.saveTsmi.Name = "saveTsmi";
            this.saveTsmi.Size = new System.Drawing.Size(100, 22);
            this.saveTsmi.Text = "保存";
            this.saveTsmi.Click += new System.EventHandler(this.saveTsmi_Click);
            // 
            // 设置ToolStripMenuItem
            // 
            this.设置ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.语言ToolStripMenuItem});
            this.设置ToolStripMenuItem.Name = "设置ToolStripMenuItem";
            this.设置ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.设置ToolStripMenuItem.Text = "设置";
            this.设置ToolStripMenuItem.Visible = false;
            // 
            // 语言ToolStripMenuItem
            // 
            this.语言ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.中文ToolStripMenuItem,
            this.英文ToolStripMenuItem});
            this.语言ToolStripMenuItem.Name = "语言ToolStripMenuItem";
            this.语言ToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.语言ToolStripMenuItem.Text = "语言";
            // 
            // 中文ToolStripMenuItem
            // 
            this.中文ToolStripMenuItem.Name = "中文ToolStripMenuItem";
            this.中文ToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.中文ToolStripMenuItem.Text = "中文";
            // 
            // 英文ToolStripMenuItem
            // 
            this.英文ToolStripMenuItem.Name = "英文ToolStripMenuItem";
            this.英文ToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.英文ToolStripMenuItem.Text = "英文";
            // 
            // 关于ToolStripMenuItem
            // 
            this.关于ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiAboutEditor,
            this.tsmiAboutConfig});
            this.关于ToolStripMenuItem.Name = "关于ToolStripMenuItem";
            this.关于ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.关于ToolStripMenuItem.Text = "关于";
            // 
            // tsmiAboutEditor
            // 
            this.tsmiAboutEditor.Name = "tsmiAboutEditor";
            this.tsmiAboutEditor.Size = new System.Drawing.Size(136, 22);
            this.tsmiAboutEditor.Text = "关于编辑器";
            this.tsmiAboutEditor.Click += new System.EventHandler(this.tsmiAboutEditor_Click);
            // 
            // tsmiAboutConfig
            // 
            this.tsmiAboutConfig.Name = "tsmiAboutConfig";
            this.tsmiAboutConfig.Size = new System.Drawing.Size(136, 22);
            this.tsmiAboutConfig.Text = "关于配置";
            this.tsmiAboutConfig.Click += new System.EventHandler(this.tsmiAboutConfig_Click);
            // 
            // EventPG
            // 
            this.EventPG.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EventPG.Location = new System.Drawing.Point(203, 3);
            this.EventPG.Name = "EventPG";
            this.EventPG.PropertySort = System.Windows.Forms.PropertySort.Categorized;
            this.EventPG.Size = new System.Drawing.Size(487, 489);
            this.EventPG.TabIndex = 1;
            // 
            // eventTC
            // 
            this.eventTC.Controls.Add(this.tabPage1);
            this.eventTC.Controls.Add(this.tabPage2);
            this.eventTC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.eventTC.Location = new System.Drawing.Point(0, 25);
            this.eventTC.Name = "eventTC";
            this.eventTC.SelectedIndex = 0;
            this.eventTC.Size = new System.Drawing.Size(701, 521);
            this.eventTC.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.splitter1);
            this.tabPage1.Controls.Add(this.EventPG);
            this.tabPage1.Controls.Add(this.tableLayoutPanel1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(693, 495);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "事件";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(203, 3);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 489);
            this.splitter1.TabIndex = 3;
            this.splitter1.TabStop = false;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Controls.Add(this.btnAddEvent, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnRemove, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.lbEvent, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.tbxSearchEvent, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnRefreshEvent, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(200, 489);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // btnAddEvent
            // 
            this.btnAddEvent.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnAddEvent.Image = global::OldVersionEventEditor.Properties.Resources.add;
            this.btnAddEvent.Location = new System.Drawing.Point(3, 3);
            this.btnAddEvent.Name = "btnAddEvent";
            this.btnAddEvent.Size = new System.Drawing.Size(35, 29);
            this.btnAddEvent.TabIndex = 0;
            this.btnAddEvent.UseVisualStyleBackColor = true;
            this.btnAddEvent.Click += new System.EventHandler(this.btnAddEvent_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnRemove.Image = global::OldVersionEventEditor.Properties.Resources.remove;
            this.btnRemove.Location = new System.Drawing.Point(162, 3);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(35, 29);
            this.btnRemove.TabIndex = 1;
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // lbEvent
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.lbEvent, 3);
            this.lbEvent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbEvent.FormattingEnabled = true;
            this.lbEvent.ItemHeight = 12;
            this.lbEvent.Location = new System.Drawing.Point(3, 68);
            this.lbEvent.Name = "lbEvent";
            this.lbEvent.Size = new System.Drawing.Size(194, 418);
            this.lbEvent.TabIndex = 2;
            this.lbEvent.SelectedIndexChanged += new System.EventHandler(this.lbEvent_SelectedIndexChanged);
            // 
            // tbxSearchEvent
            // 
            this.tbxSearchEvent.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.SetColumnSpan(this.tbxSearchEvent, 3);
            this.tbxSearchEvent.Location = new System.Drawing.Point(3, 39);
            this.tbxSearchEvent.Name = "tbxSearchEvent";
            this.tbxSearchEvent.Size = new System.Drawing.Size(194, 21);
            this.tbxSearchEvent.TabIndex = 3;
            this.tbxSearchEvent.TextChanged += new System.EventHandler(this.tbxSearchEvent_TextChanged);
            // 
            // btnRefreshEvent
            // 
            this.btnRefreshEvent.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btnRefreshEvent.Image = global::OldVersionEventEditor.Properties.Resources.refresh;
            this.btnRefreshEvent.Location = new System.Drawing.Point(69, 3);
            this.btnRefreshEvent.Name = "btnRefreshEvent";
            this.btnRefreshEvent.Size = new System.Drawing.Size(60, 29);
            this.btnRefreshEvent.TabIndex = 4;
            this.btnRefreshEvent.UseVisualStyleBackColor = true;
            this.btnRefreshEvent.Click += new System.EventHandler(this.btnRefreshEvent_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.ChoicePG);
            this.tabPage2.Controls.Add(this.tableLayoutPanel2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(693, 495);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "选项";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // ChoicePG
            // 
            this.ChoicePG.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ChoicePG.Location = new System.Drawing.Point(203, 3);
            this.ChoicePG.Name = "ChoicePG";
            this.ChoicePG.Size = new System.Drawing.Size(487, 489);
            this.ChoicePG.TabIndex = 3;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.Controls.Add(this.btnAddChoice, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnRemoveChoice, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.lbChoice, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.tbxSearchChoice, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.btnRefreshChoice, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(200, 489);
            this.tableLayoutPanel2.TabIndex = 4;
            // 
            // btnAddChoice
            // 
            this.btnAddChoice.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnAddChoice.Image = global::OldVersionEventEditor.Properties.Resources.add;
            this.btnAddChoice.Location = new System.Drawing.Point(3, 3);
            this.btnAddChoice.Name = "btnAddChoice";
            this.btnAddChoice.Size = new System.Drawing.Size(35, 29);
            this.btnAddChoice.TabIndex = 0;
            this.btnAddChoice.UseVisualStyleBackColor = true;
            this.btnAddChoice.Click += new System.EventHandler(this.btnAddChoice_Click);
            // 
            // btnRemoveChoice
            // 
            this.btnRemoveChoice.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnRemoveChoice.Image = global::OldVersionEventEditor.Properties.Resources.remove;
            this.btnRemoveChoice.Location = new System.Drawing.Point(162, 3);
            this.btnRemoveChoice.Name = "btnRemoveChoice";
            this.btnRemoveChoice.Size = new System.Drawing.Size(35, 29);
            this.btnRemoveChoice.TabIndex = 1;
            this.btnRemoveChoice.UseVisualStyleBackColor = true;
            this.btnRemoveChoice.Click += new System.EventHandler(this.btnRemoveChoice_Click);
            // 
            // lbChoice
            // 
            this.tableLayoutPanel2.SetColumnSpan(this.lbChoice, 3);
            this.lbChoice.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbChoice.FormattingEnabled = true;
            this.lbChoice.ItemHeight = 12;
            this.lbChoice.Location = new System.Drawing.Point(3, 68);
            this.lbChoice.Name = "lbChoice";
            this.lbChoice.Size = new System.Drawing.Size(194, 418);
            this.lbChoice.TabIndex = 2;
            this.lbChoice.SelectedIndexChanged += new System.EventHandler(this.lbChoice_SelectedIndexChanged);
            // 
            // tbxSearchChoice
            // 
            this.tbxSearchChoice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.SetColumnSpan(this.tbxSearchChoice, 3);
            this.tbxSearchChoice.Location = new System.Drawing.Point(3, 39);
            this.tbxSearchChoice.Name = "tbxSearchChoice";
            this.tbxSearchChoice.Size = new System.Drawing.Size(194, 21);
            this.tbxSearchChoice.TabIndex = 3;
            this.tbxSearchChoice.TextChanged += new System.EventHandler(this.tbxSearchChoice_TextChanged);
            // 
            // btnRefreshChoice
            // 
            this.btnRefreshChoice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btnRefreshChoice.Image = global::OldVersionEventEditor.Properties.Resources.refresh;
            this.btnRefreshChoice.Location = new System.Drawing.Point(69, 3);
            this.btnRefreshChoice.Name = "btnRefreshChoice";
            this.btnRefreshChoice.Size = new System.Drawing.Size(60, 29);
            this.btnRefreshChoice.TabIndex = 4;
            this.btnRefreshChoice.UseVisualStyleBackColor = true;
            this.btnRefreshChoice.Click += new System.EventHandler(this.btnRefreshChoice_Click);
            // 
            // Editor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(701, 546);
            this.Controls.Add(this.eventTC);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Editor";
            this.Text = "事件编辑器(支持v2.6.x)";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.eventTC.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 文件ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newTsmi;
        private System.Windows.Forms.ToolStripMenuItem loadTsmi;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem saveTsmi;
        private System.Windows.Forms.ToolStripMenuItem 关于ToolStripMenuItem;
        private System.Windows.Forms.PropertyGrid EventPG;
        private System.Windows.Forms.TabControl eventTC;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnAddEvent;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.PropertyGrid ChoicePG;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button btnAddChoice;
        private System.Windows.Forms.Button btnRemoveChoice;
        private System.Windows.Forms.ListBox lbEvent;
        private System.Windows.Forms.ListBox lbChoice;
        private System.Windows.Forms.TextBox tbxSearchEvent;
        private System.Windows.Forms.TextBox tbxSearchChoice;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Button btnRefreshEvent;
        private System.Windows.Forms.Button btnRefreshChoice;
        private System.Windows.Forms.ToolStripMenuItem 设置ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 语言ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 中文ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 英文ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmiAboutEditor;
        private System.Windows.Forms.ToolStripMenuItem tsmiAboutConfig;
    }
}

