namespace Project_SPS
{
    partial class Авторизация
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Авторизация));
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.UserMenu = new System.Windows.Forms.MenuStrip();
            this.Password = new System.Windows.Forms.TextBox();
            this.HelpLink = new System.Windows.Forms.LinkLabel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel1.Controls.Add(this.HelpLink);
            this.panel1.Controls.Add(this.Password);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.UserMenu);
            this.panel1.Location = new System.Drawing.Point(210, 41);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(373, 365);
            this.panel1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(139, 282);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(91, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Войти";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Пароль";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Пользователь";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(136, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Авторизация";
            // 
            // UserMenu
            // 
            this.UserMenu.Dock = System.Windows.Forms.DockStyle.None;
            this.UserMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.UserMenu.Location = new System.Drawing.Point(164, 98);
            this.UserMenu.Name = "UserMenu";
            this.UserMenu.Size = new System.Drawing.Size(202, 24);
            this.UserMenu.TabIndex = 4;
            this.UserMenu.Text = "menuStrip1";
            // 
            // Password
            // 
            this.Password.Location = new System.Drawing.Point(164, 150);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(187, 22);
            this.Password.TabIndex = 5;
            // 
            // HelpLink
            // 
            this.HelpLink.ActiveLinkColor = System.Drawing.Color.Gray;
            this.HelpLink.AutoSize = true;
            this.HelpLink.Location = new System.Drawing.Point(127, 263);
            this.HelpLink.Name = "HelpLink";
            this.HelpLink.Size = new System.Drawing.Size(114, 16);
            this.HelpLink.TabIndex = 6;
            this.HelpLink.TabStop = true;
            this.HelpLink.Text = "Забыли пароль?";
            // 
            // Авторизация
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Project_SPS.Properties.Resources._00a17a2451d14ec731c2cf9c588ab342;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.UserMenu;
            this.Name = "Авторизация";
            this.Text = "LoginForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip UserMenu;
        private System.Windows.Forms.TextBox Password;
        private System.Windows.Forms.LinkLabel HelpLink;
    }
}