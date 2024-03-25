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
    public partial class Авторизация : Form
    {
        public Авторизация()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Создаем новый экземпляр второй формы
            Form3 Form3 = new Form3();

            // Отображаем вторую форму
            Form3.Show();

            // Можно также скрыть первую форму, если это необходимо
            this.Hide();
        }

        private void User_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
