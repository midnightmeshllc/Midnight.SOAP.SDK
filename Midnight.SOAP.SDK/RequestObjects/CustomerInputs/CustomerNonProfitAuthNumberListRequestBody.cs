
using System.Xml.Serialization;

namespace Midnight.SOAP.SDK.RequestObjects.CustomerInputs;

[XmlRoot("CustomerList")]
public class CustomerNonProfitAuthNumberListRequestBody
{
    public required CustomerNonProfitAuthNumberListInputParameter InputParameter { get; set; }
}

public class CustomerNonProfitAuthNumberListInputParameter
{
    public required int CustomerID { get; set; }
}