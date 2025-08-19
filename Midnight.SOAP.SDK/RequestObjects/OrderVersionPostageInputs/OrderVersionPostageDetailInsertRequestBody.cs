using System.Xml.Serialization;

namespace Midnight.SOAP.SDK.RequestObjects.OrderVersionPostageInputs;

[XmlRoot("OrderVersionPostageDetailInsert")]
public class OrderVersionPostageDetailInsertRequestBody
{
    public required OrderVersionPostageDetailInputParameter InputParameter { get; set; }
}

public class OrderVersionPostageDetailInputParameter
{
    public int OrderVersionPostageID { get; set; }
    public string? RateCode { get; set; }
    public int Quantity { get; set; }
    public decimal Rate { get; set; }
    public decimal DetailTotalWeight { get; set; }
    public decimal DetailTotalPostage { get; set; }
    public string? DetailDate { get; set; }
    public string? WtType { get; set; }
    public char Precanceled { get; set; }
}