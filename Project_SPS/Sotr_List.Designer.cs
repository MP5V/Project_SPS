namespace Project_SPS
{
    partial class Sotr_List
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Sotr_List));
            this.label1 = new System.Windows.Forms.Label();
            this.get_list = new System.Windows.Forms.Button();
            this.Save_List = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataSet3 = new Project_SPS.DataSet3();
            this.listempBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sURNAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fATNAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gENDERDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bDATEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listempBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(289, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(244, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Список сотрудников";
            // 
            // get_list
            // 
            this.get_list.Location = new System.Drawing.Point(82, 106);
            this.get_list.Name = "get_list";
            this.get_list.Size = new System.Drawing.Size(150, 62);
            this.get_list.TabIndex = 1;
            this.get_list.Text = "Получить";
            this.get_list.UseVisualStyleBackColor = true;
            this.get_list.Click += new System.EventHandler(this.get_list_Click);
            // 
            // Save_List
            // 
            this.Save_List.Location = new System.Drawing.Point(521, 106);
            this.Save_List.Name = "Save_List";
            this.Save_List.Size = new System.Drawing.Size(150, 62);
            this.Save_List.TabIndex = 2;
            this.Save_List.Text = "Сохранить";
            this.Save_List.UseVisualStyleBackColor = true;
            this.Save_List.Click += new System.EventHandler(this.Save_List_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(-1, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(45, 45);
            this.button1.TabIndex = 3;
            this.button1.Text = "---";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sURNAMEDataGridViewTextBoxColumn,
            this.nAMEDataGridViewTextBoxColumn,
            this.fATNAMEDataGridViewTextBoxColumn,
            this.gENDERDataGridViewTextBoxColumn,
            this.bDATEDataGridViewTextBoxColumn,
            this.iDDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.listempBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 225);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(767, 213);
            this.dataGridView1.TabIndex = 4;
            // 
            // dataSet3
            // 
            this.dataSet3.DataSetName = "DataSet3";
            this.dataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // listempBindingSource
            // 
            this.listempBindingSource.DataMember = "List_emp";
            this.listempBindingSource.DataSource = this.dataSet3;
            // 
            // sURNAMEDataGridViewTextBoxColumn
            // 
            this.sURNAMEDataGridViewTextBoxColumn.DataPropertyName = "SURNAME";
            this.sURNAMEDataGridViewTextBoxColumn.HeaderText = "SURNAME";
            this.sURNAMEDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sURNAMEDataGridViewTextBoxColumn.Name = "sURNAMEDataGridViewTextBoxColumn";
            this.sURNAMEDataGridViewTextBoxColumn.Width = 125;
            // 
            // nAMEDataGridViewTextBoxColumn
            // 
            this.nAMEDataGridViewTextBoxColumn.DataPropertyName = "NAME";
            this.nAMEDataGridViewTextBoxColumn.HeaderText = "NAME";
            this.nAMEDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nAMEDataGridViewTextBoxColumn.Name = "nAMEDataGridViewTextBoxColumn";
            this.nAMEDataGridViewTextBoxColumn.Width = 125;
            // 
            // fATNAMEDataGridViewTextBoxColumn
            // 
            this.fATNAMEDataGridViewTextBoxColumn.DataPropertyName = "FAT_NAME";
            this.fATNAMEDataGridViewTextBoxColumn.HeaderText = "FAT_NAME";
            this.fATNAMEDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.fATNAMEDataGridViewTextBoxColumn.Name = "fATNAMEDataGridViewTextBoxColumn";
            this.fATNAMEDataGridViewTextBoxColumn.Width = 125;
            // 
            // gENDERDataGridViewTextBoxColumn
            // 
            this.gENDERDataGridViewTextBoxColumn.DataPropertyName = "GENDER";
            this.gENDERDataGridViewTextBoxColumn.HeaderText = "GENDER";
            this.gENDERDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.gENDERDataGridViewTextBoxColumn.Name = "gENDERDataGridViewTextBoxColumn";
            this.gENDERDataGridViewTextBoxColumn.Width = 125;
            // 
            // bDATEDataGridViewTextBoxColumn
            // 
            this.bDATEDataGridViewTextBoxColumn.DataPropertyName = "BDATE";
            this.bDATEDataGridViewTextBoxColumn.HeaderText = "BDATE";
            this.bDATEDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.bDATEDataGridViewTextBoxColumn.Name = "bDATEDataGridViewTextBoxColumn";
            this.bDATEDataGridViewTextBoxColumn.Width = 125;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.Width = 125;
            // 
            // Sotr_List
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Project_SPS.Properties.Resources._00a17a2451d14ec731c2cf9c588ab342;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Save_List);
            this.Controls.Add(this.get_list);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Sotr_List";
            this.Text = "Sotr_List";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listempBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button get_list;
        private System.Windows.Forms.Button Save_List;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn sURNAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fATNAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gENDERDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bDATEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource listempBindingSource;
        private DataSet3 dataSet3;
    }
}