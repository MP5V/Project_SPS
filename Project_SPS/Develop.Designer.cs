namespace Project_SPS
{
    partial class Develop
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.button1 = new System.Windows.Forms.Button();
            this.tb3_ServerResult = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.tb_JSON = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.nOMENBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new Project_SPS.DataSet1();
            this.dataSet11 = new Project_SPS.DataSet1();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kOLDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sTARTECDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eNDECDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rESPONSIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nOMENBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(59, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(270, 52);
            this.button1.TabIndex = 0;
            this.button1.Text = "Test 1C WS";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tb3_ServerResult
            // 
            this.tb3_ServerResult.Location = new System.Drawing.Point(135, 76);
            this.tb3_ServerResult.Name = "tb3_ServerResult";
            this.tb3_ServerResult.Size = new System.Drawing.Size(816, 22);
            this.tb3_ServerResult.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(15, 111);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(936, 22);
            this.textBox1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Ответ сервера:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(366, 13);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(270, 51);
            this.button2.TabIndex = 5;
            this.button2.Text = "GET_NOMEN";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // tb_JSON
            // 
            this.tb_JSON.Location = new System.Drawing.Point(15, 159);
            this.tb_JSON.Name = "tb_JSON";
            this.tb_JSON.Size = new System.Drawing.Size(936, 221);
            this.tb_JSON.TabIndex = 6;
            this.tb_JSON.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "JSON";
            // 
            // nOMENBindingSource
            // 
            this.nOMENBindingSource.DataMember = "NOMEN";
            this.nOMENBindingSource.DataSource = this.dataSet1;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataSet11
            // 
            this.dataSet11.DataSetName = "DataSet1";
            this.dataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.nAMEDataGridViewTextBoxColumn,
            this.kOLDataGridViewTextBoxColumn,
            this.sTARTECDataGridViewTextBoxColumn,
            this.eNDECDataGridViewTextBoxColumn,
            this.rESPONSIDDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.nOMENBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 386);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(939, 161);
            this.dataGridView1.TabIndex = 8;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.Width = 125;
            // 
            // nAMEDataGridViewTextBoxColumn
            // 
            this.nAMEDataGridViewTextBoxColumn.DataPropertyName = "NAME";
            this.nAMEDataGridViewTextBoxColumn.HeaderText = "NAME";
            this.nAMEDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nAMEDataGridViewTextBoxColumn.Name = "nAMEDataGridViewTextBoxColumn";
            this.nAMEDataGridViewTextBoxColumn.Width = 125;
            // 
            // kOLDataGridViewTextBoxColumn
            // 
            this.kOLDataGridViewTextBoxColumn.DataPropertyName = "KOL";
            this.kOLDataGridViewTextBoxColumn.HeaderText = "KOL";
            this.kOLDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.kOLDataGridViewTextBoxColumn.Name = "kOLDataGridViewTextBoxColumn";
            this.kOLDataGridViewTextBoxColumn.Width = 125;
            // 
            // sTARTECDataGridViewTextBoxColumn
            // 
            this.sTARTECDataGridViewTextBoxColumn.DataPropertyName = "START_EC";
            this.sTARTECDataGridViewTextBoxColumn.HeaderText = "START_EC";
            this.sTARTECDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sTARTECDataGridViewTextBoxColumn.Name = "sTARTECDataGridViewTextBoxColumn";
            this.sTARTECDataGridViewTextBoxColumn.Width = 125;
            // 
            // eNDECDataGridViewTextBoxColumn
            // 
            this.eNDECDataGridViewTextBoxColumn.DataPropertyName = "END_EC";
            this.eNDECDataGridViewTextBoxColumn.HeaderText = "END_EC";
            this.eNDECDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.eNDECDataGridViewTextBoxColumn.Name = "eNDECDataGridViewTextBoxColumn";
            this.eNDECDataGridViewTextBoxColumn.Width = 125;
            // 
            // rESPONSIDDataGridViewTextBoxColumn
            // 
            this.rESPONSIDDataGridViewTextBoxColumn.DataPropertyName = "RESPONS_ID";
            this.rESPONSIDDataGridViewTextBoxColumn.HeaderText = "RESPONS_ID";
            this.rESPONSIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.rESPONSIDDataGridViewTextBoxColumn.Name = "rESPONSIDDataGridViewTextBoxColumn";
            this.rESPONSIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(15, 13);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(40, 51);
            this.button3.TabIndex = 9;
            this.button3.Text = "---";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(681, 13);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(270, 51);
            this.button4.TabIndex = 10;
            this.button4.Text = "SET_NOMEN";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Develop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(963, 559);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_JSON);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.tb3_ServerResult);
            this.Controls.Add(this.button1);
            this.Name = "Develop";
            this.Text = "Develop";
            this.Load += new System.EventHandler(this.Develop_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nOMENBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox tb3_ServerResult;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.BindingSource nOMENBindingSource;
        private DataSet1 dataSet1;
        private System.Windows.Forms.RichTextBox tb_JSON;
        private System.Windows.Forms.Label label2;
        private DataSet1 dataSet11;
        private System.Windows.Forms.DataGridViewTextBoxColumn rESPONSDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kOLDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sTARTECDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eNDECDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rESPONSIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}