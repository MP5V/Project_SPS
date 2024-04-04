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
    public partial class Doc_Pass : Form
    {
        public Doc_Pass()
        {
            InitializeComponent();
        }

        private void Doc_Pass_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int Result;

            string P1 = "GET_DOCUMENT";
            string P2 = "";
            string P3 = "";
            string P4 = "";
            string P5 = "";

            dataSet2.DOCUMENT.Clear();

            //Создание объекта для вызова веб-сервиса

            WebReference.OBMEN web_1c = new WebReference.OBMEN();

            System.Net.NetworkCredential nc = new System.Net.NetworkCredential();

            nc.UserName = "WS_USER";
            nc.Password = "123";

            web_1c.PreAuthenticate = true;
            web_1c.Credentials = nc;

            try
            {
                Result = web_1c.Document_Tech(ref P1, P2, P3, P4, P5);
            }
            catch (Exception ex)
            {
                Result = 0;
                P1 = ex.Message;
            }

            Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(P1);

            foreach (DOCan doc in myDeserializedClass.DOCUMENT)
            {
                DataRow new_row = dataSet2.DOCUMENT.NewRow();

                new_row["ID"] = doc.ID;
                new_row["NAME"] = doc.NAME.ID;
                new_row["NUMBER"] = doc.NUMBER;
                new_row["ACCEPT"] = doc.ACCEPT;
                new_row["RESPONS"] = doc.RESPONS_ID.ID2;

                dataSet2.DOCUMENT.Rows.Add(new_row);
            }

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
    }

}