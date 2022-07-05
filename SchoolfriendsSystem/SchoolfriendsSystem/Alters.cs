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
    public partial class Alters : Form
    {
        string[] str = new string[12];
        public Alters()
        {
            InitializeComponent();
            CenterToScreen();
        }

        public Alters(string[] a) 
        {
            InitializeComponent();
            for (int i = 0; i < 12; i++)
            {
                str[i] = a[i];
            }
            textBox1.Text = str[0];
            textBox2.Text = str[1];
            textBox3.Text = str[2];
            textBox4.Text = str[3];
            textBox5.Text = str[4];
            dateTimePicker1.Text = str[5];
            textBox7.Text = str[6];
            textBox8.Text = str[7];
            textBox9.Text = str[8];
            textBox10.Text = str[9];
            textBox11.Text = str[10];
            textBox12.Text = str[11];

        }
        #region 修改
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox3.Text == "" || textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("修改后不能有空，请重新输入！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (textBox1.Text != str[0])
                {
                    string sql = "update FriendsInfo set studentid='" + textBox1.Text + "'" +
                        "where username='" + str[1] + "'and sex='" + str[2] + "'and graduationgrade='" + str[3] + "'and " +
                        "politicaloutlook='" + str[4] + "'and birthday='" + str[5] + "'and phone='" + str[6] + "'and " +
                        "friendqq='" + str[7] + "'and addresses='" + str[8] + "'and wordaddress='" + str[9] + "'and " +
                        "specialty='" + str[10] + "'and department='" + str[11] + "'";
                    DBhelper dbhelper = new DBhelper();
                    dbhelper.Excute(sql);
                    str[0] = textBox1.Text;
                }
                if (textBox2.Text != str[1])
                {
                    string sql = "update FriendsInfo set username='" + textBox2.Text + "'" +
                        "where studentid='" + str[0] + "'and sex='" + str[2] + "'and graduationgrade='" + str[3] + "'and " +
                        "politicaloutlook='" + str[4] + "'and birthday='" + str[5] + "'and phone='" + str[6] + "'and " +
                        "friendqq='" + str[7] + "'and addresses='" + str[8] + "'and wordaddress='" + str[9] + "'and " +
                        "specialty='" + str[10] + "'and department='" + str[11] + "'";
                    DBhelper dbhelper = new DBhelper();
                    dbhelper.Excute(sql);
                    str[1] = textBox2.Text;
                }
                if (textBox3.Text != str[2])
                {
                    string sql = "update FriendsInfo set sex='" + textBox3.Text + "'" +
                        "where studentid='" + str[0] + "'and username='" + str[1] + "'and graduationgrade='" + str[3] + "'and " +
                        "politicaloutlook='" + str[4] + "'and birthday='" + str[5] + "'and phone='" + str[6] + "'and " +
                        "friendqq='" + str[7] + "'and addresses='" + str[8] + "'and wordaddress='" + str[9] + "'and " +
                        "specialty='" + str[10] + "'and department='" + str[11] + "'";
                    DBhelper dbhelper = new DBhelper();
                    dbhelper.Excute(sql);
                    str[2] = textBox3.Text;
                }
                if (textBox4.Text != str[3])
                {
                    string sql = "update FriendsInfo set graduationgrade='" + textBox4.Text + "'" +
                        "where username='" + str[1] + "'and sex='" + str[2] + "'and studentid='" + str[1] + "'and " +
                        "politicaloutlook='" + str[4] + "'and birthday='" + str[5] + "'and phone='" + str[6] + "'and " +
                        "friendqq='" + str[7] + "'and addresses='" + str[8] + "'and wordaddress='" + str[9] + "'and " +
                        "specialty='" + str[10] + "'and department='" + str[11] + "'";
                    DBhelper dbhelper = new DBhelper();
                    dbhelper.Excute(sql);
                    str[3] = textBox4.Text;
                }
                if (textBox5.Text != str[4])
                {
                    string sql = "update FriendsInfo set politicaloutlook='" + textBox5.Text + "'" +
                        "where username='" + str[1] + "'and sex='" + str[2] + "'and graduationgrade='" + str[3] + "'and " +
                        "studentid='" + str[0] + "'and birthday='" + str[5] + "'and phone='" + str[6] + "'and " +
                        "friendqq='" + str[7] + "'and addresses='" + str[8] + "'and wordaddress='" + str[9] + "'and " +
                        "specialty='" + str[10] + "'and department='" + str[11] + "'";
                    DBhelper dbhelper = new DBhelper();
                    dbhelper.Excute(sql);
                    str[4] = textBox5.Text;
                }
                if (dateTimePicker1.Text != str[5])
                {
                    string sql = "update FriendsInfo set birthday='" + dateTimePicker1.Text + "'" +
                        "where username='" + str[1] + "'and sex='" + str[2] + "'and graduationgrade='" + str[3] + "'and " +
                        "politicaloutlook='" + str[4] + "'and studentid='" + str[0] + "'and phone='" + str[6] + "'and " +
                        "friendqq='" + str[7] + "'and addresses='" + str[8] + "'and wordaddress='" + str[9] + "'and " +
                        "specialty='" + str[10] + "'and department='" + str[11] + "'";
                    DBhelper dbhelper = new DBhelper();
                    dbhelper.Excute(sql);
                    str[5] = dateTimePicker1.Text;
                }
                if (textBox7.Text != str[6])
                {
                    string sql = "update FriendsInfo set phone='" + textBox7.Text + "'" +
                        "where username='" + str[1] + "'and sex='" + str[2] + "'and graduationgrade='" + str[3] + "'and " +
                        "politicaloutlook='" + str[4] + "'and birthday='" + str[5] + "'and studentid='" + str[0] + "'and " +
                        "friendqq='" + str[7] + "'and addresses='" + str[8] + "'and wordaddress='" + str[9] + "'and " +
                        "specialty='" + str[10] + "'and department='" + str[11] + "'";
                    DBhelper dbhelper = new DBhelper();
                    dbhelper.Excute(sql);
                    str[6] = textBox7.Text;
                }
                if (textBox8.Text != str[7])
                {
                    string sql = "update FriendsInfo set friendqq='" + textBox8.Text + "'" +
                        "where username='" + str[1] + "'and sex='" + str[2] + "'and graduationgrade='" + str[3] + "'and " +
                        "politicaloutlook='" + str[4] + "'and birthday='" + str[5] + "'and phone='" + str[6] + "'and " +
                        "studentid='" + str[0] + "'and addresses='" + str[8] + "'and wordaddress='" + str[9] + "'and " +
                        "specialty='" + str[10] + "'and department='" + str[11] + "'";
                    DBhelper dbhelper = new DBhelper();
                    dbhelper.Excute(sql);
                    str[7] = textBox8.Text;
                }
                if (textBox9.Text != str[8])
                {
                    string sql = "update FriendsInfo set addresses='" + textBox9.Text + "'" +
                        "where username='" + str[1] + "'and sex='" + str[2] + "'and graduationgrade='" + str[3] + "'and " +
                        "politicaloutlook='" + str[4] + "'and birthday='" + str[5] + "'and phone='" + str[6] + "'and " +
                        "friendqq='" + str[7] + "'and studentid='" + str[0] + "'and wordaddress='" + str[9] + "'and " +
                        "specialty='" + str[10] + "'and department='" + str[11] + "'";
                    DBhelper dbhelper = new DBhelper();
                    dbhelper.Excute(sql);
                    str[8] = textBox9.Text;
                }
                if (textBox10.Text != str[9])
                {
                    string sql = "update FriendsInfo set wordaddress='" + textBox10.Text + "'" +
                        "where username='" + str[1] + "'and sex='" + str[2] + "'and graduationgrade='" + str[3] + "'and " +
                        "politicaloutlook='" + str[4] + "'and birthday='" + str[5] + "'and phone='" + str[6] + "'and " +
                        "friendqq='" + str[7] + "'and addresses='" + str[8] + "'and studentid='" + str[0] + "'and " +
                        "specialty='" + str[10] + "'and department='" + str[11] + "'";
                    DBhelper dbhelper = new DBhelper();
                    dbhelper.Excute(sql);
                    str[9] = textBox10.Text;
                }
                if (textBox11.Text != str[10])
                {
                    string sql = "update FriendsInfo set specialty='" + textBox11.Text + "'" +
                        "where username='" + str[1] + "'and sex='" + str[2] + "'and graduationgrade='" + str[3] + "'and " +
                        "politicaloutlook='" + str[4] + "'and birthday='" + str[5] + "'and phone='" + str[6] + "'and " +
                        "friendqq='" + str[7] + "'and addresses='" + str[8] + "'and wordaddress='" + str[9] + "'and " +
                        "studentid='" + str[0] + "'and department='" + str[11] + "'";
                    DBhelper dbhelper = new DBhelper();
                    dbhelper.Excute(sql);
                    str[10] = textBox11.Text;
                }
                if (textBox12.Text != str[11])
                {
                    string sql = "update FriendsInfo set department='" + textBox12.Text + "'" +
                        "where username='" + str[1] + "'and sex='" + str[2] + "'and graduationgrade='" + str[3] + "'and " +
                        "politicaloutlook='" + str[4] + "'and birthday='" + str[5] + "'and phone='" + str[6] + "'and " +
                        "friendqq='" + str[7] + "'and addresses='" + str[8] + "'and wordaddress='" + str[9] + "'and " +
                        "specialty='" + str[10] + "'and studentid='" + str[0] + "'";
                    DBhelper dbhelper = new DBhelper();
                    dbhelper.Excute(sql);
                    str[11] = textBox12.Text;
                }
                MessageBox.Show("修改成功！");
                this.Close();
            }
        }
        #endregion

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
