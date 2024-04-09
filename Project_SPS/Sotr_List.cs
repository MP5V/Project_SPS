using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_SPS
{
    public partial class Sotr_List : Form
    {
        public Sotr_List()
        {
            InitializeComponent();
        }

        private void get_list_Click(object sender, EventArgs e)
        {

        }

        private void Save_List_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Создаем новый экземпляр второй формы
            Form3 Menu = new Form3();

            // Отображаем вторую форму
            Menu.Show();

            // Можно также скрыть первую форму, если это необходимо
            this.Hide();
        }
    }
}
