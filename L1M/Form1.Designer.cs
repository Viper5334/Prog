namespace L1M
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aCCTNBRDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lASTNAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fIRSTNAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aDDRESSDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cITYDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sTATEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iMAGEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.l1DataSet = new L1M.L1DataSet();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aCCTNBRDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sYMBOLDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sHARESDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pURPRISEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pURDATEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.holdingsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.l1DataSet1 = new L1M.L1DataSet1();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sYMBOLDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cONAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eXCHANOEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rATINGDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rANGDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rISKDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bETADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.masterBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.l1DataSet2 = new L1M.L1DataSet2();
            this.clientsTableAdapter = new L1M.L1DataSetTableAdapters.ClientsTableAdapter();
            this.holdingsTableAdapter = new L1M.L1DataSet1TableAdapters.HoldingsTableAdapter();
            this.masterTableAdapter = new L1M.L1DataSet2TableAdapters.MasterTableAdapter();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolTip2 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip3 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip4 = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.l1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.holdingsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.l1DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.masterBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.l1DataSet2)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(815, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(553, 192);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(157, 160);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.toolTip1.SetToolTip(this.pictureBox1, "Картинка. Фотография клиента. Показывается если выбрать клиента.");
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.aCCTNBRDataGridViewTextBoxColumn,
            this.lASTNAMEDataGridViewTextBoxColumn,
            this.fIRSTNAMEDataGridViewTextBoxColumn,
            this.aDDRESSDataGridViewTextBoxColumn,
            this.cITYDataGridViewTextBoxColumn,
            this.sTATEDataGridViewTextBoxColumn,
            this.iMAGEDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.clientsBindingSource;
            this.helpProvider1.SetHelpKeyword(this.dataGridView1, "");
            this.helpProvider1.SetHelpNavigator(this.dataGridView1, System.Windows.Forms.HelpNavigator.Topic);
            this.helpProvider1.SetHelpString(this.dataGridView1, "Таблица Clients");
            this.dataGridView1.Location = new System.Drawing.Point(414, 27);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ShowCellToolTips = false;
            this.helpProvider1.SetShowHelp(this.dataGridView1, true);
            this.dataGridView1.Size = new System.Drawing.Size(401, 159);
            this.dataGridView1.TabIndex = 2;
            this.toolTip2.SetToolTip(this.dataGridView1, "Таблица Clients");
            this.dataGridView1.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_RowHeaderMouseClick);
            this.dataGridView1.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.dataGridView1_HelpRequested);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // aCCTNBRDataGridViewTextBoxColumn
            // 
            this.aCCTNBRDataGridViewTextBoxColumn.DataPropertyName = "ACCT_NBR";
            this.aCCTNBRDataGridViewTextBoxColumn.HeaderText = "НОМЕР СЧЕТА";
            this.aCCTNBRDataGridViewTextBoxColumn.Name = "aCCTNBRDataGridViewTextBoxColumn";
            // 
            // lASTNAMEDataGridViewTextBoxColumn
            // 
            this.lASTNAMEDataGridViewTextBoxColumn.DataPropertyName = "LAST_NAME";
            this.lASTNAMEDataGridViewTextBoxColumn.HeaderText = "ФАМИЛИЕ";
            this.lASTNAMEDataGridViewTextBoxColumn.Name = "lASTNAMEDataGridViewTextBoxColumn";
            // 
            // fIRSTNAMEDataGridViewTextBoxColumn
            // 
            this.fIRSTNAMEDataGridViewTextBoxColumn.DataPropertyName = "FIRST_NAME";
            this.fIRSTNAMEDataGridViewTextBoxColumn.HeaderText = "ИМЯ";
            this.fIRSTNAMEDataGridViewTextBoxColumn.Name = "fIRSTNAMEDataGridViewTextBoxColumn";
            // 
            // aDDRESSDataGridViewTextBoxColumn
            // 
            this.aDDRESSDataGridViewTextBoxColumn.DataPropertyName = "ADDRESS";
            this.aDDRESSDataGridViewTextBoxColumn.HeaderText = "АДРЕС";
            this.aDDRESSDataGridViewTextBoxColumn.Name = "aDDRESSDataGridViewTextBoxColumn";
            // 
            // cITYDataGridViewTextBoxColumn
            // 
            this.cITYDataGridViewTextBoxColumn.DataPropertyName = "CITY";
            this.cITYDataGridViewTextBoxColumn.HeaderText = "ГОРОД";
            this.cITYDataGridViewTextBoxColumn.Name = "cITYDataGridViewTextBoxColumn";
            // 
            // sTATEDataGridViewTextBoxColumn
            // 
            this.sTATEDataGridViewTextBoxColumn.DataPropertyName = "STATE";
            this.sTATEDataGridViewTextBoxColumn.HeaderText = "УЛИЦА";
            this.sTATEDataGridViewTextBoxColumn.Name = "sTATEDataGridViewTextBoxColumn";
            // 
            // iMAGEDataGridViewTextBoxColumn
            // 
            this.iMAGEDataGridViewTextBoxColumn.DataPropertyName = "IMAGE";
            this.iMAGEDataGridViewTextBoxColumn.HeaderText = "ФОТО";
            this.iMAGEDataGridViewTextBoxColumn.Name = "iMAGEDataGridViewTextBoxColumn";
            // 
            // clientsBindingSource
            // 
            this.clientsBindingSource.DataMember = "Clients";
            this.clientsBindingSource.DataSource = this.l1DataSet;
            // 
            // l1DataSet
            // 
            this.l1DataSet.DataSetName = "L1DataSet";
            this.l1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn1,
            this.aCCTNBRDataGridViewTextBoxColumn1,
            this.sYMBOLDataGridViewTextBoxColumn,
            this.sHARESDataGridViewTextBoxColumn,
            this.pURPRISEDataGridViewTextBoxColumn,
            this.pURDATEDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.holdingsBindingSource;
            this.helpProvider1.SetHelpKeyword(this.dataGridView2, "Таблица Holdings");
            this.helpProvider1.SetHelpNavigator(this.dataGridView2, System.Windows.Forms.HelpNavigator.Topic);
            this.helpProvider1.SetHelpString(this.dataGridView2, "Таблица Holdings");
            this.dataGridView2.Location = new System.Drawing.Point(7, 27);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ShowCellToolTips = false;
            this.helpProvider1.SetShowHelp(this.dataGridView2, true);
            this.dataGridView2.Size = new System.Drawing.Size(401, 159);
            this.dataGridView2.TabIndex = 3;
            this.toolTip3.SetToolTip(this.dataGridView2, "Таблица Holdings");
            this.dataGridView2.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView2_RowHeaderMouseClick);
            this.dataGridView2.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.dataGridView2_HelpRequested);
            // 
            // idDataGridViewTextBoxColumn1
            // 
            this.idDataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn1.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn1.Name = "idDataGridViewTextBoxColumn1";
            // 
            // aCCTNBRDataGridViewTextBoxColumn1
            // 
            this.aCCTNBRDataGridViewTextBoxColumn1.DataPropertyName = "ACCT_NBR";
            this.aCCTNBRDataGridViewTextBoxColumn1.HeaderText = "НОМЕР СЧЕТА";
            this.aCCTNBRDataGridViewTextBoxColumn1.Name = "aCCTNBRDataGridViewTextBoxColumn1";
            // 
            // sYMBOLDataGridViewTextBoxColumn
            // 
            this.sYMBOLDataGridViewTextBoxColumn.DataPropertyName = "SYMBOL";
            this.sYMBOLDataGridViewTextBoxColumn.HeaderText = "СИМВОЛЬНЫЙ КОД";
            this.sYMBOLDataGridViewTextBoxColumn.Name = "sYMBOLDataGridViewTextBoxColumn";
            // 
            // sHARESDataGridViewTextBoxColumn
            // 
            this.sHARESDataGridViewTextBoxColumn.DataPropertyName = "SHARES";
            this.sHARESDataGridViewTextBoxColumn.HeaderText = "АКЦИИ";
            this.sHARESDataGridViewTextBoxColumn.Name = "sHARESDataGridViewTextBoxColumn";
            // 
            // pURPRISEDataGridViewTextBoxColumn
            // 
            this.pURPRISEDataGridViewTextBoxColumn.DataPropertyName = "PUR_PRISE";
            this.pURPRISEDataGridViewTextBoxColumn.HeaderText = "СТОИМОСТЬ ПОКУПКИ";
            this.pURPRISEDataGridViewTextBoxColumn.Name = "pURPRISEDataGridViewTextBoxColumn";
            // 
            // pURDATEDataGridViewTextBoxColumn
            // 
            this.pURDATEDataGridViewTextBoxColumn.DataPropertyName = "PUR_DATE";
            this.pURDATEDataGridViewTextBoxColumn.HeaderText = "ДАТА ПОКУПКИ";
            this.pURDATEDataGridViewTextBoxColumn.Name = "pURDATEDataGridViewTextBoxColumn";
            // 
            // holdingsBindingSource
            // 
            this.holdingsBindingSource.DataMember = "Holdings";
            this.holdingsBindingSource.DataSource = this.l1DataSet1;
            // 
            // l1DataSet1
            // 
            this.l1DataSet1.DataSetName = "L1DataSet1";
            this.l1DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridView3
            // 
            this.dataGridView3.AutoGenerateColumns = false;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn2,
            this.sYMBOLDataGridViewTextBoxColumn1,
            this.cONAMEDataGridViewTextBoxColumn,
            this.eXCHANOEDataGridViewTextBoxColumn,
            this.rATINGDataGridViewTextBoxColumn,
            this.rANGDataGridViewTextBoxColumn,
            this.rISKDataGridViewTextBoxColumn,
            this.bETADataGridViewTextBoxColumn});
            this.dataGridView3.DataSource = this.masterBindingSource;
            this.helpProvider1.SetHelpKeyword(this.dataGridView3, "Таблица Master");
            this.helpProvider1.SetHelpNavigator(this.dataGridView3, System.Windows.Forms.HelpNavigator.Topic);
            this.helpProvider1.SetHelpString(this.dataGridView3, "Таблица Master");
            this.dataGridView3.Location = new System.Drawing.Point(7, 192);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.ShowCellToolTips = false;
            this.helpProvider1.SetShowHelp(this.dataGridView3, true);
            this.dataGridView3.Size = new System.Drawing.Size(401, 160);
            this.dataGridView3.TabIndex = 4;
            this.toolTip4.SetToolTip(this.dataGridView3, "Таблица Master");
            this.dataGridView3.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView3_CellContentClick);
            this.dataGridView3.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.dataGridView3_HelpRequested);
            // 
            // idDataGridViewTextBoxColumn2
            // 
            this.idDataGridViewTextBoxColumn2.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn2.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn2.Name = "idDataGridViewTextBoxColumn2";
            // 
            // sYMBOLDataGridViewTextBoxColumn1
            // 
            this.sYMBOLDataGridViewTextBoxColumn1.DataPropertyName = "SYMBOL";
            this.sYMBOLDataGridViewTextBoxColumn1.HeaderText = "СИМВОЛЬНЫЙ КОД";
            this.sYMBOLDataGridViewTextBoxColumn1.Name = "sYMBOLDataGridViewTextBoxColumn1";
            // 
            // cONAMEDataGridViewTextBoxColumn
            // 
            this.cONAMEDataGridViewTextBoxColumn.DataPropertyName = "CO_NAME";
            this.cONAMEDataGridViewTextBoxColumn.HeaderText = "НАЗВАНИЕ КОМПАНИИ";
            this.cONAMEDataGridViewTextBoxColumn.Name = "cONAMEDataGridViewTextBoxColumn";
            // 
            // eXCHANOEDataGridViewTextBoxColumn
            // 
            this.eXCHANOEDataGridViewTextBoxColumn.DataPropertyName = "EXCHANOE";
            this.eXCHANOEDataGridViewTextBoxColumn.HeaderText = "КУРС";
            this.eXCHANOEDataGridViewTextBoxColumn.Name = "eXCHANOEDataGridViewTextBoxColumn";
            // 
            // rATINGDataGridViewTextBoxColumn
            // 
            this.rATINGDataGridViewTextBoxColumn.DataPropertyName = "RATING";
            this.rATINGDataGridViewTextBoxColumn.HeaderText = "БЕЗОПАСНОСТЬ";
            this.rATINGDataGridViewTextBoxColumn.Name = "rATINGDataGridViewTextBoxColumn";
            // 
            // rANGDataGridViewTextBoxColumn
            // 
            this.rANGDataGridViewTextBoxColumn.DataPropertyName = "RANG";
            this.rANGDataGridViewTextBoxColumn.HeaderText = "РАНГ";
            this.rANGDataGridViewTextBoxColumn.Name = "rANGDataGridViewTextBoxColumn";
            // 
            // rISKDataGridViewTextBoxColumn
            // 
            this.rISKDataGridViewTextBoxColumn.DataPropertyName = "RISK";
            this.rISKDataGridViewTextBoxColumn.HeaderText = "РИСК";
            this.rISKDataGridViewTextBoxColumn.Name = "rISKDataGridViewTextBoxColumn";
            // 
            // bETADataGridViewTextBoxColumn
            // 
            this.bETADataGridViewTextBoxColumn.DataPropertyName = "BETA";
            this.bETADataGridViewTextBoxColumn.HeaderText = "БЕТА";
            this.bETADataGridViewTextBoxColumn.Name = "bETADataGridViewTextBoxColumn";
            // 
            // masterBindingSource
            // 
            this.masterBindingSource.DataMember = "Master";
            this.masterBindingSource.DataSource = this.l1DataSet2;
            // 
            // l1DataSet2
            // 
            this.l1DataSet2.DataSetName = "L1DataSet2";
            this.l1DataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // clientsTableAdapter
            // 
            this.clientsTableAdapter.ClearBeforeFill = true;
            // 
            // holdingsTableAdapter
            // 
            this.holdingsTableAdapter.ClearBeforeFill = true;
            // 
            // masterTableAdapter
            // 
            this.masterTableAdapter.ClearBeforeFill = true;
            // 
            // helpProvider1
            // 
            this.helpProvider1.HelpNamespace = "C:\\Users\\Валера\\Documents\\Visual Studio 2015\\Projects\\L1M\\L1M\\help.chm";
            // 
            // toolTip1
            // 
            this.toolTip1.Popup += new System.Windows.Forms.PopupEventHandler(this.toolTip1_Popup);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel2});
            this.statusStrip1.Location = new System.Drawing.Point(0, 361);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(815, 22);
            this.statusStrip1.TabIndex = 5;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(0, 17);
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(0, 17);
            // 
            // toolTip2
            // 
            this.toolTip2.Popup += new System.Windows.Forms.PopupEventHandler(this.toolTip2_Popup);
            // 
            // toolTip3
            // 
            this.toolTip3.Popup += new System.Windows.Forms.PopupEventHandler(this.toolTip3_Popup);
            // 
            // toolTip4
            // 
            this.toolTip4.Popup += new System.Windows.Forms.PopupEventHandler(this.toolTip4_Popup);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(815, 383);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.dataGridView3);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.HelpButton = true;
            this.helpProvider1.SetHelpNavigator(this, System.Windows.Forms.HelpNavigator.Index);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.helpProvider1.SetShowHelp(this, true);
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.l1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.holdingsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.l1DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.masterBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.l1DataSet2)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridView dataGridView3;
        private L1DataSet l1DataSet;
        private System.Windows.Forms.BindingSource clientsBindingSource;
        private L1DataSetTableAdapters.ClientsTableAdapter clientsTableAdapter;
        private L1DataSet1 l1DataSet1;
        private System.Windows.Forms.BindingSource holdingsBindingSource;
        private L1DataSet1TableAdapters.HoldingsTableAdapter holdingsTableAdapter;
        private L1DataSet2 l1DataSet2;
        private System.Windows.Forms.BindingSource masterBindingSource;
        private L1DataSet2TableAdapters.MasterTableAdapter masterTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn aCCTNBRDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn sYMBOLDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sHARESDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pURPRISEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pURDATEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aCCTNBRDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lASTNAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fIRSTNAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aDDRESSDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cITYDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sTATEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iMAGEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn sYMBOLDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn cONAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eXCHANOEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rATINGDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rANGDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rISKDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bETADataGridViewTextBoxColumn;
        public System.Windows.Forms.HelpProvider helpProvider1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolTip toolTip2;
        private System.Windows.Forms.ToolTip toolTip3;
        private System.Windows.Forms.ToolTip toolTip4;
    }
}

