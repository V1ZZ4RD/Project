using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Tipography
{
    public partial class Form1 : Form
    {
        private readonly checkUser _user;

        Database database = new Database();
        public Form1(checkUser user)
        {
            _user = user;
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void IsAdmin()
        {
            if (_user.IsAdmin == 1)
            {
                buttonEmployee.Enabled = true;
                buttonService.Enabled = true;
                buttonStock.Enabled = true;
            }
            else if(_user.IsAdmin == 2)
            {
                buttonEmployee.Enabled = false;
                buttonService.Enabled = false;
                buttonStock.Enabled = true;
            }
            else
            {
                buttonEmployee.Enabled = false;
                buttonService.Enabled = false;
                buttonStock.Enabled = false;
            }
            
        }

        private void buttonOrders_Click(object sender, EventArgs e)
        {
            Orders orders = new Orders(_user);
            this.Hide();
            orders.ShowDialog();
            this.Show();
        }

        private void buttonClient_Click(object sender, EventArgs e)
        {
            Client client = new Client(_user);
            this.Hide();
            client.ShowDialog();
            this.Show();
        }

        private void buttonEmployee_Click(object sender, EventArgs e)
        {
            Employee employee = new Employee(_user);
            this.Hide();
            employee.ShowDialog();
            this.Show();
        }

        private void buttonService_Click(object sender, EventArgs e)
        {
            Service service = new Service(_user);
            this.Hide();
            service.ShowDialog();
            this.Show();
        }
        private void buttonStock_Click(object sender, EventArgs e)
        {
            Stock stock = new Stock(_user);
            stock.ShowDialog();
            this.Show();
        }
        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            IsAdmin();
        }

        
    }
}
