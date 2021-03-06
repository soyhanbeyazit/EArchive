namespace EArchive.XAdESv132
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]

    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://uri.etsi.org/01903/v1.3.2#")]
    [System.Xml.Serialization.XmlRootAttribute("CompleteCertificateRefs", Namespace = "http://uri.etsi.org/01903/v1.3.2#", IsNullable = false)]
    public partial class CompleteCertificateRefsType
    {
        private CertIDType[] certRefsField;
        private string idField;
        [System.Xml.Serialization.XmlArrayItemAttribute("Cert", IsNullable = false)]
        public CertIDType[] CertRefs
        {
            get
            {
                return this.certRefsField;
            }
            set
            {
                this.certRefsField = value;
            }
        }
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "ID")]
        public string Id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }
    }
}