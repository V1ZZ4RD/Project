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
    public partial class AddForm_Employee : Form
    {
        Database database = new Database();
        public AddForm_Employee()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            AddToCombo();
        }
        private void AddToCombo()
        {
            database.openConnection();
            SqlCommand command = new SqlCommand("SELECT Job_title FROM Employee GROUP BY Job_title", database.GetConnection());
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                comboBox_Job_title.Items.Add(reader["Job_title"].ToString());
            }
            reader.Close();
            database.closeConnection();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            database.openConnection();
            var fio = textBox_Fio.Text;
            var age = textBox_Age.Text;
            var job_title = comboBox_Job_title.Text;
            var phone = maskedTextBox_Phone.Text;
            var salary = textBox_Salary.Text;
            int sal;
            int age1;
            if (textBox_Fio.Text != "" && textBox_Age.Text != "" && comboBox_Job_title.Text != "" && maskedTextBox_Phone.Text != "" && textBox_Salary.Text != "" && int.TryParse(textBox_Salary.Text, out sal) && int.TryParse(textBox_Age.Text, out age1))
            {
                var addQuery = $"INSERT INTO Employee (Fio, Age, Job_title, Phone, Salary) VALUES (N'{fio}', '{age}', N'{job_title}', '{phone}', '{salary}')";

                var command = new SqlCommand(addQuery, database.GetConnection());
                command.ExecuteNonQuery();

                MessageBox.Show("Запись успешно создана!", "Запись создана", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Некорректные данные", "Не удалось создать запись!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            database.closeConnection();
        }

        private void ClearFields()
        {
            textBox_Fio.Text = "";
            textBox_Age.Text = "";
            comboBox_Job_title.Text = "";
            maskedTextBox_Phone.Text = "";
            textBox_Salary.Text = "";
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            ClearFields();
        }
    }
}
