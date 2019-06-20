namespace CAM.RSAL
{
    public class RSAKey
    {
        public static RSAPublic ToPublicKey(string xml)
        {
            return XML.FromXML<RSAPublic>(xml);
        }

        public static RSAPrivate ToPrivateKey(string xml)
        {
            return XML.FromXML<RSAPrivate>(xml);
        }
    }
}
