
using Midnight.SOAP.SDK.CommonObjects;
using System.Xml.Serialization;

namespace Midnight.SOAP.SDK.ResponseObjects.OrderVersionDropOutputs;

[XmlRoot("Result")]
public class OrderVersionDropListResult : CommonResult
{
    [XmlArray("OrderVersionDrops")]
    [XmlArrayItem("OrderVersionDrop")]
    public List<OrderVersionDrop> OrderVersionDrops { get; set; } = new List<OrderVersionDrop>();
}

public class OrderVersionDrop : UserDefinedFieldsFirst5
{
    public int? OrderVersionDropID { get; set; }
    public int? VersionID { get; set; }
    public int? Quantity { get; set; }
    public string? DropName { get; set; }
    public string? DropDate { get; set; }
    public string? TimeDue { get; set; }
    public string? ActualDrop { get; set; }

    [XmlElement("DropDateComplete")]
    public string? DropDateCompleteRaw { get; set; }
    [XmlIgnore]
    public bool DropDateComplete
    {
        get
        {
            if (string.IsNullOrWhiteSpace(DropDateCompleteRaw)) return false;
            return string.Equals(DropDateCompleteRaw, "true", StringComparison.OrdinalIgnoreCase)
                || DropDateCompleteRaw == "1";
        }
    }

    public decimal? PostageValue { get; set; }
}