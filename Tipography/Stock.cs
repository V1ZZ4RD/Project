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
    public partial class Stock : Form
    {
        private readonly checkUser _user;

        Database database = new Database();
        DataSet _name = new DataSet();
        Dictionary<string, int> name = new Dictionary<string, int>();

        int selectedRow;
        public Stock(checkUser user)
        {
            _user = user;
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
        private void CreateColumns()
        {
            dataGridView1.Columns.Add("id", "id");
            dataGridView1.Columns.Add("Name", "Наименование");
            dataGridView1.Columns.Add("Amount", "Количество");
            dataGridView1.Columns.Add("IsNew", String.Empty);
            dataGridView1.Columns["id"].Visible = false;
            dataGridView1.Columns["isNew"].Visible = false;
        }

        private void ClearFields()
        {
            textBox_id.Text = "";
            comboBox_Name.Text = "";
            textBox_Amount.Text = "";
        }

        private void ReadSingleRow(DataGridView dgw, IDataRecord record)
        {
            dgw.Rows.Add(record.GetInt32(0), record.GetString(1), record.GetInt32(2), RowState.ModifiedNew);
        }

        private void RefreshDataGrid(DataGridView dgw)
        {
            dgw.Rows.Clear();

            string queryString = $"SELECT * FROM Stock";

            SqlCommand command = new SqlCommand(queryString, database.GetConnection());

            database.openConnection();

            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                ReadSingleRow(dgw, reader);
            }
            reader.Close();
        }

        private void Stock_Load(object sender, EventArgs e)
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
                comboBox_Name.Text = row.Cells[1].Value.ToString();
                textBox_Amount.Text = row.Cells[2].Value.ToString();
            }
        }

        private void imgUpdate_Click(object sender, EventArgs e)
        {
            RefreshDataGrid(dataGridView1);
            ClearFields();
        }

        private void button_New_Click(object sender, EventArgs e)
        {
            Add_FormStock addfrm = new Add_FormStock();
            addfrm.Show();
        }
        private void Search(DataGridView dgw)
        {
            dgw.Rows.Clear();

            string searchString = $"SELECT * FROM Stock WHERE CONCAT (Name, Amount) LIKE '%" + textBox_Search.Text + "%'";

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
                dataGridView1.Rows[index].Cells[3].Value = RowState.Deleted;
                return;
            }
            dataGridView1.Rows[index].Cells[3].Value = RowState.Deleted;
        }
        private void Updated()
        {
            database.openConnection();
            for (int index = 0; index < dataGridView1.Rows.Count; index++)
            {
                var rowState = (RowState)dataGridView1.Rows[index].Cells[3].Value;

                if (rowState == RowState.Existed)
                    continue;
                if (rowState == RowState.Deleted)
                {
                    var id_stock = Convert.ToInt32(dataGridView1.Rows[index].Cells[0].Value);
                    var deleteQuery = $"DELETE FROM Stock WHERE id_stock = {id_stock}";

                    var command = new SqlCommand(deleteQuery, database.GetConnection());
                    command.ExecuteNonQuery();
                }

                if (rowState == RowState.Modified)
                {
                    var id = dataGridView1.Rows[index].Cells[0].Value.ToString();
                    var name = dataGridView1.Rows[index].Cells[1].Value.ToString();
                    var amount = dataGridView1.Rows[index].Cells[2].Value.ToString();

                    var changeQuery = $"UPDATE Stock SET Name = N'{name}', Amount = '{amount}' WHERE id_stock = '{id}'";

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
            var name = comboBox_Name.Text;
            int amount;
            if (dataGridView1.Rows[selectedRowIndex].Cells[0].Value.ToString() != string.Empty)
            {
                if (int.TryParse(textBox_Amount.Text, out amount))
                {
                    dataGridView1.Rows[selectedRowIndex].SetValues(id, name, amount);
                    dataGridView1.Rows[selectedRowIndex].Cells[3].Value = RowState.Modified;
                }
                else
                {
                    MessageBox.Show("Некорректно введено количество материала!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
