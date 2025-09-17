using System.Xml.Serialization;

namespace Midnight.SOAP.SDK.RequestObjects.VendorInputs;

/// <summary>
/// Represents the request body for listing vendors in the Midnight SOAP API.
/// </summary>
[XmlRoot("VendorList")]
public class VendorListRequestBody
{
    /// <summary>
    /// Gets or sets the input parameter for the vendor list request.
    /// </summary>
    public required VendorListInputParameter InputParameter { get; set; }
}

/// <summary>
/// Represents the input parameter for listing vendors in the Midnight SOAP API.
/// </summary>
public class VendorListInputParameter
{
    /// <summary>Gets or sets the vendor ID.</summary>
    public int? VendorID { get; set; } = null;
    /// <summary>Gets or sets the company ID.</summary>
    public int? CompanyID { get; set; } = null;
    /// <summary>Gets or sets the vendor code.</summary>
    public string? VendorCode { get; set; } = null;
    /// <summary>Gets or sets the vendor name.</summary>
    public string? VendorName { get; set; } = null;
    /// <summary>Gets or sets a value indicating whether the vendor is active.</summary>
    public bool Active { get; set; } = true;

}