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
    [XmlElement(IsNullable = true)]
    public int? WarehouseLocationID { get; set; }
    /// <summary>Gets or sets the description of the warehouse location.</summary>
    [XmlElement(IsNullable = true)]
    public string? Description { get; set; }
    /// <summary>Gets or sets the section of the warehouse location.</summary>
    [XmlElement(IsNullable = true)]
    public string? Section { get; set; }
    /// <summary>Gets or sets the bay of the warehouse location.</summary>
    [XmlElement(IsNullable = true)]
    public string? Bay { get; set; }
    /// <summary>Gets or sets the slot or shelf of the warehouse location.</summary>
    [XmlElement(IsNullable = true)]
    public string? SlotShelf { get; set; }
    /// <summary>Gets or sets the size ID.</summary>
    [XmlElement(IsNullable = true)]
    public int? SizeID { get; set; }
    /// <summary>Gets or sets the location type.</summary>
    [XmlElement(IsNullable = true)]
    public string? LocationType { get; set; }
    /// <summary>Gets or sets the warehouse ID.</summary>
    [XmlElement(IsNullable = true)]
    public int? WarehouseID { get; set; }
    /// <summary>Gets or sets a value indicating whether the warehouse location is active.</summary>
    public bool Active { get; set; } = true;
}