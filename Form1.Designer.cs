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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.tableListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearViewerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportToCsvToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.panelTab1 = new System.Windows.Forms.Panel();
            this.panelTab2 = new System.Windows.Forms.Panel();
            this.DataTableView = new System.Windows.Forms.DataGridView();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.panelTab1.SuspendLayout();
            this.panelTab2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataTableView)).BeginInit();
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
            this.buttonRun.Location = new System.Drawing.Point(6, 18);
            this.buttonRun.Name = "buttonRun";
            this.buttonRun.Size = new System.Drawing.Size(65, 24);
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
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(864, 347);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.panelTab1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(856, 321);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
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
            // panelTab1
            // 
            this.panelTab1.Controls.Add(this.DataTableView);
            this.panelTab1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelTab1.Location = new System.Drawing.Point(3, 3);
            this.panelTab1.Name = "panelTab1";
            this.panelTab1.Size = new System.Drawing.Size(850, 315);
            this.panelTab1.TabIndex = 0;
            // 
            // panelTab2
            // 
            this.panelTab2.Controls.Add(this.listBox1);
            this.panelTab2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelTab2.Location = new System.Drawing.Point(3, 3);
            this.panelTab2.Name = "panelTab2";
            this.panelTab2.Size = new System.Drawing.Size(850, 315);
            this.panelTab2.TabIndex = 0;
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
            this.DataTableView.Size = new System.Drawing.Size(850, 315);
            this.DataTableView.TabIndex = 1;
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
            this.listBox1.TabIndex = 0;
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
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.panelTab1.ResumeLayout(false);
            this.panelTab2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataTableView)).EndInit();
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
        private System.Windows.Forms.Panel panelTab1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Panel panelTab2;
        private System.Windows.Forms.DataGridView DataTableView;
        private System.Windows.Forms.ListBox listBox1;
    }
}

