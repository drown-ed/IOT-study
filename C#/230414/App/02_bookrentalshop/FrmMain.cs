using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Tracing;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wf13_bookrentalshop
{
    public partial class FrmMain : Form
    {
        FrmGenre frmGenre = null;   // 책 장르 관리 객체 변수
        #region < 생성자 >

        public FrmMain()
        {
            InitializeComponent();
        }

        #endregion

        #region < 이벤트 핸들러 영역 >

        private void FrmMain_Load(object sender, EventArgs e)
        {
            FrmLogin frm = new FrmLogin();
            frm.ShowDialog();
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit(); // 전체 프로그램 종료!
        }

        private void MniGenre_Click(object sender, EventArgs e)
        {
            //FrmGenre frm = new FrmGenre();
            //frm.TopLevel = false;
            //this.Controls.Add(frm);
            //frm.Show();

            frmGenre = ShowActiveForm(frmGenre, typeof(FrmGenre)) as FrmGenre;
        }

        private void MniBookInfo_Click(object sender, EventArgs e)
        {

        }

        private void MniMember_Click(object sender, EventArgs e)
        {

        }

        private void MniRental_Click(object sender, EventArgs e)
        {

        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        #endregion

        private void FrmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("종료하시겠습니까?", "확인", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                e.Cancel = false;
                Environment.Exit(0);
            }
            else
            {
                e.Cancel = true;
            }
        }

        private void ShowNewForm(Form form)
        {
            if (this.ActiveMdiChild != null)
            {
                ActiveMdiChild.Close();

                //ShowActiveForm(form, Form);
            }
        }

        private Form ShowActiveForm(Form form, Type type)
        {
            if (form == null) // 한 번도 자식창을 열지 않았으면 새로 만들 것
            {
                form = (Form)Activator.CreateInstance(type); // 리플렉션으로 타입에 맞는 창 새로 생성
                form.MdiParent = this; // FrmMain이 MDI 부모
                form.WindowState = FormWindowState.Normal;
                form.Show();
            } else
            {
                if (form.IsDisposed)
                {
                    form = (Form)Activator.CreateInstance(type); // 리플렉션으로 타입에 맞는 창 새로 생성
                    form.MdiParent = this; // FrmMain이 MDI 부모
                    form.WindowState = FormWindowState.Normal;
                    form.Show();
                }
                else
                {
                    form.Activate();
                }
            }
            return form;
        }
    }
}
