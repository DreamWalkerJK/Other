
namespace DataGridViewPaged_WinForm
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvUser = new System.Windows.Forms.DataGridView();
            this.txtCurrentPage = new System.Windows.Forms.TextBox();
            this.lblTotalPage = new System.Windows.Forms.Label();
            this.lblRecordCount = new System.Windows.Forms.Label();
            this.btnLastPage = new System.Windows.Forms.Button();
            this.btnNextPage = new System.Windows.Forms.Button();
            this.btnFirstPage = new System.Windows.Forms.Button();
            this.btnEndPage = new System.Windows.Forms.Button();
            this.btnGoPage = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUser)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvUser
            // 
            this.dgvUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUser.Location = new System.Drawing.Point(0, 0);
            this.dgvUser.Name = "dgvUser";
            this.dgvUser.RowHeadersWidth = 51;
            this.dgvUser.RowTemplate.Height = 27;
            this.dgvUser.Size = new System.Drawing.Size(659, 410);
            this.dgvUser.TabIndex = 0;
            // 
            // txtCurrentPage
            // 
            this.txtCurrentPage.Location = new System.Drawing.Point(174, 417);
            this.txtCurrentPage.Name = "txtCurrentPage";
            this.txtCurrentPage.Size = new System.Drawing.Size(100, 25);
            this.txtCurrentPage.TabIndex = 1;
            // 
            // lblTotalPage
            // 
            this.lblTotalPage.AutoSize = true;
            this.lblTotalPage.Location = new System.Drawing.Point(510, 423);
            this.lblTotalPage.Name = "lblTotalPage";
            this.lblTotalPage.Size = new System.Drawing.Size(52, 15);
            this.lblTotalPage.TabIndex = 2;
            this.lblTotalPage.Text = "总页数";
            // 
            // lblRecordCount
            // 
            this.lblRecordCount.AutoSize = true;
            this.lblRecordCount.Location = new System.Drawing.Point(578, 423);
            this.lblRecordCount.Name = "lblRecordCount";
            this.lblRecordCount.Size = new System.Drawing.Size(52, 15);
            this.lblRecordCount.TabIndex = 3;
            this.lblRecordCount.Text = "总记录";
            // 
            // btnLastPage
            // 
            this.btnLastPage.Location = new System.Drawing.Point(93, 419);
            this.btnLastPage.Name = "btnLastPage";
            this.btnLastPage.Size = new System.Drawing.Size(75, 23);
            this.btnLastPage.TabIndex = 4;
            this.btnLastPage.Text = "上一页";
            this.btnLastPage.UseVisualStyleBackColor = true;
            this.btnLastPage.Click += new System.EventHandler(this.btnLastPage_Click);
            // 
            // btnNextPage
            // 
            this.btnNextPage.Location = new System.Drawing.Point(357, 419);
            this.btnNextPage.Name = "btnNextPage";
            this.btnNextPage.Size = new System.Drawing.Size(75, 23);
            this.btnNextPage.TabIndex = 5;
            this.btnNextPage.Text = "下一页";
            this.btnNextPage.UseVisualStyleBackColor = true;
            this.btnNextPage.Click += new System.EventHandler(this.btnNextPage_Click);
            // 
            // btnFirstPage
            // 
            this.btnFirstPage.Location = new System.Drawing.Point(12, 419);
            this.btnFirstPage.Name = "btnFirstPage";
            this.btnFirstPage.Size = new System.Drawing.Size(75, 23);
            this.btnFirstPage.TabIndex = 6;
            this.btnFirstPage.Text = "首页";
            this.btnFirstPage.UseVisualStyleBackColor = true;
            this.btnFirstPage.Click += new System.EventHandler(this.btnFirstPage_Click);
            // 
            // btnEndPage
            // 
            this.btnEndPage.Location = new System.Drawing.Point(438, 419);
            this.btnEndPage.Name = "btnEndPage";
            this.btnEndPage.Size = new System.Drawing.Size(75, 23);
            this.btnEndPage.TabIndex = 7;
            this.btnEndPage.Text = "末页";
            this.btnEndPage.UseVisualStyleBackColor = true;
            this.btnEndPage.Click += new System.EventHandler(this.btnEndPage_Click);
            // 
            // btnGoPage
            // 
            this.btnGoPage.Location = new System.Drawing.Point(281, 419);
            this.btnGoPage.Name = "btnGoPage";
            this.btnGoPage.Size = new System.Drawing.Size(75, 23);
            this.btnGoPage.TabIndex = 8;
            this.btnGoPage.Text = "跳转";
            this.btnGoPage.UseVisualStyleBackColor = true;
            this.btnGoPage.Click += new System.EventHandler(this.btnGoPage_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(658, 451);
            this.Controls.Add(this.btnGoPage);
            this.Controls.Add(this.btnEndPage);
            this.Controls.Add(this.btnFirstPage);
            this.Controls.Add(this.btnNextPage);
            this.Controls.Add(this.btnLastPage);
            this.Controls.Add(this.lblRecordCount);
            this.Controls.Add(this.lblTotalPage);
            this.Controls.Add(this.txtCurrentPage);
            this.Controls.Add(this.dgvUser);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvUser)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvUser;
        private System.Windows.Forms.TextBox txtCurrentPage;
        private System.Windows.Forms.Label lblTotalPage;
        private System.Windows.Forms.Label lblRecordCount;
        private System.Windows.Forms.Button btnLastPage;
        private System.Windows.Forms.Button btnNextPage;
        private System.Windows.Forms.Button btnFirstPage;
        private System.Windows.Forms.Button btnEndPage;
        private System.Windows.Forms.Button btnGoPage;
    }
}

