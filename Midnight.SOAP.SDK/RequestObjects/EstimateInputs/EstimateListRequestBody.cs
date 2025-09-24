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
    [XmlElement(IsNullable = true)]
    public string? EstimateNumber { get; set; }
    /// <summary>Gets or sets the estimate number to copy from.</summary>
    [XmlElement(IsNullable = true)]
    public string? CopyFromEstimateNumber { get; set; }
    /// <summary>Gets or sets the customer ID.</summary>
    [XmlElement(IsNullable = true)]
    public int? CustomerID { get; set; }
    /// <summary>Gets or sets the customer code.</summary>
    [XmlElement(IsNullable = true)]
    public string? CustomerCode { get; set; }
    /// <summary>Gets or sets the estimate date from.</summary>
    [XmlElement(IsNullable = true)]
    public string? EstimateDateFrom { get; set; }
    /// <summary>Gets or sets the estimate date to.</summary>
    [XmlElement(IsNullable = true)]
    public string? EstimateDateTo { get; set; }
    /// <summary>Gets or sets the estimate status.</summary>
    [XmlElement(IsNullable = true)]
    public string? EstimateStatus { get; set; }
    /// <summary>Gets or sets the estimate due date from.</summary>
    [XmlElement(IsNullable = true)]
    public string? EstimateDueDateFrom { get; set; }
    /// <summary>Gets or sets the estimate due date to.</summary>
    [XmlElement(IsNullable = true)]
    public string? EstimateDueDateTo { get; set; }
}