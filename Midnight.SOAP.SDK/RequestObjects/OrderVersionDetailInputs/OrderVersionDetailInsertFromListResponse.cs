namespace Midnight.SOAP.SDK.RequestObjects.OrderVersionDetailInputs;

/// <summary>
/// Represents the response for inserting an order version detail from a list in the Midnight SOAP API.
/// </summary>
public class OrderVersionDetailInsertFromListResponse
{
    /// <summary>Gets or sets the order number.</summary>
    public string? OrderNumber { get; set; } = string.Empty;
    /// <summary>Gets or sets the order ID.</summary>
    public int OrderID { get; set; } = 0;
    /// <summary>Gets or sets the version ID.</summary>
    public int VersionID { get; set; } = 0;
    /// <summary>Gets or sets the return code (defaults to failure state).</summary>
    public int ReturnCode { get; set; } = 1; //defaults to failure state
    /// <summary>Gets or sets the order version detail ID.</summary>
    public int OrderVersionDetailID { get; set; } = 0;
}
