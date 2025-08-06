
namespace Midnight.SOAP.SDK.RequestObjects.CustomerInputs;

public class CustomerMailerIDListRequestBody
{
    public required CustomerMailerIDListInputParameter InputParameter { get; set; }
}

public class CustomerMailerIDListInputParameter
{
    public required int CustomerID { get; set; }
}