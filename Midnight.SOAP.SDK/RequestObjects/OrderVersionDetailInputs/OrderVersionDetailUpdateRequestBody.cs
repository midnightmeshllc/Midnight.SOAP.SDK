using Midnight.SOAP.SDK.CommonObjects;
using System.Xml.Serialization;

namespace Midnight.SOAP.SDK.RequestObjects.OrderVersionDetailInputs;

/// <summary>
/// Represents the request body for updating an order version detail in the Midnight SOAP API.
/// </summary>
[XmlRoot("OrderVersionDetailUpdate")]
public class OrderVersionDetailUpdateRequestBody
{
    /// <summary>
    /// Gets or sets the input parameter for the order version detail update request.
    /// </summary>
    public required OrderVersionDetailUpdateInputParameter InputParameter { get; set; }
}

/// <summary>
/// Represents the input parameter for updating an order version detail in the Midnight SOAP API.
/// </summary>
public class OrderVersionDetailUpdateInputParameter : UserDefinedFields
{
    /// <summary>Gets or sets the order version detail ID.</summary>
    public required int OrderVersionDetailID { get; set; }

    /// <summary>Gets or sets the service name.</summary>
    public string? ServiceName { get; set; }
    public bool ShouldSerializeServiceName() => IsSet(ServiceName);

    /// <summary>Gets or sets the quantity.</summary>
    public decimal? Quantity { get; set; }
    public bool ShouldSerializeQuantity() => Quantity.HasValue;

    /// <summary>Gets or sets the unit price.</summary>
    public decimal? UnitPrice { get; set; }
    public bool ShouldSerializeUnitPrice() => UnitPrice.HasValue;

    /// <summary>Gets or sets the run rate.</summary>
    public decimal? RunRate { get; set; }
    public bool ShouldSerializeRunRate() => RunRate.HasValue;

    /// <summary>Gets or sets the setup time.</summary>
    public decimal? SetupTime { get; set; }
    public bool ShouldSerializeSetupTime() => SetupTime.HasValue;

    /// <summary>Gets or sets the quantity done.</summary>
    public int? QtyDone { get; set; }
    public bool ShouldSerializeQtyDone() => QtyDone.HasValue;

    /// <summary>Gets or sets a value indicating whether the detail is complete.</summary>
    public bool? Complete { get; set; }
    public bool ShouldSerializeComplete() => Complete.HasValue;

    /// <summary>Gets or sets the service hyperlink.</summary>
    public string? ServiceHyperlink { get; set; }
    public bool ShouldSerializeServiceHyperlink() => IsSet(ServiceHyperlink);

    /// <summary>Gets or sets the file location.</summary>
    public string? FileLocation { get; set; }
    public bool ShouldSerializeFileLocation() => IsSet(FileLocation);

    /// <summary>Gets or sets the comment.</summary>
    public string? Comment { get; set; }
    public bool ShouldSerializeComment() => IsSet(Comment);

    /// <summary>Shared helper for determining whether a nullable string field has a meaningful value to serialize.</summary>
    private static bool IsSet(string? value) => !string.IsNullOrEmpty(value);
}