namespace BachHoaXanh
{
    partial class frm_HuongDanSuDung
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
            System.Windows.Forms.TreeNode treeNode19 = new System.Windows.Forms.TreeNode("Tổng Quan");
            System.Windows.Forms.TreeNode treeNode20 = new System.Windows.Forms.TreeNode("Tiện Ích");
            System.Windows.Forms.TreeNode treeNode21 = new System.Windows.Forms.TreeNode("Cấu hình yêu cầu");
            System.Windows.Forms.TreeNode treeNode22 = new System.Windows.Forms.TreeNode("Giới thiệu ", new System.Windows.Forms.TreeNode[] {
            treeNode19,
            treeNode20,
            treeNode21});
            System.Windows.Forms.TreeNode treeNode23 = new System.Windows.Forms.TreeNode("Hệ Thống");
            System.Windows.Forms.TreeNode treeNode24 = new System.Windows.Forms.TreeNode("Danh Mục");
            System.Windows.Forms.TreeNode treeNode25 = new System.Windows.Forms.TreeNode("Chức Năng");
            System.Windows.Forms.TreeNode treeNode26 = new System.Windows.Forms.TreeNode("Trợ Giúp");
            System.Windows.Forms.TreeNode treeNode27 = new System.Windows.Forms.TreeNode("Hướng dẫn sử dụng", new System.Windows.Forms.TreeNode[] {
            treeNode23,
            treeNode24,
            treeNode25,
            treeNode26});
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.memoEdit1 = new DevExpress.XtraEditors.MemoEdit();
            ((System.ComponentModel.ISupportInitialize)(this.memoEdit1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(13, 13);
            this.treeView1.Name = "treeView1";
            treeNode19.Name = "Node4";
            treeNode19.Text = "Tổng Quan";
            treeNode20.Name = "Node5";
            treeNode20.Text = "Tiện Ích";
            treeNode21.Name = "Node6";
            treeNode21.Text = "Cấu hình yêu cầu";
            treeNode22.Name = "node2";
            treeNode22.Text = "Giới thiệu ";
            treeNode23.Name = "Node7";
            treeNode23.Text = "Hệ Thống";
            treeNode24.Name = "Node8";
            treeNode24.Text = "Danh Mục";
            treeNode25.Name = "Node9";
            treeNode25.Text = "Chức Năng";
            treeNode26.Name = "Node10";
            treeNode26.Text = "Trợ Giúp";
            treeNode27.Name = "Node3";
            treeNode27.Text = "Hướng dẫn sử dụng";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode22,
            treeNode27});
            this.treeView1.Size = new System.Drawing.Size(220, 489);
            this.treeView1.TabIndex = 0;
            // 
            // memoEdit1
            // 
            this.memoEdit1.Location = new System.Drawing.Point(240, 13);
            this.memoEdit1.Name = "memoEdit1";
            this.memoEdit1.Properties.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.memoEdit1.Size = new System.Drawing.Size(560, 489);
            this.memoEdit1.TabIndex = 1;
            // 
            // frm_HuongDanSuDung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(801, 505);
            this.Controls.Add(this.memoEdit1);
            this.Controls.Add(this.treeView1);
            this.Name = "frm_HuongDanSuDung";
            this.Text = "frm_HuongDanSuDung";
            this.Load += new System.EventHandler(this.frm_HuongDanSuDung_Load);
            ((System.ComponentModel.ISupportInitialize)(this.memoEdit1.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView treeView1;
        private DevExpress.XtraEditors.MemoEdit memoEdit1;

    }
}