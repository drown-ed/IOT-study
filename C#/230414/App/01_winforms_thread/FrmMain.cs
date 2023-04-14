using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _01_winforms_thread
{
    public partial class FrmMain : Form
    {
        int number = 0;
        int percent = 0;
        public FrmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            Worker.WorkerReportsProgress = true;
            Worker.WorkerSupportsCancellation = true;
        }

        // 백그라운드로 일 진행 Thread.Start()
        private void Worker_DoWork(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker worker = sender as BackgroundWorker;   // 인자 값으로 BackgroundWorker 생성

            e.Result = Fibonacci((int)e.Argument, worker, e); // fibonacci cal method
        }

        private long Fibonacci(int arg, BackgroundWorker worker, DoWorkEventArgs e)
        {
            if (arg < 0 || arg > 91)
            {
                throw new Exception("오류 0 ~ 91 사이 입력");
            }
            long result = 0;

            if (worker.CancellationPending == true)
            {
                e.Cancel = true;
            }
            else
            {
                if (arg < 2)
                {
                    result = 1;
                }
                else
                {
                    result = Fibonacci(arg - 1, worker, e) + Fibonacci(arg - 2, worker, e);
                }

                int percentComplete = (int)(arg / number * 100);
                if (percentComplete > percent)
                {
                    percent = percentComplete;
                    worker.ReportProgress(percentComplete);
                }
            }
            return result;
        }

        // 백그라운드 스레드 진행 중 프로그래스 표시
        private void Worker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {

        }

        // 백그라운드 스레드 테스크 종료 후 처리
        private void Worker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Error != null)
            {
                MessageBox.Show(e.Error.Message);
            } else if (e.Cancelled)
            {
                LblResult.Text = e.Result.ToString();
            }

            TxtNumber.Text = 0.ToString();
            BtnStart.Enabled = true;
            BtnCancel.Enabled = false;
        }

        private void BtnStart_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            BtnStart.Enabled = false;
            BtnCancel.Enabled = true;

            number = int.Parse(TxtNumber.Text);

            percent = 0;
            PgbCalculator.Value = percent;
            Worker.RunWorkerAsync(number);
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            Worker.CancelAsync();
            BtnCancel.Enabled = false;
            BtnStart.Enabled = true;
        }
    }
}
