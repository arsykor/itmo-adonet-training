using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DatasetDesigner
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void GetCustomersButton_Click(object sender, EventArgs e)
        {
            NorthwindDataSet NorthwindDataset1 = new NorthwindDataSet();

            NorthwindDataSetTableAdapters.CustomersTableAdapter CustomersTableAdapter1 = new NorthwindDataSetTableAdapters.CustomersTableAdapter();

            CustomersTableAdapter1.Fill(NorthwindDataset1.Customers);

            //Обрати внимание, что NorthwindDataSet - класс (наследуемый от ds), а NorthwindDataset1 - его экзепляр
            //Похоже адаптеры для конкретных табл

            foreach (NorthwindDataSet.CustomersRow NWCustomer in NorthwindDataset1.Customers.Rows)
            {
                CustomersListBox.Items.Add(NWCustomer.CompanyName);
            }
        }
    }
}
