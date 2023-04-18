using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.WebRequestMethods;

namespace _01_filecopy
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void btnFindSource_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            var result = dialog.ShowDialog();                       // modal window
            if (result == DialogResult.OK)
            {
                txtSource.Text = dialog.FileName;
            }
        }

        private void btnFindTarget_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            var result = dialog.ShowDialog();                       // modal window
            if (result == DialogResult.OK)
            {
                txtTarget.Text = dialog.FileName;
            }
        }

        // 일반적인 동기식 파일복사
        private void btnSyncCopy_Click(object sender, EventArgs e)
        {
            long totalCopied = CopySync(txtSource.Text, txtTarget.Text);
        }

        private long CopySync(string fromFile, string toFile)
        {
            btnAsynCopy.Enabled = false; // 비동기버튼 일시 비활성화
            long totalCopied = 0;

            using(FileStream fromStream = new FileStream(fromFile, FileMode.Open))
            {       // 원본 파일 열고
                using(FileStream toStream = new FileStream(toFile, FileMode.Create))
                {   // 타겟 파일 생성
                    byte[] buffer = new byte[1024 * 1024]; // 1MByte Buffer
                    int nRead = 0;
                    while((nRead = fromStream.Read(buffer, 0, buffer.Length)) != 0) 
                    {
                        toStream.Write(buffer, 0, nRead);
                        totalCopied += nRead;

                        // progress bar
                        PgdCopy.Value = (int)((double)totalCopied / (double)fromStream.Length) * PgdCopy.Maximum;
                    }
                }
            }

            btnAsynCopy.Enabled = true;
            return totalCopied;
        }

        private async Task<long> CopyASync(string fromFile, string toFile)
        {
            btnSyncCopy.Enabled = false; // 동기복사 버튼 비활성화
            long totalCopied = 0;

            using (FileStream fromStream = new FileStream(fromFile, FileMode.Open))
            {       // 원본 파일 열고
                using (FileStream toStream = new FileStream(toFile, FileMode.Create))
                {   // 타겟 파일 생성
                    byte[] buffer = new byte[1024 * 1024]; // 1MByte Buffer
                    int nRead = 0;
                    while ((nRead = await fromStream.ReadAsync(buffer, 0, buffer.Length)) != 0)
                    {
                        await toStream.WriteAsync(buffer, 0, nRead);
                        totalCopied += nRead;

                        // progress bar
                        PgdCopy.Value = (int)((double)totalCopied / (double)fromStream.Length) * PgdCopy.Maximum;
                    }
                }
            }

            btnAsynCopy.Enabled = true;
            return totalCopied;
        }

        private async void btnAsynCopy_Click(object sender, EventArgs e)
        {
            long totalCopied = await CopyASync(txtSource.Text, txtTarget.Text);
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {

        }
    }
}
