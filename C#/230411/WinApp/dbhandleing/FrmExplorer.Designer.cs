﻿namespace wf07_myexplorer
{
    partial class FrmExplorer
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmExplorer));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.TrvDrive = new System.Windows.Forms.TreeView();
            this.ImgSmallIcon = new System.Windows.Forms.ImageList(this.components);
            this.LblPath = new System.Windows.Forms.Label();
            this.CboView = new System.Windows.Forms.ComboBox();
            this.TxtPath = new System.Windows.Forms.TextBox();
            this.LsvFolder = new System.Windows.Forms.ListView();
            this.ImgLargeIcon = new System.Windows.Forms.ImageList(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.TrvDrive);
            this.splitContainer1.Panel1.Controls.Add(this.LblPath);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.CboView);
            this.splitContainer1.Panel2.Controls.Add(this.TxtPath);
            this.splitContainer1.Panel2.Controls.Add(this.LsvFolder);
            this.splitContainer1.Panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel2_Paint);
            this.splitContainer1.Size = new System.Drawing.Size(686, 450);
            this.splitContainer1.SplitterDistance = 228;
            this.splitContainer1.TabIndex = 0;
            // 
            // TrvDrive
            // 
            this.TrvDrive.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TrvDrive.ImageIndex = 0;
            this.TrvDrive.ImageList = this.ImgSmallIcon;
            this.TrvDrive.Location = new System.Drawing.Point(13, 35);
            this.TrvDrive.Name = "TrvDrive";
            this.TrvDrive.SelectedImageIndex = 0;
            this.TrvDrive.Size = new System.Drawing.Size(202, 403);
            this.TrvDrive.TabIndex = 1;
            this.TrvDrive.BeforeExpand += new System.Windows.Forms.TreeViewCancelEventHandler(this.TrvDrive_BeforeExpand);
            this.TrvDrive.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.TrvDrive_NodeMouseClick);
            // 
            // ImgSmallIcon
            // 
            this.ImgSmallIcon.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ImgSmallIcon.ImageStream")));
            this.ImgSmallIcon.TransparentColor = System.Drawing.Color.Transparent;
            this.ImgSmallIcon.Images.SetKeyName(0, "hard-drive.png");
            this.ImgSmallIcon.Images.SetKeyName(1, "folder-normal.png");
            this.ImgSmallIcon.Images.SetKeyName(2, "folder-open.png");
            this.ImgSmallIcon.Images.SetKeyName(3, "file-exe.png");
            this.ImgSmallIcon.Images.SetKeyName(4, "file-normal.png");
            this.ImgSmallIcon.Images.SetKeyName(5, "file-img.png");
            // 
            // LblPath
            // 
            this.LblPath.AutoSize = true;
            this.LblPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.LblPath.Location = new System.Drawing.Point(12, 13);
            this.LblPath.Name = "LblPath";
            this.LblPath.Size = new System.Drawing.Size(49, 15);
            this.LblPath.TabIndex = 0;
            this.LblPath.Text = "LblPath";
            // 
            // CboView
            // 
            this.CboView.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CboView.FormattingEnabled = true;
            this.CboView.Items.AddRange(new object[] {
            "View.Details",
            "View.SmallIcon",
            "View.LargeIcon",
            "View.List",
            "View.Tile"});
            this.CboView.Location = new System.Drawing.Point(321, 13);
            this.CboView.Name = "CboView";
            this.CboView.Size = new System.Drawing.Size(121, 20);
            this.CboView.TabIndex = 2;
            this.CboView.SelectedIndexChanged += new System.EventHandler(this.CboView_SelectedIndexChanged);
            // 
            // TxtPath
            // 
            this.TxtPath.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtPath.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtPath.Location = new System.Drawing.Point(12, 13);
            this.TxtPath.Name = "TxtPath";
            this.TxtPath.Size = new System.Drawing.Size(303, 22);
            this.TxtPath.TabIndex = 1;
            this.TxtPath.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtPath_KeyPress);
            // 
            // LsvFolder
            // 
            this.LsvFolder.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LsvFolder.HideSelection = false;
            this.LsvFolder.LargeImageList = this.ImgLargeIcon;
            this.LsvFolder.Location = new System.Drawing.Point(12, 35);
            this.LsvFolder.Name = "LsvFolder";
            this.LsvFolder.Size = new System.Drawing.Size(430, 403);
            this.LsvFolder.SmallImageList = this.ImgSmallIcon;
            this.LsvFolder.TabIndex = 0;
            this.LsvFolder.UseCompatibleStateImageBehavior = false;
            // 
            // ImgLargeIcon
            // 
            this.ImgLargeIcon.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ImgLargeIcon.ImageStream")));
            this.ImgLargeIcon.TransparentColor = System.Drawing.Color.Transparent;
            this.ImgLargeIcon.Images.SetKeyName(0, "hard-drive.png");
            this.ImgLargeIcon.Images.SetKeyName(1, "folder-normal.png");
            this.ImgLargeIcon.Images.SetKeyName(2, "folder-open.png");
            this.ImgLargeIcon.Images.SetKeyName(3, "file-exe.png");
            this.ImgLargeIcon.Images.SetKeyName(4, "file-normal.png");
            this.ImgLargeIcon.Images.SetKeyName(5, "file-img.png");
            // 
            // FrmExplorer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 450);
            this.Controls.Add(this.splitContainer1);
            this.Font = new System.Drawing.Font("나눔고딕코딩", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmExplorer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "나의 탐색기 ver1.0";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TreeView TrvDrive;
        private System.Windows.Forms.Label LblPath;
        private System.Windows.Forms.ListView LsvFolder;
        private System.Windows.Forms.ImageList ImgSmallIcon;
        private System.Windows.Forms.ImageList ImgLargeIcon;
        private System.Windows.Forms.ComboBox CboView;
        private System.Windows.Forms.TextBox TxtPath;
    }
}

