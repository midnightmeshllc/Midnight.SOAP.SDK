using System.Xml.Serialization;

namespace Midnight.SOAP.SDK.RequestObjects.SettingInputs;

/// <summary>
/// Represents the request body for listing service wizards in the Midnight SOAP API.
/// </summary>
[XmlRoot("ServiceWizardList")]
public class ServiceWizardListRequestBody
{
    /// <summary>Gets or sets the wizard number.</summary>
    [XmlElement(IsNullable = true)]
    public int? WizardNumber { get; set; }
    /// <summary>Gets or sets the category.</summary>
    [XmlElement(IsNullable = true)]
    public string? Category { get; set; }
}
