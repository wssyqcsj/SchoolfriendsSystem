using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolfriendsSystem
{
    public partial class Friends : Form
    {
        public Friends()
        {
            InitializeComponent();
            SearchAll();
        }
        #region 查询所有编号
        public void SearchAll()
        {
            string sql = "select * from FriendsInfo";
            DBhelper dbhelper = new DBhelper();
            IDataReader dr = dbhelper.Reader(sql);
            while (dr.Read())
            {
                string a, b, c,e,f,g,h,i,k,l,m,n;
                a = dr["studentid"].ToString();
                b = dr["username"].ToString();
                c = dr["sex"].ToString();
                e = dr["graduationgrade"].ToString();
                f = dr["politicaloutlook"].ToString();
                g = dr["birthday"].ToString();
                h = dr["phone"].ToString();
                i = dr["friendqq"].ToString();
                k = dr["addresses"].ToString();
                l = dr["wordaddress"].ToString();
                m = dr["specialty"].ToString();
                n = dr["department"].ToString();
                string[] str = { a, b, c, e, f, g, h, i, k, l, m, n };
                dataGridView1.Rows.Add(str);
            }
            dr.Close();
        }
        #endregion
        private void 删除ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string msg = "你确定删除编码“" + dataGridView1.SelectedCells[0].Value.ToString() + "”吗?";
            if ((int)MessageBox.Show(msg, "删除编码", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation) != 1)
            {
                return;
            }
            else
            {
                string studentid, username, sex, graduationgrade, politicaloutlook, birthday, phone, friendqq, addresses, wordaddress, specialty, department;
                studentid = dataGridView1.SelectedCells[0].Value.ToString();
                username = dataGridView1.SelectedCells[1].Value.ToString();
                sex = dataGridView1.SelectedCells[2].Value.ToString();
                graduationgrade = dataGridView1.SelectedCells[3].Value.ToString();
                politicaloutlook = dataGridView1.SelectedCells[4].Value.ToString();
                birthday = dataGridView1.SelectedCells[5].Value.ToString();
                phone = dataGridView1.SelectedCells[6].Value.ToString();
                friendqq = dataGridView1.SelectedCells[7].Value.ToString();
                addresses = dataGridView1.SelectedCells[8].Value.ToString();
                wordaddress = dataGridView1.SelectedCells[9].Value.ToString();
                specialty = dataGridView1.SelectedCells[10].Value.ToString();
                department = dataGridView1.SelectedCells[11].Value.ToString();
                string sql1 = "delete from FriendsInfo" +
                    " where studentid='" + studentid + "'and username='" + username + "'and sex='" + sex + "'and " +
                    "graduationgrade='" + graduationgrade + "'and politicaloutlook='" + politicaloutlook + "'and birthday='" + birthday + "'and " +
                    "phone='" + phone + "'and friendqq='" + friendqq + "'and addresses='" + addresses + "'and " +
                    "wordaddress='" + wordaddress + "'and specialty='" + specialty + "'and department='" + department + "'";
                DBhelper dbhelper = new DBhelper();
                dbhelper.Excute(sql1);
                dataGridView1.Rows.Clear();
                SearchAll();
            }
        }

        private void 修改ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string[] str = {
                dataGridView1.SelectedCells[0].Value.ToString(),
                dataGridView1.SelectedCells[1].Value.ToString(),
                dataGridView1.SelectedCells[2].Value.ToString(),
                dataGridView1.SelectedCells[3].Value.ToString(),
                dataGridView1.SelectedCells[4].Value.ToString(),
                dataGridView1.SelectedCells[5].Value.ToString(),
                dataGridView1.SelectedCells[6].Value.ToString(),
                dataGridView1.SelectedCells[7].Value.ToString(),
                dataGridView1.SelectedCells[8].Value.ToString(),
                dataGridView1.SelectedCells[9].Value.ToString(),
                dataGridView1.SelectedCells[10].Value.ToString(),
                dataGridView1.SelectedCells[11].Value.ToString()
            };
            Alters Alter = new Alters(str);
            Alter.ShowDialog();
            dataGridView1.Rows.Clear();
            SearchAll();
        }

        #region 搜索框
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                dataGridView1.Rows.Clear();
                SearchAll();
            }
            else
            {
                dataGridView1.Rows.Clear();
                string sql = "select* from FriendsInfo where studentid = '"+textBox1.Text+ "' or username = '" + textBox1.Text + "' or politicaloutlook='"+ textBox1.Text + "'";
                DBhelper dbhelper = new DBhelper();
                IDataReader dr = dbhelper.Reader(sql);
                while (dr.Read())
                {
                    string a, b, c, x, f, g, h, i, k, l, m, n;
                    a = dr["studentid"].ToString();
                    b = dr["username"].ToString();
                    c = dr["sex"].ToString();
                    x = dr["graduationgrade"].ToString();
                    f = dr["politicaloutlook"].ToString();
                    g = dr["birthday"].ToString();
                    h = dr["phone"].ToString();
                    i = dr["friendqq"].ToString();
                    k = dr["addresses"].ToString();
                    l = dr["wordaddress"].ToString();
                    m = dr["specialty"].ToString();
                    n = dr["department"].ToString();
                    string[] str = { a, b, c, x, f, g, h, i, k, l, m, n };
                    dataGridView1.Rows.Add(str);
                }
                dr.Close();
            }
        }
        #endregion

        private void 添加ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Add add = new Add();
            add.ShowDialog();
        }
    }
}
