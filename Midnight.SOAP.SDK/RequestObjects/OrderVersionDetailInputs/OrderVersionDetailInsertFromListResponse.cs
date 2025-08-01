namespace Midnight.SOAP.SDK.RequestObjects.OrderVersionDetailInputs;

public class OrderVersionDetailInsertFromListResponse
{
    public string? OrderNumber { get; set; } = string.Empty;
    public int OrderID { get; set; } = 0;
    public int VersionID { get; set; } = 0;
    public int ReturnCode { get; set; } = 1; //defaults to failure state
    public int OrderVersionDetailID { get; set; } = 0;
}
