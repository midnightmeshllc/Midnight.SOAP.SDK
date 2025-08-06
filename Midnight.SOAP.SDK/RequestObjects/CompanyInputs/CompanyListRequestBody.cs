
using System.Xml.Serialization;

namespace Midnight.SOAP.SDK.RequestObjects.CompanyInputs;

[XmlRoot("CompanyList")]
public class CompanyListRequestBody
{
    public required CompanyListInputParameter InputParameter { get; set; }
}

public class CompanyListInputParameter
{
    public int CompanyID { get; set; }
    public string? CompanyCode { get; set; }
    public string? CompanyName { get; set; }
    public int? ParentCompanyID { get; set; }
    public bool Active { get; set; } = true;
}