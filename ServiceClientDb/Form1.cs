using System;
using System.Windows.Forms;

namespace ServiceClientDb
{
    public partial class Form1 : Form
    {
        private readonly ServiceClient _client = new ServiceClient("BasicHttpBinding_IService");
        public Form1()
        {
            InitializeComponent();
        }

        private void showTablesBtn_Click(object sender, EventArgs e)
        {
            var tables = _client.GetTables();
            tablesListView.Items.Clear();
            foreach (var tableName in tables)
            {
                tablesListView.Items.Add(tableName);
            }
        }

        private void showDataBtn_Click(object sender, EventArgs e)
        {
            var tableName = tablesListView.SelectedItem as string;
            var data = _client.GetTableData(tableName);
            dataListView.Items.Clear();
            foreach (var row in data)
            {
                dataListView.Items.Add(row);
            }
        }
    }
}
