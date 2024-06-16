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
    public partial class Sotr_List : Form
    {
        public Sotr_List()
        {
            InitializeComponent();
        }

        private void get_list_Click(object sender, EventArgs e)
        {
            int Result;

            string Par1 = "GET_LIST";
            string Par2 = "";
            string Par3 = "";
            string Par4 = "";
            string Par5 = "";

            dataSet3.List_emp.Clear();

            //Создание объекта для вызова веб-сервиса

            WebReference.OBMEN web_1c = new WebReference.OBMEN();

            System.Net.NetworkCredential nc = new System.Net.NetworkCredential();

            nc.UserName = "WS_USER";
            nc.Password = "123";

            web_1c.PreAuthenticate = true;
            web_1c.Credentials = nc;

            try
            {
                Result = web_1c.List_emp(ref Par1, Par2, Par3, Par4, Par5);
            }
            catch (Exception ex)
            {
                Result = 0;
                Par1 = ex.Message;
            }

                Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(Par1);

                foreach (EMPan emp in myDeserializedClass.EMPLOY)
                {
                    DataRow new_row = dataSet3.List_emp.NewRow();

                    new_row["ID"] = emp.ID;
                    new_row["SURNAME"] = emp.SURNAME;
                    new_row["NAME"] = emp.NAME;
                    new_row["FAT_NAME"] = emp.FAT_NAME;
                    new_row["GENDER"] = emp.GENDER;
                    new_row["BDATE"] = emp.BDATE;



                    dataSet3.List_emp.Rows.Add(new_row);
                }
            
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
