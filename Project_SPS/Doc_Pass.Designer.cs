namespace Project_SPS
{
    partial class Doc_Pass
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Doc_Pass));
            this.dataSet2 = new Project_SPS.DataSet2();
            this.dataSet2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nUMBERDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aCCEPTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rESPONSDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dOCUMENTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet2BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dOCUMENTBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataSet2
            // 
            this.dataSet2.DataSetName = "DataSet2";
            this.dataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataSet2BindingSource
            // 
            this.dataSet2BindingSource.DataSource = this.dataSet2;
            this.dataSet2BindingSource.Position = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(138, 64);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(170, 67);
            this.button1.TabIndex = 1;
            this.button1.Text = "Получить паспорта";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(496, 64);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(158, 72);
            this.button2.TabIndex = 2;
            this.button2.Text = "Изменить";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.nAMEDataGridViewTextBoxColumn,
            this.nUMBERDataGridViewTextBoxColumn,
            this.aCCEPTDataGridViewTextBoxColumn,
            this.rESPONSDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.dOCUMENTBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 175);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(776, 263);
            this.dataGridView1.TabIndex = 3;
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
            // nUMBERDataGridViewTextBoxColumn
            // 
            this.nUMBERDataGridViewTextBoxColumn.DataPropertyName = "NUMBER";
            this.nUMBERDataGridViewTextBoxColumn.HeaderText = "NUMBER";
            this.nUMBERDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nUMBERDataGridViewTextBoxColumn.Name = "nUMBERDataGridViewTextBoxColumn";
            this.nUMBERDataGridViewTextBoxColumn.Width = 125;
            // 
            // aCCEPTDataGridViewTextBoxColumn
            // 
            this.aCCEPTDataGridViewTextBoxColumn.DataPropertyName = "ACCEPT";
            this.aCCEPTDataGridViewTextBoxColumn.HeaderText = "ACCEPT";
            this.aCCEPTDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.aCCEPTDataGridViewTextBoxColumn.Name = "aCCEPTDataGridViewTextBoxColumn";
            this.aCCEPTDataGridViewTextBoxColumn.Width = 125;
            // 
            // rESPONSDataGridViewTextBoxColumn
            // 
            this.rESPONSDataGridViewTextBoxColumn.DataPropertyName = "RESPONS";
            this.rESPONSDataGridViewTextBoxColumn.HeaderText = "RESPONS";
            this.rESPONSDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.rESPONSDataGridViewTextBoxColumn.Name = "rESPONSDataGridViewTextBoxColumn";
            this.rESPONSDataGridViewTextBoxColumn.Width = 125;
            // 
            // dOCUMENTBindingSource
            // 
            this.dOCUMENTBindingSource.DataMember = "DOCUMENT";
            this.dOCUMENTBindingSource.DataSource = this.dataSet2;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(13, 13);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(47, 68);
            this.button3.TabIndex = 4;
            this.button3.Text = "---";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Doc_Pass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Project_SPS.Properties.Resources._00a17a2451d14ec731c2cf9c588ab342;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Doc_Pass";
            this.Text = "Doc_Pass";
            this.Load += new System.EventHandler(this.Doc_Pass_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet2BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dOCUMENTBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource dataSet2BindingSource;
        private DataSet2 dataSet2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nUMBERDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aCCEPTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rESPONSDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource dOCUMENTBindingSource;
        private System.Windows.Forms.Button button3;
    }
}