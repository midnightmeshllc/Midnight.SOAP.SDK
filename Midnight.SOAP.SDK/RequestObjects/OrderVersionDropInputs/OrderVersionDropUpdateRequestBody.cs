using Midnight.SOAP.SDK.CommonObjects;
using System.Xml.Serialization;

namespace Midnight.SOAP.SDK.RequestObjects.OrderVersionDropInputs;

/// <summary>
/// Represents the request body for updating an order version drop in the Midnight SOAP API.
/// </summary>
[XmlRoot("OrderVersionDropUpdate")]
public class OrderVersionDropUpdateRequestBody
{
    /// <summary>
    /// Gets or sets the input parameter for the order version drop update request.
    /// </summary>
    public required OrderVersionDropUpdateInputParameter InputParameter { get; set; }
}

/// <summary>
/// Represents the input parameter for updating an order version drop in the Midnight SOAP API.
/// </summary>
public class OrderVersionDropUpdateInputParameter
{
    /// <summary>Gets or sets the order version drop ID.</summary>
    public required int OrderVersionDropID { get; set; }

    /// <summary>Gets or sets the drop date.</summary>
    public string? DropDate { get; set; }
    public bool ShouldSerializeDropDate() => IsSet(DropDate);

    /// <summary>Gets or sets the quantity.</summary>
    public int? Quantity { get; set; }
    public bool ShouldSerializeQuantity() => Quantity.HasValue;

    /// <summary>Gets or sets the drop name.</summary>
    public string? DropName { get; set; }
    public bool ShouldSerializeDropName() => IsSet(DropName);

    /// <summary>Gets or sets the time due.</summary>
    public string? TimeDue { get; set; }
    public bool ShouldSerializeTimeDue() => IsSet(TimeDue);

    /// <summary>Gets or sets the actual drop.</summary>
    public string? ActualDrop { get; set; }
    public bool ShouldSerializeActualDrop() => IsSet(ActualDrop);

    /// <summary>Gets or sets a value indicating whether the drop date is complete.</summary>
    public bool? DropDateComplete { get; set; }
    public bool ShouldSerializeDropDateComplete() => DropDateComplete.HasValue;

    /// <summary>Gets or sets the postage value.</summary>
    public decimal? PostageValue { get; set; }
    public bool ShouldSerializePostageValue() => PostageValue.HasValue;

    /// <summary>Gets or sets the list of user-defined fields for the drop update.</summary>
    public DropUpdateUDFList UDFList { get; set; } = new DropUpdateUDFList();

    /// <summary>Shared helper for determining whether a nullable string field has a meaningful value to serialize.</summary>
    private static bool IsSet(string? value) => !string.IsNullOrEmpty(value);
}

/// <summary>
/// Represents the list of user-defined fields for a drop update in the Midnight SOAP API.
/// </summary>
public class DropUpdateUDFList : UserDefinedFieldsFirst5
{
}