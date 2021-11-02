namespace ShipmentProducts
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.BT_OK = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.ListType = new System.Windows.Forms.ListBox();
            this.GB = new System.Windows.Forms.GroupBox();
            this.GBBox = new System.Windows.Forms.GroupBox();
            this.CBBox2 = new System.Windows.Forms.CheckBox();
            this.ClearBT = new System.Windows.Forms.Button();
            this.BtLiterAdd = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.BTOk1 = new System.Windows.Forms.Button();
            this.GBValue = new System.Windows.Forms.GroupBox();
            this.CBBox1 = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.BTOk = new System.Windows.Forms.Button();
            this.NUM = new System.Windows.Forms.NumericUpDown();
            this.LoadLB = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.OkBT = new System.Windows.Forms.Button();
            this.GridReport = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.CBStatus = new System.Windows.Forms.ComboBox();
            this.CBLOT = new System.Windows.Forms.ComboBox();
            this.CBModel = new System.Windows.Forms.ComboBox();
            this.CBClient = new System.Windows.Forms.ComboBox();
            this.LabelText = new System.Windows.Forms.Label();
            this.Grid = new System.Windows.Forms.DataGridView();
            this.GB.SuspendLayout();
            this.GBBox.SuspendLayout();
            this.GBValue.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUM)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridReport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Grid)).BeginInit();
            this.SuspendLayout();
            // 
            // BT_OK
            // 
            this.BT_OK.BackColor = System.Drawing.Color.Wheat;
            this.BT_OK.FlatAppearance.BorderSize = 0;
            this.BT_OK.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.BT_OK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BT_OK.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BT_OK.Location = new System.Drawing.Point(12, 432);
            this.BT_OK.Name = "BT_OK";
            this.BT_OK.Size = new System.Drawing.Size(336, 38);
            this.BT_OK.TabIndex = 5;
            this.BT_OK.Text = "Выбрать";
            this.BT_OK.UseVisualStyleBackColor = false;
            this.BT_OK.Click += new System.EventHandler(this.BT_OK_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(10, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(225, 24);
            this.label1.TabIndex = 4;
            this.label1.Text = "Выберите тип продукта";
            // 
            // ListType
            // 
            this.ListType.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ListType.FormattingEnabled = true;
            this.ListType.ItemHeight = 24;
            this.ListType.Location = new System.Drawing.Point(12, 38);
            this.ListType.Name = "ListType";
            this.ListType.Size = new System.Drawing.Size(336, 388);
            this.ListType.TabIndex = 3;
            this.ListType.DoubleClick += new System.EventHandler(this.ListType_DoubleClick);
            // 
            // GB
            // 
            this.GB.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.GB.Controls.Add(this.GBBox);
            this.GB.Controls.Add(this.GBValue);
            this.GB.Controls.Add(this.LoadLB);
            this.GB.Controls.Add(this.groupBox1);
            this.GB.Controls.Add(this.CBLOT);
            this.GB.Controls.Add(this.CBModel);
            this.GB.Controls.Add(this.CBClient);
            this.GB.Controls.Add(this.LabelText);
            this.GB.Location = new System.Drawing.Point(354, 38);
            this.GB.Name = "GB";
            this.GB.Size = new System.Drawing.Size(959, 597);
            this.GB.TabIndex = 6;
            this.GB.TabStop = false;
            this.GB.Text = "GB";
            this.GB.Visible = false;
            // 
            // GBBox
            // 
            this.GBBox.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.GBBox.Controls.Add(this.CBBox2);
            this.GBBox.Controls.Add(this.ClearBT);
            this.GBBox.Controls.Add(this.BtLiterAdd);
            this.GBBox.Controls.Add(this.listBox1);
            this.GBBox.Controls.Add(this.BTOk1);
            this.GBBox.Location = new System.Drawing.Point(6, 323);
            this.GBBox.Name = "GBBox";
            this.GBBox.Size = new System.Drawing.Size(282, 274);
            this.GBBox.TabIndex = 12;
            this.GBBox.TabStop = false;
            this.GBBox.Text = "Сформировать по коробкам";
            this.GBBox.Visible = false;
            // 
            // CBBox2
            // 
            this.CBBox2.AutoSize = true;
            this.CBBox2.Checked = true;
            this.CBBox2.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CBBox2.Location = new System.Drawing.Point(7, 209);
            this.CBBox2.Name = "CBBox2";
            this.CBBox2.Size = new System.Drawing.Size(109, 17);
            this.CBBox2.TabIndex = 15;
            this.CBBox2.Text = "Полная коробка";
            this.CBBox2.UseVisualStyleBackColor = true;
            // 
            // ClearBT
            // 
            this.ClearBT.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.ClearBT.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ClearBT.Location = new System.Drawing.Point(248, 78);
            this.ClearBT.Name = "ClearBT";
            this.ClearBT.Size = new System.Drawing.Size(32, 31);
            this.ClearBT.TabIndex = 14;
            this.ClearBT.Text = "-";
            this.ClearBT.UseVisualStyleBackColor = true;
            this.ClearBT.Click += new System.EventHandler(this.ClearBT_Click);
            // 
            // BtLiterAdd
            // 
            this.BtLiterAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtLiterAdd.Location = new System.Drawing.Point(6, 30);
            this.BtLiterAdd.Name = "BtLiterAdd";
            this.BtLiterAdd.Size = new System.Drawing.Size(241, 35);
            this.BtLiterAdd.TabIndex = 13;
            this.BtLiterAdd.Text = "Добавить литера";
            this.BtLiterAdd.UseVisualStyleBackColor = true;
            this.BtLiterAdd.Click += new System.EventHandler(this.BtLiterAdd_Click);
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 24;
            this.listBox1.Location = new System.Drawing.Point(6, 78);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(241, 124);
            this.listBox1.TabIndex = 12;
            // 
            // BTOk1
            // 
            this.BTOk1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BTOk1.Location = new System.Drawing.Point(6, 233);
            this.BTOk1.Name = "BTOk1";
            this.BTOk1.Size = new System.Drawing.Size(241, 35);
            this.BTOk1.TabIndex = 6;
            this.BTOk1.Text = "Сформировать по коробкам";
            this.BTOk1.UseVisualStyleBackColor = true;
            this.BTOk1.Click += new System.EventHandler(this.BTOk1_Click);
            // 
            // GBValue
            // 
            this.GBValue.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.GBValue.Controls.Add(this.CBBox1);
            this.GBValue.Controls.Add(this.label2);
            this.GBValue.Controls.Add(this.BTOk);
            this.GBValue.Controls.Add(this.NUM);
            this.GBValue.Location = new System.Drawing.Point(6, 159);
            this.GBValue.Name = "GBValue";
            this.GBValue.Size = new System.Drawing.Size(282, 158);
            this.GBValue.TabIndex = 8;
            this.GBValue.TabStop = false;
            this.GBValue.Text = "Сформировать по кол-во";
            this.GBValue.Visible = false;
            // 
            // CBBox1
            // 
            this.CBBox1.AutoSize = true;
            this.CBBox1.Checked = true;
            this.CBBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CBBox1.Location = new System.Drawing.Point(6, 89);
            this.CBBox1.Name = "CBBox1";
            this.CBBox1.Size = new System.Drawing.Size(109, 17);
            this.CBBox1.TabIndex = 7;
            this.CBBox1.Text = "Полная коробка";
            this.CBBox1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(6, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 24);
            this.label2.TabIndex = 6;
            this.label2.Text = "Количество ";
            // 
            // BTOk
            // 
            this.BTOk.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BTOk.Location = new System.Drawing.Point(6, 112);
            this.BTOk.Name = "BTOk";
            this.BTOk.Size = new System.Drawing.Size(241, 35);
            this.BTOk.TabIndex = 6;
            this.BTOk.Text = "Сформировать по кол-ву";
            this.BTOk.UseVisualStyleBackColor = true;
            this.BTOk.Click += new System.EventHandler(this.BTOk_Click);
            // 
            // NUM
            // 
            this.NUM.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NUM.Location = new System.Drawing.Point(6, 53);
            this.NUM.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.NUM.Name = "NUM";
            this.NUM.Size = new System.Drawing.Size(142, 31);
            this.NUM.TabIndex = 0;
            // 
            // LoadLB
            // 
            this.LoadLB.AutoSize = true;
            this.LoadLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LoadLB.Location = new System.Drawing.Point(292, 414);
            this.LoadLB.Name = "LoadLB";
            this.LoadLB.Size = new System.Drawing.Size(59, 18);
            this.LoadLB.TabIndex = 10;
            this.LoadLB.Text = "LBLoad";
            this.LoadLB.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox1.Controls.Add(this.OkBT);
            this.groupBox1.Controls.Add(this.GridReport);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.CBStatus);
            this.groupBox1.Location = new System.Drawing.Point(294, 19);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(652, 345);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Отчёт о выгрузке";
            // 
            // OkBT
            // 
            this.OkBT.BackColor = System.Drawing.Color.YellowGreen;
            this.OkBT.FlatAppearance.BorderSize = 0;
            this.OkBT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OkBT.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OkBT.Location = new System.Drawing.Point(6, 295);
            this.OkBT.Name = "OkBT";
            this.OkBT.Size = new System.Drawing.Size(628, 44);
            this.OkBT.TabIndex = 12;
            this.OkBT.Text = "Выбрать";
            this.OkBT.UseVisualStyleBackColor = false;
            this.OkBT.Click += new System.EventHandler(this.OkBT_Click);
            // 
            // GridReport
            // 
            this.GridReport.AllowUserToAddRows = false;
            this.GridReport.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.GridReport.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GridReport.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.GridReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.GridReport.DefaultCellStyle = dataGridViewCellStyle2;
            this.GridReport.Location = new System.Drawing.Point(8, 76);
            this.GridReport.Name = "GridReport";
            this.GridReport.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GridReport.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.GridReport.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GridReport.Size = new System.Drawing.Size(626, 211);
            this.GridReport.TabIndex = 10;
            this.GridReport.Visible = false;
            this.GridReport.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridReport_CellDoubleClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Статус отгрузки";
            // 
            // CBStatus
            // 
            this.CBStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CBStatus.FormattingEnabled = true;
            this.CBStatus.Location = new System.Drawing.Point(6, 38);
            this.CBStatus.Name = "CBStatus";
            this.CBStatus.Size = new System.Drawing.Size(628, 32);
            this.CBStatus.TabIndex = 8;
            this.CBStatus.SelectionChangeCommitted += new System.EventHandler(this.CBStatus_SelectionChangeCommitted);
            // 
            // CBLOT
            // 
            this.CBLOT.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBLOT.DropDownWidth = 500;
            this.CBLOT.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CBLOT.FormattingEnabled = true;
            this.CBLOT.Location = new System.Drawing.Point(6, 127);
            this.CBLOT.Name = "CBLOT";
            this.CBLOT.Size = new System.Drawing.Size(282, 26);
            this.CBLOT.TabIndex = 9;
            this.CBLOT.SelectionChangeCommitted += new System.EventHandler(this.CBLOT_SelectionChangeCommitted);
            // 
            // CBModel
            // 
            this.CBModel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBModel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CBModel.FormattingEnabled = true;
            this.CBModel.Location = new System.Drawing.Point(6, 88);
            this.CBModel.Name = "CBModel";
            this.CBModel.Size = new System.Drawing.Size(282, 33);
            this.CBModel.TabIndex = 8;
            this.CBModel.SelectionChangeCommitted += new System.EventHandler(this.CBModel_SelectionChangeCommitted);
            // 
            // CBClient
            // 
            this.CBClient.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CBClient.FormattingEnabled = true;
            this.CBClient.Location = new System.Drawing.Point(6, 49);
            this.CBClient.Name = "CBClient";
            this.CBClient.Size = new System.Drawing.Size(282, 33);
            this.CBClient.TabIndex = 7;
            this.CBClient.SelectionChangeCommitted += new System.EventHandler(this.CBClient_SelectionChangeCommitted);
            // 
            // LabelText
            // 
            this.LabelText.AutoSize = true;
            this.LabelText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelText.Location = new System.Drawing.Point(2, 17);
            this.LabelText.Name = "LabelText";
            this.LabelText.Size = new System.Drawing.Size(286, 24);
            this.LabelText.TabIndex = 5;
            this.LabelText.Text = "Выберите Заказчика и модель";
            // 
            // Grid
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Grid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.Grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Grid.DefaultCellStyle = dataGridViewCellStyle5;
            this.Grid.Location = new System.Drawing.Point(1367, 11);
            this.Grid.Name = "Grid";
            this.Grid.Size = new System.Drawing.Size(46, 21);
            this.Grid.TabIndex = 7;
            this.Grid.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1328, 647);
            this.Controls.Add(this.Grid);
            this.Controls.Add(this.GB);
            this.Controls.Add(this.BT_OK);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ListType);
            this.Name = "Form1";
            this.Text = "Отгрузка GS";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.GB.ResumeLayout(false);
            this.GB.PerformLayout();
            this.GBBox.ResumeLayout(false);
            this.GBBox.PerformLayout();
            this.GBValue.ResumeLayout(false);
            this.GBValue.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUM)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridReport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Grid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BT_OK;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox ListType;
        private System.Windows.Forms.GroupBox GB;
        private System.Windows.Forms.Label LabelText;
        private System.Windows.Forms.Button BTOk;
        private System.Windows.Forms.ComboBox CBClient;
        private System.Windows.Forms.ComboBox CBModel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown NUM;
        private System.Windows.Forms.ComboBox CBLOT;
        private System.Windows.Forms.Label LoadLB;
        private System.Windows.Forms.DataGridView Grid;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox CBStatus;
        private System.Windows.Forms.DataGridView GridReport;
        private System.Windows.Forms.Button OkBT;
        private System.Windows.Forms.GroupBox GBBox;
        private System.Windows.Forms.Button BTOk1;
        private System.Windows.Forms.GroupBox GBValue;
        private System.Windows.Forms.Button BtLiterAdd;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button ClearBT;
        private System.Windows.Forms.CheckBox CBBox1;
        private System.Windows.Forms.CheckBox CBBox2;
    }
}

