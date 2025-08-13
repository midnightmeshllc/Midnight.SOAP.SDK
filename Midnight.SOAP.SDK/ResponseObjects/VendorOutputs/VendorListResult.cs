
using Midnight.SOAP.SDK.CommonObjects;
using System.Xml.Serialization;

namespace Midnight.SOAP.SDK.ResponseObjects.VendorOutputs;

[XmlRoot("Result")]
public class VendorListResult : CommonResult
{
    [XmlArray("Vendors")]
    [XmlArrayItem("Vendor")]
    public List<Vendor> Vendors { get; set; } = new List<Vendor>();
}

public class Vendor : UserDefinedFields
{
    public int? VendorID { get; set; }
    public int? CompanyID { get; set; }
    public string? VendorCode { get; set; }


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

    public string? URL { get; set; }
    public string? EnterDate { get; set; }
    public string? VendorAddressLine1 { get; set; }
    public string? VendorAddressLine2 { get; set; }
    public string? VendorAddressLine3 { get; set; }
    public string? VendorAddressCity { get; set; }
    public string? VendorAddressState { get; set; }
    public string? VendorAddressZip { get; set; }
    public string? VendorAddressCountry { get; set; }
    public string? VendorEmailAddress { get; set; }
    public int? VendorPhone { get; set; }
    public int? VendorFax { get; set; }
    public string? VendorNotes { get; set; }

}