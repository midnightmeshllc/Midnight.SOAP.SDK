
using System.Xml.Serialization;

namespace Midnight.SOAP.SDK.RequestObjects.SettingInputs;

[XmlRoot("PostageAffixList")]
public class PostageAffixListRequestBody
{
    public required PostageAffixListInputParameter InputParameter { get; set; }
}

public class PostageAffixListInputParameter
{
    public int? PostageAffixID { get; set; }
    public string? Name { get; set; }
    public string? Description { get; set; }
    public string? GLID { get; set; }
    public string? InvItem { get; set; }
    public string? PostageBankAccount { get; set; }
    public bool Taxable { get; set; } = false;
    public bool Active { get; set; } = true;
}