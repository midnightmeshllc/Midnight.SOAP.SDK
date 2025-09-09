using System.Xml.Serialization;

namespace Midnight.SOAP.SDK.RequestObjects.DJBInputs;

/// <summary>
/// Represents the request body for updating a DJB status in the Midnight SOAP API.
/// </summary>
[XmlRoot("DJBStatusUpdate")]
public class DJBStatusUpdateRequestBody
{
    /// <summary>
    /// Gets or sets the input parameter for the DJB status update request.
    /// </summary>
    public required DJBStatusUpdateInputParameter InputParameter { get; set; }
}

/// <summary>
/// Represents the input parameter for updating a DJB status in the Midnight SOAP API.
/// </summary>
public class DJBStatusUpdateInputParameter
{
    /// <summary>Gets or sets the DJB detail ID.</summary>
    public required int DJBDetailID { get; set; }
    /// <summary>Gets or sets the DJB status ID.</summary>
    public required int DJBStatusID { get; set; }
}