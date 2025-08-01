using System.Xml.Serialization;

namespace Midnight.SOAP.SDK.RequestObjects.OrderVersionDetailInputs;

[XmlRoot("OrderVersionDetailInsert")]
public class OrderVersionDetailInsertRequestBody
{
    public required OrderVersionDetailInsertInputParameter InputParameter { get; set; }
}

public class OrderVersionDetailInsertInputParameter
{
    public int VersionID { get; set; }
    public int ServiceID { get; set; } = 0;
    public string ServiceName { get; set; } = string.Empty;
    public int Quantity { get; set; } = 0;
    public decimal UnitPrice { get; set; } = decimal.Zero;
    public bool Taxable { get; set; } = false;
    public int? Priority { get; set; }
    public string? ServiceHyperlink { get; set; }
    public string? FileLocation { get; set; }
    public string? Comment { get; set; }
}