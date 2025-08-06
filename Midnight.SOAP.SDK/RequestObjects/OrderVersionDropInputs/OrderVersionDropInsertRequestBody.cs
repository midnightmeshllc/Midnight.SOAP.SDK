using Midnight.SOAP.SDK.CommonObjects;
using System.Xml.Serialization;

namespace Midnight.SOAP.SDK.RequestObjects.OrderVersionDropInputs;

[XmlRoot("OrderVersionDropInsert")]
public class OrderVersionDropInsertRequestBody
{
    public required OrderVersionDropInsertInputParameter InputParameter { get; set; }
}

public class OrderVersionDropInsertInputParameter : UserDefinedFieldsFirst5
{
    public int VersionID { get; set; }
    public string DropDate { get; set; } = string.Empty;
    public int Quantity { get; set; }
    public string DropName { get; set; } = string.Empty;
    public string TimeDue { get; set; } = string.Empty;
    public string ActualDrop { get; set; } = string.Empty;
    public bool DropDateComplete { get; set; }
    public decimal PostageValue { get; set; }

}
