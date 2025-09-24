using System.Xml.Serialization;

namespace Midnight.SOAP.SDK.RequestObjects.DJBInputs;

/// <summary>
/// Represents the request body for listing DJB job statuses in the Midnight SOAP API.
/// </summary>
[XmlRoot("DJBStatusList")]
public class DJBJobStatusListRequestBody
{
    /// <summary>
    /// Gets or sets the input parameter for the DJB job status list request.
    /// </summary>
    public required DJBStatusListInputParameter InputParameter { get; set; }
}

/// <summary>
/// Represents the input parameter for listing DJB job statuses in the Midnight SOAP API.
/// </summary>
public class DJBStatusListInputParameter
{
    /// <summary>Gets or sets the DJB job status ID.</summary>
    [XmlElement(IsNullable = true)]
    public int? DJBJobStatusID { get; set; }
    /// <summary>Gets or sets the status.</summary>
    [XmlElement(IsNullable = true)]
    public string? Status { get; set; }
}