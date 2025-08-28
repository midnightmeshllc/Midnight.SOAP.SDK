using Midnight.SOAP.SDK.CommonObjects;
using System.Xml.Serialization;

namespace Midnight.SOAP.SDK.ResponseObjects.SettingOutputs;

/// <summary>
/// Represents the result of a service wizard list request in the Midnight SOAP API.
/// </summary>
[XmlRoot("Result")]
public class ServiceWizardListResult : CommonResult
{
    /// <summary>
    /// Gets or sets the list of service wizards returned by the request.
    /// </summary>
    [XmlArray("ServiceWizards")]
    [XmlArrayItem("ServiceWizard")]
    public List<ServiceWizard> ServiceWizards { get; set; } = new List<ServiceWizard>();
}

/// <summary>
/// Represents a service wizard in the Midnight SOAP API.
/// </summary>
public class ServiceWizard
{
    /// <summary>Gets or sets the wizard number.</summary>
    public int? WizardNumber { get; set; }
    /// <summary>Gets or sets the category of the service wizard.</summary>
    public string? Category { get; set; }
    /// <summary>Gets or sets the description of the service wizard.</summary>
    public string? Description { get; set; }
    /// <summary>Gets or sets the instruction for the service wizard.</summary>
    public string? Instruction { get; set; }

    /// <summary>Gets or sets the details of the service wizard.</summary>
    [XmlArray("ServiceWizardDetails")]
    [XmlArrayItem("ServiceWizardDetail")]
    public List<ServiceWizardDetail> ServiceWizardDetails { get; set; } = new List<ServiceWizardDetail>();
}

/// <summary>
/// Represents a detail entry for a service wizard in the Midnight SOAP API.
/// </summary>
public class ServiceWizardDetail
{
    /// <summary>Gets or sets the choice text.</summary>
    public string? ChoiceText { get; set; }
    /// <summary>Gets or sets the factor.</summary>
    public decimal? Factor { get; set; }
    /// <summary>Gets or sets the successor.</summary>
    public int? Successor { get; set; }
    /// <summary>Gets or sets the price expression.</summary>
    public string? PriceExpr { get; set; }
    /// <summary>Gets or sets the price variance.</summary>
    public decimal? PriceVariance { get; set; }
    /// <summary>Gets or sets the sort order.</summary>
    public int? SortOrder { get; set; }

    /// <summary>Gets or sets the raw value indicating if text input is enabled.</summary>
    [XmlElement("TextInput")]
    public string? TextInputRaw { get; set; }

    /// <summary>Gets a value indicating whether text input is enabled.</summary>
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