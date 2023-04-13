using MySql.Data.MySqlClient;
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
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            Environment.Exit(0); // 가장 완벽하게 프로그램 종료하는 방법
        }

        private void TxtPassword_TextChanged(object sender, EventArgs e)
        {
            
        }

        private bool LoginProcess() {
            if (string.IsNullOrEmpty(TxtId.Text)){
                MessageBox.Show("User ID EMPTY!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (string.IsNullOrEmpty(TxtPassword.Text))
            {
                MessageBox.Show("User Password EMPTY!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            string strUserId = TxtId.Text;
            string strPassword = TxtId.Text;

            try
            {
                string connectionString = "Server=localhost;Port=3306;Database=bookrentalshop;Uid=root;Pwd=1234";

                using(MySqlConnection conn = new MySqlConnection(""))
                {
                    conn.Open();

                    string selQuery = @"SELECT userID, password 
                                            FROM usertbl
                                            WHERE userID = @userID
                                            AND password = @password";

                    MySqlCommand selCmd = new MySqlCommand(selQuery, conn);
                    MySqlParameter prmUserId = new MySqlParameter("@userID", TxtId.Text);
                    MySqlParameter prmPassword = new MySqlParameter("@password", TxtPassword.Text);

                    selCmd.Parameters.Add(prmUserId);
                    selCmd.Parameters.Add(prmPassword);

                    MySqlDataReader reader = selCmd.ExecuteReader();
                    reader.Read();

                    strUserId = reader["userID"]?.ToString();
                    strPassword = reader["password"]?.ToString();
                }

            } catch (Exception ex)
            {
                MessageBox.Show($"비정상적 오류 : {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        private void TxtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                BtnLogin_Click(sender, e);
            }
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {

        }
    }
}
