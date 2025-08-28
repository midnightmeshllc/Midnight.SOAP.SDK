using System.Xml.Serialization;

namespace Midnight.SOAP.SDK.RequestObjects.SettingInputs;

/// <summary>
/// Represents the request body for listing warehouses in the Midnight SOAP API.
/// </summary>
[XmlRoot("WarehouseList")]
public class WarehouseListRequestBody
{
    /// <summary>
    /// Gets or sets the input parameter for the warehouse list request.
    /// </summary>
    public required WarehouseListInputParameter InputParameter { get; set; }
}

/// <summary>
/// Represents the input parameter for listing warehouses in the Midnight SOAP API.
/// </summary>
public class WarehouseListInputParameter
{
    /// <summary>Gets or sets the warehouse ID.</summary>
    public int? WarehouseID { get; set; }
    /// <summary>Gets or sets the name of the warehouse.</summary>
    public string? Name { get; set; }
    /// <summary>Gets or sets the default receiving ID.</summary>
    public int? DefaultReceivingID { get; set; }
}