using Midnight.SOAP.SDK.CommonObjects;
using System.Xml.Serialization;

namespace Midnight.SOAP.SDK.RequestObjects.OrderInputs;

/// <summary>
/// Represents the request body for quickly adding an order in the Midnight SOAP API.
/// </summary>
[XmlRoot("OrderQuickAdd")]
public class OrderQuickAddRequestBody
{
    /// <summary>
    /// Gets or sets the order input parameter for quick add.
    /// </summary>
    public required OrderQuickAddInputParameter Order { get; set; }
}

/// <summary>
/// Represents the input parameter for quickly adding an order in the Midnight SOAP API.
/// </summary>
public class OrderQuickAddInputParameter : UserDefinedFields
{
    /// <summary>Gets or sets the customer ID.</summary>
    public required int CustomerID { get; set; }
    /// <summary>Gets or sets the order date.</summary>
    public string? OrderDate { get; set; } = null;
    /// <summary>Gets or sets the expected quantity.</summary>
    public int ExpectedQuantity { get; set; }
    /// <summary>Gets or sets the order comments.</summary>
    public string? OrderComments { get; set; } = null;
    /// <summary>Gets or sets the template ID.</summary>
    public string? TemplateID { get; set; } = null;
    /// <summary>Gets or sets a value indicating whether to copy versions (Y/N).</summary>
    public bool CopyVersions { get; set; } = false;
    /// <summary>Gets or sets a value indicating whether to update pricing (Y/N).</summary>
    public bool UpdatePricing { get; set; } = false;
    /// <summary> Gets or sets the identifier representing the urgency level. </summary>
    public int? UrgencyID { get; set; } = null;
}

