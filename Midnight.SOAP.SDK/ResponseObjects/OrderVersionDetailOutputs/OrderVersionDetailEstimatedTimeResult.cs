
using Midnight.SOAP.SDK.CommonObjects;
using System.Xml.Serialization;

namespace Midnight.SOAP.SDK.ResponseObjects.OrderVersionDetailOutputs;

[XmlRoot("Result")]
public class OrderVersionDetailEstimatedTimeResult : CommonResult
{
    [XmlArray("OrderVersionDetailEstimatedTime")]
    [XmlArrayItem("Details")]
    public List<OrderVersionEstimatedTimeDetail> OrderVersionDetailEstimatedTime { get; set; } = new List<OrderVersionEstimatedTimeDetail>();
}

public class OrderVersionEstimatedTimeDetail : UserDefinedFieldsFirst10
{
    public int? CustomerID { get; set; }
    public string? OrderNumber { get; set; }
    public int? OrderID { get; set; }
    public int? VersionID { get; set; }
    public string? OrderVersionDueDate { get; set; }
    public int? OrderVersionDetailID { get; set; }
    public int? ServiceID { get; set; }
    public string? ServiceCode { get; set; }
    public decimal? OrderVersionDetailQuantity { get; set; } = decimal.Zero;
    public decimal? OrderVersionDetailRunRate { get; set; } = decimal.Zero;
    public decimal? EstimateServiceTime { get; set; } = decimal.Zero;
}