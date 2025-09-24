using System.Xml.Serialization;

namespace Midnight.SOAP.SDK.RequestObjects.SettingInputs;

/// <summary>
/// Represents the request body for listing postage affixes in the Midnight SOAP API.
/// </summary>
[XmlRoot("PostageAffixList")]
public class PostageAffixListRequestBody
{
    /// <summary>
    /// Gets or sets the input parameter for the postage affix list request.
    /// </summary>
    public required PostageAffixListInputParameter InputParameter { get; set; }
}

/// <summary>
/// Represents the input parameter for listing postage affixes in the Midnight SOAP API.
/// </summary>
public class PostageAffixListInputParameter
{
    /// <summary>Gets or sets the postage affix ID.</summary>
    [XmlElement(IsNullable = true)]
    public int? PostageAffixID { get; set; }
    /// <summary>Gets or sets the name of the postage affix.</summary>
    [XmlElement(IsNullable = true)]
    public string? Name { get; set; }
    /// <summary>Gets or sets the description of the postage affix.</summary>
    [XmlElement(IsNullable = true)]
    public string? Description { get; set; }
    /// <summary>Gets or sets the GLID.</summary>
    [XmlElement(IsNullable = true)]
    public string? GLID { get; set; }
    /// <summary>Gets or sets the inventory item.</summary>
    [XmlElement(IsNullable = true)]
    public string? InvItem { get; set; }
    /// <summary>Gets or sets the postage bank account.</summary>
    [XmlElement(IsNullable = true)]
    public string? PostageBankAccount { get; set; } = null;
    /// <summary>Gets or sets a value indicating whether the postage affix is taxable.</summary>
    public bool Taxable { get; set; } = false;
    /// <summary>Gets or sets a value indicating whether the postage affix is active.</summary>
    public bool Active { get; set; } = true;
}