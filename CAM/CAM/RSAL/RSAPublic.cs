using System.Xml.Serialization;

namespace CAM.RSAL
{
    [XmlRoot("RSAKeyValue")]
   public class RSAPublic
    {
        [XmlElement("Modulus")]
        public string Modulus { get; set; }

        [XmlElement("Exponent")]
        public string Exponent { get; set; }

        public virtual string ToXml()
        {
            return XML.ToXML(this);
        }
    }
}
