using Npgsql;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Postgres_Viewer
{
    public static class QueryManager
    {
    
        public static string Initquery = "SELECT table_name FROM information_schema.tables WHERE table_schema = 'public' AND table_type = 'BASE TABLE'";
        public static string tmpInit = @"
    SELECT
        tbl.table_name AS ""Table Name"",
        pg_catalog.pg_get_userbyid(cls.relowner) AS ""Owner"",
        pg_catalog.obj_description(cls.oid, 'pg_class') AS ""Description""
    FROM
        information_schema.tables tbl
    JOIN
        pg_catalog.pg_class cls ON tbl.table_name = cls.relname
    WHERE
        tbl.table_schema = 'public'
        AND tbl.table_type = 'BASE TABLE';";

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
        public static bool IsSelectQuery(string query)
        {
            
            string cleanedQuery = RemoveComments(query).Trim();


            return Regex.IsMatch(cleanedQuery, @"^\s*SELECT\b", RegexOptions.IgnoreCase);
        }

        public static bool RunQuery(NpgsqlConnection connection, System.Windows.Forms.DataGridView DataTableView, System.Windows.Forms.ListBox listBox ,  string sql) {
            try
            {
                listBox.ClearSelected();
                using (var command = new NpgsqlCommand(sql, connection))
                {
                    if (QueryManager.IsSelectQuery(sql))
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
                            else if (reader.FieldCount > 0) {
                                for (int i = 0; i < reader.FieldCount; i++)
                                {
                                    DataGridViewTextBoxColumn column = new DataGridViewTextBoxColumn();
                                    column.HeaderText = reader.GetName(i);
                                    column.Name = reader.GetName(i);
                                    DataTableView.Columns.Add(column); // 컬럼 추가
                                }
                            }
                            else
                            {

                                Console.WriteLine("No data returned from the query.");
                            }
                        }
                    }
                    else
                    {
                        DataTableView.Rows.Clear();
                        DataTableView.Columns.Clear();
                        command.ExecuteNonQuery();
                    }

                }
            }

            catch (Exception ex)
            {
                listBox.Items.Add(ex.Message);
                
                
                return false;
            }

            
            return true;
        }
        static string RemoveComments(string query)
        {
            // Remove single line comments (--)
            query = Regex.Replace(query, @"--.*?(\r?\n|$)", " ");

            // Remove multi-line comments (/* ... */)
            query = Regex.Replace(query, @"/\*.*?\*/", " ", RegexOptions.Singleline);

            return query;
        }
        public static bool GetTables(NpgsqlConnection connection, System.Windows.Forms.DataGridView DataTableView)
        {
            try
            {
                DataTableView.Rows.Clear();
                DataTableView.Columns.Clear();
                using (var command = new NpgsqlCommand(QueryManager.tmpInit, connection))
                {
                    using (var reader = command.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            // 컬럼 헤더 추가
                            DataTableView.Columns.Add("Table Name", "Table Name");
                            DataTableView.Columns.Add("Owner", "Owner");
                            DataTableView.Columns.Add("Description", "Description");

                            // 데이터 읽기
                            while (reader.Read())
                            {
                                // 각 행의 데이터를 배열에 추가
                                object[] rowData = new object[reader.FieldCount];
                                for (int i = 0; i < reader.FieldCount; i++)
                                {
                                    rowData[i] = reader.IsDBNull(i) ? "NULL" : reader.GetValue(i); // NULL 값을 'NULL'로 표시
                                }

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
