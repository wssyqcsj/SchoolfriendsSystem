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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            CenterToScreen();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Friends friends = new Friends();
            Userfriends userfriends = new Userfriends();
            if (radioButton1.Checked == true)
            {
                if (textBox1.Text == "" || textBox2.Text == "")
                {
                    MessageBox.Show("账号或密码不能为空，请重新输入!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    string sql = "select * from [Admins] where adminno='" + textBox1.Text + "'and " + "passwd='" + textBox2.Text + "'";
                    DBhelper dbhelper = new DBhelper();
                    IDataReader Reader = dbhelper.Reader(sql);
                    if (Reader.Read())
                    {
                        MessageBox.Show("登录成功！");
                        friends.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("登录失败,账号或密码有错，请重新输入！");
                    }
                }
            }
            else if (radioButton2.Checked == true)
            {
                if (textBox1.Text == "" || textBox2.Text == "")
                {
                    MessageBox.Show("账号或密码不能为空，请重新输入!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    string sql = "select * from [Users] where name='" + textBox1.Text + "'and " + "passwd='" + textBox2.Text + "'";
                    DBhelper dbhelper = new DBhelper();
                    IDataReader Reader = dbhelper.Reader(sql);
                    if (Reader.Read())
                    {
                        MessageBox.Show("登录成功！");
                        userfriends.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("登录失败,账号或密码有错，请重新输入！");
                    }
                }
            }
            else
            {
                MessageBox.Show("请选择用户角色！");
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Register Register=new Register();
            Register.ShowDialog();
        }
    }
}
