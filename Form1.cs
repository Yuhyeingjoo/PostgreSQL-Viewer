using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Postgres_Viewer
{
    public partial class Form1 : Form
    {
       
        NpgsqlConnection connection;

        public Form1()
        {
            InitializeComponent();
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

            try {
                connection.Open();
                // Sample query execution
               
            }
            catch (Exception ex) { 
                Console.WriteLine(ex.Message);
                MessageBox.Show("데이터베이스 접속 실패", "Error");
                return;
            }

            buttonConnect.Enabled = false;
            StatusVar.connected = true;
        }

        private void buttonDisconnect_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Close();
                buttonConnect.Enabled = true;
                StatusVar.connected = false;
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
                        // 반환된 데이터가 있는지 확인
                        
                        if (reader is string)
                        {
                            Console.WriteLine($"String result: {reader}");
                        }
                        else if (reader is int)
                        { 
                            Console.WriteLine($"Integer result: {reader}");
                        }
                        else if (reader.HasRows)
                        {
                            // DataGridView 초기화
                            DataTableView.Rows.Clear();
                            DataTableView.Columns.Clear();

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
    }
}
