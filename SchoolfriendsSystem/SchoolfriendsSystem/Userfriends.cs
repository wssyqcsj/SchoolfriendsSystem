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
    public partial class Userfriends : Form
    {
        public Userfriends()
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
                string a, b, c, e, f, g, h, i, k, l, m, n;
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
        private void 新增ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Add add = new Add();
            add.ShowDialog();
        }

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
                string sql = "select* from FriendsInfo where studentid = '" + textBox1.Text + "' or username = '" + textBox1.Text + "' or politicaloutlook='" + textBox1.Text + "'";
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
    }
}
