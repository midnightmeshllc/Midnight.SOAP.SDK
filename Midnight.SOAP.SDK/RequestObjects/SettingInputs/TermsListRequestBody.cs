
using System.Xml.Serialization;

namespace Midnight.SOAP.SDK.RequestObjects.SettingInputs;

[XmlRoot("TermsList")]
public class TermsListRequestBody
{
    public required TermsListInputParameter InputParameter { get; set; }
}

public class TermsListInputParameter
{
    public string? TermsCode { get; set; }
    public string? TermsName { get; set; }
    public int? DaysTillDue { get; set; }
    public bool Active { get; set; } = true;
}