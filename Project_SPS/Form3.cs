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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Develop Develop_form = new Develop();

            // Отображаем вторую форму
            Develop_form.Show();

            // Можно также скрыть первую форму, если это необходимо
            this.Hide();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Создаем новый экземпляр второй формы
            Nomen_list Nomenclature = new Nomen_list();

            // Отображаем вторую форму
            Nomenclature.Show();

            // Можно также скрыть первую форму, если это необходимо
            this.Hide();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Sotr_List ListOfemp = new Sotr_List();

            // Отображаем вторую форму
            ListOfemp.Show();

            // Можно также скрыть первую форму, если это необходимо
            this.Hide();
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Doc_Pass Document_TechPass = new Doc_Pass();

            // Отображаем вторую форму
            Document_TechPass.Show();

            // Можно также скрыть первую форму, если это необходимо
            this.Hide();
        }
    }
}
