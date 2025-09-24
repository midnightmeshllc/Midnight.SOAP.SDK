using System.Xml.Serialization;

namespace Midnight.SOAP.SDK.RequestObjects.OrderVersionPostageInputs;

/// <summary>
/// Represents the request body for updating an order version postage in the Midnight SOAP API.
/// </summary>
[XmlRoot("OrderVersionPostageUpdate")]
public class OrderVersionPostageUpdateRequestBody
{
    /// <summary>
    /// Gets or sets the input parameter for the order version postage update request.
    /// </summary>
    public required OrderVersionPostageUpdateInputParameter InputParameter { get; set; }
}

/// <summary>
/// Represents the input parameter for updating an order version postage in the Midnight SOAP API.
/// </summary>
public class OrderVersionPostageUpdateInputParameter
{
    /// <summary>Gets or sets the order version postage ID.</summary>
    public required int OrderVersionPostageID { get; set; }
    /// <summary>Gets or sets the postage affix ID.</summary>
    [XmlElement(IsNullable = true)]
    public int? PostageAffixID { get; set; }
    /// <summary>Gets or sets the postage affix name.</summary>
    [XmlElement(IsNullable = true)]
    public string? PostageAffixName { get; set; }
    /// <summary>Gets or sets the postage quantity.</summary>
    [XmlElement(IsNullable = true)]
    public int? PostageQuantity { get; set; }
    /// <summary>Gets or sets the postage rate.</summary>
    [XmlElement(IsNullable = true)]
    public decimal? PostageRate { get; set; }
    /// <summary>Gets or sets the postage total.</summary>
    [XmlElement(IsNullable = true)]
    public decimal? PostageTotal { get; set; }
    /// <summary>Gets or sets the date used.</summary>
    [XmlElement(IsNullable = true)]
    public string? DateUsed { get; set; }
    /// <summary>Gets or sets the mail class ID.</summary>
    [XmlElement(IsNullable = true)]
    public int? MailClassID { get; set; }
    /// <summary>Gets or sets the total weight.</summary>
    [XmlElement(IsNullable = true)]
    public decimal? TotalWeight { get; set; }
    /// <summary>Gets or sets the form number.</summary>
    [XmlElement(IsNullable = true)]
    public string? FormNo { get; set; }
    /// <summary>Gets or sets the lot.</summary>
    [XmlElement(IsNullable = true)]
    public string? Lot { get; set; }
    /// <summary>Gets or sets the permit number.</summary>
    [XmlElement(IsNullable = true)]
    public string? PermitNo { get; set; }
    /// <summary>Gets or sets the non-profit information.</summary>
    [XmlElement(IsNullable = true)]
    public string? NonProfit { get; set; }
    /// <summary>Gets or sets the post office.</summary>
    [XmlElement(IsNullable = true)]
    public string? PostOffice { get; set; }
    /// <summary>Gets or sets the post office city.</summary>
    [XmlElement(IsNullable = true)]
    public string? POCity { get; set; }
    /// <summary>Gets or sets the post office zip code.</summary>
    [XmlElement(IsNullable = true)]
    public string? POZip { get; set; }
    /// <summary>Gets or sets the weight status.</summary>
    [XmlElement(IsNullable = true)]
    public string? WTStatus { get; set; }
    /// <summary>Gets or sets the processing category.</summary>
    [XmlElement(IsNullable = true)]
    public int? ProcessingCategory { get; set; }
    /// <summary>Gets or sets the FTtr1 value.</summary>
    [XmlElement(IsNullable = true)]
    public string? FTtr1 { get; set; }
    /// <summary>Gets or sets the FTtr2 value.</summary>
    [XmlElement(IsNullable = true)]
    public string? FTtr2 { get; set; }
    /// <summary>Gets or sets the number of sacks.</summary>
    [XmlElement(IsNullable = true)]
    public int? Sacks { get; set; }
    /// <summary>Gets or sets the number of pallets.</summary>
    [XmlElement(IsNullable = true)]
    public int? Pallets { get; set; }
    /// <summary>Gets or sets the flat tray value.</summary>
    [XmlElement(IsNullable = true)]
    public string? FlatTr { get; set; }
    /// <summary>Gets or sets other information.</summary>
    [XmlElement(IsNullable = true)]
    public string? Other { get; set; }
    /// <summary>Gets or sets the tare weight.</summary>
    [XmlElement(IsNullable = true)]
    public decimal? TareWt { get; set; }
    /// <summary>Gets or sets a value indicating whether the postage is precanceled.</summary>
    [XmlElement(IsNullable = true)]
    public bool? Precanceled { get; set; }
    /// <summary>Gets or sets the postage markup type.</summary>
    [XmlElement(IsNullable = true)]
    public string? PostageMarkupType { get; set; }
    /// <summary>Gets or sets the postage markup value.</summary>
    [XmlElement(IsNullable = true)]
    public decimal? PostageMarkupValue { get; set; }
    /// <summary>Gets or sets the postage sell rate.</summary>
    [XmlElement(IsNullable = true)]
    public decimal? PostageSellRate { get; set; }
}