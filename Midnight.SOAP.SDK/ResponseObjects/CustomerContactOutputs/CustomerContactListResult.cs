using Midnight.SOAP.SDK.CommonObjects;
using System.Xml.Serialization;

namespace Midnight.SOAP.SDK.ResponseObjects.CustomerContactOutputs;

[XmlRoot("Result")]
public class CustomerContactListResult : CommonResult
{
    [XmlArray("CustomerContacts")]
    [XmlArrayItem("CustomerContact")]
    public List<CustomerContact>? CustomerContacts { get; set; } = new List<CustomerContact>();
}

public class CustomerContact
{
    [XmlElement("CustomerID")]
    public int CustomerID { get; set; }
    [XmlElement("ContactID")]
    public int ContactID { get; set; }
    [XmlElement("FirstName")]
    public string? FirstName { get; set; }
    [XmlElement("MiddleName")]
    public string? MiddleName { get; set; }
    [XmlElement("LastName")]
    public string? LastName { get; set; }
    [XmlElement("EmailAddress")]
    public string? EmailAddress { get; set; }
    [XmlElement("Active")]
    public string? ActiveRaw { get; set; }

    [XmlIgnore]
    public bool Active
    {
        get
        {
            if (string.IsNullOrWhiteSpace(ActiveRaw)) return false;
            return string.Equals(ActiveRaw, "true", StringComparison.OrdinalIgnoreCase)
                || ActiveRaw == "1";
        }
    }
}