using System.ComponentModel.DataAnnotations;
using System.Xml.Serialization;

namespace Midnight.SOAP.SDK.RequestObjects.CustomerInputs;

/// <summary>
/// Represents the request body for listing customers in the Midnight SOAP API.
/// </summary>
[XmlRoot("CustomerList")]
public class CustomerListRequestBody
{
    /// <summary>
    /// Gets or sets the input parameter for the customer list request.
    /// </summary>
    [Required]
    public required CustomerListInputParameter InputParameter { get; set; }
}

/// <summary>
/// Represents the input parameter for listing customers in the Midnight SOAP API.
/// </summary>
public class CustomerListInputParameter : UserDefinedFields
{
    /// <summary>Gets or sets the customer ID.</summary>
    public int? CustomerID { get; set; }
    /// <summary>Gets or sets the customer type ID.</summary>
    public int? CustomerTypeID { get; set; }
    /// <summary>Gets or sets the customer code.</summary>
    public string? CustomerCode { get; set; } = string.Empty;
    /// <summary>Gets or sets the email address.</summary>
    public string? EmailAddress { get; set; } = string.Empty;
    /// <summary>Gets or sets the customer name.</summary>
    public string? CustomerName { get; set; } = string.Empty;
    /// <summary>Gets or sets a value indicating whether the customer is active.</summary>
    public bool Active { get; set; } = true;

}