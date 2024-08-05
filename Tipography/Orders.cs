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
using Microsoft.Office.Interop.Word;
using Application = Microsoft.Office.Interop.Word.Application;
using Document = Microsoft.Office.Interop.Word.Document;

namespace Tipography
{
    enum RowState
    {
        Existed,
        New,
        Modified,
        ModifiedNew,
        Deleted
    }
    public partial class Orders : Form
    {

        private readonly checkUser _user;

        Database database = new Database();
        DataSet _client = new DataSet();
        DataSet _employe = new DataSet();
        DataSet _service = new DataSet();
        Dictionary<string, int> client = new Dictionary<string, int>();
        Dictionary<string, int> employe = new Dictionary<string, int>();
        Dictionary<string, int> service = new Dictionary<string, int>();

        int selectedRow;

        public Orders(checkUser user)
        {
            _user = user;
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            dateTimePicker_Date.CustomFormat = "dd.MM.yyyy hh:mm:ss";
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
                comboBox_Client.Items.Add(row[1]);
                client.Add(row[1].ToString(), int.Parse(row[0].ToString()));
            }
            foreach (DataRow row in _employe.Tables[0].Rows)
            {
                comboBox_Employee.Items.Add(row[1]);
                employe.Add(row[1].ToString(), int.Parse(row[0].ToString()));
            }
            foreach (DataRow row in _service.Tables[0].Rows)
            {
                comboBox_Service.Items.Add(row[1]);
                service.Add(row[1].ToString(), int.Parse(row[0].ToString()));
            }
        }
        private void IsAdmin()
        {
            if (_user.IsAdmin == 1)
            {
                button_Delete.Enabled = true;
                button_Check.Enabled = true;
                button_Report.Enabled = true;
            }
            else if (_user.IsAdmin == 2)
            {
                button_Delete.Enabled = false;
                button_Check.Enabled = true;
                button_Report.Enabled = true;
            }
            else
            {
                button_Delete.Enabled = false;
                button_Check.Enabled = true;
                button_Report.Enabled = false;
            }
            
        }
        
        private void CreateColumns()
        {
            dataGridView1.Columns.Add("id", "id");
            dataGridView1.Columns.Add("Client", "Клиент");
            dataGridView1.Columns.Add("Employee", "Сотрудник");
            dataGridView1.Columns.Add("Service", "Услуга");
            dataGridView1.Columns.Add("Date", "Дата заказа");
            dataGridView1.Columns.Add("Amount_service", "Количество услуг");
            dataGridView1.Columns.Add("Summ", "Итого");
            dataGridView1.Columns.Add("Status", "Статус заказа");
            dataGridView1.Columns.Add("IsNew", String.Empty);
            dataGridView1.Columns["id"].Visible = false;
            dataGridView1.Columns["IsNew"].Visible = false;
        }

        private void ClearFields()
        {
            textBox_id.Text = "";
            comboBox_Client.Text = "";
            comboBox_Employee.Text = "";
            comboBox_Service.Text = "";
            dateTimePicker_Date.Text = "";
            textBox_Amount.Text = "";
            comboBox_Status.Text = "";
        }
        private void ReadSingleRow(DataGridView dgw, IDataRecord record)
        {
            dgw.Rows.Add(record.GetInt32(0), record.GetString(1), record.GetString(2), record.GetString(3), record.GetDateTime(4), record.GetInt32(5), record.GetInt32(6), record.GetString(7), RowState.ModifiedNew);
        }

