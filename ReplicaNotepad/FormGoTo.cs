using System;
using System.Windows.Forms;

namespace ReplicaNotepad
{
    public partial class FormGoTo : Form
    {
        private int lineNum;
        private int lineNumMax;

        /// <summary>
        /// 跳转行号（只写）
        /// </summary>
        public int LineNum
        {
            get { return lineNum; }
        }

        /// <summary>
        /// 当前文本最大行行号（只读）
        /// </summary>
        public int LineNumMax
        {
            set { lineNumMax = value; }
        }

        public FormGoTo()
        {
            InitializeComponent();
        }

        private void btnGoTo_Click(object sender, EventArgs e)
        {
            int lineNumValue = Convert.ToInt32(this.numLineNum.Value);
            if (lineNumValue <= lineNumMax)
            {
                this.lineNum = lineNumValue;
            }
            else
            {
                MessageBox.Show("行数超过了总行数。", "跳行", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.DialogResult = DialogResult.None;
            }
        }
    }
}
