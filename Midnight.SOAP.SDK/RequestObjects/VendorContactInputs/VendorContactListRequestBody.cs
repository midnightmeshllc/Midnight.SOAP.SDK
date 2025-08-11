
using System.Xml.Serialization;

namespace Midnight.SOAP.SDK.RequestObjects.VendorContactInputs;

[XmlRoot("VendorContactList")]
public class VendorContactListRequestBody
{
    public required VendorContactListInputParameter InputParameter { get; set; }
}

public class VendorContactListInputParameter
{
    public int? VendorID { get; set; }
    public int? ContactID { get; set; }
    public string? FirstName { get; set; }
    public string? MiddleName { get; set; }
    public string? LastName { get; set; }
    public string? EmailAddress { get; set; }
    public bool Active { get; set; } = true;
}