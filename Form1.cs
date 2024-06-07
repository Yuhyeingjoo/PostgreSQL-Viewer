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
        UIManager UiManager = new UIManager();
        List<System.Windows.Forms.TextBox> textBoxes = new List<System.Windows.Forms.TextBox>();
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
            tabControl1.TabPages[StatusVar.tabResultIndex].Text = "Results";
            tabControl1.TabPages[StatusVar.tabProblemsIndex].Text = "Problems";
            tabControl1.TabPages[StatusVar.tabTablesIndex].Text = "Tables";
            tabControl1.TabPages[StatusVar.tabCallStackIndex].Text = "Call Stacks";
            this.listBox1.DrawMode = DrawMode.OwnerDrawFixed;
            this.listBox1.DrawItem += new DrawItemEventHandler(listBoxErrors_DrawItem);

        }
        private void TextBox_KeyDown(object sender, KeyEventArgs e)
        {
            
            if( e.Control && e.KeyCode == Keys.Enter)
            {
                e.Handled = true;
                buttonRun_Click(null, null);
                return;
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
                MessageBox.Show("Please enter a valid value", "Error");
                return;
            }
            string connectionString = $"Host={host};Port={port};Username={username};Password={password};Database={database}";
            connection = new NpgsqlConnection(connectionString);

            if (QueryUiManager.connect(connection) && QueryUiManager.GetTables(connection, dataGridViewTables)) {
                buttonConnect.Enabled = false;
                StatusVar.connected = true;
                foreach (var box in textBoxes) {
                    box.ReadOnly = true;
                }
                MessageBox.Show("DB Connection successful!", "Connection status");
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
            if (QueryUiManager.RunQuery(connection, DataTableView, listBox1, sql))
            {
                AddCallStack(sql);
            }
            else {
                MessageBox.Show("Failed to Run Query", "Error");
                return;
            }


        }

        private void tableListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (StatusVar.connected) {
                QueryUiManager.GetTables(connection, dataGridViewTables);
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

        private void listBoxErrors_DrawItem(object sender, DrawItemEventArgs e)
        {
            // 항목이 없으면 반환
            if (e.Index < 0) return;

            // 항목 텍스트를 가져옴
            string text = listBox1.Items[e.Index].ToString();

            // 기본 백그라운드와 포그라운드 색상을 설정
            e.DrawBackground();
            e.Graphics.DrawString(text, e.Font, Brushes.Black, e.Bounds);

            // 각 항목 사이에 선을 그리기 위한 펜
            using (Pen pen = new Pen(Color.Gray))
            {
                int y = e.Bounds.Bottom - 1;
                e.Graphics.DrawLine(pen, e.Bounds.Left, y, e.Bounds.Right, y);
            }

            e.DrawFocusRectangle();
        }
        private void AddCallStack(string sql)
        {
            listBoxCallStack.Items.Add(sql);
        }

        private void buttonCopy_Click(object sender, EventArgs e)
        {
            string copyString = UiManager.GetLowestSelectedItemText(listBoxCallStack);
            Clipboard.SetText(copyString);
        }
       
        private void buttonDelete_Click(object sender, EventArgs e)
        {
            for (int i = listBoxCallStack.SelectedIndices.Count - 1; i >= 0; i--)
            {
                int selectedIndex = listBoxCallStack.SelectedIndices[i];
                listBoxCallStack.Items.RemoveAt(selectedIndex);
            }
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            listBoxCallStack.Items.Clear();
        }

        private void rightPageBtn_Click(object sender, EventArgs e)
        {
            QueryUiManager.NextPage(DataTableView);
        }

        private void LeftPageBtn_Click(object sender, EventArgs e)
        {
            QueryUiManager.PrevPage(DataTableView);
        }
    }
}
