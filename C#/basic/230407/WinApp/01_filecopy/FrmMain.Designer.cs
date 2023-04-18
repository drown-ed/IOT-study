namespace _01_filecopy
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
            this.lbSource = new System.Windows.Forms.Label();
            this.txtSource = new System.Windows.Forms.TextBox();
            this.btnFindSource = new System.Windows.Forms.Button();
            this.lbtarget = new System.Windows.Forms.Label();
            this.txtTarget = new System.Windows.Forms.TextBox();
            this.btnFindTarget = new System.Windows.Forms.Button();
            this.btnAsynCopy = new System.Windows.Forms.Button();
            this.btnSyncCopy = new System.Windows.Forms.Button();
            this.PgdCopy = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // lbSource
            // 
            this.lbSource.AutoSize = true;
            this.lbSource.Location = new System.Drawing.Point(12, 30);
            this.lbSource.Name = "lbSource";
            this.lbSource.Size = new System.Drawing.Size(53, 12);
            this.lbSource.TabIndex = 0;
            this.lbSource.Text = "Source :";
            // 
            // txtSource
            // 
            this.txtSource.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtSource.Location = new System.Drawing.Point(71, 26);
            this.txtSource.Name = "txtSource";
            this.txtSource.ReadOnly = true;
            this.txtSource.Size = new System.Drawing.Size(253, 21);
            this.txtSource.TabIndex = 1;
            this.txtSource.TabStop = false;
            // 
            // btnFindSource
            // 
            this.btnFindSource.Location = new System.Drawing.Point(330, 25);
            this.btnFindSource.Name = "btnFindSource";
            this.btnFindSource.Size = new System.Drawing.Size(31, 23);
            this.btnFindSource.TabIndex = 2;
            this.btnFindSource.Text = "…";
            this.btnFindSource.UseVisualStyleBackColor = true;
            this.btnFindSource.Click += new System.EventHandler(this.btnFindSource_Click);
            // 
            // lbtarget
            // 
            this.lbtarget.AutoSize = true;
            this.lbtarget.Location = new System.Drawing.Point(16, 63);
            this.lbtarget.Name = "lbtarget";
            this.lbtarget.Size = new System.Drawing.Size(49, 12);
            this.lbtarget.TabIndex = 3;
            this.lbtarget.Text = "Target :";
            this.lbtarget.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtTarget
            // 
            this.txtTarget.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtTarget.Location = new System.Drawing.Point(71, 59);
            this.txtTarget.Name = "txtTarget";
            this.txtTarget.ReadOnly = true;
            this.txtTarget.Size = new System.Drawing.Size(253, 21);
            this.txtTarget.TabIndex = 3;
            this.txtTarget.TabStop = false;
            // 
            // btnFindTarget
            // 
            this.btnFindTarget.Location = new System.Drawing.Point(330, 58);
            this.btnFindTarget.Name = "btnFindTarget";
            this.btnFindTarget.Size = new System.Drawing.Size(31, 23);
            this.btnFindTarget.TabIndex = 4;
            this.btnFindTarget.Text = "…";
            this.btnFindTarget.UseVisualStyleBackColor = true;
            this.btnFindTarget.Click += new System.EventHandler(this.btnFindTarget_Click);
            // 
            // btnAsynCopy
            // 
            this.btnAsynCopy.Location = new System.Drawing.Point(43, 96);
            this.btnAsynCopy.Name = "btnAsynCopy";
            this.btnAsynCopy.Size = new System.Drawing.Size(109, 23);
            this.btnAsynCopy.TabIndex = 5;
            this.btnAsynCopy.Text = "ASyncCopy";
            this.btnAsynCopy.UseVisualStyleBackColor = true;
            this.btnAsynCopy.Click += new System.EventHandler(this.btnAsynCopy_Click);
            // 
            // btnSyncCopy
            // 
            this.btnSyncCopy.Location = new System.Drawing.Point(229, 96);
            this.btnSyncCopy.Name = "btnSyncCopy";
            this.btnSyncCopy.Size = new System.Drawing.Size(109, 23);
            this.btnSyncCopy.TabIndex = 6;
            this.btnSyncCopy.Text = "Sync Copy";
            this.btnSyncCopy.UseVisualStyleBackColor = true;
            this.btnSyncCopy.Click += new System.EventHandler(this.btnSyncCopy_Click);
            // 
            // PgdCopy
            // 
            this.PgdCopy.Location = new System.Drawing.Point(14, 128);
            this.PgdCopy.Name = "PgdCopy";
            this.PgdCopy.Size = new System.Drawing.Size(347, 23);
            this.PgdCopy.TabIndex = 7;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(376, 179);
            this.Controls.Add(this.PgdCopy);
            this.Controls.Add(this.btnSyncCopy);
            this.Controls.Add(this.btnAsynCopy);
            this.Controls.Add(this.btnFindTarget);
            this.Controls.Add(this.txtTarget);
            this.Controls.Add(this.lbtarget);
            this.Controls.Add(this.btnFindSource);
            this.Controls.Add(this.txtSource);
            this.Controls.Add(this.lbSource);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MinimizeBox = false;
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Async File Copy";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbSource;
        private System.Windows.Forms.TextBox txtSource;
        private System.Windows.Forms.Button btnFindSource;
        private System.Windows.Forms.Label lbtarget;
        private System.Windows.Forms.TextBox txtTarget;
        private System.Windows.Forms.Button btnFindTarget;
        private System.Windows.Forms.Button btnAsynCopy;
        private System.Windows.Forms.Button btnSyncCopy;
        private System.Windows.Forms.ProgressBar PgdCopy;
    }
}

