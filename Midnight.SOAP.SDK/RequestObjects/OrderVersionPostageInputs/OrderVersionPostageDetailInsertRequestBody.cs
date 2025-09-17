using System.Xml.Serialization;

namespace Midnight.SOAP.SDK.RequestObjects.OrderVersionPostageInputs;

/// <summary>
/// Represents the request body for inserting an order version postage detail in the Midnight SOAP API.
/// </summary>
[XmlRoot("OrderVersionPostageDetailInsert")]
public class OrderVersionPostageDetailInsertRequestBody
{
    /// <summary>
    /// Gets or sets the input parameter for the order version postage detail insert request.
    /// </summary>
    public required OrderVersionPostageDetailInputParameter InputParameter { get; set; }
}

/// <summary>
/// Represents the input parameter for inserting an order version postage detail in the Midnight SOAP API.
/// </summary>
public class OrderVersionPostageDetailInputParameter
{
    /// <summary>Gets or sets the order version postage ID.</summary>
    public int OrderVersionPostageID { get; set; }
    /// <summary>Gets or sets the rate code.</summary>
    public string? RateCode { get; set; }
    /// <summary>Gets or sets the quantity.</summary>
    public int Quantity { get; set; }
    /// <summary>Gets or sets the rate.</summary>
    public decimal Rate { get; set; }
    /// <summary>Gets or sets the detail total weight.</summary>
    public decimal DetailTotalWeight { get; set; }
    /// <summary>Gets or sets the detail total postage.</summary>
    public decimal DetailTotalPostage { get; set; }
    /// <summary>Gets or sets the detail date.</summary>
    public string? DetailDate { get; set; } = null;
    /// <summary>Gets or sets the weight type.</summary>
    public string? WtType { get; set; } = null;
    /// <summary>Gets or sets the precanceled flag.</summary>
    public char? Precanceled { get; set; } = 'N';
}