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
    public partial class Employee : Form
    {
        private readonly checkUser _user;

        Database database = new Database();

        int selectedRow;
        public Employee(checkUser user)
        {
            _user = user;
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }
        private void CreateColumns()
        {
            dataGridView1.Columns.Add("id", "id");
            dataGridView1.Columns.Add("Fio", "ФИО");
            dataGridView1.Columns.Add("Age", "Возраст");
            dataGridView1.Columns.Add("Job_title", "Должность");
            dataGridView1.Columns.Add("Phone", "Номер");
            dataGridView1.Columns.Add("Salary", "Зарплата");
            dataGridView1.Columns.Add("IsNew", String.Empty);
            dataGridView1.Columns["id"].Visible = false;
            dataGridView1.Columns["isNew"].Visible = false;
        }
        

        private void ClearFields()
        {
            textBox_id.Text = "";
            textBox_Fio.Text = "";
            textBox_Age.Text = "";
            comboBox_Job_title.Text = "";
            comboBox_Job_title.Text = "";
            maskedTextBox_Phone.Text = "";
            textBox_Salary.Text = "";
        }

        private void ReadSingleRow(DataGridView dgw, IDataRecord record)
        {
            dgw.Rows.Add(record.GetInt32(0), record.GetString(1), record.GetInt32(2), record.GetString(3), record.GetString(4), record.GetString(5), RowState.ModifiedNew);
        }
        
        private void RefreshDataGrid(DataGridView dgw)
        {
            dgw.Rows.Clear();

            string queryString = $"SELECT * FROM Employee";

            SqlCommand command = new SqlCommand(queryString, database.GetConnection());

            database.openConnection();

            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                ReadSingleRow(dgw, reader);
            }
            reader.Close();
        }

        private void Employee_Load(object sender, EventArgs e)
        {
            CreateColumns();
            RefreshDataGrid(dataGridView1);
            AddToCombo();
        }
        private void AddToCombo()
        {
            SqlCommand command = new SqlCommand("SELECT Job_title FROM Employee GROUP BY Job_title", database.GetConnection());
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                comboBox_Job_title.Items.Add(reader["Job_title"].ToString());
            }
            reader.Close();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRow = e.RowIndex;

            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[selectedRow];
                textBox_id.Text = row.Cells[0].Value.ToString();
                textBox_Fio.Text = row.Cells[1].Value.ToString();
                textBox_Age.Text = row.Cells[2].Value.ToString();
                comboBox_Job_title.Text = row.Cells[3].Value.ToString();
                maskedTextBox_Phone.Text = row.Cells[4].Value.ToString();
                textBox_Salary.Text = row.Cells[5].Value.ToString();
            }
        }

        private void imgUpdate_Click(object sender, EventArgs e)
        {
            RefreshDataGrid(dataGridView1);
            ClearFields();
        }

        private void button_New_Click(object sender, EventArgs e)
        {
            AddForm_Employee addfrm = new AddForm_Employee();
            addfrm.Show();
        }

        private void Search(DataGridView dgw)
        {
            dgw.Rows.Clear();

            string searchString = $"SELECT * FROM Employee WHERE CONCAT (Fio, Age, Job_title, Phone, Salary) LIKE '%" + textBox_Search.Text + "%'";

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
                dataGridView1.Rows[index].Cells[6].Value = RowState.Deleted;
                return;
            }
            dataGridView1.Rows[index].Cells[6].Value = RowState.Deleted;
        }

        private void Updated()
        {
            database.openConnection();
            for (int index = 0; index < dataGridView1.Rows.Count; index++)
            {
                var rowState = (RowState)dataGridView1.Rows[index].Cells[6].Value;

                if (rowState == RowState.Existed)
                    continue;
                if (rowState == RowState.Deleted)
                {
                    var id_employee = Convert.ToInt32(dataGridView1.Rows[index].Cells[0].Value);
                    var deleteQuery = $"DELETE FROM Employee WHERE id_Employee = {id_employee}";

                    var command = new SqlCommand(deleteQuery, database.GetConnection());
                    command.ExecuteNonQuery();
                }

                if (rowState == RowState.Modified)
                {
                    var id = dataGridView1.Rows[index].Cells[0].Value.ToString();
                    var fio = dataGridView1.Rows[index].Cells[1].Value.ToString();
                    var age = dataGridView1.Rows[index].Cells[2].Value.ToString();
                    var job_title = dataGridView1.Rows[index].Cells[3].Value.ToString();
                    var phone = dataGridView1.Rows[index].Cells[4].Value.ToString();
                    var salary = dataGridView1.Rows[index].Cells[5].Value.ToString();

                    var changeQuery = $"UPDATE Employee SET Fio = N'{fio}', Age = '{age}', Job_title = N'{job_title}', Phone = '{phone}', Salary = '{salary}' WHERE id_Employee = '{id}'";

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
            var age = textBox_Age.Text;
            var job_title = comboBox_Job_title.Text;
            var phone = maskedTextBox_Phone.Text;
            var salary = textBox_Salary.Text;
            int sal;
            int age1;
            
            if (dataGridView1.Rows[selectedRowIndex].Cells[0].Value.ToString() != string.Empty)
            {
                if (!int.TryParse(textBox_Salary.Text, out sal))
                {
                    MessageBox.Show("Некорректные данные в поле \"Зарплата\"", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else if(!int.TryParse(textBox_Age.Text, out age1))
                {
                    MessageBox.Show("Некорректные данные в поле \"Возраст\"", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    if (textBox_Fio.Text != "" && textBox_Age.Text != "" && comboBox_Job_title.Text != "" && maskedTextBox_Phone.Text != "" && textBox_Salary.Text != "")
                    {
                        dataGridView1.Rows[selectedRowIndex].SetValues(id, fio, age, job_title, phone, salary);
                        dataGridView1.Rows[selectedRowIndex].Cells[6].Value = RowState.Modified;
                    }
                    else
                    {
                        MessageBox.Show("Некорректные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Ошибка!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
