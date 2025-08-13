
using System.Xml.Serialization;

namespace Midnight.SOAP.SDK.RequestObjects.CustomerInputs;

[XmlRoot("CustomerPostageAccountList")]
public class CustomerPostageAccountListRequestBody
{
    public required CustomerPostageAccountListInputParameter InputParameter { get; set; }
}

public class CustomerPostageAccountListInputParameter
{
    public int? PostageAccountID { get; set; }
    public required int CustomerID { get; set; }
    public string? AccountNumber { get; set; }
    public bool Active { get; set; } = true;
}