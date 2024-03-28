using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Services.Description;
using System.Windows.Forms;

namespace Project_SPS
{
    public partial class Develop : Form
    {
        public Develop()
        {
            InitializeComponent();
        }

        private void Develop_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int Result;

            string P1 = "TEST";
            string P2 = "";
            string P3 = "";
            string P4 = "";
            string P5 = "";

            //Создание объекта для вызова веб-сервиса

            WebReference.OBMEN web_1c = new WebReference.OBMEN();

            System.Net.NetworkCredential nc = new System.Net.NetworkCredential();

            nc.UserName = "WS_USER";
            nc.Password = "123";

            web_1c.PreAuthenticate = true;
            web_1c.Credentials = nc;

            try
            {
                Result = web_1c.Universal(ref P1, P2, P3, P4, P5);
            }
            catch (Exception ex)
            {
                Result = 0;
                P1 = ex.Message;
            }
            tb3_ServerResult.Text = Result.ToString();
            textBox1.Text = P1;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
