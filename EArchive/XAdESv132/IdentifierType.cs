//
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://uri.etsi.org/01903/v1.3.2#")]
public partial class IdentifierType
{
    private QualifierType qualifierField;
    private bool qualifierFieldSpecified;
    private string valueField;
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public QualifierType Qualifier
    {
        get
        {
            return this.qualifierField;
        }
        set
        {
            this.qualifierField = value;
        }
    }
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool QualifierSpecified
    {
        get
        {
            return this.qualifierFieldSpecified;
        }
        set
        {
            this.qualifierFieldSpecified = value;
        }
    }
    [System.Xml.Serialization.XmlTextAttribute(DataType = "anyURI")]
    public string Value
    {
        get
        {
            return this.valueField;
        }
        set
        {
            this.valueField = value;
        }
    }
}