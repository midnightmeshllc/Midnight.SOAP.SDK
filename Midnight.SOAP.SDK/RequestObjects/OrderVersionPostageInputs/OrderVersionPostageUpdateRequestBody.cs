using System.ComponentModel.DataAnnotations;
using System.Xml.Serialization;

namespace Midnight.SOAP.SDK.RequestObjects.OrderVersionPostageInputs;

[XmlRoot("OrderVersionPostageUpdate")]
public class OrderVersionPostageUpdateRequestBody
{
    [Required]
    public required OrderVersionPostageUpdateInputParameter InputParameter { get; set; }
}

public class OrderVersionPostageUpdateInputParameter
{
    [Required]
    public int OrderVersionPostageID { get; set; }
    public int? PostageAffixID { get; set; }
    public string? PostageAffixName { get; set; }
    public int? PostageQuantity { get; set; }
    public decimal? PostageRate { get; set; }
    public decimal? PostageTotal { get; set; }
    public string? DateUsed { get; set; }
    public int? MailClassID { get; set; }
    public string? PostageMarkupType { get; set; }
    public decimal? PostageMarkupValue { get; set; }
    public decimal? PostageSellRate { get; set; }
}