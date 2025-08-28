using Midnight.SOAP.SDK.CommonObjects;
using System.Xml.Serialization;

namespace Midnight.SOAP.SDK.ResponseObjects.VendorContactOutputs;

/// <summary>
/// Represents the result of a vendor contact list request in the Midnight SOAP API.
/// </summary>
[XmlRoot("Result")]
public class VendorContactListResult : CommonResult
{
    /// <summary>
    /// Gets or sets the list of vendor contacts returned by the request.
    /// </summary>
    [XmlArray("VendorContacts")]
    [XmlArrayItem("VendorContact")]
    public List<VendorContact> VendorContacts { get; set; } = new List<VendorContact>();
}

/// <summary>
/// Represents a vendor contact in the Midnight SOAP API.
/// </summary>
public class VendorContact
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
}