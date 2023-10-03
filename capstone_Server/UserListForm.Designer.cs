namespace capstone_Server
{
    partial class UserListForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.ListViewGroup listViewGroup4 = new System.Windows.Forms.ListViewGroup("ListViewGroup", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup5 = new System.Windows.Forms.ListViewGroup("ListViewGroup", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup6 = new System.Windows.Forms.ListViewGroup("ListViewGroup", System.Windows.Forms.HorizontalAlignment.Left);
            this.userListView = new MetroFramework.Controls.MetroListView();
            this.userID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.userIP = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.userStat = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // userListView
            // 
            this.userListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.userID,
            this.userIP,
            this.userStat});
            this.userListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userListView.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.userListView.FullRowSelect = true;
            listViewGroup4.Header = "ListViewGroup";
            listViewGroup4.Name = "listViewGroup1";
            listViewGroup5.Header = "ListViewGroup";
            listViewGroup5.Name = "listViewGroup2";
            listViewGroup6.Header = "ListViewGroup";
            listViewGroup6.Name = "listViewGroup3";
            this.userListView.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            listViewGroup4,
            listViewGroup5,
            listViewGroup6});
            this.userListView.Location = new System.Drawing.Point(20, 60);
            this.userListView.MaximumSize = new System.Drawing.Size(760, 370);
            this.userListView.MinimumSize = new System.Drawing.Size(760, 370);
            this.userListView.Name = "userListView";
            this.userListView.OwnerDraw = true;
            this.userListView.Size = new System.Drawing.Size(760, 370);
            this.userListView.TabIndex = 0;
            this.userListView.UseCompatibleStateImageBehavior = false;
            this.userListView.UseSelectable = true;
            this.userListView.View = System.Windows.Forms.View.Details;
            this.userListView.SelectedIndexChanged += new System.EventHandler(this.metroListView1_SelectedIndexChanged);
            // 
            // userID
            // 
            this.userID.Text = "ID";
            this.userID.Width = 150;
            // 
            // userIP
            // 
            this.userIP.Text = "IP";
            this.userIP.Width = 356;
            // 
            // userStat
            // 
            this.userStat.Text = "STATUS";
            this.userStat.Width = 253;
            // 
            // UserListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.userListView);
            this.MaximumSize = new System.Drawing.Size(800, 450);
            this.MinimumSize = new System.Drawing.Size(800, 450);
            this.Name = "UserListForm";
            this.Text = "UserListForm";
            this.Load += new System.EventHandler(this.UserListForm_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ColumnHeader userID;
        private System.Windows.Forms.ColumnHeader userIP;
        private System.Windows.Forms.ColumnHeader userStat;
        public MetroFramework.Controls.MetroListView userListView;
    }
}