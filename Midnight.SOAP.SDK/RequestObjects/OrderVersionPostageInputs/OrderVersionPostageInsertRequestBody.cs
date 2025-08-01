using System.Xml.Serialization;

namespace Midnight.SOAP.SDK.RequestObjects.OrderVersionPostageInputs;

[XmlRoot("OrderVersionPostageInsert")]
public class OrderVersionPostageInsertRequestBody
{
    public required OrderVersionPostageInsertInputParameter InputParameter { get; set; }
}

public class OrderVersionPostageInsertInputParameter
{
    public int VersionID { get; set; }
    public string PostageAffixName { get; set; } = string.Empty;
    public int PostageQuantity { get; set; }
    public decimal PostageRate { get; set; }
    public decimal PostageTotal { get; set; }
    public string DateUsed { get; set; } = string.Empty;
    public int MailClassID { get; set; }
    public decimal TotalWeight { get; set; } = decimal.Zero;
    public string PostageMarkupType { get; set; } = "$";
    public decimal PostageMarkupValue { get; set; }
    public decimal PostageSellRate { get; set; }
}
