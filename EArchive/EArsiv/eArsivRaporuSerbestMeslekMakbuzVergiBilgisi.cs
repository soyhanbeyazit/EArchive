[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://earsiv.efatura.gov.tr")]
public partial class eArsivRaporuSerbestMeslekMakbuzVergiBilgisi
{
    private decimal vergilerToplamiField;
    private eArsivRaporuSerbestMeslekMakbuzVergiBilgisiVergi[] vergiField;
    private eArsivRaporuSerbestMeslekMakbuzVergiBilgisiTevkifat[] tevkifatField;
    public decimal vergilerToplami
    {
        get
        {
            return this.vergilerToplamiField;
        }
        set
        {
            this.vergilerToplamiField = value;
        }
    }
    [System.Xml.Serialization.XmlElementAttribute("vergi")]
    public eArsivRaporuSerbestMeslekMakbuzVergiBilgisiVergi[] vergi
    {
        get
        {
            return this.vergiField;
        }
        set
        {
            this.vergiField = value;
        }
    }
    [System.Xml.Serialization.XmlElementAttribute("tevkifat")]
    public eArsivRaporuSerbestMeslekMakbuzVergiBilgisiTevkifat[] tevkifat
    {
        get
        {
            return this.tevkifatField;
        }
        set
        {
            this.tevkifatField = value;
        }
    }
}