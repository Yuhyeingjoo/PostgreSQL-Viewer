namespace Postgres_Viewer
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonDisconnect = new System.Windows.Forms.Button();
            this.buttonConnect = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxDBName = new System.Windows.Forms.TextBox();
            this.textBoxPasswd = new System.Windows.Forms.TextBox();
            this.textBoxUserName = new System.Windows.Forms.TextBox();
            this.textBoxHost = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.textBoxSQL = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.buttonRun = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tab1TablePanel = new System.Windows.Forms.TableLayoutPanel();
            this.panelTab1 = new System.Windows.Forms.Panel();
            this.DataTableView = new System.Windows.Forms.DataGridView();
            this.tab1LowTablePanel = new System.Windows.Forms.TableLayoutPanel();
            this.LeftPageBtn = new System.Windows.Forms.Button();
            this.rightPageBtn = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.panelTab2 = new System.Windows.Forms.Panel();
            this.dataGridViewTables = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.panelTab3 = new System.Windows.Forms.Panel();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.tab4CallStackPanel = new System.Windows.Forms.Panel();
            this.listBoxCallStack = new System.Windows.Forms.ListBox();
            this.tab4ToolPanel = new System.Windows.Forms.Panel();
            this.buttonClear = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonCopy = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.tableListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearViewerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportToCsvToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label6 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tab1TablePanel.SuspendLayout();
            this.panelTab1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataTableView)).BeginInit();
            this.tab1LowTablePanel.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.panelTab2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTables)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.panelTab3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tab4CallStackPanel.SuspendLayout();
            this.tab4ToolPanel.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel3, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 24);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 75F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(870, 505);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonDisconnect);
            this.panel1.Controls.Add(this.buttonConnect);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.textBoxDBName);
            this.panel1.Controls.Add(this.textBoxPasswd);
            this.panel1.Controls.Add(this.textBoxUserName);
            this.panel1.Controls.Add(this.textBoxHost);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(864, 29);
            this.panel1.TabIndex = 0;
            // 
            // buttonDisconnect
            // 
            this.buttonDisconnect.Location = new System.Drawing.Point(757, 3);
            this.buttonDisconnect.Name = "buttonDisconnect";
            this.buttonDisconnect.Size = new System.Drawing.Size(101, 23);
            this.buttonDisconnect.TabIndex = 2;
            this.buttonDisconnect.Text = "Disconnect";
            this.buttonDisconnect.UseVisualStyleBackColor = true;
            this.buttonDisconnect.Click += new System.EventHandler(this.buttonDisconnect_Click);
            // 
            // buttonConnect
            // 
            this.buttonConnect.Location = new System.Drawing.Point(655, 3);
            this.buttonConnect.Name = "buttonConnect";
            this.buttonConnect.Size = new System.Drawing.Size(102, 23);
            this.buttonConnect.TabIndex = 2;
            this.buttonConnect.Text = "Connect";
            this.buttonConnect.UseVisualStyleBackColor = true;
            this.buttonConnect.Click += new System.EventHandler(this.buttonConnect_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(491, 8);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 12);
            this.label4.TabIndex = 1;
            this.label4.Text = "DB Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(329, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 12);
            this.label3.TabIndex = 1;
            this.label3.Text = "Passwd";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(169, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "User";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "HOST";
            // 
            // textBoxDBName
            // 
            this.textBoxDBName.Location = new System.Drawing.Point(556, 3);
            this.textBoxDBName.Name = "textBoxDBName";
            this.textBoxDBName.Size = new System.Drawing.Size(94, 21);
            this.textBoxDBName.TabIndex = 0;
            this.textBoxDBName.Text = "testdb";
            // 
            // textBoxPasswd
            // 
            this.textBoxPasswd.Location = new System.Drawing.Point(382, 3);
            this.textBoxPasswd.Name = "textBoxPasswd";
            this.textBoxPasswd.PasswordChar = '*';
            this.textBoxPasswd.Size = new System.Drawing.Size(94, 21);
            this.textBoxPasswd.TabIndex = 0;
            // 
            // textBoxUserName
            // 
            this.textBoxUserName.Location = new System.Drawing.Point(208, 3);
            this.textBoxUserName.Name = "textBoxUserName";
            this.textBoxUserName.Size = new System.Drawing.Size(94, 21);
            this.textBoxUserName.TabIndex = 0;
            this.textBoxUserName.Text = "postgres";
            // 
            // textBoxHost
            // 
            this.textBoxHost.Location = new System.Drawing.Point(55, 3);
            this.textBoxHost.Name = "textBoxHost";
            this.textBoxHost.Size = new System.Drawing.Size(94, 21);
            this.textBoxHost.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.tableLayoutPanel2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 38);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(864, 111);
            this.panel2.TabIndex = 1;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel2.Controls.Add(this.panel6, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.panel4, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(864, 111);
            this.tableLayoutPanel2.TabIndex = 5;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.textBoxSQL);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(3, 3);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(778, 105);
            this.panel6.TabIndex = 9;
            // 
            // textBoxSQL
            // 
            this.textBoxSQL.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxSQL.Location = new System.Drawing.Point(0, 0);
            this.textBoxSQL.Multiline = true;
            this.textBoxSQL.Name = "textBoxSQL";
            this.textBoxSQL.Size = new System.Drawing.Size(778, 105);
            this.textBoxSQL.TabIndex = 4;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label6);
            this.panel4.Controls.Add(this.buttonRun);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(787, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(74, 105);
            this.panel4.TabIndex = 10;
            // 
            // buttonRun
            // 
            this.buttonRun.Location = new System.Drawing.Point(6, 27);
            this.buttonRun.Name = "buttonRun";
            this.buttonRun.Size = new System.Drawing.Size(65, 35);
            this.buttonRun.TabIndex = 6;
            this.buttonRun.Text = "Run";
            this.buttonRun.UseVisualStyleBackColor = true;
            this.buttonRun.Click += new System.EventHandler(this.buttonRun_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 3);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 12);
            this.label5.TabIndex = 0;
            this.label5.Text = "SQL";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.tabControl1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(3, 155);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(864, 347);
            this.panel3.TabIndex = 2;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(864, 347);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.tab1TablePanel);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(856, 321);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tab1TablePanel
            // 
            this.tab1TablePanel.ColumnCount = 1;
            this.tab1TablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tab1TablePanel.Controls.Add(this.panelTab1, 0, 0);
            this.tab1TablePanel.Controls.Add(this.tab1LowTablePanel, 0, 1);
            this.tab1TablePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tab1TablePanel.Location = new System.Drawing.Point(3, 3);
            this.tab1TablePanel.Name = "tab1TablePanel";
            this.tab1TablePanel.RowCount = 2;
            this.tab1TablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tab1TablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.tab1TablePanel.Size = new System.Drawing.Size(850, 315);
            this.tab1TablePanel.TabIndex = 1;
            // 
            // panelTab1
            // 
            this.panelTab1.Controls.Add(this.DataTableView);
            this.panelTab1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelTab1.Location = new System.Drawing.Point(3, 3);
            this.panelTab1.Name = "panelTab1";
            this.panelTab1.Size = new System.Drawing.Size(844, 276);
            this.panelTab1.TabIndex = 1;
            // 
            // DataTableView
            // 
            this.DataTableView.AllowUserToAddRows = false;
            this.DataTableView.AllowUserToDeleteRows = false;
            this.DataTableView.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.DataTableView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataTableView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DataTableView.Location = new System.Drawing.Point(0, 0);
            this.DataTableView.Name = "DataTableView";
            this.DataTableView.ReadOnly = true;
            this.DataTableView.RowTemplate.Height = 23;
            this.DataTableView.Size = new System.Drawing.Size(844, 276);
            this.DataTableView.TabIndex = 1;
            // 
            // tab1LowTablePanel
            // 
            this.tab1LowTablePanel.ColumnCount = 2;
            this.tab1LowTablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tab1LowTablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tab1LowTablePanel.Controls.Add(this.LeftPageBtn, 0, 0);
            this.tab1LowTablePanel.Controls.Add(this.rightPageBtn, 1, 0);
            this.tab1LowTablePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tab1LowTablePanel.Location = new System.Drawing.Point(3, 285);
            this.tab1LowTablePanel.Name = "tab1LowTablePanel";
            this.tab1LowTablePanel.RowCount = 1;
            this.tab1LowTablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tab1LowTablePanel.Size = new System.Drawing.Size(844, 27);
            this.tab1LowTablePanel.TabIndex = 2;
            // 
            // LeftPageBtn
            // 
            this.LeftPageBtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.LeftPageBtn.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.LeftPageBtn.Location = new System.Drawing.Point(392, 3);
            this.LeftPageBtn.Name = "LeftPageBtn";
            this.LeftPageBtn.Size = new System.Drawing.Size(27, 21);
            this.LeftPageBtn.TabIndex = 2;
            this.LeftPageBtn.Text = "<";
            this.LeftPageBtn.UseVisualStyleBackColor = true;
            this.LeftPageBtn.Click += new System.EventHandler(this.LeftPageBtn_Click);
            // 
            // rightPageBtn
            // 
            this.rightPageBtn.Dock = System.Windows.Forms.DockStyle.Left;
            this.rightPageBtn.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.rightPageBtn.Location = new System.Drawing.Point(425, 3);
            this.rightPageBtn.Name = "rightPageBtn";
            this.rightPageBtn.Size = new System.Drawing.Size(25, 21);
            this.rightPageBtn.TabIndex = 1;
            this.rightPageBtn.Text = ">";
            this.rightPageBtn.UseVisualStyleBackColor = true;
            this.rightPageBtn.Click += new System.EventHandler(this.rightPageBtn_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.panelTab2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(856, 321);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // panelTab2
            // 
            this.panelTab2.Controls.Add(this.dataGridViewTables);
            this.panelTab2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelTab2.Location = new System.Drawing.Point(3, 3);
            this.panelTab2.Name = "panelTab2";
            this.panelTab2.Size = new System.Drawing.Size(850, 315);
            this.panelTab2.TabIndex = 0;
            // 
            // dataGridViewTables
            // 
            this.dataGridViewTables.AllowUserToAddRows = false;
            this.dataGridViewTables.AllowUserToDeleteRows = false;
            this.dataGridViewTables.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridViewTables.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTables.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewTables.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewTables.Name = "dataGridViewTables";
            this.dataGridViewTables.ReadOnly = true;
            this.dataGridViewTables.RowTemplate.Height = 23;
            this.dataGridViewTables.Size = new System.Drawing.Size(850, 315);
            this.dataGridViewTables.TabIndex = 2;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.panelTab3);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(856, 321);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "tabPage3";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // panelTab3
            // 
            this.panelTab3.Controls.Add(this.listBox1);
            this.panelTab3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelTab3.Location = new System.Drawing.Point(3, 3);
            this.panelTab3.Name = "panelTab3";
            this.panelTab3.Size = new System.Drawing.Size(850, 315);
            this.panelTab3.TabIndex = 0;
            // 
            // listBox1
            // 
            this.listBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 12;
            this.listBox1.Location = new System.Drawing.Point(0, 0);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(850, 315);
            this.listBox1.TabIndex = 1;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.tableLayoutPanel3);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(856, 321);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "tabPage4";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.tab4CallStackPanel, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.tab4ToolPanel, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.47619F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 89.52381F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(850, 315);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // tab4CallStackPanel
            // 
            this.tab4CallStackPanel.Controls.Add(this.listBoxCallStack);
            this.tab4CallStackPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tab4CallStackPanel.Location = new System.Drawing.Point(3, 35);
            this.tab4CallStackPanel.Name = "tab4CallStackPanel";
            this.tab4CallStackPanel.Size = new System.Drawing.Size(844, 277);
            this.tab4CallStackPanel.TabIndex = 1;
            // 
            // listBoxCallStack
            // 
            this.listBoxCallStack.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxCallStack.FormattingEnabled = true;
            this.listBoxCallStack.ItemHeight = 12;
            this.listBoxCallStack.Location = new System.Drawing.Point(0, 0);
            this.listBoxCallStack.Name = "listBoxCallStack";
            this.listBoxCallStack.Size = new System.Drawing.Size(844, 277);
            this.listBoxCallStack.TabIndex = 0;
            // 
            // tab4ToolPanel
            // 
            this.tab4ToolPanel.Controls.Add(this.buttonClear);
            this.tab4ToolPanel.Controls.Add(this.buttonDelete);
            this.tab4ToolPanel.Controls.Add(this.buttonCopy);
            this.tab4ToolPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tab4ToolPanel.Location = new System.Drawing.Point(3, 3);
            this.tab4ToolPanel.Name = "tab4ToolPanel";
            this.tab4ToolPanel.Size = new System.Drawing.Size(844, 26);
            this.tab4ToolPanel.TabIndex = 0;
            // 
            // buttonClear
            // 
            this.buttonClear.BackColor = System.Drawing.Color.Transparent;
            this.buttonClear.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonClear.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonClear.Location = new System.Drawing.Point(103, 3);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(44, 20);
            this.buttonClear.TabIndex = 1;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = false;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.BackColor = System.Drawing.Color.Transparent;
            this.buttonDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonDelete.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonDelete.Location = new System.Drawing.Point(53, 3);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(44, 20);
            this.buttonDelete.TabIndex = 0;
            this.buttonDelete.Text = "Del";
            this.buttonDelete.UseVisualStyleBackColor = false;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonCopy
            // 
            this.buttonCopy.BackColor = System.Drawing.Color.Transparent;
            this.buttonCopy.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonCopy.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonCopy.Location = new System.Drawing.Point(3, 3);
            this.buttonCopy.Name = "buttonCopy";
            this.buttonCopy.Size = new System.Drawing.Size(44, 20);
            this.buttonCopy.TabIndex = 0;
            this.buttonCopy.Text = "Copy";
            this.buttonCopy.UseVisualStyleBackColor = false;
            this.buttonCopy.Click += new System.EventHandler(this.buttonCopy_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(870, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tableListToolStripMenuItem,
            this.clearViewerToolStripMenuItem,
            this.exportToCsvToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(42, 20);
            this.toolStripMenuItem1.Text = "Tool";
            // 
            // tableListToolStripMenuItem
            // 
            this.tableListToolStripMenuItem.Name = "tableListToolStripMenuItem";
            this.tableListToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.tableListToolStripMenuItem.Text = "TableList";
            this.tableListToolStripMenuItem.Click += new System.EventHandler(this.tableListToolStripMenuItem_Click);
            // 
            // clearViewerToolStripMenuItem
            // 
            this.clearViewerToolStripMenuItem.Name = "clearViewerToolStripMenuItem";
            this.clearViewerToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.clearViewerToolStripMenuItem.Text = "Clear Viewer";
            this.clearViewerToolStripMenuItem.Click += new System.EventHandler(this.clearViewerToolStripMenuItem_Click);
            // 
            // exportToCsvToolStripMenuItem
            // 
            this.exportToCsvToolStripMenuItem.Name = "exportToCsvToolStripMenuItem";
            this.exportToCsvToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.exportToCsvToolStripMenuItem.Text = "Export to csv";
            this.exportToCsvToolStripMenuItem.Click += new System.EventHandler(this.exportToCsvToolStripMenuItem_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("굴림", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label6.Location = new System.Drawing.Point(9, 67);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 11);
            this.label6.TabIndex = 7;
            this.label6.Text = "Ctrl+Enter";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.GhostWhite;
            this.ClientSize = new System.Drawing.Size(870, 529);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Postgres Viewer";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tab1TablePanel.ResumeLayout(false);
            this.panelTab1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataTableView)).EndInit();
            this.tab1LowTablePanel.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.panelTab2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTables)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.panelTab3.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tab4CallStackPanel.ResumeLayout(false);
            this.tab4ToolPanel.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBoxUserName;
        private System.Windows.Forms.TextBox textBoxHost;
        private System.Windows.Forms.TextBox textBoxPasswd;
        private System.Windows.Forms.TextBox textBoxDBName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonDisconnect;
        private System.Windows.Forms.Button buttonConnect;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem tableListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearViewerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportToCsvToolStripMenuItem;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button buttonRun;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.TextBox textBoxSQL;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Panel panelTab2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Panel panelTab3;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.DataGridView dataGridViewTables;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Panel tab4CallStackPanel;
        private System.Windows.Forms.Panel tab4ToolPanel;
        private System.Windows.Forms.Button buttonCopy;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.ListBox listBoxCallStack;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.TableLayoutPanel tab1TablePanel;
        private System.Windows.Forms.Panel panelTab1;
        private System.Windows.Forms.DataGridView DataTableView;
        private System.Windows.Forms.TableLayoutPanel tab1LowTablePanel;
        private System.Windows.Forms.Button LeftPageBtn;
        private System.Windows.Forms.Button rightPageBtn;
        private System.Windows.Forms.Label label6;
    }
}

