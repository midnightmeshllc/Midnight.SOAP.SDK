using Midnight.SOAP.SDK.CommonObjects;
using System.Xml.Serialization;

namespace Midnight.SOAP.SDK.ResponseObjects.VendorContactOutputs;

/// <summary>
/// Represents the result of a vendor contact insert operation in the Midnight SOAP API.
/// </summary>
[XmlRoot("Result")]
public class VendorContactInsertResult : CommonResult
{
    /// <summary>
    /// Gets or sets the list of inserted vendor contacts.
    /// </summary>
    [XmlArray("VendorContacts")]
    [XmlArrayItem("VendorContact")]
    public List<VendorContactInserted>? VendorContacts { get; set; }
}

/// <summary>
/// Represents a vendor contact that was inserted.
/// </summary>
public class VendorContactInserted
{
    /// <summary>
    /// Gets or sets the unique identifier of the inserted vendor contact.
    /// </summary>
    [XmlElement("VendorContactID")]
    public int VendorContactID { get; set; }
    /// <summary>
    /// Gets or sets the raw value indicating if the vendor contact is active.
    /// </summary>
    [XmlElement("Active")]
    public string? ActiveRaw { get; set; }

    /// <summary>
    /// Gets a value indicating whether the vendor contact is active.
    /// </summary>
    [XmlIgnore]
    public bool Active
    {
        get
        {
            if (string.IsNullOrWhiteSpace(ActiveRaw)) return false;
            return string.Equals(ActiveRaw, "true", StringComparison.OrdinalIgnoreCase)
                || ActiveRaw == "1";
        }
    }
}