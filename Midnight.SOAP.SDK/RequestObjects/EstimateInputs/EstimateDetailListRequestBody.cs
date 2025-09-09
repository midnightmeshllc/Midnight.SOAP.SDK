using System.Xml.Serialization;

namespace Midnight.SOAP.SDK.RequestObjects.EstimateInputs;

/// <summary>
/// Represents the request body for listing estimate details in the Midnight SOAP API.
/// </summary>
[XmlRoot("EstimateDetailList")]
public class EstimateDetailListRequestBody
{
    /// <summary>
    /// Gets or sets the input parameter for the estimate detail list request.
    /// </summary>
    public required EstimateDetailListInputParameter InputParameter { get; set; }
}

/// <summary>
/// Represents the input parameter for listing estimate details in the Midnight SOAP API.
/// </summary>
public class EstimateDetailListInputParameter
{
    /// <summary>Gets or sets the estimate ID.</summary>
    public required int EstimateID { get; set; }
}