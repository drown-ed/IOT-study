namespace _02_login
{
    partial class FrmMain
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.TbID = new System.Windows.Forms.TextBox();
            this.TbPw = new System.Windows.Forms.TextBox();
            this.LbID = new System.Windows.Forms.Label();
            this.LbPW = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.LbloginTxt = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TbID
            // 
            this.TbID.Location = new System.Drawing.Point(101, 38);
            this.TbID.Name = "TbID";
            this.TbID.Size = new System.Drawing.Size(100, 21);
            this.TbID.TabIndex = 1;
            this.TbID.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TbID_KeyDown);
            // 
            // TbPw
            // 
            this.TbPw.Location = new System.Drawing.Point(101, 65);
            this.TbPw.Name = "TbPw";
            this.TbPw.PasswordChar = '●';
            this.TbPw.Size = new System.Drawing.Size(100, 21);
            this.TbPw.TabIndex = 2;
            this.TbPw.UseWaitCursor = true;
            this.TbPw.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TbPw_KeyDown);
            // 
            // LbID
            // 
            this.LbID.AutoSize = true;
            this.LbID.Location = new System.Drawing.Point(45, 42);
            this.LbID.Name = "LbID";
            this.LbID.Size = new System.Drawing.Size(16, 12);
            this.LbID.TabIndex = 2;
            this.LbID.Text = "ID";
            // 
            // LbPW
            // 
            this.LbPW.AutoSize = true;
            this.LbPW.Location = new System.Drawing.Point(45, 69);
            this.LbPW.Name = "LbPW";
            this.LbPW.Size = new System.Drawing.Size(23, 12);
            this.LbPW.TabIndex = 3;
            this.LbPW.Text = "PW";
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(218, 38);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(72, 48);
            this.btnLogin.TabIndex = 3;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            this.btnLogin.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnLogin_KeyDown);
            // 
            // LbloginTxt
            // 
            this.LbloginTxt.AutoSize = true;
            this.LbloginTxt.Location = new System.Drawing.Point(99, 106);
            this.LbloginTxt.Name = "LbloginTxt";
            this.LbloginTxt.Size = new System.Drawing.Size(0, 12);
            this.LbloginTxt.TabIndex = 5;
            this.LbloginTxt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 161);
            this.Controls.Add(this.LbloginTxt);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.LbPW);
            this.Controls.Add(this.LbID);
            this.Controls.Add(this.TbPw);
            this.Controls.Add(this.TbID);
            this.MaximumSize = new System.Drawing.Size(350, 200);
            this.MinimumSize = new System.Drawing.Size(350, 200);
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "로그인";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TbID;
        private System.Windows.Forms.TextBox TbPw;
        private System.Windows.Forms.Label LbID;
        private System.Windows.Forms.Label LbPW;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label LbloginTxt;
    }
}

