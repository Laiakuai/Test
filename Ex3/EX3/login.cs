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
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "")
            {
                Boolean flag = Login();
                if(flag == true)
                {
                    FrmMain frmMain = new FrmMain();
                    this.Hide();
                    frmMain.ShowDialog();
                    this.Dispose();
                }
            }
            else
            {
                MessageBox.Show("账号或密码为空，请重新输入", "提示", MessageBoxButtons.OK);
            }
        }
        //登入方法验证是否允许登入，允许返回真
        public Boolean Login()
        {
            DAO dao = new DAO();
            //string sql = "select * from personLogin where id = '" + textBox1.Text + "' and password = '" + textBox2.Text + "'";
            //string sql2 = String.Format("select * from personLogin where id = '{0}' and password = '{1}'", textBox1.Text, textBox2.Text);
            string sql3 = $"select * from personLogin where id = '{textBox1.Text}' and password = '{textBox2.Text}'";
            IDataReader dc = dao.read(sql3);
            if (dc.Read())
            {
                MessageBox.Show("登入成功");
                return true;
            }
            else
            {
                MessageBox.Show("登入失败");
                return false;
            }
        }

        private void login_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Register register = new Register();
            register.ShowDialog();
        }
    }
}
