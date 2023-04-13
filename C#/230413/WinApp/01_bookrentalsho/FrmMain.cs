using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _01_bookrentalsho
{

    public partial class FrmMain : Form
    {

        #region < 생성자 >

        public FrmMain()
        {
            InitializeComponent();
        }

        #endregion


        #region < event handler area >

        private void FrmMain_Load(object sender, EventArgs e)
        {
            FrmLogin frm = new FrmLogin();
            frm.ShowDialog();
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MniGenre_Click(object sender, EventArgs e)
        {

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


    }
}
