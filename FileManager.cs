using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Postgres_Viewer
{
    public static class FileManager
    {
        public static bool ExportDataGridViewToCSV(DataGridView dgv, string filePath)
        {
            try
            {
                StringBuilder csvContent = new StringBuilder();

                // 컬럼 헤더 추가
                for (int i = 0; i < dgv.Columns.Count; i++)
                {
                    csvContent.Append(dgv.Columns[i].HeaderText);
                    if (i < dgv.Columns.Count - 1)
                        csvContent.Append(",");
                }
                csvContent.AppendLine();

                // 데이터 추가
                foreach (DataGridViewRow row in dgv.Rows)
                {
                    for (int i = 0; i < dgv.Columns.Count; i++)
                    {
                        csvContent.Append(row.Cells[i].Value);
                        if (i < dgv.Columns.Count - 1)
                            csvContent.Append(",");
                    }
                    csvContent.AppendLine();
                }

                // 파일 저장
                File.WriteAllText(filePath, csvContent.ToString(), Encoding.UTF8);
            }
            catch {
                
                return false;
            }
            return true;
            
        }

    }
}
