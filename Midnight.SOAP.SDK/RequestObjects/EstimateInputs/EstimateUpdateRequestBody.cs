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
    public int? UpdatedQuantity { get; set; }
    public bool ShouldSerializeUpdatedQuantity() => UpdatedQuantity.HasValue;

    /// <summary>
    /// Gets or sets the customer ID associated with the estimate.
    /// </summary>
    public int? CustomerID { get; set; }
    public bool ShouldSerializeCustomerID() => CustomerID.HasValue;

    /// <summary>
    /// Gets or sets the contact ID associated with the estimate.
    /// </summary>
    public int? ContactID { get; set; }
    public bool ShouldSerializeContactID() => ContactID.HasValue;

    /// <summary>
    /// Gets or sets the sales representative ID.
    /// </summary>
    public int? SalesRepID { get; set; }
    public bool ShouldSerializeSalesRepID() => SalesRepID.HasValue;

    /// <summary>
    /// Gets or sets the customer service representative ID.
    /// </summary>
    public int? CSRID { get; set; }
    public bool ShouldSerializeCSRID() => CSRID.HasValue;

    /// <summary>
    /// Gets or sets the licensee ID.
    /// </summary>
    public int? LicenseeID { get; set; }
    public bool ShouldSerializeLicenseeID() => LicenseeID.HasValue;

    /// <summary>
    /// Gets or sets the project name.
    /// </summary>
    public string? ProjectName { get; set; }
    public bool ShouldSerializeProjectName() => IsSet(ProjectName);

    /// <summary>
    /// Gets or sets the purchase order number.
    /// </summary>
    public string? PONumber { get; set; }
    public bool ShouldSerializePONumber() => IsSet(PONumber);

    /// <summary>
    /// Gets or sets the terms code.
    /// </summary>
    public string? TermsCode { get; set; }
    public bool ShouldSerializeTermsCode() => IsSet(TermsCode);

    /// <summary>
    /// Gets or sets a value indicating whether the estimate is taxable.
    /// </summary>
    public bool EstimateTaxable { get; set; } = true;

    /// <summary>
    /// Gets or sets the estimate date.
    /// </summary>
    public string? EstimateDate { get; set; }
    public bool ShouldSerializeEstimateDate() => IsSet(EstimateDate);

    /// <summary>
    /// Gets or sets the data in date.
    /// </summary>
    public string? DataIn { get; set; }
    public bool ShouldSerializeDataIn() => IsSet(DataIn);

    /// <summary>
    /// Gets or sets the material in date.
    /// </summary>
    public string? MaterialInDate { get; set; }
    public bool ShouldSerializeMaterialInDate() => IsSet(MaterialInDate);

    /// <summary>
    /// Gets or sets the artwork in date.
    /// </summary>
    public string? ArtworkInDate { get; set; }
    public bool ShouldSerializeArtworkInDate() => IsSet(ArtworkInDate);

    /// <summary>
    /// Gets or sets the due date.
    /// </summary>
    public string? DueDate { get; set; }
    public bool ShouldSerializeDueDate() => IsSet(DueDate);

    /// <summary>
    /// Gets or sets the time due.
    /// </summary>
    public string? TimeDue { get; set; }
    public bool ShouldSerializeTimeDue() => IsSet(TimeDue);

    /// <summary>
    /// Gets or sets the estimate detail comment.
    /// </summary>
    public string? EstimateDetailComment { get; set; }
    public bool ShouldSerializeEstimateDetailComment() => IsSet(EstimateDetailComment);

    /// <summary>
    /// Gets or sets the list of user-defined fields for the estimate.
    /// </summary>
    public List<EstimateUDF> EstimateUDFList { get; set; } = new List<EstimateUDF>();

    /// <summary>
    /// Gets or sets the status name of the estimate.
    /// </summary>
    public string? StatusName { get; set; }
    public bool ShouldSerializeStatusName() => IsSet(StatusName);

    /// <summary>Shared helper for determining whether a nullable string field has a meaningful value to serialize.</summary>
    private static bool IsSet(string? value) => !string.IsNullOrEmpty(value);
}
