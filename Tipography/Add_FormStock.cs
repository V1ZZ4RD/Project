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
    public partial class Add_FormStock : Form
    {
        Database database = new Database();
        DataSet _name = new DataSet();
        Dictionary<string, int> name = new Dictionary<string, int>();
        public Add_FormStock()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            AddToComboName();
            loadComboBox();
        }
        private void AddToComboName()
        {
            database.openConnection();
            string queryString = "SELECT id_stock, Name FROM Stock";
            SqlDataAdapter adapter = new SqlDataAdapter(queryString, database.GetConnection());
            adapter.Fill(_name, "Names");
            database.closeConnection();
        }
        private void loadComboBox()
        {
            foreach (DataRow row in _name.Tables[0].Rows)
            {
                comboBox_Name.Items.Add(row[1]);
                name.Add(row[1].ToString(), int.Parse(row[0].ToString()));
            }
            comboBox_Name.SelectedIndex = 0;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            database.openConnection();
            var name = comboBox_Name.Text;
            int amount;
            if (int.TryParse(textBox_Amount.Text, out amount))
            {
                var addQuery = $"UPDATE Stock SET Amount = Amount + '{amount}' WHERE Name = '" + name + "'";

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
            comboBox_Name.Text = "";
            textBox_Amount.Text = "";
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            ClearFields();
        }
    }
}