        private void RefreshDataGrid(DataGridView dgw)
        {
            if (checkBoxIsNotReady.Checked==true)
            {
                dgw.Rows.Clear();

                string queryString = $"SELECT Orders.id_Order, Client.Fio AS ClientFio, Employee.Fio AS EmployeeFio, " +
                    "Service.Name AS SeriveName, Orders.Date, Orders.Amount_service, (Service.Cost*Orders.Amount_Service) AS Summ, Orders.Status " +
                    "FROM Orders INNER JOIN Client ON Client.id_Client = Orders.Client INNER JOIN Employee ON Employee.id_Employee = Orders.Employee " +
                    "INNER JOIN Service ON Service.id_Service = Orders.Service INNER JOIN Stock ON Stock.id_stock = Orders.Stock WHERE Orders.Status LIKE '%Не выполнен%'";

                SqlCommand command = new SqlCommand(queryString, database.GetConnection());

                database.openConnection();

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    ReadSingleRow(dgw, reader);
                }
                reader.Close();
            }
            else
            {
                dgw.Rows.Clear();

                string queryString = $"SELECT Orders.id_Order, Client.Fio AS ClientFio, Employee.Fio AS EmployeeFio, " +
                    "Service.Name AS SeriveName, Orders.Date, Orders.Amount_service, (Service.Cost*Orders.Amount_Service) AS Summ, Orders.Status " +
                    "FROM Orders INNER JOIN Client ON Client.id_Client = Orders.Client INNER JOIN Employee ON Employee.id_Employee = Orders.Employee " +
                    "INNER JOIN Service ON Service.id_Service = Orders.Service INNER JOIN Stock ON Stock.id_stock = Orders.Stock;";

                SqlCommand command = new SqlCommand(queryString, database.GetConnection());

                database.openConnection();

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    ReadSingleRow(dgw, reader);
                }
                reader.Close();
            }
        }
        private void Orders_Load(object sender, EventArgs e)
        {
            IsAdmin();
            CreateColumns();
            RefreshDataGrid(dataGridView1);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRow = e.RowIndex;

            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[selectedRow];

                textBox_id.Text = row.Cells[0].Value.ToString();
                comboBox_Client.Text = row.Cells[1].Value.ToString();
                comboBox_Employee.Text = row.Cells[2].Value.ToString();
                comboBox_Service.Text = row.Cells[3].Value.ToString();
                dateTimePicker_Date.Text = row.Cells[4].Value.ToString();
                textBox_Amount.Text = row.Cells[5].Value.ToString();
                comboBox_Status.Text = row.Cells[7].Value.ToString();
            }
        }

        private void imgUpdate_Click(object sender, EventArgs e)
        {
            RefreshDataGrid(dataGridView1);
            ClearFields();
        }

        private void button_New_Click(object sender, EventArgs e)
        {
            Add_FormOrders addfrm = new Add_FormOrders();
            addfrm.Show();
        }


        private void Search(DataGridView dgw)
        {
            if (checkBoxIsNotReady.Checked == true)
            {
                dgw.Rows.Clear();
                string searchString = $"SELECT Orders.id_Order, Client.Fio AS ClientFio, Employee.Fio AS EmployeeFio, Service.Name AS SeriveName, Orders.Date, Orders.Amount_service, (Service.Cost * Orders.Amount_Service) AS Summ, Orders.Status FROM Orders INNER JOIN Client ON Client.id_Client = Orders.Client INNER JOIN Employee ON Employee.id_Employee = Orders.Employee INNER JOIN Service ON Service.id_Service = Orders.Service INNER JOIN Stock ON Stock.id_stock = Orders.Stock WHERE CONCAT(Client.Fio, Employee.Fio, Service.Name, Date, Amount_service, (Service.Cost* Orders.Amount_Service)) LIKE '%" + textBox_Search.Text + "%' AND Orders.Status LIKE '%Не выполнен%'";

                SqlCommand com = new SqlCommand(searchString, database.GetConnection());

                database.openConnection();

                SqlDataReader read = com.ExecuteReader();

                while (read.Read())
                {
                    ReadSingleRow(dgw, read);
                }

                read.Close();
            }
            else
            {
                dgw.Rows.Clear();
                string searchString = $"SELECT Orders.id_Order, Client.Fio AS ClientFio, Employee.Fio AS EmployeeFio, Service.Name AS SeriveName, Orders.Date, Orders.Amount_service, (Service.Cost * Orders.Amount_Service) AS Summ, Orders.Status FROM Orders INNER JOIN Client ON Client.id_Client = Orders.Client INNER JOIN Employee ON Employee.id_Employee = Orders.Employee INNER JOIN Service ON Service.id_Service = Orders.Service INNER JOIN Stock ON Stock.id_stock = Orders.Stock WHERE CONCAT(Client.Fio, Employee.Fio, Service.Name, Date, Amount_service, (Service.Cost* Orders.Amount_Service)) LIKE '%" + textBox_Search.Text + "%'";

                SqlCommand com = new SqlCommand(searchString, database.GetConnection());

                database.openConnection();

                SqlDataReader read = com.ExecuteReader();

                while (read.Read())
                {
                    ReadSingleRow(dgw, read);
                }

                read.Close();
            }
        }
       
        private void textBox_Search_TextChanged(object sender, EventArgs e)
        {
            Search(dataGridView1);
        }

        private void deleteRow()
        {
            int index = dataGridView1.CurrentCell.RowIndex;

            dataGridView1.Rows[index].Visible = false;

            if (dataGridView1.Rows[index].Cells[0].Value.ToString()==string.Empty)
            {
                dataGridView1.Rows[index].Cells[8].Value = RowState.Deleted;
                return;
            }
            dataGridView1.Rows[index].Cells[8].Value = RowState.Deleted;
        }
        
        private void Updated()
        {
            database.openConnection();
            for (int index = 0; index < dataGridView1.Rows.Count; index++)
            {
                var rowState = (RowState)dataGridView1.Rows[index].Cells[8].Value;

                if (rowState == RowState.Existed)
                continue;
                if (rowState==RowState.Deleted)
                {
                    var id_order = Convert.ToInt32(dataGridView1.Rows[index].Cells[0].Value);
                    var deleteQuery = $"DELETE FROM Orders WHERE id_Order = {id_order}";

                    var command = new SqlCommand(deleteQuery, database.GetConnection());
                    command.ExecuteNonQuery();
                }

                if (rowState == RowState.Modified)
                {
                    var id = dataGridView1.Rows[index].Cells[0].Value.ToString();
                    var client1 = client[comboBox_Client.Text];
                    var employee1 = employe[comboBox_Employee.Text];
                    var service1 = service[comboBox_Service.Text];
                    var date = dateTimePicker_Date.Text;
                    var amount = dataGridView1.Rows[index].Cells[5].Value.ToString();
                    var status = comboBox_Status.Text;

                    var changeQuery = $"UPDATE Orders SET Client = '{client1}', Employee = '{employee1}', Service = '{service1}', Date = '{date}', Amount_service = '{amount}', Status = '{status}' WHERE id_Order = '{id}'";

                    var command = new SqlCommand(changeQuery, database.GetConnection());
                    command.ExecuteNonQuery();
                }
            }
            database.closeConnection();
        }

        private void button_Delete_Click(object sender, EventArgs e)
        {
            deleteRow();
            ClearFields();
        }

        private void button_Save_Click(object sender, EventArgs e)
        {
            Updated();
            ClearFields();
        }

        private bool ChangeStock(int amount)
        {

            database.openConnection();
            string check = "SELECT Stock.Amount FROM Stock INNER JOIN Service ON Service.Material = Stock.id_stock WHERE Service.Name = '" + comboBox_Service.Text + "'; ";
            SqlCommand command1 = new SqlCommand(check, database.GetConnection());
            string res = command1.ExecuteScalar().ToString();
            int stockamount = int.Parse(res);
            database.closeConnection();
            if (amount <= stockamount)
            {
                database.openConnection();
                string query = "UPDATE R SET R.Amount = R.Amount - " + amount + " FROM Stock AS R INNER JOIN Service AS P ON R.id_stock = P.Material WHERE P.Name = '" + comboBox_Service.Text + "'; ";
                SqlCommand command = new SqlCommand(query, database.GetConnection());
                command.ExecuteNonQuery();
                database.closeConnection();
                return true;
            }
            else
            {
                MessageBox.Show("Не хватает материала на складе!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                database.closeConnection();
                return false;
            }
        }
        private bool ReturnStock(int amount)
        {
            database.openConnection();
            string check = "SELECT Stock.Amount FROM Stock INNER JOIN Service ON Service.Material = Stock.id_stock WHERE Service.Name = '" + comboBox_Service.Text + "'; ";
            SqlCommand command1 = new SqlCommand(check, database.GetConnection());
            string res = command1.ExecuteScalar().ToString();
            int stockamount = int.Parse(res);
            database.closeConnection();
            if (amount <= stockamount)
            {
                database.openConnection();
                string query = "UPDATE R SET R.Amount = R.Amount + " + amount + " FROM Stock AS R INNER JOIN Service AS P ON R.id_stock = P.Material WHERE P.Name = '" + comboBox_Service.Text + "'; ";
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
        private void Change()
        {
            var selectedRowIndex = dataGridView1.CurrentCell.RowIndex;
            if (selectedRowIndex < 0 || dataGridView1.Rows[selectedRowIndex].Cells[0].Value.ToString() == string.Empty)
                return;

            int newAmount;
            if (!int.TryParse(textBox_Amount.Text, out newAmount))
            {
                MessageBox.Show("Количество услуг должно иметь числовое значение!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int oldAmount = Convert.ToInt32(dataGridView1.Rows[selectedRowIndex].Cells[5].Value);
            int difference = newAmount - oldAmount;

            if (difference > 0 && !ChangeStock(difference))
                return;


            dataGridView1.Rows[selectedRowIndex].Cells[1].Value = comboBox_Client.Text;
            dataGridView1.Rows[selectedRowIndex].Cells[2].Value = comboBox_Employee.Text;
            dataGridView1.Rows[selectedRowIndex].Cells[3].Value = comboBox_Service.Text;
            dataGridView1.Rows[selectedRowIndex].Cells[4].Value = dateTimePicker_Date.Text;
            dataGridView1.Rows[selectedRowIndex].Cells[5].Value = newAmount.ToString();
            dataGridView1.Rows[selectedRowIndex].Cells[7].Value = comboBox_Status.Text;
            dataGridView1.Rows[selectedRowIndex].Cells[8].Value = RowState.Modified;
            if (difference < 0)
                ReturnStock(-difference);
        }
        
       
        private void button_Update_Click(object sender, EventArgs e)
        {
            Change();
        }

        private void imgClear_Click(object sender, EventArgs e)
        {
            ClearFields();
        }
        private string SearchServiceCost()
        {
            database.openConnection();
            DataGridViewRow row = dataGridView1.Rows[selectedRow];
            string search = $"SELECT Cost FROM Service WHERE Name LIKE '%" + row.Cells[3].Value.ToString() + "%'";
            SqlCommand srch = new SqlCommand(search, database.GetConnection());
            string getValue = srch.ToString();
            string res = srch.ExecuteScalar().ToString();
            return res;
        }
        private void button_Check_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentCell == null)
            {
                MessageBox.Show("Кликните по нужному заказу для подготовки квитанции!", "Квитанция", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string inputFilePath = $@"{System.Windows.Forms.Application.StartupPath}\Receipt\Example.docx";
                string outputFilePath = $@"{System.Windows.Forms.Application.StartupPath}\Receipt\Чек от {DateTime.Now.ToString("dd-MM-yyyy hh-mm-ss")}.pdf";

                var selectedRowIndex = dataGridView1.CurrentCell.RowIndex;

                if (dataGridView1.Rows[selectedRowIndex].Cells[0].Value.ToString() != string.Empty)
                {
                    DataGridViewRow row = dataGridView1.Rows[selectedRow];
                    int amount = int.Parse(row.Cells[5].Value.ToString());
                    int cost = int.Parse(SearchServiceCost());
                    int sum = amount * cost;
                    var replacements = new System.Collections.Generic.Dictionary<string, string>
                {
                {"<Num>", row.Cells[0].Value.ToString()},
                {"<Fio_client>", row.Cells[1].Value.ToString()},
                {"<Name>", row.Cells[3].Value.ToString()},
                {"<Cost>", cost.ToString()},
                {"<Amount>", row.Cells[5].Value.ToString()},
                {"<Sum>", row.Cells[6].Value.ToString()},
                {"<Fio_employee>", row.Cells[2].Value.ToString()},
                {"<DateTime>", row.Cells[4].Value.ToString()}
                };
                    if (ReplaceTags(inputFilePath, outputFilePath, replacements) == true)
                    {
                        MessageBox.Show("Чек успешно сформирован!", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Кликните по нужному заказу для подготовки квитанции!", "Квитанция", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
        }
        public static bool ReplaceTags(string inputFilePath, string outputFilePath, System.Collections.Generic.Dictionary<string, string> replacements)
        {
            Application wordApp = new Application();
            try
            {
                Document doc = wordApp.Documents.Open(inputFilePath, ReadOnly: true);
                Range range = doc.Content;
                Document newDoc = wordApp.Documents.Add();
                range.Copy();
                newDoc.Range().Paste();
                foreach (var replacement in replacements)
                {
                    newDoc.Content.Find.Execute(FindText: replacement.Key, ReplaceWith: replacement.Value, Replace: WdReplace.wdReplaceAll);
                }
                newDoc.SaveAs2(outputFilePath, WdSaveFormat.wdFormatPDF);
                newDoc.Close(SaveChanges: false);
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при формировании чека: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            finally
            {
                wordApp.Quit();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Report addfrm = new Report();
            addfrm.Show();
        }

        private void checkBoxIsNotReady_CheckedChanged(object sender, EventArgs e)
        {
            RefreshDataGrid(dataGridView1);
        }
    }
}
