using System.ComponentModel.DataAnnotations;
using System.Xml.Serialization;

namespace Midnight.SOAP.SDK.RequestObjects.CustomerContactInputs;

[XmlRoot("CustomerContactList")]
public class CustomerContactListRequestBody
{
    [Required]
    public required CustomerContactListInputParameter InputParameter { get; set; }
}

/// <summary>
/// By default, If Active is True, all active contacts are returned, if False, all inactive contacts are
/// returned.If neither is entered, all active and inactive contacts are returned.
/// </summary>
public class CustomerContactListInputParameter
{
    public int? CustomerID { get; set; } = null;
    public int? ContactID { get; set; } = null;
    public string? FirstName { get; set; } = null;
    public string? MiddleName { get; set; } = null;
    public string? LastName { get; set; } = null;
    public string? EmailAddress { get; set; } = null;
    public bool? Active { get; set; } = true;
}