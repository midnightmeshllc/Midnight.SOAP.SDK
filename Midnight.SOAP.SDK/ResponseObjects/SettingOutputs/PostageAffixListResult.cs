
using Midnight.SOAP.SDK.CommonObjects;
using System.Xml.Serialization;

namespace Midnight.SOAP.SDK.ResponseObjects.SettingOutputs;

[XmlRoot("Result")]
public class PostageAffixListResult : CommonResult
{
    [XmlArray("PostageAffixes")]
    [XmlArrayItem("PostageAffix")]
    public List<PostageAffix> PostageAffixes { get; set; } = new List<PostageAffix>();
}

public class PostageAffix
{
    public int? PostageAffixID { get; set; }
    public string? Name { get; set; }
    public string? Description { get; set; }
    public string? GLID { get; set; }
    public string? InvItem { get; set; }
    public string? PostageBankAccount { get; set; }

    [XmlElement("Taxable")]
    public string? TaxableRaw { get; set; }

    [XmlIgnore]
    public bool Taxable
    {
        get
        {
            if (string.IsNullOrWhiteSpace(TaxableRaw)) return false;
            return string.Equals(TaxableRaw, "true", StringComparison.OrdinalIgnoreCase)
                || TaxableRaw == "1";
        }
    }
}