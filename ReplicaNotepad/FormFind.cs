using System;
using System.Windows.Forms;

namespace ReplicaNotepad
{
    public partial class FormFind : Form
    {
        public FormFind()
        {
            InitializeComponent();
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            if (this.txtFind.TextLength > 0)
            {
                FormMain frm = this.Owner as FormMain;
                TextBox txt = frm.Controls["txtNotepad"] as TextBox;

                int matchIndex = this.chkUp.Checked ? FindPrevious(txt) : FindNext(txt);
                if (matchIndex != -1)
                {
                    txt.Select(matchIndex, this.txtFind.TextLength);
                    frm.Activate();
                }
                else
                {
                    NotFoundShow(this.txtFind.Text);
                }
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
                this.txtFind.Text,
                searchStartIndex,
                this.chkCase.Checked ? StringComparison.CurrentCulture : StringComparison.CurrentCultureIgnoreCase
            );
        }

        private int FindPrevious(TextBox txt)
        {
            // 将文本框光标设置到下一个匹配到的首字符位置
            return txt.Text
                .LastIndexOf(
                    this.txtFind.Text,
                    txt.SelectionStart - 1,
                    this.chkCase.Checked ? StringComparison.CurrentCulture : StringComparison.CurrentCultureIgnoreCase
                );
        }
    }
}
