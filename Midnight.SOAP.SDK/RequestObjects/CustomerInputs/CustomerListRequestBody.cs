using Midnight.SOAP.SDK.CommonObjects;
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
    [XmlElement(IsNullable = true)]
    public int? CustomerID { get; set; }
    /// <summary>Gets or sets the customer type ID.</summary>
    [XmlElement(IsNullable = true)]
    public int? CustomerTypeID { get; set; }
    /// <summary>Gets or sets the customer code.</summary>
    [XmlElement(IsNullable = true)]
    public string? CustomerCode { get; set; }
    /// <summary>Gets or sets the email address.</summary>
    [XmlElement(IsNullable = true)]
    public string? EmailAddress { get; set; }
    /// <summary>Gets or sets the customer name.</summary>
    [XmlElement(IsNullable = true)]
    public string? CustomerName { get; set; }

    [XmlElement(IsNullable = true)]
    /// <summary>Leaving off of request will return inactive and active customers.</summary>
    public bool? Active { get; set; }
}