using System;
using System.Windows.Forms;

namespace WinFormsAppNetFramework
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ServiceReference1.Service1Client DataSvc = new ServiceReference1.Service1Client();
            northwindDataSet.Customers.Merge(DataSvc.GetCustomers());
            northwindDataSet.Orders.Merge(DataSvc.GetOrders());
        }
    }
}
