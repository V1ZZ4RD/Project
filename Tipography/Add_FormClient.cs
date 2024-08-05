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
    public partial class Add_FormClient : Form
    {
        Database database = new Database();
        public Add_FormClient()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            database.openConnection();
            var fio = textBox_Fio.Text;
            var phone = maskedTextBox_Phone.Text;
            var address = textBox_Address.Text;
            var organization = textBox_Organization.Text;
            if (textBox_Fio.Text != "" && maskedTextBox_Phone.Text != "" && textBox_Address.Text != "" && textBox_Organization.Text != "")
            {
                var addQuery = $"INSERT INTO Client (Fio, Phone, Address_c, Organization) VALUES (N'{fio}', '{phone}', N'{address}', N'{organization}')";

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
            maskedTextBox_Phone.Text = "";
            textBox_Address.Text = "";
            textBox_Organization.Text = "";
            
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            ClearFields();
        }
    }
}
