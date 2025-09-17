using System.ComponentModel.DataAnnotations;
using System.Xml.Serialization;

namespace Midnight.SOAP.SDK.RequestObjects.OrderVersionInputs;

/// <summary>
/// Represents the request body for quickly adding an order version in the Midnight SOAP API.
/// </summary>
[XmlRoot("OrderVersionQuickAdd")]
public class OrderVersionQuickAddRequestBody
{
    /// <summary>
    /// Gets or sets the order version input parameter for quick add.
    /// </summary>
    public required OrderVersionQuickAddInputParameter OrderVersion { get; set; }
}

/// <summary>
/// Represents the input parameter for quickly adding an order version in the Midnight SOAP API.
/// </summary>
public class OrderVersionQuickAddInputParameter
{
    /// <summary>Gets or sets the order number.</summary>
    public required string OrderNumber { get; set; }
    /// <summary>Gets or sets the version drop date.</summary>
    public string? VersionDropDate { get; set; } = null;
    /// <summary>Gets or sets the version quantity.</summary>
    public int? VersionQuantity { get; set; } = null;
    /// <summary>Gets or sets the version name.</summary>
    public string? VersionName { get; set; } = null;
    /// <summary>Gets or sets the version comments.</summary>
    public string? VersionComments { get; set; } = null;
    /// <summary>Gets or sets the template order number.</summary>
    public string? TemplateOrderNumber { get; set; } = null;
    /// <summary>Gets or sets the template version suffix.</summary>
    public int TemplateVersionSuffix { get; set; } = 0;
}