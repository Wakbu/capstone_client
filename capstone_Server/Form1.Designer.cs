namespace capstone_Server
{
    partial class serverMainForm
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
            this.serverMainTable = new System.Windows.Forms.TableLayoutPanel();
            this.contTablePanel = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.logTBox = new System.Windows.Forms.TextBox();
            this.serverMainTable.SuspendLayout();
            this.contTablePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // serverMainTable
            // 
            this.serverMainTable.ColumnCount = 2;
            this.serverMainTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.serverMainTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.serverMainTable.Controls.Add(this.contTablePanel, 0, 0);
            this.serverMainTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.serverMainTable.Location = new System.Drawing.Point(0, 0);
            this.serverMainTable.Name = "serverMainTable";
            this.serverMainTable.RowCount = 1;
            this.serverMainTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.serverMainTable.Size = new System.Drawing.Size(914, 562);
            this.serverMainTable.TabIndex = 0;
            // 
            // contTablePanel
            // 
            this.contTablePanel.ColumnCount = 1;
            this.contTablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.contTablePanel.Controls.Add(this.label1, 0, 0);
            this.contTablePanel.Controls.Add(this.logTBox, 0, 1);
            this.contTablePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contTablePanel.Location = new System.Drawing.Point(3, 3);
            this.contTablePanel.Name = "contTablePanel";
            this.contTablePanel.RowCount = 2;
            this.contTablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.contTablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.contTablePanel.Size = new System.Drawing.Size(725, 556);
            this.contTablePanel.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("휴먼둥근헤드라인", 25.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(719, 55);
            this.label1.TabIndex = 0;
            this.label1.Text = "Server Control GUI";
            this.label1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // logTBox
            // 
            this.logTBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.logTBox.Location = new System.Drawing.Point(3, 58);
            this.logTBox.Multiline = true;
            this.logTBox.Name = "logTBox";
            this.logTBox.ReadOnly = true;
            this.logTBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.logTBox.Size = new System.Drawing.Size(719, 495);
            this.logTBox.TabIndex = 1;
            this.logTBox.TextChanged += new System.EventHandler(this.logTBox_TextChanged);
            // 
            // serverMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 562);
            this.Controls.Add(this.serverMainTable);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "serverMainForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.serverMainForm_Load);
            this.serverMainTable.ResumeLayout(false);
            this.contTablePanel.ResumeLayout(false);
            this.contTablePanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel serverMainTable;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox logTBox;
        public System.Windows.Forms.TableLayoutPanel contTablePanel;
    }
}

