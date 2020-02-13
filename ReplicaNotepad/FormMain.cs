using System;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace ReplicaNotepad
{
    public partial class FormMain : Form
    {
        private FormFind frmFind;
        private FormReplace frmReplace;
        private Settings settings;
        private string textToPrint; // 在处理多页打印时，需要用到一个字段来控制逻辑
        private PrintDocument printDoc;
        private string currFileName;
        private bool hasChanged = false;

        public FormMain()
        {
            InitializeComponent();
            settings = new Settings();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            try
            {
                this.Location = new Point(settings.PositionLeft, settings.PositionTop);
                this.Width = settings.StartWidth;
                this.Height = settings.StartHeight;
                this.tsmiWordWrap.Checked = this.txtNotepad.WordWrap = settings.WordWrap;
                this.txtNotepad.Font = settings.Font;
                this.tsmiStatusBar.Checked = settings.StatusBarVisible;
                // 当未勾选自动换行并且勾选状态栏时才显示状态栏
                this.statusStrip1.Visible = !this.tsmiWordWrap.Checked && this.tsmiStatusBar.Checked;
                this.txtNotepad.BackColor = settings.BackColor;

                string[] args = Environment.GetCommandLineArgs();
                if (args.Length > 1)
                {
                    this.currFileName = args[1];
                    this.Text = this.currFileName.Substring(this.currFileName.LastIndexOf('\\') + 1);
                    ReadText();

                    this.txtNotepad.SelectionStart = 0;
                    this.hasChanged = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "记事本", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                if (hasChanged)
                {
                    switch (NotifySave())
                    {
                        case System.Windows.Forms.DialogResult.Yes:
                            Save();
                            break;
                        case System.Windows.Forms.DialogResult.No:
                            break;
                        case System.Windows.Forms.DialogResult.Cancel:
                            e.Cancel = true;    // 不执行关闭操作了
                            return;
                        default:
                            break;
                    }
                }

                settings.Set("PositionLeft", this.Location.X.ToString());
                settings.Set("PositionTop", this.Location.Y.ToString());
                settings.Set("StartWidth", this.Width.ToString());
                settings.Set("StartHeight", this.Height.ToString());
                settings.Set("WordWrap", this.tsmiWordWrap.Checked ? "1" : "0");
                settings.Set("StatusBarVisible", this.tsmiStatusBar.Checked ? "1" : "0");
                settings.Set("FontName", this.txtNotepad.Font.Name);
                settings.Set("FontStyle", this.txtNotepad.Font.Style.ToString());
                settings.Set("FontSize", Convert.ToInt32(this.txtNotepad.Font.Size).ToString());
                settings.Set("BackColor", ColorTranslator.ToHtml(this.txtNotepad.BackColor));
            }
            catch { }
        }

        #region Menu Event

        #region Menu File

        private void tsmiNew_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.hasChanged)
                {
                    switch (NotifySave())
                    {
                        case System.Windows.Forms.DialogResult.Yes:
                            Save();
                            break;
                        case System.Windows.Forms.DialogResult.No:
                            break;
                        case System.Windows.Forms.DialogResult.Cancel:
                            return; // 不执行“新建”操作了
                        default:
                            break;
                    }
                }

                this.currFileName = null;
                this.txtNotepad.Clear();
                this.txtNotepad.ClearUndo();
                this.hasChanged = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "记事本", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tsmiOpen_Click(object sender, EventArgs e)
        {
            try
            {
                this.openFileDialog1.FileName = null;
                if (this.openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    this.currFileName = this.openFileDialog1.FileName;
                    this.Text = this.currFileName.Substring(this.currFileName.LastIndexOf('\\') + 1);
                    ReadText();
                    this.hasChanged = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "记事本", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tsmiSave_Click(object sender, EventArgs e)
        {
            try
            {
                Save();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "记事本", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tsmiSaveAs_Click(object sender, EventArgs e)
        {
            try
            {
                SaveAs();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "记事本", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tsmiPageSetup_Click(object sender, EventArgs e)
        {
            try
            {
                if (printDoc == null)
                {
                    printDoc = new PrintDocument();
                }

                PageSetupDialog psd = new PageSetupDialog();
                psd.Document = printDoc;
                psd.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "记事本", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tsmiPrint_Click(object sender, EventArgs e)
        {
            try
            {
                if (printDoc == null)
                {
                    printDoc = new PrintDocument();
                }

                printDoc.PrintPage += new PrintPageEventHandler(TextBox_PrintPage);
                printDoc.OriginAtMargins = true;

                PrintDialog pd = new PrintDialog();
                pd.Document = printDoc;
                if (pd.ShowDialog() == DialogResult.OK)
                {
                    this.textToPrint = this.txtNotepad.Text;
                    printDoc.Print();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "记事本", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tsmiExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        #endregion

        #region Menu Edit

        private void tsmiUndo_Click(object sender, EventArgs e)
        {
            this.txtNotepad.Undo();
        }

        private void tsmiCut_Click(object sender, EventArgs e)
        {
            if (this.txtNotepad.SelectionLength > 0)
            {
                this.txtNotepad.Cut();
            }
        }

        private void tsmiCopy_Click(object sender, EventArgs e)
        {
            if (this.txtNotepad.SelectionLength > 0)
            {
                this.txtNotepad.Copy();
            }
        }

        private void tsmiPaste_Click(object sender, EventArgs e)
        {
            this.txtNotepad.Paste();
        }

        private void tsmiDelete_Click(object sender, EventArgs e)
        {
            if (this.txtNotepad.SelectionLength > 0)
            {
                int start = 0;
                int selectStart = this.txtNotepad.SelectionStart;
                int selectEnd = this.txtNotepad.SelectionStart + this.txtNotepad.SelectionLength;
                int end = this.txtNotepad.TextLength;
                this.txtNotepad.Text =
                    this.txtNotepad.Text.Substring(start, selectStart) // 保留所选文本之前的部分
                    + this.txtNotepad.Text.Substring(selectEnd, end - selectEnd);  // 保留所选文本之后的部分
            }
        }

        private void tsmiFind_Click(object sender, EventArgs e)
        {
            if (frmReplace == null || frmReplace.IsDisposed)
            {
                if (frmFind == null || frmFind.IsDisposed)
                {
                    frmFind = new FormFind();
                    frmFind.Show(this);
                }
                else
                {
                    frmFind.BringToFront();
                }
            }
        }

        private void tsmiReplace_Click(object sender, EventArgs e)
        {
            if (frmFind == null || frmFind.IsDisposed)
            {
                if (frmReplace == null || frmReplace.IsDisposed)
                {
                    frmReplace = new FormReplace();
                    frmReplace.Show(this);
                }
                else
                {
                    frmReplace.BringToFront();
                }
            }
        }

        private void tsmiGoTo_Click(object sender, EventArgs e)
        {
            if (this.txtNotepad.TextLength > 0)
            {
                FormGoTo frm = new FormGoTo();
                frm.LineNumMax = this.txtNotepad.Lines.Length;
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    this.txtNotepad.SelectionStart = this.txtNotepad.GetFirstCharIndexFromLine(frm.LineNum - 1);
                    this.txtNotepad.ScrollToCaret();
                }
            }
        }

        private void tsmiSelectAll_Click(object sender, EventArgs e)
        {
            this.txtNotepad.SelectAll();
        }

        private void tsmiTimeDate_Click(object sender, EventArgs e)
        {
            // 和Notepad一样，输出 "时:分 年/月/日"
            this.txtNotepad.AppendText(
                string.Format("{0}:{1} {2}",
                    DateTime.Now.Hour.ToString().PadLeft(2, '0'),
                    DateTime.Now.Minute.ToString().PadLeft(2, '0'),
                    DateTime.Now.ToShortDateString()
                )
            );
        }

        #endregion

        #region Menu Format

        private void tsmiWordWrap_Click(object sender, EventArgs e)
        {
            // 切换自动换行的选中状态
            this.tsmiWordWrap.Checked ^= true;
        }

        private void tsmiWordWrap_CheckedChanged(object sender, EventArgs e)
        {
            // 设置文本框是否自动换行
            this.txtNotepad.WordWrap = this.tsmiWordWrap.Checked;

            // 当启动自动换行时，隐藏状态栏，禁用状态栏可见性菜单，禁用跳转菜单。
            this.statusStrip1.Visible = this.tsmiWordWrap.Checked ? false : this.tsmiStatusBar.Checked;
            this.tsmiStatusBar.Enabled = this.tsmiGoTo.Enabled = !this.tsmiWordWrap.Checked;
        }

        private void tsmiFont_Click(object sender, EventArgs e)
        {
            this.fontDialog1.Font = this.txtNotepad.Font;
            if (this.fontDialog1.ShowDialog() == DialogResult.OK)
            {
                this.txtNotepad.Font = this.fontDialog1.Font;
            }
        }

        #endregion

        #region Menu View

        private void tsmiStatusBar_Click(object sender, EventArgs e)
        {
            this.tsmiStatusBar.Checked ^= true;
            this.statusStrip1.Visible = this.tsmiStatusBar.Checked;
        }

        private void tsmiBackColor_Click(object sender, EventArgs e)
        {
            this.colorDialog1.Color = this.txtNotepad.BackColor;
            if (this.colorDialog1.ShowDialog() == DialogResult.OK)
            {
                this.txtNotepad.BackColor = this.colorDialog1.Color;
            }
        }

        #endregion

        #region Menu Help

        private void tsmiAbout_Click(object sender, EventArgs e)
        {
            FormAbout frm = new FormAbout();
            frm.ShowDialog();
        }

        #endregion

        #endregion

        #region 实时更新当前光标位置信息（状态栏显示信息）

        private void txtNotepad_MouseClick(object sender, MouseEventArgs e)
        {
            UpdateStatusBar();
        }

        private void txtNotepad_KeyDown(object sender, KeyEventArgs e)
        {
            UpdateStatusBar();
        }

        private void statusStrip1_VisibleChanged(object sender, EventArgs e)
        {
            UpdateStatusBar();
        }

        private void UpdateStatusBar()
        {
            if (this.statusStrip1.Visible)
            {
                int rowIndex = this.txtNotepad.GetLineFromCharIndex(this.txtNotepad.SelectionStart);
                int colIndex = this.txtNotepad.SelectionStart - this.txtNotepad.GetFirstCharIndexOfCurrentLine();
                this.stalblPosition.Text = string.Format("第 {0} 行 ， 第 {1} 列", rowIndex + 1, colIndex + 1);
            }
        }

        #endregion

        // 自定义打印事件
        private void TextBox_PrintPage(object sender, PrintPageEventArgs e)
        {
            int chars = 0;
            int lines = 0;
            Rectangle rec = new Rectangle(Point.Empty, e.MarginBounds.Size);

            e.Graphics.MeasureString(this.textToPrint, this.txtNotepad.Font, rec.Size, StringFormat.GenericTypographic, out chars, out lines);
            e.Graphics.DrawString(this.textToPrint, this.txtNotepad.Font, Brushes.Black, rec, StringFormat.GenericTypographic);

            this.textToPrint = this.textToPrint.Substring(chars);
            e.HasMorePages = (this.textToPrint.Length > 0);
        }

        private void txtNotepad_TextChanged(object sender, EventArgs e)
        {
            hasChanged = true;
        }

        private void ReadText()
        {
            using (StreamReader sr = new StreamReader(this.currFileName, Encoding.Default))    // Default 可以进行“智能”侦测
            {
                this.txtNotepad.Clear();
                this.txtNotepad.AppendText(sr.ReadToEnd().Replace("\0", ""));
                /* 添加Replace("\0", "")是为了解决：
                 * 当读取一段来自网页的文本时，可能会遇到包含'\0'字符的内容。
                 * 如果不做处理，那么最终返回给程序的将只有从开头到'\0'以前部分的字符串
                 * 所以需要替换掉'\0'，这样最终界面上文本框显示的才是全部的内容。
                 */
            }
        }

        private void Save()
        {
            if (string.IsNullOrEmpty(this.currFileName))
            {
                SaveAs();
            }
            else
            {
                using (StreamWriter sw = new StreamWriter(this.currFileName, false, Encoding.UTF8)) // 自带的保存对话框没有编码选项
                {
                    sw.Write(this.txtNotepad.Text);
                }

                this.hasChanged = false;
            }
        }

        private void SaveAs()
        {
            if (!string.IsNullOrEmpty(this.currFileName))
            {
                this.saveFileDialog1.FileName = this.currFileName.Substring(this.currFileName.LastIndexOf('\\') + 1);
            }

            if (this.saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                this.currFileName = this.saveFileDialog1.FileName;
                using (StreamWriter sw = new StreamWriter(this.saveFileDialog1.FileName, false, Encoding.UTF8)) // 自带的保存对话框没有编码选项
                {
                    sw.Write(this.txtNotepad.Text);
                }

                this.hasChanged = false;
            }
        }

        // 通知保存
        private DialogResult NotifySave()
        {
            string fileNameToSave = string.IsNullOrEmpty(this.currFileName)
                                   ? "文件"
                                   : "\"" + this.currFileName.Substring(this.currFileName.LastIndexOf('\\') + 1) + "\"";
            string text = string.Format("是否将更改保存到{0}？", fileNameToSave);
            string caption = "记事本";

            return MessageBox.Show(text, caption, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Asterisk);
        }

        private void txtNotepad_DragDrop(object sender, DragEventArgs e)
        {
            if (hasChanged)
            {
                switch (NotifySave())
                {
                    case System.Windows.Forms.DialogResult.Yes:
                        Save();
                        break;
                    case System.Windows.Forms.DialogResult.No:
                        break;
                    case System.Windows.Forms.DialogResult.Cancel:
                        return;
                    default:
                        break;
                }
            }

            this.currFileName = ((string[])e.Data.GetData(DataFormats.FileDrop))[0];
            ReadText();
            this.hasChanged = false;
        }

        private void txtNotepad_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop, false))
            {
                e.Effect = DragDropEffects.All;
            }
        }
    }
}
