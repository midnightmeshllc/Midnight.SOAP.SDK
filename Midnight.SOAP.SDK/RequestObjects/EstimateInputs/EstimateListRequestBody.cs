using Midnight.SOAP.SDK.CommonObjects;
using System.Xml.Serialization;

namespace Midnight.SOAP.SDK.RequestObjects.EstimateInputs;

/// <summary>
/// Represents the request body for listing estimates in the Midnight SOAP API.
/// </summary>
[XmlRoot("EstimateList")]
public class EstimateListRequestBody
{
    /// <summary>
    /// Gets or sets the input parameter for the estimate list request.
    /// </summary>
    public required EstimateListInputParameter InputParameter { get; set; }
}

/// <summary>
/// Represents the input parameter for listing estimates in the Midnight SOAP API.
/// </summary>
public class EstimateListInputParameter : UserDefinedFields
{
    /// <summary>Gets or sets the estimate number.</summary>
    public string? EstimateNumber { get; set; } = null;
    /// <summary>Gets or sets the estimate number to copy from.</summary>
    public string? CopyFromEstimateNumber { get; set; } = null;
    /// <summary>Gets or sets the customer ID.</summary>
    public int? CustomerID { get; set; } = null;
    /// <summary>Gets or sets the customer code.</summary>
    public string? CustomerCode { get; set; } = null;
    /// <summary>Gets or sets the estimate date from.</summary>
    public string? EstimateDateFrom { get; set; } = null;
    /// <summary>Gets or sets the estimate date to.</summary>
    public string? EstimateDateTo { get; set; } = null;
    /// <summary>Gets or sets the estimate status.</summary>
    public string? EstimateStatus { get; set; } = null;
    /// <summary>Gets or sets the estimate due date from.</summary>
    public string? EstimateDueDateFrom { get; set; } = null;
    /// <summary>Gets or sets the estimate due date to.</summary>
    public string? EstimateDueDateTo { get; set; } = null;
}