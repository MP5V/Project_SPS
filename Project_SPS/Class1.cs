using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_SPS
{
    // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
    public class NOMan
    {
        public string ID { get; set; }
        public string NAME { get; set; }
        public string KOL { get; set; }
        public DateTime START_EC { get; set; }
        public DateTime END_EC { get; set; }
        public RESPONS RESPONS { get; set; }
    }

    public class DOCan
    {
        public string ID { get; set; }
        public NAME_ID NAME { get; set; }
        public string NUMBER { get; set; }
        public DateTime ACCEPT { get; set; }
        public RESPONS_ID RESPONS_ID { get; set; }
    }

    public class RESPONS
    {
        public string ID { get; set; }
    }

    public class EMPan
    {
        public string ID { get; set; }
        public string SURNAME { get; set; }
        public string NAME { get; set; }
        public string FAT_NAME { get; set; }
        public string GENDER { get; set; }
        public string BDATE {  get; set; }
    }

    public class NAME_ID
    {
        public string ID { get; set; }
    }

    public class RESPONS_ID
    {
        public string ID2 { get; set; }
    }

    public class Root
    {
        public string NAME { get; set; }
        public List<NOMan> NOMEN { get; set; }
        public List<DOCan> DOCUMENT { get; set; }
        public List<EMPan> EMPLOY {  get; set; }
    }

}
