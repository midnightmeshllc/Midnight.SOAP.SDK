
using System.Xml.Serialization;

namespace Midnight.SOAP.SDK.RequestObjects.CustomerInputs;

[XmlRoot("CustomerList")]
public class CustomerRegIDListRequestBody
{
    public required CustomerRegIDListInputParameter InputParameter { get; set; }
}

public class CustomerRegIDListInputParameter
{
    public required int CustomerID { get; set; }
}