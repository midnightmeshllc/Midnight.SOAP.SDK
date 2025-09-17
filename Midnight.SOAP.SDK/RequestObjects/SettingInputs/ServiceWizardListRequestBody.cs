using System.Xml.Serialization;

namespace Midnight.SOAP.SDK.RequestObjects.SettingInputs;

/// <summary>
/// Represents the request body for listing service wizards in the Midnight SOAP API.
/// </summary>
[XmlRoot("ServiceWizardList")]
public class ServiceWizardListRequestBody
{
    /// <summary>Gets or sets the wizard number.</summary>
    public int? WizardNumber { get; set; } = null;
    /// <summary>Gets or sets the category.</summary>
    public string? Category { get; set; } = null;
}
