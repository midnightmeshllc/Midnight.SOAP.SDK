using System.ComponentModel.DataAnnotations;
using System.Xml.Serialization;

namespace Midnight.SOAP.SDK.RequestObjects.CustomerInputs;

[XmlRoot("CustomerList")]
public class CustomerListRequestBody
{
    [Required]
    public required CustomerListInputParameter InputParameter { get; set; }
}

public class CustomerListInputParameter
{
    public int? CustomerID { get; set; }
    public int? CustomerTypeID { get; set; }
    public string? CustomerCode { get; set; } = string.Empty;
    public string? EmailAddress { get; set; } = string.Empty;
    public string? CustomerName { get; set; } = string.Empty;
    public bool Active { get; set; } = true;

}