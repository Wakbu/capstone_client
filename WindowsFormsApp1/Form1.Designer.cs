namespace WindowsFormsApp1
{
    partial class Form1
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("철학자");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("문학자");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("과학자");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("의학자");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("화학자");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("사회봉사자");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("종교인");
            this.mainSplitCon = new System.Windows.Forms.SplitContainer();
            this.sltTable = new System.Windows.Forms.TableLayoutPanel();
            this.prsList = new System.Windows.Forms.TreeView();
            this.cnfTable = new System.Windows.Forms.TableLayoutPanel();
            this.crtButton = new MetroFramework.Controls.MetroButton();
            this.edtButton = new MetroFramework.Controls.MetroButton();
            this.cnfButton = new MetroFramework.Controls.MetroButton();
            this.docSplit = new System.Windows.Forms.SplitContainer();
            this.contTable = new System.Windows.Forms.TableLayoutPanel();
            this.imgLabel = new MetroFramework.Controls.MetroLabel();
            this.etcLabel = new MetroFramework.Controls.MetroLabel();
            this.contLabel = new MetroFramework.Controls.MetroLabel();
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
            this.prsList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.prsList.Location = new System.Drawing.Point(3, 3);
            this.prsList.Name = "prsList";
            treeNode1.Name = "phsNode";
            treeNode1.Text = "철학자";
            treeNode2.Name = "ltrNode";
            treeNode2.Text = "문학자";
            treeNode3.Name = "sctNode";
            treeNode3.Text = "과학자";
            treeNode4.Name = "medNode";
            treeNode4.Text = "의학자";
            treeNode5.Name = "chtNode";
            treeNode5.Text = "화학자";
            treeNode6.Name = "votNode";
            treeNode6.Text = "사회봉사자";
            treeNode7.Name = "regNode";
            treeNode7.Text = "종교인";
            this.prsList.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3,
            treeNode4,
            treeNode5,
            treeNode6,
            treeNode7});
            this.prsList.Size = new System.Drawing.Size(194, 370);
            this.prsList.TabIndex = 0;
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
            // crtButton
            // 
            this.crtButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crtButton.Location = new System.Drawing.Point(3, 3);
            this.crtButton.Name = "crtButton";
            this.crtButton.Size = new System.Drawing.Size(58, 82);
            this.crtButton.TabIndex = 0;
            this.crtButton.Text = "데이터추가";
            this.crtButton.UseSelectable = true;
            // 
            // edtButton
            // 
            this.edtButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.edtButton.Location = new System.Drawing.Point(67, 3);
            this.edtButton.Name = "edtButton";
            this.edtButton.Size = new System.Drawing.Size(58, 82);
            this.edtButton.TabIndex = 1;
            this.edtButton.Text = "데이터수정";
            this.edtButton.UseSelectable = true;
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
            this.contTable.Controls.Add(this.imgLabel, 0, 0);
            this.contTable.Controls.Add(this.contLabel, 1, 0);
            this.contTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contTable.Location = new System.Drawing.Point(0, 0);
            this.contTable.Name = "contTable";
            this.contTable.RowCount = 1;
            this.contTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.contTable.Size = new System.Drawing.Size(756, 370);
            this.contTable.TabIndex = 0;
            // 
            // imgLabel
            // 
            this.imgLabel.AutoSize = true;
            this.imgLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.imgLabel.Location = new System.Drawing.Point(3, 0);
            this.imgLabel.Name = "imgLabel";
            this.imgLabel.Size = new System.Drawing.Size(296, 370);
            this.imgLabel.TabIndex = 0;
            this.imgLabel.Text = "이미지라벨";
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
            // contLabel
            // 
            this.contLabel.AutoSize = true;
            this.contLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contLabel.Location = new System.Drawing.Point(305, 0);
            this.contLabel.Name = "contLabel";
            this.contLabel.Size = new System.Drawing.Size(448, 370);
            this.contLabel.TabIndex = 1;
            this.contLabel.Text = "글 라벨";
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(1000, 550);
            this.Controls.Add(this.mainSplitCon);
            this.Name = "Form1";
            this.Text = "PersonageWIKI";
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
            this.contTable.PerformLayout();
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
        private MetroFramework.Controls.MetroLabel imgLabel;
        private MetroFramework.Controls.MetroLabel etcLabel;
        private MetroFramework.Controls.MetroLabel contLabel;
    }
}

