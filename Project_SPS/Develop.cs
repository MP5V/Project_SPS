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

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

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

        private void button2_Click(object sender, EventArgs e)
        {
            int Result;

            string P1 = "GET_NOMEN";
            string P2 = "";
            string P3 = "";
            string P4 = "";
            string P5 = "";

            dataSet1.NOMEN.Clear();

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
            if (Result == 0)
            {
                tb3_ServerResult.Text = Result.ToString();
                textBox1.Text = "Ошибка " + P1;
            }
            else
            {
                tb3_ServerResult.Text = Result.ToString();
                tb_JSON.Text = P1;

                Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(P1);

                foreach (NOMan nom in myDeserializedClass.NOMEN)
                {
                    DataRow new_row = dataSet1.NOMEN.NewRow();

                    new_row["ID"] = nom.ID;
                    new_row["NAME"] = nom.NAME;
                    new_row["KOL"] = nom.KOL;
                    new_row["START_EC"] = nom.START_EC;
                    new_row["END_EC"] = nom.END_EC;
                    new_row["RESPONS"] = nom.RESPONS;

                    dataSet1.NOMEN.Rows.Add(new_row);
                }
            }
        }
    }
}
