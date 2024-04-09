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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Sotr_List));
            this.label1 = new System.Windows.Forms.Label();
            this.get_list = new System.Windows.Forms.Button();
            this.Save_List = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
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
            // Sotr_List
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Project_SPS.Properties.Resources._00a17a2451d14ec731c2cf9c588ab342;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Save_List);
            this.Controls.Add(this.get_list);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Sotr_List";
            this.Text = "Sotr_List";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button get_list;
        private System.Windows.Forms.Button Save_List;
        private System.Windows.Forms.Button button1;
    }
}