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
using Excel = Microsoft.Office.Interop.Excel;

namespace Tipography
{
    public partial class Report : Form
    {
        Database database = new Database();
        DataSet _service = new DataSet();
        Dictionary<string, int> service = new Dictionary<string, int>();

        public Report()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            dateTimePicker_FirstDate.CustomFormat = "dd.MM.yyyy hh:mm:ss";
            dateTimePicker_SecondDate.CustomFormat = "dd.MM.yyyy hh:mm:ss";
            AddToComboServices();
            loadComboBox();
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
            foreach (DataRow row in _service.Tables[0].Rows)
            {
                comboBox_Service.Items.Add(row[1]);
                service.Add(row[1].ToString(), int.Parse(row[0].ToString()));
            }
            comboBox_Service.SelectedIndex = 0;
        }

        private void GetReport()
        {
            Excel.Application exApp = new Excel.Application();
            exApp.Workbooks.Add();
            Excel.Worksheet wsh = (Excel.Worksheet)exApp.ActiveSheet;

            database.openConnection();
            var service1 = service[comboBox_Service.Text];
            var date1 = dateTimePicker_FirstDate.Text;
            var date2 = dateTimePicker_SecondDate.Text;


            string reportQuery = $"SELECT Orders.id_Order AS ID, Service.Name AS Наименование_услуги, Orders.Date AS Дата, (Service.Cost * Orders.Amount_Service) AS Сумма FROM Orders INNER JOIN Service ON Service.id_Service = Orders.Service WHERE Service.Name = '{comboBox_Service.Text}' AND(Orders.Date BETWEEN '{date1}' AND '{date2}')";
            SqlCommand command = new SqlCommand(reportQuery, database.GetConnection());
            command.Parameters.AddWithValue("@serviceName", comboBox_Service.Text);
            command.Parameters.AddWithValue("@date1", date1);
            command.Parameters.AddWithValue("@date2", date2);

            DataTable dt = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(dt);

            int row = 1;
            for (int i = 0; i < dt.Columns.Count; i++)
            {
                wsh.Cells[row, i + 1] = dt.Columns[i].ColumnName;
            }

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                row++;
                for (int j = 0; j < dt.Columns.Count; j++)
                {
                    wsh.Cells[row, j + 1] = dt.Rows[i][j].ToString();
                }
            }
            int lastRow = row + 1;
            string sumColumnLetter = "D";
            wsh.Cells[lastRow, 3].Value = "ИТОГО";
            wsh.Cells[lastRow, 4].Formula = $"=SUM({sumColumnLetter}2:{sumColumnLetter}{lastRow - 1})";
            exApp.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GetReport();
        }
        private void ClearFields()
        {
            comboBox_Service.Text = "";
            dateTimePicker_FirstDate.Text = "";
            dateTimePicker_SecondDate.Text = "";
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            ClearFields();
        }
    }
}
