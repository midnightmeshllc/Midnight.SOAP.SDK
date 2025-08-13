
using Midnight.SOAP.SDK.CommonObjects;
using System.Xml.Serialization;

namespace Midnight.SOAP.SDK.ResponseObjects.SettingOutputs;

[XmlRoot("Result")]
public class ServiceWizardListResult : CommonResult
{
    [XmlArray("ServiceWizards")]
    [XmlArrayItem("ServiceWizard")]
    public List<ServiceWizard> ServiceWizards { get; set; } = new List<ServiceWizard>();
}

public class ServiceWizard
{
    public int? WizardNumber { get; set; }
    public string? Category { get; set; }
    public string? Description { get; set; }
    public string? Instruction { get; set; }

    [XmlArray("ServiceWizardDetails")]
    [XmlArrayItem("ServiceWizardDetail")]
    public List<ServiceWizardDetail> ServiceWizardDetails { get; set; } = new List<ServiceWizardDetail>();
}

public class ServiceWizardDetail
{
    public string? ChoiceText { get; set; }
    public decimal? Factor { get; set; }
    public int? Successor { get; set; }
    public string? PriceExpr { get; set; }
    public decimal? PriceVariance { get; set; }
    public int? SortOrder { get; set; }

    [XmlElement("TextInput")]
    public string? TextInputRaw { get; set; }

    [XmlIgnore]
    public bool TextInput
    {
        get
        {
            if (string.IsNullOrWhiteSpace(TextInputRaw)) return false;
            return string.Equals(TextInputRaw, "true", StringComparison.OrdinalIgnoreCase)
                || TextInputRaw == "1";
        }
    }

}