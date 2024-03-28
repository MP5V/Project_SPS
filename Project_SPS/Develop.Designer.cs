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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KOL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.START_EC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.END_EC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RESPONS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nOMENBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new Project_SPS.DataSet1();
            this.button2 = new System.Windows.Forms.Button();
            this.tb_JSON = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nOMENBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(174, 52);
            this.button1.TabIndex = 0;
            this.button1.Text = "Test 1C WS";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tb3_ServerResult
            // 
            this.tb3_ServerResult.Location = new System.Drawing.Point(135, 76);
            this.tb3_ServerResult.Name = "tb3_ServerResult";
            this.tb3_ServerResult.Size = new System.Drawing.Size(637, 22);
            this.tb3_ServerResult.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(15, 111);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(757, 22);
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
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.NAME,
            this.KOL,
            this.START_EC,
            this.END_EC,
            this.RESPONS});
            this.dataGridView1.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.nOMENBindingSource, "ID", true));
            this.dataGridView1.Location = new System.Drawing.Point(15, 241);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(757, 197);
            this.dataGridView1.TabIndex = 4;
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.MinimumWidth = 6;
            this.ID.Name = "ID";
            this.ID.Width = 125;
            // 
            // NAME
            // 
            this.NAME.HeaderText = "NAME";
            this.NAME.MinimumWidth = 6;
            this.NAME.Name = "NAME";
            this.NAME.Width = 125;
            // 
            // KOL
            // 
            this.KOL.HeaderText = "KOL";
            this.KOL.MinimumWidth = 6;
            this.KOL.Name = "KOL";
            this.KOL.Width = 125;
            // 
            // START_EC
            // 
            this.START_EC.HeaderText = "START_EC";
            this.START_EC.MinimumWidth = 6;
            this.START_EC.Name = "START_EC";
            this.START_EC.Width = 125;
            // 
            // END_EC
            // 
            this.END_EC.HeaderText = "END_EC";
            this.END_EC.MinimumWidth = 6;
            this.END_EC.Name = "END_EC";
            this.END_EC.Width = 125;
            // 
            // RESPONS
            // 
            this.RESPONS.HeaderText = "RESPONS";
            this.RESPONS.MinimumWidth = 6;
            this.RESPONS.Name = "RESPONS";
            this.RESPONS.Width = 125;
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
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(225, 13);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(143, 51);
            this.button2.TabIndex = 5;
            this.button2.Text = "GET_NOMEN";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // tb_JSON
            // 
            this.tb_JSON.Location = new System.Drawing.Point(15, 159);
            this.tb_JSON.Name = "tb_JSON";
            this.tb_JSON.Size = new System.Drawing.Size(757, 76);
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
            // Develop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_JSON);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.tb3_ServerResult);
            this.Controls.Add(this.button1);
            this.Name = "Develop";
            this.Text = "Develop";
            this.Load += new System.EventHandler(this.Develop_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nOMENBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox tb3_ServerResult;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn NAME;
        private System.Windows.Forms.DataGridViewTextBoxColumn KOL;
        private System.Windows.Forms.DataGridViewTextBoxColumn START_EC;
        private System.Windows.Forms.DataGridViewTextBoxColumn END_EC;
        private System.Windows.Forms.DataGridViewTextBoxColumn RESPONS;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.BindingSource nOMENBindingSource;
        private DataSet1 dataSet1;
        private System.Windows.Forms.RichTextBox tb_JSON;
        private System.Windows.Forms.Label label2;
    }
}