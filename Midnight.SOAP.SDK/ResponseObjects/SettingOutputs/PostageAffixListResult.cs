using Midnight.SOAP.SDK.CommonObjects;
using System.Xml.Serialization;

namespace Midnight.SOAP.SDK.ResponseObjects.SettingOutputs;

/// <summary>
/// Represents the result of a postage affix list request in the Midnight SOAP API.
/// </summary>
[XmlRoot("Result")]
public class PostageAffixListResult : CommonResult
{
    /// <summary>
    /// Gets or sets the list of postage affixes returned by the request.
    /// </summary>
    [XmlArray("PostageAffixes")]
    [XmlArrayItem("PostageAffix")]
    public List<PostageAffix> PostageAffixes { get; set; } = new List<PostageAffix>();
}

/// <summary>
/// Represents a postage affix in the Midnight SOAP API.
/// </summary>
public class PostageAffix
{
    /// <summary>Gets or sets the postage affix ID.</summary>
    public int? PostageAffixID { get; set; }
    /// <summary>Gets or sets the name of the postage affix.</summary>
    public string? Name { get; set; }
    /// <summary>Gets or sets the description of the postage affix.</summary>
    public string? Description { get; set; }
    /// <summary>Gets or sets the GLID.</summary>
    public string? GLID { get; set; }
    /// <summary>Gets or sets the inventory item.</summary>
    public string? InvItem { get; set; }
    /// <summary>Gets or sets the postage bank account.</summary>
    public string? PostageBankAccount { get; set; }

    /// <summary>Gets or sets the raw value indicating if the postage affix is taxable.</summary>
    [XmlElement("Taxable")]
    public string? TaxableRaw { get; set; }

    /// <summary>Gets a value indicating whether the postage affix is taxable.</summary>
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