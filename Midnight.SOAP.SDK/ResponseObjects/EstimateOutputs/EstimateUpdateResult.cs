using Midnight.SOAP.SDK.CommonObjects;
using System.Xml.Serialization;

namespace Midnight.SOAP.SDK.ResponseObjects.EstimateOutputs;

/// <summary>
/// Represents the result of updating an estimate in the Midnight SOAP API.
/// </summary>
[XmlRoot("Result")]
public class EstimateUpdateResult : CommonResult
{
    /// <summary>
    /// Gets or sets the updated estimate information.
    /// </summary>
    [XmlElement("Estimate")]
    public EstimateUpdated Estimate { get; set; } = new EstimateUpdated();
}

/// <summary>
/// Represents an updated estimate in the Midnight SOAP API.
/// </summary>
public class EstimateUpdated
{
    /// <summary>Gets or sets the estimate ID.</summary>
    public int? EstimateID { get; set; }
    /// <summary>Gets or sets the estimate number.</summary>
    public string? EstimateNumber { get; set; }
}