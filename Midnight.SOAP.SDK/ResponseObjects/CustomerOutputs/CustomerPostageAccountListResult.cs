
using Midnight.SOAP.SDK.CommonObjects;
using System.Xml.Serialization;

namespace Midnight.SOAP.SDK.ResponseObjects.CustomerOutputs;

[XmlRoot("Result")]
public class CustomerPostageAccountListResult : CommonResult
{
    [XmlArray("CustomerPostageAccounts")]
    [XmlArrayItem("CustomerPostageAccount")]
    public List<CustomerPostageAccount>? CustomerPostageAccounts { get; set; } = new List<CustomerPostageAccount>();
}

public class CustomerPostageAccount
{
    public int? PostageAccountID { get; set; }
    public int? CustomerID { get; set; }
    public string? AccountNumber { get; set; }
    public string? Description { get; set; }
    public decimal? Balance { get; set; }
    public decimal? CreditAmount { get; set; }

    [XmlElement("Active")]
    public string? ActiveRaw { get; set; }

    [XmlIgnore]
    public bool Active
    {
        get
        {
            if (string.IsNullOrWhiteSpace(ActiveRaw)) return false;
            return string.Equals(ActiveRaw, "true", StringComparison.OrdinalIgnoreCase)
                || ActiveRaw == "1";
        }
    }
}