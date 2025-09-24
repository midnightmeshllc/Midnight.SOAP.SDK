using System.Xml.Serialization;

namespace Midnight.SOAP.SDK.RequestObjects.SettingInputs;

/// <summary>
/// Represents the request body for listing document types in the Midnight SOAP API.
/// </summary>
[XmlRoot("DocumentTypeList")]
public class DocumentTypeListRequestBody
{
    /// <summary>
    /// Gets or sets the input parameter for the document type list request.
    /// </summary>
    public required DocumentTypeListInputParameter InputParameter { get; set; }
}

/// <summary>
/// Represents the input parameter for listing document types in the Midnight SOAP API.
/// </summary>
public class DocumentTypeListInputParameter
{
    /// <summary>Gets or sets the document type ID.</summary>
    [XmlElement(IsNullable = true)]
    public int? DocumentTypeID { get; set; }

    /// <summary>Gets or sets the name of the document type.</summary>
    [XmlElement(IsNullable = true)]
    public string? Name { get; set; }

    /// <summary>Gets or sets a value indicating whether the document type is active.</summary>
    public bool Active { get; set; } = true;
}