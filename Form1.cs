using Npgsql;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Npgsql.Replication.PgOutput.Messages.RelationMessage;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Postgres_Viewer
{
    public partial class Form1 : Form
    {
       
        NpgsqlConnection connection;
        List< System.Windows.Forms.TextBox> textBoxes = new List<System.Windows.Forms.TextBox>();
        public Form1()
        {
            InitializeComponent();
            initUserComponent();
            typeof(DataGridView).InvokeMember("DoubleBuffered", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.SetProperty, null, DataTableView, new object[] { true });
        }
        private void initUserComponent() {
            textBoxSQL.KeyDown += new KeyEventHandler(TextBox_KeyDown);
            textBoxes.Add(textBoxHost);
            textBoxes.Add(textBoxDBName);
            textBoxes.Add(textBoxPasswd);
            textBoxes.Add(textBoxUserName);
        }
        private void TextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                buttonRun_Click(null, null);
            }
        }
        private void buttonConnect_Click(object sender, EventArgs e)
        {
            string host = textBoxHost.Text;
            string port = "5432";
            string username = textBoxUserName.Text;
            string password = textBoxPasswd.Text;
            string database = textBoxDBName.Text;

            if (host == "" || username == "" || password == "" || database == "") {
                MessageBox.Show("올바른 값을 입력하세요.", "Error");
                return;
            }
            string connectionString = $"Host={host};Port={port};Username={username};Password={password};Database={database}";
            connection = new NpgsqlConnection(connectionString);
            
            if (QueryManager.connect(connection) && QueryManager.GetTables(connection, DataTableView)) {
                buttonConnect.Enabled = false;
                StatusVar.connected = true;
                foreach (var box in textBoxes) { 
                    box.ReadOnly = true;
                }
            }
           
            
        }

        private void buttonDisconnect_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Close();
                buttonConnect.Enabled = true;
                StatusVar.connected = false;
                foreach (var box in textBoxes)
                {
                    box.ReadOnly = false;
                }
            }
            catch { 
            
            }
            
        }



        private void buttonRun_Click(object sender, EventArgs e)
        {
            string sql =  textBoxSQL.Text;
            if (sql == "") {
                return;
            }
            if (!QueryManager.RunQuery(connection, DataTableView, sql)) {
                MessageBox.Show("Failed to Run Query", "Error");
            }


        }

        private void tableListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (StatusVar.connected) {
                QueryManager.GetTables(connection, DataTableView);
            }
        }

        private void clearViewerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataTableView.Rows.Clear();
            DataTableView.Columns.Clear();
        }

        private void exportToCsvToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "CSV files (*.csv)|*.csv|All files (*.*)|*.*";
                saveFileDialog.FilterIndex = 1;
                saveFileDialog.RestoreDirectory = true;

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = saveFileDialog.FileName;
                    if (FileManager.ExportDataGridViewToCSV(DataTableView, filePath))
                    {
                        MessageBox.Show(filePath , "Success");
                    }
                    else {
                        MessageBox.Show("Failed to Exoprt", "Error");
                    }
                }
            }
        }
    }
}
