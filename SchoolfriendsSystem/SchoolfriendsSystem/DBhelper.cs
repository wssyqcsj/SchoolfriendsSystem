using System.Data.SqlClient;
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
    internal class DBhelper
    {
        public SqlConnection connection()
        {
            string str = "Data Source = DESKTOP-MAVVO41; Initial Catalog = Schoolfriends; Integrated Security = True";
            SqlConnection sc = new SqlConnection(str);
            sc.Open();//打开数据链接
            return sc;
        }
        //命令
        public SqlCommand command(string sql)
        {
            SqlCommand sc = new SqlCommand(sql, connection());
            return sc;
        }

        //添加，删除，更新
        public int Excute(string sql)
        {
            return command(sql).ExecuteNonQuery();
        }

        //查询，返回数据
        public SqlDataReader Reader(string sql)
        {
            return command(sql).ExecuteReader();
        }
    }
}
