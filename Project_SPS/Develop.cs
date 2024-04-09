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
                    new_row["RESPONS_ID"] = nom.RESPONS.ID;



                    dataSet1.NOMEN.Rows.Add(new_row);
                }
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

        private void button4_Click(object sender, EventArgs e)
        {
            Root root_nomen = new Root();
            root_nomen.NAME = "Список номенклатуры .NET";
            root_nomen.NOMEN = new List<NOMan>();

            foreach (DataRow row in dataSet1.NOMEN.Rows)
            {
                NOMan nomen = new NOMan();
                var cells = row.ItemArray;

                nomen.ID = cells[0].ToString();
                nomen.NAME = cells[1].ToString();
                nomen.KOL = cells[2].ToString();
                nomen.START_EC = DateTime.Parse(cells[3].ToString());
                nomen.END_EC = DateTime.Parse(cells[4].ToString());
                nomen.RESPONS = new RESPONS();
                nomen.RESPONS.ID = cells[5].ToString();

                root_nomen.NOMEN.Add(nomen);
            }

            string json = JsonConvert.SerializeObject(root_nomen);

            tb_JSON.Text = json;

            int Result;

            string P1 = "SET_NOMEN";
            string P2 = json;
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
            if (Result == 0)
            {
                tb3_ServerResult.Text = Result.ToString();
                textBox1.Text = "Ошибка " + P1;
            }
            else
            {
                tb3_ServerResult.Text = Result.ToString();
                textBox1.Text = "OK";
            }
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
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
            if (Result == 0)
            {
                textBox2.Text = Result.ToString();
                textBox3.Text = "Ошибка " + P1;
            }
            else
            {
                textBox2.Text = Result.ToString();
                richTextBox1.Text = P1;

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
        }

        private void tb_JSON_TextChanged(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {
            Root root_nomen = new Root();
            root_nomen.NAME = "Список номенклатуры .NET";
            root_nomen.EMPLOY = new List<EMPan>();

            foreach (DataRow row in dataSet3.List_emp.Rows)
            {
                EMPan emp = new EMPan();
                var cells = row.ItemArray;

                emp.ID = cells[0].ToString();
                emp.SURNAME = cells[1].ToString();
                emp.NAME = cells[2].ToString();
                emp.FAT_NAME = cells[3].ToString();
                emp.GENDER = cells[4].ToString();
                emp.BDATE = cells[5].ToString();

                root_nomen.EMPLOY.Add(emp);
            }

            string json = JsonConvert.SerializeObject(root_nomen);

            tb_JSON.Text = json;

            int Result;

            string P1 = "SET_DOCUMENT";
            string P2 = json;
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
                Result = web_1c.Document_Tech(ref P1, P2, P3, P4, P5);
            }
            catch (Exception ex)
            {
                Result = 0;
                P1 = ex.Message;
            }
            if (Result == 0)
            {
                textBox2.Text = Result.ToString();
                textBox3.Text = "Ошибка " + P1;
            }
            else
            {
                textBox2.Text = Result.ToString();
                textBox3.Text = "OK";
            }
        }
    

        private void button9_Click(object sender, EventArgs e)
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
            if (Result == 0)
            {
                textBox4.Text = Result.ToString();
                textBox5.Text = "Ошибка " + Par1;
            }
            else
            {
                textBox4.Text = Result.ToString();
                richTextBox2.Text = Par1;

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
        }

        private void button5_Click(object sender, EventArgs e)
        {
            // Создаем новый экземпляр второй формы
            Form3 Menu = new Form3();

            // Отображаем вторую форму
            Menu.Show();

            // Можно также скрыть первую форму, если это необходимо
            this.Hide();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            // Создаем новый экземпляр второй формы
            Form3 Menu = new Form3();

            // Отображаем вторую форму
            Menu.Show();

            // Можно также скрыть первую форму, если это необходимо
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Root root_nomen = new Root();
            root_nomen.NAME = "Список номенклатуры .NET";
            root_nomen.DOCUMENT = new List<DOCan>();

            foreach (DataRow row in dataSet2.DOCUMENT.Rows)
            {
                DOCan doc = new DOCan();
                var cells = row.ItemArray;

                doc.ID = cells[0].ToString();
                doc.NAME = new NAME_ID();
                doc.NAME.ID = cells[1].ToString();
                doc.NUMBER = cells[2].ToString();
                doc.ACCEPT = DateTime.Parse(cells[3].ToString());
                doc.RESPONS_ID = new RESPONS_ID();
                doc.RESPONS_ID.ID2 = cells[5].ToString();

                root_nomen.DOCUMENT.Add(doc);
            }

            string json = JsonConvert.SerializeObject(root_nomen);

            tb_JSON.Text = json;

            int Result;

            string P1 = "SET_DOCUMENT";
            string P2 = json;
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
                Result = web_1c.Document_Tech(ref P1, P2, P3, P4, P5);
            }
            catch (Exception ex)
            {
                Result = 0;
                P1 = ex.Message;
            }
            if (Result == 0)
            {
                textBox2.Text = Result.ToString();
                textBox3.Text = "Ошибка " + P1;
            }
            else
            {
                textBox2.Text = Result.ToString();
                textBox3.Text = "OK";
            }
        }
    }
}
