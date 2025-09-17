using Midnight.SOAP.SDK.CommonObjects;
using System.Xml.Serialization;

namespace Midnight.SOAP.SDK.RequestObjects.OrderVersionDetailInputs;

/// <summary>
/// Represents the request body for estimating time for an order version detail in the Midnight SOAP API.
/// </summary>
[XmlRoot("OrderVersionDetailEstimatedTime")]
public class OrderVersionDetailEstimatedTimeRequestBody
{
    /// <summary>
    /// Gets or sets the input parameter for the order version detail estimated time request.
    /// </summary>
    public required OrderVersionDetailEstimatedTimeInputParameter InputParameter { get; set; }
}

/// <summary>
/// Represents the input parameter for estimating time for an order version detail in the Midnight SOAP API.
/// </summary>
public class OrderVersionDetailEstimatedTimeInputParameter : UserDefinedFieldsFirst10
{
    /// <summary>Gets or sets the order ID.</summary>
    public int? OrderID { get; set; } = null;
    /// <summary>Gets or sets the version ID.</summary>
    public int? VersionID { get; set; } = null;
    /// <summary>Gets or sets the order version detail ID.</summary>
    public int OrderVersionDetailID { get; set; }
    /// <summary>Gets or sets the service ID.</summary>
    public int? ServiceID { get; set; } = null;
}