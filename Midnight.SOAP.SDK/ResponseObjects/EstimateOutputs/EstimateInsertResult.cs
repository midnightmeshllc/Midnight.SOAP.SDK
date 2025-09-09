using Midnight.SOAP.SDK.CommonObjects;
using System.Xml.Serialization;

namespace Midnight.SOAP.SDK.ResponseObjects.EstimateOutputs;

/// <summary>
/// Represents the result of inserting a new estimate in the Midnight SOAP API.
/// </summary>
[XmlRoot("Result")]
public class EstimateInsertResult : CommonResult
{
    /// <summary>
    /// Gets or sets the new estimate information.
    /// </summary>
    [XmlElement("Estimate")]
    public NewEstimate? Estimate { get; set; }
}

/// <summary>
/// Represents a new estimate in the Midnight SOAP API.
/// </summary>
public class NewEstimate
{
    /// <summary>Gets or sets the estimate ID.</summary>
    public int? EstimateID { get; set; }
    /// <summary>Gets or sets the estimate number.</summary>
    public string? EstimateNumber { get; set; }
}