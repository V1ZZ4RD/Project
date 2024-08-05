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
    public partial class Service : Form
    {
        private readonly checkUser _user;

        Database database = new Database();
        DataSet _stock = new DataSet();
        Dictionary<string, int> stock = new Dictionary<string, int>();

        int selectedRow;

        public Service(checkUser user)
        {
            _user = user;
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

        private void CreateColumns()
        {
            dataGridView1.Columns.Add("id", "id");
            dataGridView1.Columns.Add("Name", "Наименование");
            dataGridView1.Columns.Add("Cost", "Стоимость");
            dataGridView1.Columns.Add("Material", "Материал");
            dataGridView1.Columns.Add("IsNew", String.Empty);
            dataGridView1.Columns["id"].Visible = false;
            dataGridView1.Columns["isNew"].Visible = false;
        }

        private void ClearFields()
        {
            textBox_id.Text = "";
            textBox_Name.Text = "";
            textBox_Cost.Text = "";
            comboBox_Material.Text = "";
        }

        private void ReadSingleRow(DataGridView dgw, IDataRecord record)
        {
            dgw.Rows.Add(record.GetInt32(0), record.GetString(1), record.GetString(2), record.GetString(3), RowState.ModifiedNew);
        }

        private void RefreshDataGrid(DataGridView dgw)
        {
            dgw.Rows.Clear();

            string queryString = $"SELECT Service.id_Service, Service.Name, Service.Cost, Stock.Name AS Material FROM Service INNER JOIN Stock ON Stock.id_stock = Service.Material";

            SqlCommand command = new SqlCommand(queryString, database.GetConnection());

            database.openConnection();

            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                ReadSingleRow(dgw, reader);
            }
            reader.Close();
        }

        private void Service_Load(object sender, EventArgs e)
        {
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
                textBox_Name.Text = row.Cells[1].Value.ToString();
                textBox_Cost.Text = row.Cells[2].Value.ToString();
                comboBox_Material.Text = row.Cells[3].Value.ToString();
            }
        }

        private void imgUpdate_Click(object sender, EventArgs e)
        {
            RefreshDataGrid(dataGridView1);
            ClearFields();
        }

        private void button_New_Click(object sender, EventArgs e)
        {
            Add_FormService addfrm = new Add_FormService();
            addfrm.Show();
        }


        private void Search(DataGridView dgw)
        {
            dgw.Rows.Clear();

            string searchString = $"SELECT Service.id_Service, Service.Name, Service.Cost, Stock.Name AS Material FROM Service INNER JOIN Stock ON Stock.id_stock = Service.Material WHERE CONCAT(Service.Name, Service.Cost, Stock.Name) LIKE '%" + textBox_Search.Text + "%'";

            SqlCommand com = new SqlCommand(searchString, database.GetConnection());

            database.openConnection();

            SqlDataReader read = com.ExecuteReader();

            while (read.Read())
            {
                ReadSingleRow(dgw, read);
            }

            read.Close();
        }

        private void textBox_Search_TextChanged(object sender, EventArgs e)
        {
            Search(dataGridView1);
        }

        private void deleteRow()
        {
            int index = dataGridView1.CurrentCell.RowIndex;

            dataGridView1.Rows[index].Visible = false;

            if (dataGridView1.Rows[index].Cells[0].Value.ToString() == string.Empty)
            {
                dataGridView1.Rows[index].Cells[4].Value = RowState.Deleted;
                return;
            }
            dataGridView1.Rows[index].Cells[4].Value = RowState.Deleted;
        }


        private void Updated()
        {
            database.openConnection();
            for (int index = 0; index < dataGridView1.Rows.Count; index++)
            {
                var rowState = (RowState)dataGridView1.Rows[index].Cells[4].Value;

                if (rowState == RowState.Existed)
                    continue;
                if (rowState == RowState.Deleted)
                {
                    var id_service = Convert.ToInt32(dataGridView1.Rows[index].Cells[0].Value);
                    var deleteQuery = $"DELETE FROM Service WHERE id_Service = {id_service}";

                    var command = new SqlCommand(deleteQuery, database.GetConnection());
                    command.ExecuteNonQuery();
                }

                if (rowState == RowState.Modified)
                {
                    var id = dataGridView1.Rows[index].Cells[0].Value.ToString();
                    var name = dataGridView1.Rows[index].Cells[1].Value.ToString();
                    var cost = dataGridView1.Rows[index].Cells[2].Value.ToString();
                    var material = stock[comboBox_Material.Text];

                    var changeQuery = $"UPDATE Service SET Name = N'{name}', Cost = '{cost}', Material = '{material}' WHERE id_Service = '{id}'";

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

        private void Change()
        {
            var selectedRowIndex = dataGridView1.CurrentCell.RowIndex;

            var id = textBox_id.Text;
            var name = textBox_Name.Text;
            int cost;
            var material = stock[comboBox_Material.Text];
            if (dataGridView1.Rows[selectedRowIndex].Cells[0].Value.ToString() != string.Empty)
            {
                if (int.TryParse(textBox_Cost.Text, out cost) && textBox_Name.Text != "")
                {
                    dataGridView1.Rows[selectedRowIndex].Cells[0].Value = textBox_id.Text;
                    dataGridView1.Rows[selectedRowIndex].Cells[1].Value = textBox_Name.Text;
                    dataGridView1.Rows[selectedRowIndex].Cells[2].Value = textBox_Cost.Text;
                    dataGridView1.Rows[selectedRowIndex].Cells[3].Value = comboBox_Material.Text;
                    dataGridView1.Rows[selectedRowIndex].Cells[4].Value = RowState.Modified;
                }
                else
                {
                    MessageBox.Show("Некорректные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }


        }

        private void button_Update_Click(object sender, EventArgs e)
        {
            Change();
        }

        private void imgClear_Click(object sender, EventArgs e)
        {
            ClearFields();
        }
    }
}
