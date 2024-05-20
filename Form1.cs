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
            try {
                using (var command = new NpgsqlCommand(sql, connection))
                {
                    using (var reader = command.ExecuteReader())
                    {
                        // DataGridView 초기화
                        DataTableView.Rows.Clear();
                        DataTableView.Columns.Clear();


                        // 반환된 데이터가 있는지 확인

                        if (reader is string)
                        {
                            DataGridViewTextBoxColumn column = new DataGridViewTextBoxColumn();
                            DataTableView.Columns.Add(column);
                            DataTableView.Rows.Add(reader);
                            Console.WriteLine($"String result: {reader}");
                        }
                        else if (reader is int)
                        {
                            DataGridViewTextBoxColumn column = new DataGridViewTextBoxColumn();
                            DataTableView.Columns.Add(column);
                            DataTableView.Rows.Add(reader.ToString());
                            Console.WriteLine($"Integer result: {reader}");
                        }
                        else if (reader.HasRows)
                        {
                           
                            // 컬럼 헤더 추가
                            for (int i = 0; i < reader.FieldCount; i++)
                            {
                                DataGridViewTextBoxColumn column = new DataGridViewTextBoxColumn();
                                column.HeaderText = reader.GetName(i);
                                column.Name = reader.GetName(i);
                                DataTableView.Columns.Add(column); // 컬럼 추가
                            }

                            // 데이터 읽기
                            while (reader.Read())
                            {
                                // 각 행의 데이터를 배열에 추가
                                object[] rowData = new object[reader.FieldCount];
                                reader.GetValues(rowData);

                                // DataGridView에 행 추가
                                DataTableView.Rows.Add(rowData);
                            }

                            // 컬럼 너비 자동 조정
                            DataTableView.AutoResizeColumns();
                            DataTableView.Refresh();
                        }
                        else
                        {
                            Console.WriteLine("No data returned from the query.");
                        }
                    }
                }
            } 
            
            catch { 
            
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
