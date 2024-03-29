using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Project_SPS
{
    public partial class Nomen_list : Form
    {
        public Nomen_list()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Создаем новый экземпляр второй формы
            Form3 Menu = new Form3();

            // Отображаем вторую форму
            Menu.Show();

            // Можно также скрыть первую форму, если это необходимо
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
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
            /*if (Result == 0)
            {
                tb3_ServerResult.Text = Result.ToString();
                textBox1.Text = "Ошибка " + P1;
            }*/
            if (Result != 0)
            {
                /*tb3_ServerResult.Text = Result.ToString();
                tb_JSON.Text = P1;*/

                Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(P1);

                foreach (NOMan nom in myDeserializedClass.NOMEN)
                {
                    DataRow new_row = dataSet1.NOMEN.NewRow();

                    new_row["ID"] = nom.ID;
                    new_row["NAME"] = nom.NAME;
                    new_row["KOL"] = nom.KOL;
                    new_row["START_EC"] = nom.START_EC;
                    new_row["END_EC"] = nom.END_EC;
                    new_row["RESPONS_ID"] = nom.RESPONS.ID;



                    dataSet1.NOMEN.Rows.Add(new_row);
                }
            }
        }
    }
}
