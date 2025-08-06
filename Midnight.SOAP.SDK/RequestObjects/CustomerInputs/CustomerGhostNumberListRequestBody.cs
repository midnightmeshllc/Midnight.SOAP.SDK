
using System.Xml.Serialization;

namespace Midnight.SOAP.SDK.RequestObjects.CustomerInputs;

[XmlRoot("CustomerList")]
public class CustomerGhostNumberListRequestBody
{
    public required CustomerGhostNumberListInputParameter InputParameter { get; set; }
}

public class CustomerGhostNumberListInputParameter
{
    public required int CustomerID { get; set; }
}