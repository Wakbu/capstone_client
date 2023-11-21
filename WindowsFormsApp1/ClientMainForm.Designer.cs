namespace capstone_client
{
    partial class clientMainForm
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("지도자");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("종교인");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("혁명가");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("탐험가");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("사업가");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("운동선수");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("예술가");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("극작가");
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("음악가");
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("건축가");
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("철학자");
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("물리학자");
            System.Windows.Forms.TreeNode treeNode13 = new System.Windows.Forms.TreeNode("생물학자");
            System.Windows.Forms.TreeNode treeNode14 = new System.Windows.Forms.TreeNode("화학자");
            System.Windows.Forms.TreeNode treeNode15 = new System.Windows.Forms.TreeNode("사회봉사자");
            System.Windows.Forms.TreeNode treeNode16 = new System.Windows.Forms.TreeNode("교육학자");
            this.mainSplitCon = new System.Windows.Forms.SplitContainer();
            this.sltTable = new System.Windows.Forms.TableLayoutPanel();
            this.prsList = new System.Windows.Forms.TreeView();
            this.cnfTable = new System.Windows.Forms.TableLayoutPanel();
            this.cnfButton = new MetroFramework.Controls.MetroButton();
            this.edtButton = new MetroFramework.Controls.MetroButton();
            this.crtButton = new MetroFramework.Controls.MetroButton();
            this.docSplit = new System.Windows.Forms.SplitContainer();
            this.contTable = new System.Windows.Forms.TableLayoutPanel();
            this.contLabel = new MetroFramework.Controls.MetroTextBox();
            this.imgVidTab = new MetroFramework.Controls.MetroTabControl();
            this.imgTab = new MetroFramework.Controls.MetroTabPage();
            this.imgBox = new System.Windows.Forms.PictureBox();
            this.vidTab = new MetroFramework.Controls.MetroTabPage();
            this.etcLabel = new MetroFramework.Controls.MetroLabel();
            ((System.ComponentModel.ISupportInitialize)(this.mainSplitCon)).BeginInit();
            this.mainSplitCon.Panel1.SuspendLayout();
            this.mainSplitCon.Panel2.SuspendLayout();
            this.mainSplitCon.SuspendLayout();
            this.sltTable.SuspendLayout();
            this.cnfTable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.docSplit)).BeginInit();
            this.docSplit.Panel1.SuspendLayout();
            this.docSplit.Panel2.SuspendLayout();
            this.docSplit.SuspendLayout();
            this.contTable.SuspendLayout();
            this.imgVidTab.SuspendLayout();
            this.imgTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgBox)).BeginInit();
            this.SuspendLayout();
            // 
            // mainSplitCon
            // 
            this.mainSplitCon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainSplitCon.Location = new System.Drawing.Point(20, 60);
            this.mainSplitCon.Name = "mainSplitCon";
            // 
            // mainSplitCon.Panel1
            // 
            this.mainSplitCon.Panel1.Controls.Add(this.sltTable);
            this.mainSplitCon.Panel1MinSize = 200;
            // 
            // mainSplitCon.Panel2
            // 
            this.mainSplitCon.Panel2.Controls.Add(this.docSplit);
            this.mainSplitCon.Panel2MinSize = 500;
            this.mainSplitCon.Size = new System.Drawing.Size(960, 470);
            this.mainSplitCon.SplitterDistance = 200;
            this.mainSplitCon.TabIndex = 0;
            // 
            // sltTable
            // 
            this.sltTable.ColumnCount = 1;
            this.sltTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.sltTable.Controls.Add(this.prsList, 0, 0);
            this.sltTable.Controls.Add(this.cnfTable, 0, 1);
            this.sltTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sltTable.Location = new System.Drawing.Point(0, 0);
            this.sltTable.Name = "sltTable";
            this.sltTable.RowCount = 2;
            this.sltTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.sltTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.sltTable.Size = new System.Drawing.Size(200, 470);
            this.sltTable.TabIndex = 0;
            // 
            // prsList
            // 
            this.prsList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.prsList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.prsList.Location = new System.Drawing.Point(3, 3);
            this.prsList.Name = "prsList";
            treeNode1.Name = "readNode";
            treeNode1.Text = "지도자";
            treeNode2.Name = "regNode";
            treeNode2.Text = "종교인";
            treeNode3.Name = "revNode";
            treeNode3.Text = "혁명가";
            treeNode4.Name = "advNode";
            treeNode4.Text = "탐험가";
            treeNode5.Name = "comNode";
            treeNode5.Text = "사업가";
            treeNode6.Name = "arcNode";
            treeNode6.Text = "운동선수";
            treeNode7.Name = "artNode";
            treeNode7.Text = "예술가";
            treeNode8.Name = "styNode";
            treeNode8.Text = "극작가";
            treeNode9.Name = "mscNode";
            treeNode9.Text = "음악가";
            treeNode10.Name = "achNode";
            treeNode10.Text = "건축가";
            treeNode11.Name = "phsNode";
            treeNode11.Text = "철학자";
            treeNode12.Name = "psyNode";
            treeNode12.Text = "물리학자";
            treeNode13.Name = "bioNode";
            treeNode13.Text = "생물학자";
            treeNode14.Name = "chtNode";
            treeNode14.Text = "화학자";
            treeNode15.Name = "volNode";
            treeNode15.Text = "사회봉사자";
            treeNode16.Name = "eduNode";
            treeNode16.Text = "교육학자";
            this.prsList.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3,
            treeNode4,
            treeNode5,
            treeNode6,
            treeNode7,
            treeNode8,
            treeNode9,
            treeNode10,
            treeNode11,
            treeNode12,
            treeNode13,
            treeNode14,
            treeNode15,
            treeNode16});
            this.prsList.Size = new System.Drawing.Size(194, 370);
            this.prsList.TabIndex = 0;
            this.prsList.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.prsList_AfterSelect);
            this.prsList.MouseClick += new System.Windows.Forms.MouseEventHandler(this.prsList_MouseClick);
            // 
            // cnfTable
            // 
            this.cnfTable.ColumnCount = 3;
            this.cnfTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.cnfTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.cnfTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.cnfTable.Controls.Add(this.cnfButton, 2, 0);
            this.cnfTable.Controls.Add(this.edtButton, 1, 0);
            this.cnfTable.Controls.Add(this.crtButton, 0, 0);
            this.cnfTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cnfTable.Location = new System.Drawing.Point(3, 379);
            this.cnfTable.Name = "cnfTable";
            this.cnfTable.RowCount = 1;
            this.cnfTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.cnfTable.Size = new System.Drawing.Size(194, 88);
            this.cnfTable.TabIndex = 1;
            // 
            // cnfButton
            // 
            this.cnfButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cnfButton.Location = new System.Drawing.Point(131, 3);
            this.cnfButton.Name = "cnfButton";
            this.cnfButton.Size = new System.Drawing.Size(60, 82);
            this.cnfButton.TabIndex = 2;
            this.cnfButton.Text = "환경설정";
            this.cnfButton.UseSelectable = true;
            this.cnfButton.Click += new System.EventHandler(this.cnfButton_Click);
            // 
            // edtButton
            // 
            this.edtButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.edtButton.Location = new System.Drawing.Point(67, 3);
            this.edtButton.Name = "edtButton";
            this.edtButton.Size = new System.Drawing.Size(58, 82);
            this.edtButton.TabIndex = 1;
            this.edtButton.Text = "수정";
            this.edtButton.UseSelectable = true;
            this.edtButton.Click += new System.EventHandler(this.edtButton_Click);
            // 
            // crtButton
            // 
            this.crtButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crtButton.Location = new System.Drawing.Point(3, 3);
            this.crtButton.Name = "crtButton";
            this.crtButton.Size = new System.Drawing.Size(58, 82);
            this.crtButton.TabIndex = 0;
            this.crtButton.Text = "추가";
            this.crtButton.UseSelectable = true;
            this.crtButton.Click += new System.EventHandler(this.crtButton_Click);
            // 
            // docSplit
            // 
            this.docSplit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.docSplit.Location = new System.Drawing.Point(0, 0);
            this.docSplit.Name = "docSplit";
            this.docSplit.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // docSplit.Panel1
            // 
            this.docSplit.Panel1.Controls.Add(this.contTable);
            // 
            // docSplit.Panel2
            // 
            this.docSplit.Panel2.Controls.Add(this.etcLabel);
            this.docSplit.Size = new System.Drawing.Size(756, 470);
            this.docSplit.SplitterDistance = 370;
            this.docSplit.TabIndex = 0;
            // 
            // contTable
            // 
            this.contTable.ColumnCount = 2;
            this.contTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.contTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.contTable.Controls.Add(this.contLabel, 1, 0);
            this.contTable.Controls.Add(this.imgVidTab, 0, 0);
            this.contTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contTable.Location = new System.Drawing.Point(0, 0);
            this.contTable.Name = "contTable";
            this.contTable.RowCount = 1;
            this.contTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.contTable.Size = new System.Drawing.Size(756, 370);
            this.contTable.TabIndex = 0;
            // 
            // contLabel
            // 
            // 
            // 
            // 
            this.contLabel.CustomButton.Image = null;
            this.contLabel.CustomButton.Location = new System.Drawing.Point(86, 2);
            this.contLabel.CustomButton.Name = "";
            this.contLabel.CustomButton.Size = new System.Drawing.Size(359, 359);
            this.contLabel.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.contLabel.CustomButton.TabIndex = 1;
            this.contLabel.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.contLabel.CustomButton.UseSelectable = true;
            this.contLabel.CustomButton.Visible = false;
            this.contLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contLabel.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.contLabel.Lines = new string[0];
            this.contLabel.Location = new System.Drawing.Point(305, 3);
            this.contLabel.MaxLength = 100000;
            this.contLabel.Multiline = true;
            this.contLabel.Name = "contLabel";
            this.contLabel.PasswordChar = '\0';
            this.contLabel.ReadOnly = true;
            this.contLabel.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.contLabel.SelectedText = "";
            this.contLabel.SelectionLength = 0;
            this.contLabel.SelectionStart = 0;
            this.contLabel.ShortcutsEnabled = true;
            this.contLabel.Size = new System.Drawing.Size(448, 364);
            this.contLabel.TabIndex = 1;
            this.contLabel.UseSelectable = true;
            this.contLabel.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.contLabel.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // imgVidTab
            // 
            this.imgVidTab.Controls.Add(this.imgTab);
            this.imgVidTab.Controls.Add(this.vidTab);
            this.imgVidTab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.imgVidTab.Location = new System.Drawing.Point(3, 3);
            this.imgVidTab.Name = "imgVidTab";
            this.imgVidTab.SelectedIndex = 0;
            this.imgVidTab.Size = new System.Drawing.Size(296, 364);
            this.imgVidTab.TabIndex = 2;
            this.imgVidTab.UseSelectable = true;
            // 
            // imgTab
            // 
            this.imgTab.Controls.Add(this.imgBox);
            this.imgTab.HorizontalScrollbarBarColor = true;
            this.imgTab.HorizontalScrollbarHighlightOnWheel = false;
            this.imgTab.HorizontalScrollbarSize = 10;
            this.imgTab.Location = new System.Drawing.Point(4, 38);
            this.imgTab.Name = "imgTab";
            this.imgTab.Size = new System.Drawing.Size(288, 322);
            this.imgTab.TabIndex = 0;
            this.imgTab.Text = "이미지";
            this.imgTab.VerticalScrollbarBarColor = true;
            this.imgTab.VerticalScrollbarHighlightOnWheel = false;
            this.imgTab.VerticalScrollbarSize = 10;
            // 
            // imgBox
            // 
            this.imgBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.imgBox.Location = new System.Drawing.Point(0, 0);
            this.imgBox.Name = "imgBox";
            this.imgBox.Size = new System.Drawing.Size(288, 322);
            this.imgBox.TabIndex = 2;
            this.imgBox.TabStop = false;
            // 
            // vidTab
            // 
            this.vidTab.HorizontalScrollbarBarColor = true;
            this.vidTab.HorizontalScrollbarHighlightOnWheel = false;
            this.vidTab.HorizontalScrollbarSize = 10;
            this.vidTab.Location = new System.Drawing.Point(4, 36);
            this.vidTab.Name = "vidTab";
            this.vidTab.Size = new System.Drawing.Size(288, 324);
            this.vidTab.TabIndex = 1;
            this.vidTab.Text = "영상자료";
            this.vidTab.VerticalScrollbarBarColor = true;
            this.vidTab.VerticalScrollbarHighlightOnWheel = false;
            this.vidTab.VerticalScrollbarSize = 10;
            // 
            // etcLabel
            // 
            this.etcLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.etcLabel.Location = new System.Drawing.Point(0, 0);
            this.etcLabel.Name = "etcLabel";
            this.etcLabel.Size = new System.Drawing.Size(756, 96);
            this.etcLabel.TabIndex = 0;
            this.etcLabel.Text = "기타 정보 라벨";
            // 
            // clientMainForm
            // 
            this.ClientSize = new System.Drawing.Size(1000, 550);
            this.Controls.Add(this.mainSplitCon);
            this.Name = "clientMainForm";
            this.Text = "PersonageWIKI";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.clientMainForm_FormClosing);
            this.Load += new System.EventHandler(this.clientMainForm_Load);
            this.mainSplitCon.Panel1.ResumeLayout(false);
            this.mainSplitCon.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mainSplitCon)).EndInit();
            this.mainSplitCon.ResumeLayout(false);
            this.sltTable.ResumeLayout(false);
            this.cnfTable.ResumeLayout(false);
            this.docSplit.Panel1.ResumeLayout(false);
            this.docSplit.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.docSplit)).EndInit();
            this.docSplit.ResumeLayout(false);
            this.contTable.ResumeLayout(false);
            this.imgVidTab.ResumeLayout(false);
            this.imgTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imgBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer mainSplitCon;
        private System.Windows.Forms.TableLayoutPanel sltTable;
        private System.Windows.Forms.TreeView prsList;
        private System.Windows.Forms.TableLayoutPanel cnfTable;
        private MetroFramework.Controls.MetroButton cnfButton;
        private MetroFramework.Controls.MetroButton edtButton;
        private MetroFramework.Controls.MetroButton crtButton;
        private System.Windows.Forms.SplitContainer docSplit;
        private System.Windows.Forms.TableLayoutPanel contTable;
        private MetroFramework.Controls.MetroTextBox contLabel;
        private MetroFramework.Controls.MetroTabControl imgVidTab;
        private MetroFramework.Controls.MetroTabPage imgTab;
        private MetroFramework.Controls.MetroTabPage vidTab;
        private MetroFramework.Controls.MetroLabel etcLabel;
        private System.Windows.Forms.PictureBox imgBox;
    }
}

