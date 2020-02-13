using System;
using System.Windows.Forms;

namespace ReplicaNotepad
{
    public partial class FormReplace : Form
    {
        private FormMain frmMain;
        private TextBox frmMainTxt;

        public FormReplace()
        {
            InitializeComponent();
        }

        private void FormReplace_Load(object sender, EventArgs e)
        {
            frmMain = this.Owner as FormMain;
            frmMainTxt = frmMain.Controls["txtNotepad"] as TextBox;
        }

        private void btnFindNext_Click(object sender, EventArgs e)
        {
            if (this.txtSource.TextLength > 0)
            {
                int matchIndex = FindNext(frmMainTxt);
                if (matchIndex != -1)
                {
                    frmMainTxt.Select(matchIndex, this.txtSource.TextLength);
                    frmMain.Activate();
                }
                else
                {
                    NotFoundShow(this.txtSource.Text);
                }
            }
        }

        private void btnReplace_Click(object sender, EventArgs e)
        {
            if (this.txtSource.TextLength > 0)
            {
                string sourceText = this.txtSource.Text;

                if (frmMainTxt.SelectionStart > 0)
                {
                    // 此处代码的原因是，当每次替换之后，程序会查找下一个符合项，然后将其选中。
                    // 这时，光标将跑到被选中的文本末端，也就是说，再次替换时，会忽略掉这个被选中应该替换掉的文本。
                    int diff = frmMainTxt.SelectionStart - sourceText.Length;
                    frmMainTxt.SelectionStart = diff > 0 ? diff : 0;
                }

                // 先进行一次查找，然后定位需要替换的文本段
                int matchIndex = FindNext(frmMainTxt);
                if (matchIndex != -1)
                {
                    string beforeReplace = frmMainTxt.Text.Substring(0, matchIndex);
                    string toReplace = frmMainTxt.Text.Substring(matchIndex, sourceText.Length); // 需要替换的部分
                    string afterReplace = frmMainTxt.Text.Substring(matchIndex + sourceText.Length);

                    // 如果不区分大小写
                    // 则将查找内容和原始文本都转成小写进行替换操作
                    if (!this.chkCase.Checked)
                    {
                        toReplace = toReplace.ToLower();
                        sourceText = sourceText.ToLower();
                    }

                    frmMainTxt.Text = beforeReplace + toReplace.Replace(sourceText, this.txtTarget.Text) + afterReplace;
                    
                    // 重新执行一次查找, 得到下一个替换项
                    frmMainTxt.SelectionStart = matchIndex + this.txtTarget.TextLength; //执行之前先将光标设置到已找过的文本之后，否则光标将跑到文本起始处
                    int matchIndex2 = FindNext(frmMainTxt);
                    if (matchIndex2 != -1)
                    {
                        frmMainTxt.Select(matchIndex2, sourceText.Length);
                        frmMain.Activate();
                    }
                }
                else
                {
                    NotFoundShow(this.txtSource.Text);
                }
            }
        }

        private void btnReplaceAll_Click(object sender, EventArgs e)
        {
            if (this.txtSource.TextLength > 0)
            {
                string newText = frmMainTxt.Text.Replace(this.txtSource.Text, this.txtTarget.Text);
                // 没有采取直接对Text属性赋值的做法是因为那样产生的界面效果会在赋值完后将文本全选中
                // 采取Append方法不会造成全选效果
                frmMainTxt.Clear();
                frmMainTxt.AppendText(newText);
                frmMain.Activate();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void NotFoundShow(string searchKey)
        {
            MessageBox.Show(string.Format("找不到\"{0}\"", searchKey), "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private int FindNext(TextBox txt)
        {
            // 查找行为的起始位置
            int searchStartIndex = txt.SelectionStart + txt.SelectionLength;
            // 将文本框光标设置到下一个匹配到的首字符位置
            return txt.Text.IndexOf(
                this.txtSource.Text,
                searchStartIndex,
                this.chkCase.Checked ? StringComparison.CurrentCulture : StringComparison.CurrentCultureIgnoreCase
            );
        }
    }
}
