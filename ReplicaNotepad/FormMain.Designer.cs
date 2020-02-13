namespace ReplicaNotepad
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tsmiFile = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiNew = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSave = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSaveAs = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiPageSetup = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiPrint = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiExit = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiUndo = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiCut = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiCopy = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiPaste = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiFind = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiReplace = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiGoTo = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiSelectAll = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiTimeDate = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiFormat = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiWordWrap = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiFont = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiView = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiStatusBar = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiBackColor = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.stalblPosition = new System.Windows.Forms.ToolStripStatusLabel();
            this.txtNotepad = new System.Windows.Forms.TextBox();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.Font = new System.Drawing.Font("Microsoft YaHei", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiFile,
            this.tsmiEdit,
            this.tsmiFormat,
            this.tsmiView,
            this.tsmiHelp});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(784, 28);
            this.menuStrip1.TabIndex = 0;
            // 
            // tsmiFile
            // 
            this.tsmiFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiNew,
            this.tsmiOpen,
            this.tsmiSave,
            this.tsmiSaveAs,
            this.toolStripSeparator1,
            this.tsmiPageSetup,
            this.tsmiPrint,
            this.toolStripSeparator2,
            this.tsmiExit});
            this.tsmiFile.Name = "tsmiFile";
            this.tsmiFile.Size = new System.Drawing.Size(66, 24);
            this.tsmiFile.Text = "文件(&F)";
            // 
            // tsmiNew
            // 
            this.tsmiNew.Name = "tsmiNew";
            this.tsmiNew.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.tsmiNew.Size = new System.Drawing.Size(189, 24);
            this.tsmiNew.Text = "新建(&N)";
            this.tsmiNew.Click += new System.EventHandler(this.tsmiNew_Click);
            // 
            // tsmiOpen
            // 
            this.tsmiOpen.Name = "tsmiOpen";
            this.tsmiOpen.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.tsmiOpen.Size = new System.Drawing.Size(189, 24);
            this.tsmiOpen.Text = "打开(&O)...";
            this.tsmiOpen.Click += new System.EventHandler(this.tsmiOpen_Click);
            // 
            // tsmiSave
            // 
            this.tsmiSave.Name = "tsmiSave";
            this.tsmiSave.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.tsmiSave.Size = new System.Drawing.Size(189, 24);
            this.tsmiSave.Text = "保存(&S)";
            this.tsmiSave.Click += new System.EventHandler(this.tsmiSave_Click);
            // 
            // tsmiSaveAs
            // 
            this.tsmiSaveAs.Name = "tsmiSaveAs";
            this.tsmiSaveAs.Size = new System.Drawing.Size(189, 24);
            this.tsmiSaveAs.Text = "另存为(&A)...";
            this.tsmiSaveAs.Click += new System.EventHandler(this.tsmiSaveAs_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(186, 6);
            // 
            // tsmiPageSetup
            // 
            this.tsmiPageSetup.Name = "tsmiPageSetup";
            this.tsmiPageSetup.Size = new System.Drawing.Size(189, 24);
            this.tsmiPageSetup.Text = "页面设置(&U)...";
            this.tsmiPageSetup.Click += new System.EventHandler(this.tsmiPageSetup_Click);
            // 
            // tsmiPrint
            // 
            this.tsmiPrint.Name = "tsmiPrint";
            this.tsmiPrint.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.tsmiPrint.Size = new System.Drawing.Size(189, 24);
            this.tsmiPrint.Text = "打印(&P)...";
            this.tsmiPrint.Click += new System.EventHandler(this.tsmiPrint_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(186, 6);
            // 
            // tsmiExit
            // 
            this.tsmiExit.Name = "tsmiExit";
            this.tsmiExit.Size = new System.Drawing.Size(189, 24);
            this.tsmiExit.Text = "退出(&X)";
            this.tsmiExit.Click += new System.EventHandler(this.tsmiExit_Click);
            // 
            // tsmiEdit
            // 
            this.tsmiEdit.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiUndo,
            this.toolStripSeparator3,
            this.tsmiCut,
            this.tsmiCopy,
            this.tsmiPaste,
            this.tsmiDelete,
            this.toolStripSeparator4,
            this.tsmiFind,
            this.tsmiReplace,
            this.tsmiGoTo,
            this.toolStripSeparator5,
            this.tsmiSelectAll,
            this.tsmiTimeDate});
            this.tsmiEdit.Name = "tsmiEdit";
            this.tsmiEdit.Size = new System.Drawing.Size(67, 24);
            this.tsmiEdit.Text = "编辑(&E)";
            // 
            // tsmiUndo
            // 
            this.tsmiUndo.Name = "tsmiUndo";
            this.tsmiUndo.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.tsmiUndo.Size = new System.Drawing.Size(187, 24);
            this.tsmiUndo.Text = "撤销(&Z)";
            this.tsmiUndo.Click += new System.EventHandler(this.tsmiUndo_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(184, 6);
            // 
            // tsmiCut
            // 
            this.tsmiCut.Name = "tsmiCut";
            this.tsmiCut.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.tsmiCut.Size = new System.Drawing.Size(187, 24);
            this.tsmiCut.Text = "剪切(&T)";
            this.tsmiCut.Click += new System.EventHandler(this.tsmiCut_Click);
            // 
            // tsmiCopy
            // 
            this.tsmiCopy.Name = "tsmiCopy";
            this.tsmiCopy.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.tsmiCopy.Size = new System.Drawing.Size(187, 24);
            this.tsmiCopy.Text = "复制(&C)";
            this.tsmiCopy.Click += new System.EventHandler(this.tsmiCopy_Click);
            // 
            // tsmiPaste
            // 
            this.tsmiPaste.Name = "tsmiPaste";
            this.tsmiPaste.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.tsmiPaste.Size = new System.Drawing.Size(187, 24);
            this.tsmiPaste.Text = "粘贴(&P)";
            this.tsmiPaste.Click += new System.EventHandler(this.tsmiPaste_Click);
            // 
            // tsmiDelete
            // 
            this.tsmiDelete.Name = "tsmiDelete";
            this.tsmiDelete.ShortcutKeys = System.Windows.Forms.Keys.Delete;
            this.tsmiDelete.Size = new System.Drawing.Size(187, 24);
            this.tsmiDelete.Text = "删除(&L)";
            this.tsmiDelete.Click += new System.EventHandler(this.tsmiDelete_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(184, 6);
            // 
            // tsmiFind
            // 
            this.tsmiFind.Name = "tsmiFind";
            this.tsmiFind.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F)));
            this.tsmiFind.Size = new System.Drawing.Size(187, 24);
            this.tsmiFind.Text = "查找(&F)...";
            this.tsmiFind.Click += new System.EventHandler(this.tsmiFind_Click);
            // 
            // tsmiReplace
            // 
            this.tsmiReplace.Name = "tsmiReplace";
            this.tsmiReplace.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.H)));
            this.tsmiReplace.Size = new System.Drawing.Size(187, 24);
            this.tsmiReplace.Text = "替换(&R)...";
            this.tsmiReplace.Click += new System.EventHandler(this.tsmiReplace_Click);
            // 
            // tsmiGoTo
            // 
            this.tsmiGoTo.Name = "tsmiGoTo";
            this.tsmiGoTo.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.G)));
            this.tsmiGoTo.Size = new System.Drawing.Size(187, 24);
            this.tsmiGoTo.Text = "转到(&G)...";
            this.tsmiGoTo.Click += new System.EventHandler(this.tsmiGoTo_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(184, 6);
            // 
            // tsmiSelectAll
            // 
            this.tsmiSelectAll.Name = "tsmiSelectAll";
            this.tsmiSelectAll.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.tsmiSelectAll.Size = new System.Drawing.Size(187, 24);
            this.tsmiSelectAll.Text = "全选(&A)";
            this.tsmiSelectAll.Click += new System.EventHandler(this.tsmiSelectAll_Click);
            // 
            // tsmiTimeDate
            // 
            this.tsmiTimeDate.Name = "tsmiTimeDate";
            this.tsmiTimeDate.ShortcutKeys = System.Windows.Forms.Keys.F5;
            this.tsmiTimeDate.Size = new System.Drawing.Size(187, 24);
            this.tsmiTimeDate.Text = "时间/日期(&D)";
            this.tsmiTimeDate.Click += new System.EventHandler(this.tsmiTimeDate_Click);
            // 
            // tsmiFormat
            // 
            this.tsmiFormat.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiWordWrap,
            this.tsmiFont});
            this.tsmiFormat.Name = "tsmiFormat";
            this.tsmiFormat.Size = new System.Drawing.Size(70, 24);
            this.tsmiFormat.Text = "格式(&O)";
            // 
            // tsmiWordWrap
            // 
            this.tsmiWordWrap.Name = "tsmiWordWrap";
            this.tsmiWordWrap.Size = new System.Drawing.Size(158, 24);
            this.tsmiWordWrap.Text = "自动换行(&W)";
            this.tsmiWordWrap.CheckedChanged += new System.EventHandler(this.tsmiWordWrap_CheckedChanged);
            this.tsmiWordWrap.Click += new System.EventHandler(this.tsmiWordWrap_Click);
            // 
            // tsmiFont
            // 
            this.tsmiFont.Name = "tsmiFont";
            this.tsmiFont.Size = new System.Drawing.Size(158, 24);
            this.tsmiFont.Text = "字体(&F)...";
            this.tsmiFont.Click += new System.EventHandler(this.tsmiFont_Click);
            // 
            // tsmiView
            // 
            this.tsmiView.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiStatusBar,
            this.tsmiBackColor});
            this.tsmiView.Name = "tsmiView";
            this.tsmiView.Size = new System.Drawing.Size(68, 24);
            this.tsmiView.Text = "查看(&V)";
            // 
            // tsmiStatusBar
            // 
            this.tsmiStatusBar.Name = "tsmiStatusBar";
            this.tsmiStatusBar.Size = new System.Drawing.Size(139, 24);
            this.tsmiStatusBar.Text = "状态栏(&S)";
            this.tsmiStatusBar.Click += new System.EventHandler(this.tsmiStatusBar_Click);
            // 
            // tsmiBackColor
            // 
            this.tsmiBackColor.Name = "tsmiBackColor";
            this.tsmiBackColor.Size = new System.Drawing.Size(139, 24);
            this.tsmiBackColor.Text = "背景色(&B)";
            this.tsmiBackColor.Click += new System.EventHandler(this.tsmiBackColor_Click);
            // 
            // tsmiHelp
            // 
            this.tsmiHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiAbout});
            this.tsmiHelp.Name = "tsmiHelp";
            this.tsmiHelp.Size = new System.Drawing.Size(70, 24);
            this.tsmiHelp.Text = "帮助(&H)";
            // 
            // tsmiAbout
            // 
            this.tsmiAbout.Name = "tsmiAbout";
            this.tsmiAbout.Size = new System.Drawing.Size(168, 24);
            this.tsmiAbout.Text = "关于记事本(&A)";
            this.tsmiAbout.Click += new System.EventHandler(this.tsmiAbout_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.Transparent;
            this.statusStrip1.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stalblPosition});
            this.statusStrip1.Location = new System.Drawing.Point(0, 438);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.statusStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.statusStrip1.Size = new System.Drawing.Size(784, 24);
            this.statusStrip1.SizingGrip = false;
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.VisibleChanged += new System.EventHandler(this.statusStrip1_VisibleChanged);
            // 
            // stalblPosition
            // 
            this.stalblPosition.BackColor = System.Drawing.Color.Transparent;
            this.stalblPosition.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.stalblPosition.Name = "stalblPosition";
            this.stalblPosition.Size = new System.Drawing.Size(114, 19);
            this.stalblPosition.Text = "第 1 行 ， 第 1 列";
            // 
            // txtNotepad
            // 
            this.txtNotepad.AllowDrop = true;
            this.txtNotepad.BackColor = System.Drawing.Color.White;
            this.txtNotepad.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtNotepad.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtNotepad.Location = new System.Drawing.Point(0, 28);
            this.txtNotepad.MaxLength = 0;
            this.txtNotepad.Multiline = true;
            this.txtNotepad.Name = "txtNotepad";
            this.txtNotepad.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtNotepad.Size = new System.Drawing.Size(784, 410);
            this.txtNotepad.TabIndex = 2;
            this.txtNotepad.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtNotepad_MouseClick);
            this.txtNotepad.TextChanged += new System.EventHandler(this.txtNotepad_TextChanged);
            this.txtNotepad.DragDrop += new System.Windows.Forms.DragEventHandler(this.txtNotepad_DragDrop);
            this.txtNotepad.DragEnter += new System.Windows.Forms.DragEventHandler(this.txtNotepad_DragEnter);
            this.txtNotepad.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtNotepad_KeyDown);
            // 
            // fontDialog1
            // 
            this.fontDialog1.ShowEffects = false;
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.DefaultExt = "txt";
            this.saveFileDialog1.Filter = "所有文件|*.*";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Filter = "文本文件|*.txt|所有文件|*.*";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(784, 462);
            this.Controls.Add(this.txtNotepad);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "记事本";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMain_FormClosing);
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.TextBox txtNotepad;
        private System.Windows.Forms.ToolStripMenuItem tsmiFile;
        private System.Windows.Forms.ToolStripMenuItem tsmiNew;
        private System.Windows.Forms.ToolStripMenuItem tsmiOpen;
        private System.Windows.Forms.ToolStripMenuItem tsmiSave;
        private System.Windows.Forms.ToolStripMenuItem tsmiSaveAs;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem tsmiPageSetup;
        private System.Windows.Forms.ToolStripMenuItem tsmiPrint;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem tsmiExit;
        private System.Windows.Forms.ToolStripMenuItem tsmiEdit;
        private System.Windows.Forms.ToolStripMenuItem tsmiFormat;
        private System.Windows.Forms.ToolStripMenuItem tsmiView;
        private System.Windows.Forms.ToolStripMenuItem tsmiHelp;
        private System.Windows.Forms.ToolStripMenuItem tsmiUndo;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem tsmiCut;
        private System.Windows.Forms.ToolStripMenuItem tsmiCopy;
        private System.Windows.Forms.ToolStripMenuItem tsmiPaste;
        private System.Windows.Forms.ToolStripMenuItem tsmiDelete;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem tsmiFind;
        private System.Windows.Forms.ToolStripMenuItem tsmiReplace;
        private System.Windows.Forms.ToolStripMenuItem tsmiGoTo;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem tsmiSelectAll;
        private System.Windows.Forms.ToolStripMenuItem tsmiTimeDate;
        private System.Windows.Forms.ToolStripMenuItem tsmiWordWrap;
        private System.Windows.Forms.ToolStripMenuItem tsmiFont;
        private System.Windows.Forms.ToolStripMenuItem tsmiStatusBar;
        private System.Windows.Forms.ToolStripMenuItem tsmiAbout;
        private System.Windows.Forms.ToolStripMenuItem tsmiBackColor;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.ToolStripStatusLabel stalblPosition;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}