using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Tipography
{
    public partial class log_in : Form
    {
        Database database = new Database();
        public log_in()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }
        private void log_in_Load_1(object sender, EventArgs e)
        {
            pictureBox3.Visible = false;
            textBox_password.UseSystemPasswordChar = true;
            textBox_login.MaxLength = 50;
            textBox_password.MaxLength = 50;
        }

        private void label1_Click(object sender, EventArgs e) {}
        private void pictureBox4_Click(object sender, EventArgs e)
        {
            textBox_login.Text = "";
            textBox_password.Text = "";
        }
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            textBox_password.UseSystemPasswordChar = true;
            pictureBox3.Visible = false;
            pictureBox2.Visible = true;
        }

        public void pictureBox2_Click(object sender, EventArgs e)
        {
            textBox_password.UseSystemPasswordChar = false;
            pictureBox2.Visible = false;
            pictureBox3.Visible = true;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            var loginUser = textBox_login.Text;
            var passwordUser = textBox_password.Text;


            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();


            string querystring = $"select id_user, login_user, password_user, is_admin from register where login_user = '{loginUser}' and password_user='{passwordUser}'";
            SqlCommand command = new SqlCommand(querystring, database.GetConnection());
            adapter.SelectCommand = command;
            adapter.Fill(table);
                
            if (table.Rows.Count == 1)
            {
                var user = new checkUser(table.Rows[0].ItemArray[1].ToString(), Convert.ToSByte(table.Rows[0].ItemArray[3]));

                MessageBox.Show("Вход успешно выполнен", "Успешно!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Form1 frm1 = new Form1(user);
                this.Hide();
                frm1.ShowDialog();
                this.Show();
            }
            else
                MessageBox.Show("Неправильно введен логин или пароль", "Неверные данные", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
