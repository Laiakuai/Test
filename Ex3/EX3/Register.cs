using Ex3.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex3
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DAO dao = new DAO();
            string sql = $"select * from personLogin where id = '{textBox1.Text}'";
            string sql2 = $"insert into personLogin values('{textBox1.Text}','{textBox2.Text}')";
            if (textBox1.Text != "" && textBox1.Text != ""&& textBox3.Text!="")
            {
                if (textBox2.Text == textBox3.Text)
                {
                    IDataReader dc = dao.read(sql);
                    if (dc.Read())
                    {
                        MessageBox.Show("该账号已经被人注册");
                    }
                    else
                    {
                        dao.Execute(sql2);
                        MessageBox.Show("注册成功", "提示", MessageBoxButtons.OK);
                    }
                }
                else
                {
                    MessageBox.Show("两次输入密码不同，请重新确认");
                }
            }
            else
            {
                MessageBox.Show("账号或者密码为空");
            }
        }
    }
}
