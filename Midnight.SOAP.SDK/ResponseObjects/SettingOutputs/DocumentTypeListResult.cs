using Midnight.SOAP.SDK.CommonObjects;
using System.Xml.Serialization;

namespace Midnight.SOAP.SDK.ResponseObjects.SettingOutputs;

/// <summary>
/// Represents the result of a document type list request in the Midnight SOAP API.
/// </summary>
[XmlRoot("Result")]
public class DocumentTypeListResult : CommonResult
{
    /// <summary>
    /// Gets or sets the list of document types returned by the request.
    /// </summary>
    [XmlArray("DocumentTypes")]
    [XmlArrayItem("DocumentType")]
    public List<DocumentType> DocumentTypes { get; set; } = new List<DocumentType>();
}

/// <summary>
/// Represents a document type in the Midnight SOAP API.
/// </summary>
public class DocumentType
{
    /// <summary>Gets or sets the document type ID.</summary>
    public int DocumentTypeID { get; set; }
    /// <summary>Gets or sets the name of the document type.</summary>
    public string? Name { get; set; } = string.Empty;
}