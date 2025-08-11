
using Midnight.SOAP.SDK.CommonObjects;
using System.Xml.Serialization;

namespace Midnight.SOAP.SDK.ResponseObjects.VendorContactOutputs;

[XmlRoot("Result")]
public class VendorContactListResult : CommonResult
{
    [XmlArray("VendorContacts")]
    [XmlArrayItem("VendorContact")]
    public List<VendorContact> VendorContacts { get; set; } = new List<VendorContact>();
}

public class VendorContact
{
    public int? VendorID { get; set; }
    public int? ContactID { get; set; }
    public string? FirstName { get; set; }
    public string? MiddleName { get; set; }
    public string? LastName { get; set; }
    public string? EmailAddress { get; set; }
}