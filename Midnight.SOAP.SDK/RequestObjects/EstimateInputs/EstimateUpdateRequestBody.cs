using System.Xml.Serialization;

namespace Midnight.SOAP.SDK.RequestObjects.EstimateInputs;

/// <summary>
/// Represents the request body for updating an estimate in the Midnight SOAP API.
/// </summary>
[XmlRoot("EstimateUpdateModel")]
public class EstimateUpdateRequestBody
{
    /// <summary>
    /// Gets or sets the unique identifier for the estimate to update.
    /// </summary>
    public required int EstimateID { get; set; }
    /// <summary>
    /// Gets or sets the updated quantity for the estimate.
    /// </summary>
    [XmlElement(IsNullable = true)]
    public int? UpdatedQuantity { get; set; }
    /// <summary>
    /// Gets or sets the customer ID associated with the estimate.
    /// </summary>
    [XmlElement(IsNullable = true)]
    public int? CustomerID { get; set; }
    /// <summary>
    /// Gets or sets the contact ID associated with the estimate.
    /// </summary>
    [XmlElement(IsNullable = true)]
    public int? ContactID { get; set; }
    /// <summary>
    /// Gets or sets the sales representative ID.
    /// </summary>
    [XmlElement(IsNullable = true)]
    public int? SalesRepID { get; set; }
    /// <summary>
    /// Gets or sets the customer service representative ID.
    /// </summary>
    [XmlElement(IsNullable = true)]
    public int? CSRID { get; set; }
    /// <summary>
    /// Gets or sets the licensee ID.
    /// </summary>
    [XmlElement(IsNullable = true)]
    public int? LicenseeID { get; set; }
    /// <summary>
    /// Gets or sets the project name.
    /// </summary>
    [XmlElement(IsNullable = true)]
    public string? ProjectName { get; set; }
    /// <summary>
    /// Gets or sets the purchase order number.
    /// </summary>
    [XmlElement(IsNullable = true)]
    public string? PONumber { get; set; }
    /// <summary>
    /// Gets or sets the terms code.
    /// </summary>
    [XmlElement(IsNullable = true)]
    public string? TermsCode { get; set; }
    /// <summary>
    /// Gets or sets a value indicating whether the estimate is taxable.
    /// </summary>
    public bool EstimateTaxable { get; set; } = true;
    /// <summary>
    /// Gets or sets the estimate date.
    /// </summary>
    [XmlElement(IsNullable = true)]
    public string? EstimateDate { get; set; }
    /// <summary>
    /// Gets or sets the data in date.
    /// </summary>
    [XmlElement(IsNullable = true)]
    public string? DataIn { get; set; }
    /// <summary>
    /// Gets or sets the material in date.
    /// </summary>
    [XmlElement(IsNullable = true)]
    public string? MaterialInDate { get; set; }
    /// <summary>
    /// Gets or sets the artwork in date.
    /// </summary>
    [XmlElement(IsNullable = true)]
    public string? ArtworkInDate { get; set; }
    /// <summary>
    /// Gets or sets the due date.
    /// </summary>
    [XmlElement(IsNullable = true)]
    public string? DueDate { get; set; }
    /// <summary>
    /// Gets or sets the time due.
    /// </summary>
    [XmlElement(IsNullable = true)]
    public string? TimeDue { get; set; }
    /// <summary>
    /// Gets or sets the estimate detail comment.
    /// </summary>
    [XmlElement(IsNullable = true)]
    public string? EstimateDetailComment { get; set; }
    /// <summary>
    /// Gets or sets the list of user-defined fields for the estimate.
    /// </summary>
    public List<EstimateUDF> EstimateUDFList { get; set; } = new List<EstimateUDF>();
    /// <summary>
    /// Gets or sets the status name of the estimate.
    /// </summary>
    [XmlElement(IsNullable = true)]
    public string? StatusName { get; set; }
}
