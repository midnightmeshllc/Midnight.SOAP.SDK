
using System.Xml.Serialization;

namespace Midnight.SOAP.SDK.RequestObjects.CustomerInputs;

[XmlRoot("CustomerList")]
public class CustomerPermitNumberListRequestBody
{
    public required CustomerPermitNumberListInputParameter InputParameter { get; set; }
}

public class CustomerPermitNumberListInputParameter
{
    public required int CustomerID { get; set; }
}