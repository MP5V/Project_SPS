using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Project_SPS;

namespace Project_SPS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Создаем новый экземпляр второй формы
            Авторизация loginForm = new Авторизация();

            // Отображаем вторую форму
            loginForm.Show();

            // Можно также скрыть первую форму, если это необходимо
            this.Hide();
        }
    }
}
