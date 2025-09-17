using System.Xml.Serialization;

namespace Midnight.SOAP.SDK.RequestObjects.SettingInputs;

/// <summary>
/// Represents the request body for listing warehouse locations in the Midnight SOAP API.
/// </summary>
[XmlRoot("WarehouseLocationList")]
public class WarehouseLocationListRequestBody
{
    /// <summary>
    /// Gets or sets the input parameter for the warehouse location list request.
    /// </summary>
    public required WarehouseLocationListInputParameter InputParameter { get; set; }
}

/// <summary>
/// Represents the input parameter for listing warehouse locations in the Midnight SOAP API.
/// </summary>
public class WarehouseLocationListInputParameter
{
    /// <summary>Gets or sets the warehouse location ID.</summary>
    public int? WarehouseLocationID { get; set; } = null;
    /// <summary>Gets or sets the description of the warehouse location.</summary>
    public string? Description { get; set; } = null;
    /// <summary>Gets or sets the section of the warehouse location.</summary>
    public string? Section { get; set; } = null;
    /// <summary>Gets or sets the bay of the warehouse location.</summary>
    public string? Bay { get; set; } = null;
    /// <summary>Gets or sets the slot or shelf of the warehouse location.</summary>
    public string? SlotShelf { get; set; } = null;
    /// <summary>Gets or sets the size ID.</summary>
    public int? SizeID { get; set; } = null;
    /// <summary>Gets or sets the location type.</summary>
    public string? LocationType { get; set; } = null;
    /// <summary>Gets or sets the warehouse ID.</summary>
    public int? WarehouseID { get; set; } = null;
    /// <summary>Gets or sets a value indicating whether the warehouse location is active.</summary>
    public bool Active { get; set; } = true;
}