using Midnight.SOAP.SDK.CommonObjects;
using System.Xml.Serialization;

namespace Midnight.SOAP.SDK.RequestObjects.OrderVersionDropInputs;

[XmlRoot("OrderVersionDropUpdate")]
public class OrderVersionDropUpdateRequestBody
{
    public required OrderVersionDropUpdateInputParameter InputParameter { get; set; }
}

public class OrderVersionDropUpdateInputParameter
{
    public required int OrderVersionDropID { get; set; }
    public string? DropDate { get; set; } = null;
    public int? Quantity { get; set; } = null;
    public string? DropName { get; set; } = null;
    public string? TimeDue { get; set; } = null;
    public string? ActualDrop { get; set; } = null;
    public bool? DropDateComplete { get; set; } = null;
    public decimal? PostageValue { get; set; } = null;
    public DropUpdateUDFList UDFList { get; set; } = new DropUpdateUDFList();
}

public class DropUpdateUDFList : UserDefinedFieldsFirst5
{
}