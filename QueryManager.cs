using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Postgres_Viewer
{
    public static class QueryManager
    {
    
        public static string Initquery = "SELECT table_name FROM information_schema.tables WHERE table_schema = 'public' AND table_type = 'BASE TABLE'";


        public static bool connect(NpgsqlConnection connection) {
            try
            {
                connection.Open();
            }
            catch
            {
                MessageBox.Show("데이터베이스 접속 실패", "Error");
                return false;
            }
            return true;
        }
        public static bool GetTables(NpgsqlConnection connection, System.Windows.Forms.DataGridView DataTableView)
        {
            try
            {
                
                // Sample query execution
                using (var command = new NpgsqlCommand(QueryManager.Initquery, connection))
                {
                    using (var reader = command.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            // DataGridView 초기화
                            DataTableView.Rows.Clear();
                            DataTableView.Columns.Clear();

                            // 컬럼 헤더 추가
                            DataTableView.Columns.Add("TableName", "Table Name");

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
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                MessageBox.Show("데이터베이스 접속 실패", "Error");
                return false;
            }
            return true;
        }
    }
    
}
