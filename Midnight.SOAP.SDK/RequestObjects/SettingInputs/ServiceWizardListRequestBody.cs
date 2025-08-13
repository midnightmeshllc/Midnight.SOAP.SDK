
using System.Xml.Serialization;

namespace Midnight.SOAP.SDK.RequestObjects.SettingInputs;

[XmlRoot("ServiceWizardList")]
public class ServiceWizardListRequestBody
{
    public int? WizardNumber { get; set; }
    public string? Category { get; set; }
}
