
using System.Xml.Serialization;

namespace Midnight.SOAP.SDK.RequestObjects.VendorInputs;

[XmlRoot("VendorList")]
public class VendorListRequestBody
{
    public required VendorListInputParameter InputParameter { get; set; }
}

public class VendorListInputParameter
{
    public int? VendorID { get; set; }
    public int? CompanyID { get; set; }
    public string? VendorCode { get; set; }
    public string? VendorName { get; set; }
    public bool Active { get; set; } = true;

}