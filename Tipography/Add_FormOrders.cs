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
using System.Data.Common;

namespace Tipography
{
    public partial class Add_FormOrders : Form
    {
        Database database = new Database();
        DataSet _client = new DataSet();
        DataSet _employe = new DataSet();
        DataSet _service = new DataSet();
        Dictionary<string, int> client = new Dictionary<string, int>();
        Dictionary<string, int> employe = new Dictionary<string, int>(); 
        Dictionary<string, int> service = new Dictionary<string, int>();

        public Add_FormOrders()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            dateTimePicker_Date1.CustomFormat = "dd.MM.yyyy hh:mm:ss";
            AddToComboClient();
            AddToComboEmployee();
            AddToComboServices();
            loadComboBox();
        }
        private void AddToComboClient()
        {
            database.openConnection();
            string queryString = "SELECT id_Client, Fio FROM Client";
            SqlDataAdapter adapter = new SqlDataAdapter(queryString, database.GetConnection());
            adapter.Fill(_client, "Clients");
            database.closeConnection();
        }
        private void AddToComboEmployee()
        {
            database.openConnection();
            string queryString = "SELECT id_Employee, Fio FROM Employee";
            SqlDataAdapter adapter = new SqlDataAdapter(queryString, database.GetConnection());
            adapter.Fill(_employe, "Employee");
            database.closeConnection();
        }
        private void AddToComboServices()
        {
            database.openConnection();
            string queryString = "SELECT id_Service, Name FROM Service";
            SqlDataAdapter adapter = new SqlDataAdapter(queryString, database.GetConnection());
            adapter.Fill(_service, "Services");
            database.closeConnection();
        }
        private void loadComboBox()
        {
            foreach (DataRow row in _client.Tables[0].Rows)
            {
                comboBox_Client1.Items.Add(row[1]);
                client.Add(row[1].ToString(), int.Parse(row[0].ToString()));
            }
            foreach (DataRow row in _employe.Tables[0].Rows)
            {
                comboBox_Employee1.Items.Add(row[1]);
                employe.Add(row[1].ToString(), int.Parse(row[0].ToString()));
            }
            foreach (DataRow row in _service.Tables[0].Rows)
            {
                comboBox_Service1.Items.Add(row[1]);
                service.Add(row[1].ToString(), int.Parse(row[0].ToString()));
            }
            comboBox_Client1.SelectedIndex = 0;
            comboBox_Employee1.SelectedIndex = 0;
            comboBox_Service1.SelectedIndex = 0;
        }

        private bool ChangeStock(int amount)
        {

                database.openConnection();
                string check = "SELECT Stock.Amount FROM Stock INNER JOIN Service ON Service.Material = Stock.id_stock WHERE Service.Name = '" + comboBox_Service1.Text + "'; ";
                SqlCommand command1 = new SqlCommand(check, database.GetConnection());
                string res = command1.ExecuteScalar().ToString();
                int stockamount = int.Parse(res);
                database.closeConnection();
                if (amount <= stockamount)
                {
                    database.openConnection();
                    string query = "UPDATE R SET R.Amount = R.Amount - " + amount + " FROM Stock AS R INNER JOIN Service AS P ON R.id_stock = P.Material WHERE P.Name = '" + comboBox_Service1.Text + "'; ";
                    SqlCommand command = new SqlCommand(query, database.GetConnection());
                    command.ExecuteNonQuery();
                    database.closeConnection();
                    return true;
                }
                else
                {
                    MessageBox.Show("Не хватает материала на складе!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    database.closeConnection();
                    return false;
                }
        }
        private string SearchStockAmount()
        {

            string search = $"SELECT Material FROM Service WHERE Name LIKE '%" + comboBox_Service1.Text + "%'";
            SqlCommand srch = new SqlCommand(search, database.GetConnection());
            string getValue = srch.ToString();
            string res = srch.ExecuteScalar().ToString();
            

            return res;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            database.openConnection();
            var client1 = client[comboBox_Client1.Text];
            var employee1 = employe[comboBox_Employee1.Text];
            var service1 = service[comboBox_Service1.Text];
            var date = dateTimePicker_Date1.Text;
            var material = SearchStockAmount();
            string status = "Не выполнен";
            int amount;
            if (int.TryParse(textBox_Amount1.Text, out amount))
            {
                if (ChangeStock(amount)==true)
                {
                    database.openConnection();
                    var addQuery = $"INSERT INTO Orders (Client, Employee, Service, Date, Amount_service, Status, Stock) VALUES ('{client1}', '{employee1}', '{service1}', '{date}', '{amount}', '{status}', '{material}')";

                    var command = new SqlCommand(addQuery, database.GetConnection());
                    command.ExecuteNonQuery();

                    MessageBox.Show("Запись успешно создана!", "Запись создана", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                database.closeConnection();
            }
            else
            {
                MessageBox.Show("Некорректные данные", "Не удалось создать запись!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                database.closeConnection();
            }

            
        }

        private void ClearFields()
        {
            comboBox_Client1.Text = "";
            comboBox_Employee1.Text = "";
            comboBox_Service1.Text = "";
            dateTimePicker_Date1.Text = "";
            textBox_Amount1.Text = "";
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            ClearFields();
        }
    }
}
