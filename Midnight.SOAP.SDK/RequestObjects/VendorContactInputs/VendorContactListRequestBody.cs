using System.Xml.Serialization;

namespace Midnight.SOAP.SDK.RequestObjects.VendorContactInputs;

/// <summary>
/// Represents the request body for listing vendor contacts in the Midnight SOAP API.
/// </summary>
[XmlRoot("VendorContactList")]
public class VendorContactListRequestBody
{
    /// <summary>
    /// Gets or sets the input parameter for the vendor contact list request.
    /// </summary>
    public required VendorContactListInputParameter InputParameter { get; set; }
}

/// <summary>
/// Represents the input parameter for listing vendor contacts in the Midnight SOAP API.
/// </summary>
public class VendorContactListInputParameter
{
    /// <summary>Gets or sets the vendor ID.</summary>
    public int? VendorID { get; set; }
    /// <summary>Gets or sets the contact ID.</summary>
    public int? ContactID { get; set; }
    /// <summary>Gets or sets the first name.</summary>
    public string? FirstName { get; set; }
    /// <summary>Gets or sets the middle name.</summary>
    public string? MiddleName { get; set; }
    /// <summary>Gets or sets the last name.</summary>
    public string? LastName { get; set; }
    /// <summary>Gets or sets the email address.</summary>
    public string? EmailAddress { get; set; }
    /// <summary>Gets or sets a value indicating whether the contact is active.</summary>
    public bool Active { get; set; } = true;
}