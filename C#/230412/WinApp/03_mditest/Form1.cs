﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _03_mditest
{
    public partial class Form1 : Form
    {
        FrmChild1 child1 = null;
        FrmChild2 child2 = null;
        public Form1()
        {
            InitializeComponent();
        }

        [Obsolete("OldMethod는 다음 버전에서 폐기됩니다. NewMethod를 이용하세요.")]
        private void OldMethod()
        {
            Console.WriteLine("올드 메서드!");
        }

        private void NewMethod()
        {
            Console.WriteLine(); 
        }

        private void MniForm1_Click(object sender, EventArgs e)
        {
            OldMethod();
            child1 = new FrmChild1();
            child1.TopLevel = false;
            this.Controls.Add(child1);
            child1.Show();
        }

        private void MniForm2_Click(object sender, EventArgs e)
        {
            child2 = new FrmChild2();
            child2.TopLevel = false;
            this.Controls.Add(child2);
            child2.Show();
        }

        private void MniExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MniAbout_Click(object sender, EventArgs e)
        {
            FrmAbout about = new FrmAbout();
            about.ShowDialog();
        }
    }
}
