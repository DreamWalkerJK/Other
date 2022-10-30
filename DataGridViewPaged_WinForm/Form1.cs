using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace DataGridViewPaged_WinForm
{
    public partial class Form1 : Form
    {
        private int pageSize = 5;
        private int recordCount = 0;
        private int pageCount = 0;
        private int currentPage = 1;

        public Form1()
        {
            InitializeComponent();
            txtCurrentPage.Text = "0";
            LoadData();
        }

        /// <summary>
        /// 首页
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnFirstPage_Click(object sender, EventArgs e)
        {
            currentPage = 1;
            LoadData();
        }

        /// <summary>
        /// 上一页
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLastPage_Click(object sender, EventArgs e)
        {
            if (currentPage == 1)
            {
                MessageBox.Show("当前已经是第一页");
            }
            else
            {
                currentPage--;
                LoadData();
            }
        }

        /// <summary>
        /// 跳转
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnGoPage_Click(object sender, EventArgs e)
        {
            if (!IsNormalPage(txtCurrentPage.Text.Trim()))
            {
                MessageBox.Show("跳转页数必须为正整数");
            }
            else
            {
                int page = Convert.ToInt32(txtCurrentPage.Text.Trim());

                if (page <= pageCount)
                {
                    currentPage = page;
                    LoadData();
                }
                else
                {
                    MessageBox.Show("跳转页面不能大于总页数");
                }
            }
        }

        /// <summary>
        /// 下一页
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnNextPage_Click(object sender, EventArgs e)
        {
            if (currentPage < pageCount)
            {
                currentPage++;
                LoadData();
            }
            else
            {
                MessageBox.Show("当前已经是最后一页");
            }
        }

        /// <summary>
        /// 尾页
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEndPage_Click(object sender, EventArgs e)
        {
            currentPage = pageCount;
            LoadData();
        }

        /// <summary>
        /// 填写的跳转页面数值是否是正整数
        /// </summary>
        /// <param name="page"></param>
        /// <returns></returns>
        private static bool IsNormalPage(string page)
        {
            return string.IsNullOrWhiteSpace(page) ? false : Regex.IsMatch(page, @"^[1-9]\d*$");
        }

        /// <summary>
        /// 加载数据
        /// </summary>
        private void LoadData()
        {
            dgvUser.DataSource = DBUtil.GetListTable(currentPage, pageSize, ref recordCount);
            pageCount = (recordCount + pageSize - 1) / pageSize;

            if (pageCount == 0)
            {
                lblRecordCount.Text = "总记录数：0";
                txtCurrentPage.Text = "0";
                lblTotalPage.Text = "总页数：0页";
            }
            else
            {
                lblRecordCount.Text = "总记录数：" + recordCount;
                txtCurrentPage.Text = currentPage.ToString();
                lblTotalPage.Text = "总页数: " + pageCount + "页";
            }
        }
    }
}
