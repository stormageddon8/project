using System.Xml.Serialization;


namespace CAM.RSAL
{
    [XmlRoot("RSAKeyValue")]
    public class RSAPrivate : RSAPublic
    {
        [XmlElement("P")]
        public string P
        {
            get;
            set;
        }

        [XmlElement("Q")]
        public string Q
        {
            get;
            set;
        }

        [XmlElement("DP")]
        public string DP
        {
            get;
            set;
        }

        [XmlElement("DQ")]
        public string DQ
        {
            get;
            set;
        }

        [XmlElement("InverseQ")]
        public string InverseQ
        {
            get;
            set;
        }

        [XmlElement("D")]
        public string D
        {
            get;
            set;
        }
    }
}
