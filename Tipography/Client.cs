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

    public partial class Client : Form
    {
        private readonly checkUser _user;

        Database database = new Database();

        int selectedRow;
        public Client(checkUser user)
        {
            _user = user;
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }
        private void IsAdmin()
        {
            if (_user.IsAdmin == 1)
            {
                button_Delete.Enabled = true;
            }
            else
            {
                button_Delete.Enabled = false;
            }
        }
        private void CreateColumns()
        {
            dataGridView1.Columns.Add("id", "id");
            dataGridView1.Columns.Add("Fio", "ФИО");
            dataGridView1.Columns.Add("Phone", "Телефон");
            dataGridView1.Columns.Add("Address", "Адрес");
            dataGridView1.Columns.Add("Organization", "Организация");
            dataGridView1.Columns.Add("IsNew", String.Empty);
            dataGridView1.Columns["id"].Visible = false;
            dataGridView1.Columns["isNew"].Visible = false;
        }
        private void ClearFields()
        {
            textBox_id.Text = "";
            textBox_Fio.Text = "";
            maskedTextBox_Phone.Text = "";
            textBox_Address.Text = "";
            textBox_Organization.Text = "";
        }

        private void ReadSingleRow(DataGridView dgw, IDataRecord record)
        {
            dgw.Rows.Add(record.GetInt32(0), record.GetString(1), record.GetString(2), record.GetString(3), record.GetString(4), RowState.ModifiedNew);
        }
        private void RefreshDataGrid(DataGridView dgw)
        {
            dgw.Rows.Clear();

            string queryString = $"SELECT * FROM Client";

            SqlCommand command = new SqlCommand(queryString, database.GetConnection());

            database.openConnection();

            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                ReadSingleRow(dgw, reader);
            }
            reader.Close();
        }
        private void Client_Load(object sender, EventArgs e)
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
                textBox_Fio.Text = row.Cells[1].Value.ToString();
                maskedTextBox_Phone.Text = row.Cells[2].Value.ToString();
                textBox_Address.Text = row.Cells[3].Value.ToString();
                textBox_Organization.Text = row.Cells[4].Value.ToString();
            }
        }

        private void imgUpdate_Click(object sender, EventArgs e)
        {
            RefreshDataGrid(dataGridView1);
            ClearFields();
        }

        private void button_New_Click(object sender, EventArgs e)
        {
            Add_FormClient addfrm = new Add_FormClient();
            addfrm.Show();
        }

        private void Search(DataGridView dgw)
        {
            dgw.Rows.Clear();

            string searchString = $"SELECT * FROM Client WHERE CONCAT (Fio, Phone, Address_c, Organization) LIKE '%" + textBox_Search.Text + "%'";

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
                dataGridView1.Rows[index].Cells[5].Value = RowState.Deleted;
                return;
            }
            dataGridView1.Rows[index].Cells[5].Value = RowState.Deleted;
        }
        private void Updated()
        {
            database.openConnection();
            for (int index = 0; index < dataGridView1.Rows.Count; index++)
            {
                var rowState = (RowState)dataGridView1.Rows[index].Cells[5].Value;

                if (rowState == RowState.Existed)
                    continue;
                if (rowState == RowState.Deleted)
                {
                    var id_client = Convert.ToInt32(dataGridView1.Rows[index].Cells[0].Value);
                    var deleteQuery = $"DELETE FROM Client WHERE id_Client = {id_client}";

                    var command = new SqlCommand(deleteQuery, database.GetConnection());
                    command.ExecuteNonQuery();
                }

                if (rowState == RowState.Modified)
                {
                    var id = dataGridView1.Rows[index].Cells[0].Value.ToString();
                    var fio = dataGridView1.Rows[index].Cells[1].Value.ToString();
                    var phone = dataGridView1.Rows[index].Cells[2].Value.ToString();
                    var address = dataGridView1.Rows[index].Cells[3].Value.ToString();
                    var organization = dataGridView1.Rows[index].Cells[4].Value.ToString();

                    var changeQuery = $"UPDATE Client SET Fio = N'{fio}', Phone = '{phone}', Address_c = N'{address}', Organization = N'{organization}' WHERE id_Client = '{id}'";

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
            var fio = textBox_Fio.Text;
            var phone = maskedTextBox_Phone.Text;
            var address = textBox_Address.Text;
            var organization = textBox_Organization.Text;
            if (dataGridView1.Rows[selectedRowIndex].Cells[0].Value.ToString() != string.Empty)
            {
                if (textBox_Fio.Text != "" && maskedTextBox_Phone.Text != "" && textBox_Address.Text != "" && textBox_Organization.Text != "")
                {
                    dataGridView1.Rows[selectedRowIndex].SetValues(id, fio, phone, address, organization);
                    dataGridView1.Rows[selectedRowIndex].Cells[5].Value = RowState.Modified;
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
