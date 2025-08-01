using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kasir
{
    public partial class CashierCustomerForm : UserControl
    {
        public CashierCustomerForm()
        {
            InitializeComponent();
            displayCustomerData();
        }

        public void displayCustomerData()
        {
            CustomersData customerData = new CustomersData();
            List<CustomersData> listData = customerData.allCustomersData();
            dataGridView1.DataSource = listData;
            dataGridView1.Columns["Price"].DefaultCellStyle.Format = "c";
            dataGridView1.Columns["Price"].DefaultCellStyle.FormatProvider = CultureInfo.GetCultureInfo("id-ID");
            dataGridView1.Columns["Price"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            dataGridView1.Columns["Pay"].DefaultCellStyle.Format = "c";
            dataGridView1.Columns["Pay"].DefaultCellStyle.FormatProvider = CultureInfo.GetCultureInfo("id-ID");
            dataGridView1.Columns["Pay"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            dataGridView1.Columns["Change"].DefaultCellStyle.Format = "c";
            dataGridView1.Columns["Change"].DefaultCellStyle.FormatProvider = CultureInfo.GetCultureInfo("id-ID");
            dataGridView1.Columns["Change"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            gridTable();
        }

        public void gridTable()
        {
            dataGridView1.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            int defaultWidth = 160;
            int idWidth = 60;
            foreach (DataGridViewColumn col in dataGridView1.Columns)
            {
                if (col.Name.Equals("CustID", StringComparison.OrdinalIgnoreCase))
                {
                    col.Width = idWidth;
                }
                else
                {
                    col.Width = defaultWidth;
                }
            }
        }
    }
}
