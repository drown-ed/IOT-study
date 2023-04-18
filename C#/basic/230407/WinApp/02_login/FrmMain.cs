using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _02_login
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if ((TbID.Text == "abcd") & (TbPw.Text == "1234"))
            {
                LbloginTxt.Text = "로그인에 성공했습니다.";
            }
            else if ((TbID.Text != "abcd")) 
            {
                LbloginTxt.Text = "등록되지 않은 아이디입니다.";
            }
            else if ((TbID.Text == "abcd") & (TbPw.Text != "1234"))
            {
                LbloginTxt.Text = "비밀번호를 확인해주세요.";
            }
            TbID.Text = "";
            TbPw.Text = "";
        }

        private void btnLogin_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                btnLogin_Click(sender, e);
            }
        }

        private void TbPw_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnLogin_Click(sender, e);
            }
        }

        private void TbID_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnLogin_Click(sender, e);
            }
        }
    }
}
