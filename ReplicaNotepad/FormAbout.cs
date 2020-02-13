using System.Windows.Forms;
using System;

namespace ReplicaNotepad
{
    public partial class FormAbout : Form
    {
        public FormAbout()
        {
            InitializeComponent();
        }

        private void FormAbout_Load(object sender, System.EventArgs e)
        {
            this.lblAbout.Text = string.Format(
                "计算机名： {1}{0}操作系统： {2}{0}用户名：{3}{0}系统开机时长：{4}（分钟）",
                Environment.NewLine,
                Environment.MachineName,
                Environment.OSVersion,
                Environment.UserName,
                Environment.TickCount/1000/60
            );
        }
    }
}
