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
    public partial class Add_FormService : Form
    {
        Database database = new Database();
        DataSet _stock = new DataSet();
        Dictionary<string, int> stock = new Dictionary<string, int>();

        public Add_FormService()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            AddToComboMaterial();
            loadComboBox();
        }
        private void AddToComboMaterial()
        {
            database.openConnection();
            string queryString = "SELECT id_stock, Name FROM Stock";
            SqlDataAdapter adapter = new SqlDataAdapter(queryString, database.GetConnection());
            adapter.Fill(_stock, "Stocks");
            database.closeConnection();
        }
        private void loadComboBox()
        {
            foreach (DataRow row in _stock.Tables[0].Rows)
            {
                comboBox_Material.Items.Add(row[1]);
                stock.Add(row[1].ToString(), int.Parse(row[0].ToString()));
            }
            comboBox_Material.SelectedIndex = 0;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            database.openConnection();
            var name = textBox_Name.Text;
            int cost;
            var material = stock[comboBox_Material.Text];
            if (int.TryParse(textBox_Cost.Text, out cost) && textBox_Name.Text != "")
            {
                var addQuery = $"INSERT INTO Service (Name, Cost, Material) VALUES (N'{name}', '{cost}', '{material}')";

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
            textBox_Name.Text = "";
            textBox_Cost.Text = "";
            comboBox_Material.Text = "";
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            ClearFields();
        }        
    }
}
